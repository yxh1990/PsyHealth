using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using libStreamSDK;
using libNeuroSkyECG;
using System.IO;
using XjHealth.Ecg;
using System.Collections;
using System.Threading;
using System.Windows.Navigation;
using System.ComponentModel;
using XjHealth.Model;

namespace XjHealth.page.jiance2
{
    /// <summary>
    /// jiancemain.xaml 的交互逻辑
    /// </summary>
    public partial class jiancemain2 : Page,IDriverConnectListener
    {
        #region 报表准备
        NeuroSkyECG ecg;

        public delegate void AddDataDelegate();
        public AddDataDelegate updateUIDel;

        public static bool isTouch = false;
        private Thread writeDataRunner;

        public static ArrayList moodList = new ArrayList();
        public static ArrayList stressList = new ArrayList();
        public static ArrayList smoothDataList = new ArrayList();
        public static ArrayList hrvList = new ArrayList();

        public static int sample_count = 0;
        

        public const int SAMPLE_RATE = 512;
        public const int POWERLINE_FREQ = 1;


        public Userinfo currentUser;

        public static String mUserName = "NSKECG";
        public static int mUserAge = 30;
        public static bool mUserGenger = false;

        //rest接口返回的用户信息没有身高和体重
        public static int mUserHeight = 170;
        public static int mUserWeight = 65;

        public static int hr = 0;

      
        //信号标志位
        private int bReceiveData = 0;
        private Thread DisconnectRunner;

        #endregion

        public jiancemain2()
        {

            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                ecg = new NeuroSkyECG();
                ecg.ecgEventHandler += onEcgDataReceived;
                ecg.ecgExceptHandler += onEcgExceptionReceived;
                ecg.setupNeuroSkyECG(SAMPLE_RATE, POWERLINE_FREQ);

                currentUser = App.CurrentUser;
            }
            catch (DllNotFoundException)
            {
                MessageBox.Show("加载dll失败.");
            }
            EcgHelper.getInstance().AddDriverConnectListener(this);
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            #region 隐藏图表
            this.chartwindow.Dispose();
            this.chart1.Dispose();
            #endregion

            this.btn_backmain.IsEnabled = false;

            #region 主线程加载等待动画
            loading.Visibility = System.Windows.Visibility.Visible;
            #endregion

            #region 启动另外一个线程断开连接
            ThreadStart DisconnectThreadStart = new ThreadStart(DisconnectThreadMethod);
            DisconnectRunner = new Thread(DisconnectThreadStart);
            DisconnectRunner.Start();
            #endregion

            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        /// <summary>
        /// 断开蓝牙接收数据的线程方法
        /// </summary>
        private void DisconnectThreadMethod()
        {
            if (EcgHelper.getInstance().connectionId >= 0)
            {
                EcgHelper.getInstance().DisconnectDriver(EcgHelper.getInstance().connectionId);
            }
        }

        #region 实现IDriverConnectListener接口
        public void AfterDriverConnectedFailed()
        {
            MessageBox.Show("连接终端设备失败，请重新插好!");
            Dispatcher.BeginInvoke(new Action(delegate
            {
                this.btn_monstart.Visibility =Visibility.Visible;
                this.loading.Visibility = Visibility.Hidden;

                #region 重新启用四个按钮
                this.btn_hr.IsEnabled = true;
                this.btn_hrv.IsEnabled = true;
                this.btn_stress.IsEnabled = true;
                this.btn_mood.IsEnabled = true;
                #endregion

            }));
        }

        public void AfterDriverConnectedSuc()
        {
           
            if (writeDataRunner == null || writeDataRunner.IsAlive == false)
            {
                ThreadStart writeDataThreadStart = new ThreadStart(WriteDataThreadLoop);
                writeDataRunner = new Thread(writeDataThreadStart);
                writeDataRunner.Start();
            }

            Dispatcher.BeginInvoke(new Action(delegate
            {
                this.btn_monstart.IsEnabled = false;
                this.btn_monstop.IsEnabled = true;
                this.loading.Visibility = Visibility.Hidden;
            }));
        }

