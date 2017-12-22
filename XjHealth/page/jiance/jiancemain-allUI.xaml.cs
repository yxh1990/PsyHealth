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

namespace XjHealth.page.jiance
{
    /// <summary>
    /// jiancemain.xaml 的交互逻辑
    /// </summary>
    public partial class jiancemain : Page, IDriverConnectListener
    {
        #region 报表准备
        NeuroSkyECG ecg;

        // Thread 
        // 添加数据线程
        private Thread addDataRunner;
        public delegate void AddDataDelegate();
        public AddDataDelegate updateUIDel;

        // 标志位，为true时表示未松动
        //         为false时表示松动
        public static bool isTouch = false;

        // 标志位，为true时表示回放
        //         为false时表示不需要回放
        public static bool isReplay = false;

        // 写数据线程
        private Thread writeDataRunner;


        // MOOD情绪度最近十次的值
        public static ArrayList moodList = new ArrayList();

        // Stress最近十次值
        public static ArrayList stressList = new ArrayList();

        // R2R间隔
        public static int sample_count = 0;
        public static ArrayList smoothDataList = new ArrayList();

        // ECG Data Sample Rate
        public const int SAMPLE_RATE = 512;
        public const int POWERLINE_FREQ = 1;

        // User Profile
        public static String mUserName = "NSKECG";
        public static int mUserAge = 30;
        public static bool mUserGenger = false;     // false - female, true - male
        public static int mUserHeight = 170;
        public static int mUserWeight = 67;

        // UI Update
        public static int rri = 0;
        public static int rri_counter = 0;
        public static int sq = 0;
        public static int overallSQ = 0;
        public static int hr = 0;
        public static int robustHR = 0;
        public static int mood = 0;
        public static int hrv = 0;
        public static int stress = 0;
        public static int heartAge = 0;

        // 标志位
        // 标志位为0时，表示刚开始
        // 标志位为1时，表示已失联一次
        // 标志位为2时，表示已失联两次
        // 标志位为3时，表示可以接收数据
        private int bReceiveData = 0;

        #endregion

        public jiancemain()
        {

            InitializeComponent();
            try
            {
                // NeuroSky Algorithm object constructor 
                ecg = new NeuroSkyECG();

                // Add event handler for algorithm callback
                ecg.ecgEventHandler += onEcgDataReceived;
                ecg.ecgExceptHandler += onEcgExceptionReceived;

                ecg.setupNeuroSkyECG(SAMPLE_RATE, POWERLINE_FREQ);
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
            //ThreadStart DisconnectThreadStart = new ThreadStart(DisconnectThreadMethod);
            //DisconnectRunner = new Thread(DisconnectThreadStart);
            //DisconnectRunner.Start();
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
            Dispatcher.BeginInvoke(new Action(delegate
            {
                MessageBox.Show("连接终端设备失败，请重新插好!");
                this.btn_monstart.Visibility = Visibility.Visible;
                this.loading.Visibility = Visibility.Hidden;

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
                this.btn_monstart.Visibility = Visibility.Hidden;
                this.btn_monstop.Visibility = Visibility.Visible;
                this.loading.Visibility = Visibility.Hidden;
            }));
        }

        public void AfterDriverDisconnected()
        {
            if (writeDataRunner != null)
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

                case (int)NeuroSkyECG.nskECGMessage.NSK_ECG_SIGNAL_QUALITY:
                    sq = e.value;
                    break;
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
                catch (Exception)
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
            bReceiveData = 0;
            moodList.Clear();
            stressList.Clear();

            //即时心率
            hr = 0;
            sq = 0;

            ecg.resetECGAnalysis();  
        }

        private void refreshUserProfile()
        {
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

        public void UpdateUI()
        {
            while (smoothDataList.Count > sample_count)
            {
                // 如果信号好且连接上
                if (isReplay)
                {
                    chart1.Series[0].Points.AddXY(sample_count, (short)smoothDataList[sample_count]);
                }
                else if (isTouch && !EcgHelper.getInstance().isOff)
                    chart1.Series[0].Points.AddXY(sample_count, (short)smoothDataList[sample_count]);
                else
                    chart1.Series[0].Points.AddXY(sample_count, 0);
                while (chart1.Series[0].Points[0].XValue < (sample_count - (4 * SAMPLE_RATE)))
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }

                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[0].XValue + (4 * SAMPLE_RATE);
                chart1.Invalidate();

                sample_count++;
            }

            lblhr.Content = hr.ToString();
            lblxh.Content = sq.ToString();
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
            // create a deleate for adding data
            updateUIDel += new AddDataDelegate(UpdateUI);

            this.chart1.ChartAreas.Add(new ChartArea());
            // Predefine the viewing area of the chart
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = 4 * SAMPLE_RATE;

            // Reset number of series in the chart.
            this.chart1.Series.Clear();

            // Create a line chart series
            Series newSeries = new Series("ECG");
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 2;
            newSeries.Color =System.Drawing.Color.OrangeRed;
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
            this.refreshUserProfile();

            btn_monstart.IsEnabled = false;

            // Thread Switch
            if (EcgHelper.getInstance().isOff)
            {
                // 删除目录下的文件
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

                Directory.CreateDirectory("./tmp");

                // 连接
                EcgHelper.getInstance().ConnectDriver("6");

                // Disable all controls on the form
                // Lock UI

            }
            else
            {
                EcgHelper.getInstance().DisconnectDriver(EcgHelper.getInstance().connectionId);
            }

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
        private void btn_monbreath_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Visible;
        }

        int img_index = 0;
        string[] imgarr = new string[4] { "/resource/img/SPCS_HXZS_SL.bmp", "/resource/img/SPCS_HXZS_SZ.bmp", "/resource/img/SPCS_HXZS_GG.bmp", "/resource/img/SPCS_HXZS_CQ.bmp" };
        string[] aviarr = new string[4] { "resource/video/huxi_shalou.avi", "resource/video/huxi_shanzi.avi", "resource/video/huxi_gangguang.avi", "resource/video/huxi_chuiqiu.avi" };
        private void btn_qiehuan_Click(object sender, RoutedEventArgs e)
        {
            this.videoMediaElement.Stop();
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

        private void btn_tuichu_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Hidden;
            this.videoMediaElement.Stop();
        }

        private void videoMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            //设置一下视频进度，确保从头开始播放
            this.videoMediaElement.Position = TimeSpan.Zero;
            this.videoMediaElement.Play();
        }
        #endregion

        #region 设置
        private void btn_monset_Click(object sender, RoutedEventArgs e)
        {
            this.userconfig.Visibility = Visibility.Visible;
            this.rbMusic.IsChecked = true;
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