        public void AfterDriverDisconnected()
        {
            if(writeDataRunner != null)
            { 
              if (writeDataRunner.IsAlive == true)
              {
                  writeDataRunner.Abort();
              }
            }
        }
        #endregion

        #region 实现接收数据委托
        private void onEcgDataReceived(object sender, NSKECGEventArgs e)
        {
            switch (e.tag)
            {
                case (int)NeuroSkyECG.nskECGMessage.NSK_ECG_SMOOTHED_WAVE:
                    smoothDataList.Add(e.value);
                    break;
                case (int)NeuroSkyECG.nskECGMessage.NSK_ECG_HEART_RATE:
                    hr = e.value;
                    break;
                //case (int)NeuroSkyECG.nskECGMessage.NSK_ECG_HRV:
                //    hrvList.Add(e.value);
                //    break;
            }

            // Control UI update frame rate
            if (smoothDataList.Count % 10 == 0)
            {
                while (!chart1.IsHandleCreated)
                {
                    ;
                }

                try
                { 
                    chart1.Invoke(updateUIDel);
                }
                catch(Exception)
                {
                   //捕获到异常但不需要进行任何处理
                }
            } 
        }
        private void onEcgExceptionReceived(object sender, NSKECGExceptMsg e)
        {
           MessageBox.Show(e.message);
        }
        #endregion

        #region 刷新页面
        private void refreshValues()
        {
            sample_count = 0;
            bReceiveData = 0;

            //情绪指数
            moodList.Clear();

            //放松度
            stressList.Clear();

            //hrv集合
            hrvList.Clear();

            //心率图(默认为第一个)
            smoothDataList.Clear();

            //即时心率
            hr = 0;

            ecg.resetECGAnalysis(); 
        }

        private void refreshUserProfile()
        {
            //string mUserName = currentUser.Name;
            //bool mUserGenger = currentUser.Sex == "男" ? true : false;
            //int mUserAge = currentUser.Age;

            short[] mUserDataProfile;
            if (File.Exists(mUserName))
            {
                System.IO.StreamReader profileReader = new System.IO.StreamReader(mUserName);
                string profileStr = profileReader.ReadLine();
                mUserDataProfile = profileStr.Split(',').Select(n => Convert.ToInt16(n)).ToArray();
                profileReader.Close();
            }
            else
            {
                // Create new user profile
                mUserDataProfile = new short[128];
            }

            // Pass user profile to Algorithm
            ecg.setupUserProfile(mUserName, mUserGenger, mUserAge, mUserHeight, mUserWeight, mUserDataProfile);

            refreshValues();
            this.chart1.Series[0].Points.Clear();
        }

        public void updateUI()
        {
            int datacount = smoothDataList.Count;
            //switch (App.stype)
            //{
            //    case ShowtbType.hr:
            //        datacount = smoothDataList.Count;
            //        break;
            //    case ShowtbType.hrv:
            //        datacount = hrvList.Count;
            //        break;
            //    case ShowtbType.stress:
            //        datacount = stressList.Count;
            //        break;
            //    case ShowtbType.mood:
            //        datacount = moodList.Count;
            //        break;
            //}

            while (datacount > sample_count)
            {
                if (isTouch && !EcgHelper.getInstance().isOff)
                {
                    chart1.Series[0].Points.AddXY(sample_count, (short)smoothDataList[sample_count]);
                }
                else
                {
                    chart1.Series[0].Points.AddXY(sample_count, 0);
                }

                while (chart1.Series[0].Points[0].XValue < (sample_count - (4 * SAMPLE_RATE)))
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }

                #region 控制图表的显示
                this.chartwindow.Width = 620;
                this.chartwindow.Height = 325;
                this.chart1.Width = 620;
                this.chart1.Height = 325;
                this.btn_monstop.Visibility = Visibility.Visible;
                #endregion

                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[0].XValue + (4 * SAMPLE_RATE);
                chart1.Invalidate();

                sample_count++;
            }


            lblhr.Content= hr.ToString();
        }
        #endregion

        #region 线程方法
        private void WriteDataThreadLoop()
        {
            while (!EcgHelper.getInstance().isOff)
            {
                int errCode = 0;
                errCode = NativeThinkgear.TG_ReadPackets(EcgHelper.getInstance().connectionId, 1);
                if (errCode == 1)
                {
                    if (NativeThinkgear.TG_GetValueStatus(EcgHelper.getInstance().connectionId, NativeThinkgear.DataType.TG_DATA_RAW) != 0)
                    {
                        int f = (int)NativeThinkgear.TG_GetValue(EcgHelper.getInstance().connectionId, NativeThinkgear.DataType.TG_DATA_RAW);
                        int f2 = (int)NativeThinkgear.TG_GetValue(EcgHelper.getInstance().connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL);

                        if (f2 == 0)
                        {
                            isTouch = false;
                            ecg.analyzeECGData(0);
                            this.refreshValues();
                        }
                        else
                        {
                            isTouch = true;
                            ecg.analyzeECGData((short)f);
                        }
                    }
                }
            }
        }
        #endregion

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            updateUIDel += new AddDataDelegate(updateUI);
            ChartArea area = new ChartArea();
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 4 * SAMPLE_RATE;
            this.chart1.ChartAreas.Add(area);

            this.chart1.Series.Clear();
            Series newSeries = new Series("ECG");
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 2;
            newSeries.Color =System.Drawing.Color.Red;
            newSeries.XValueType = ChartValueType.Int32;
            this.chart1.Series.Add(newSeries);

            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = true;

            switch (App.stype)
            {
                case ShowtbType.hr:
                    this.btn_hr.Opacity = 0.5;
                    break;
                case ShowtbType.hrv:
                    this.btn_hrv.Opacity = 0.5;
                    break;
                case ShowtbType.mood:
                    this.btn_mood.Opacity = 0.5;
                    break;
                case ShowtbType.stress:
                    this.btn_stress.Opacity = 0.5;
                    break;
            }
        }

        private Thread StartThread;
        private void btn_monstart_Click(object sender, RoutedEventArgs e)
        {
            btn_monstart.Visibility=Visibility.Hidden;
            loading.Visibility = System.Windows.Visibility.Visible;

            #region 启动另外一个线程创建保存数据文件
            ThreadStart ThreadStart = new ThreadStart(doStartThreadMethod);
            StartThread = new Thread(ThreadStart);
            StartThread.Start();
            #endregion

            #region 控制四个类别按钮不可用
            this.btn_hr.IsEnabled = false;
            this.btn_hrv.IsEnabled = false;
            this.btn_stress.IsEnabled = false;
            this.btn_mood.IsEnabled = false;
            #endregion

        }

        private void doStartThreadMethod()
        {
            this.refreshUserProfile();
            if (EcgHelper.getInstance().isOff)
            {
                DirectoryInfo di = new DirectoryInfo("./tmp");
                if (di.Exists)
                {
                    FileInfo[] fi = di.GetFiles();
                    foreach (FileInfo f in fi)
                    {
                        if (f.Exists)
                        {
                            if (!(f.FullName.IndexOf("tmp.log") >= 0))
                            {
                                try
                                {
                                    File.Delete(f.FullName);
                                }
                                catch (Exception e2)
                                {
                                    Console.WriteLine(e2.ToString());
                                }
                            }
                        }
                    }
                }
                //如果不存tmp目录,则创建一个新的tmp目录
                Directory.CreateDirectory("./tmp");
                EcgHelper.getInstance().ConnectDriver("6");
            }
            else
            {
                EcgHelper.getInstance().DisconnectDriver(EcgHelper.getInstance().connectionId);
            }
        }

        private void btn_monstop_Click(object sender, RoutedEventArgs e)
        {
            #region 控制图表的隐藏
            this.chartwindow.Dispose();
            this.chart1.Dispose();
            #endregion

            this.btn_monstop.IsEnabled = false;
            this.btn_monstart.IsEnabled = true;

            #region 主线程加载等待动画
            loading.Visibility = System.Windows.Visibility.Visible;
            #endregion

            #region 启动另外一个线程断开连接
            if (EcgHelper.getInstance().connectionId >= 0)
            {
                EcgHelper.getInstance().DisconnectDriver(EcgHelper.getInstance().connectionId);
            }

            //ThreadStart DisconnectThreadStart = new ThreadStart(DisconnectThreadMethod);
            //DisconnectRunner = new Thread(DisconnectThreadStart);
            //DisconnectRunner.Start();
            #endregion

            #region 通过父窗口刷新当前page
            NavigationWindow win = (NavigationWindow)this.Parent;
            this.chartwindow.Width = 0;
            this.chartwindow.Height = 0;
            win.Refresh();
            #endregion
        }


        #region 呼吸助手
        private void btn_zhushou_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Visible;
        }

        private void btn_tuichu_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Hidden;
        }

        int img_index = 0;
        string[] imgarr = new string[4] { "/resource/img/SPCS_HXZS_SL.bmp", "/resource/img/SPCS_HXZS_SZ.bmp", "/resource/img/SPCS_HXZS_GG.bmp", "/resource/img/SPCS_HXZS_CQ.bmp" };
        string[] aviarr = new string[4] { "resource/video/huxi_shalou.avi", "resource/video/huxi_shanzi.avi", "resource/video/huxi_gangguang.avi", "resource/video/huxi_chuiqiu.avi" };
        private void btn_qiehuan_Click(object sender, RoutedEventArgs e)
        {
            this.videoMediaElement.Visibility = Visibility.Hidden;
            this.hximg.Visibility = Visibility.Visible;
            img_index++;
            if (img_index > 3) { img_index = 0; }
            this.hximg.Source = new BitmapImage(new Uri(imgarr[img_index], UriKind.Relative));
        }

        private void btn_kaishi_Click(object sender, RoutedEventArgs e)
        {
            this.hximg.Visibility = Visibility.Hidden;
            this.videoMediaElement.Visibility = Visibility.Visible;
            this.videoMediaElement.Source = new Uri(aviarr[img_index], UriKind.Relative);
            this.videoMediaElement.Play();
        }
        #endregion

        #region 四个监测按钮曲线展示
        private void btn_hrv_Click(object sender, RoutedEventArgs e)
        {
            App.stype = ShowtbType.hrv;

            #region 控制四个按钮的显示图标
            this.btn_hrv.Opacity = 0.5;
            this.btn_hr.Opacity = 1.0;
            this.btn_stress.Opacity = 1.0;
            this.btn_mood.Opacity = 1.0;
            #endregion

        }

        private void btn_hr_Click(object sender, RoutedEventArgs e)
        {
            #region 控制四个按钮的显示图标
            this.btn_hrv.Opacity = 1.0;
            this.btn_hr.Opacity = 0.5;
            this.btn_stress.Opacity = 1.0;
            this.btn_mood.Opacity = 1.0;
            #endregion

            App.stype = ShowtbType.hr;
        }
        #endregion


        #region 设置
        private void btn_monset_Click(object sender, RoutedEventArgs e)
        {
            this.userconfig.Visibility = Visibility.Visible;
        }

        private void btn_checkfile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "音频文件|*.mp3";
            if (dialog.ShowDialog() == true)
            {
                this.txtmusicpath.Text = dialog.FileName;
            }
        }

        private void btn_cancle_Click(object sender, RoutedEventArgs e)
        {
            this.userconfig.Visibility = Visibility.Hidden;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            string mp3url = this.txtmusicpath.Text;
            this.media1.Source = new Uri(mp3url, UriKind.Relative);
            this.media1.Play();
        }
        #endregion

    }
}
