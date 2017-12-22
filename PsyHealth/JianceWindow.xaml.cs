using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Threading;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Visifire.Charts;

namespace PsyHealth
{
    /// <summary>
    /// JianceWindow.xaml 的交互逻辑
    /// </summary>
    public partial class JianceWindow : Page
    {
        Random random = new Random();
        private DispatcherTimer timer = new DispatcherTimer();
        CompositeDataSource compositeDataSource1;
        CompositeDataSource compositeDataSource2;

        EnumerableDataSource<DateTime> datesDataSource = null;
        EnumerableDataSource<int> numberOpenDataSource = null;
        EnumerableDataSource<int> numberClosedDataSource = null;

        List<DateTime> vardatetime = new List<DateTime>();
        int i = 0;

        List<int> numberOpen = new List<int>();
        List<int> numberClosed = new List<int>();


        public JianceWindow()
        {
            InitializeComponent();
            CreateChartPie("饼图报表",strListx, strListy);
        }

        #region 饼状图
        private List<string> strListx = new List<string>() { "苹果", "樱桃" };
        private List<string> strListy = new List<string>() { "13", "75" };
        public void CreateChartPie(string name, List<string> valuex, List<string> valuey)
        {
            //创建一个图标
            Chart chart = new Chart();

            //设置图标的宽度和高度
            chart.Width = 320;
            chart.Height = 250;
            chart.Margin = new Thickness(0);
            //是否启用打印和保持图片
            chart.ToolBarEnabled = false;

            //设置图标的属性
            chart.ScrollingEnabled = false;//是否启用或禁用滚动
            chart.View3D = true;//3D效果显示

            //创建一个标题的对象
            Title title = new Title();

            //设置标题的名称
            title.Text = name;
            title.Padding = new Thickness(0);

            //向图标添加标题
            //chart.Titles.Add(title);

            // 创建一个新的数据线。               
            DataSeries dataSeries = new DataSeries();

            // 设置数据线的格式
            dataSeries.RenderAs = RenderAs.Pie;//柱状Stacked


            // 设置数据点              
            DataPoint dataPoint;
            for (int i = 0; i < valuex.Count; i++)
            {
                // 创建一个数据点的实例。                   
                dataPoint = new DataPoint();
                // 设置X轴点                    
                dataPoint.AxisXLabel = valuex[i];

                dataPoint.LegendText = "##" + valuex[i];
                //设置Y轴点                   
                dataPoint.YValue = double.Parse(valuey[i]);
                //添加一个点击事件        
                dataPoint.MouseLeftButtonDown += new MouseButtonEventHandler(dataPoint_MouseLeftButtonDown);
                //添加数据点                   
                dataSeries.DataPoints.Add(dataPoint);
            }

            // 添加数据线到数据序列。                
            chart.Series.Add(dataSeries);

            //将生产的图表增加到Grid，然后通过Grid添加到上层Grid.           
            Grid gr = new Grid();
            gr.Children.Add(chart);
            //maincontent.Children.Add(gr);
        }
        #endregion

        #region 点击事件
        //点击事件
        void dataPoint_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //DataPoint dp = sender as DataPoint;
            //MessageBox.Show(dp.YValue.ToString());
        }
        #endregion

        private void btn_xuexi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XueXiWindow.xaml", UriKind.Relative));
        }

        private void Btn_backIndex_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Index.xaml", UriKind.Relative));
        }

        private void btn_jilu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RecordWindow.xaml", UriKind.Relative));
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XunlianWindow.xaml", UriKind.Relative));
        }

        private void Window1_Loaded(object sender, EventArgs e)
        {
            DateTime tempDateTime = new DateTime();
            tempDateTime = DateTime.Now;

            vardatetime.Add(tempDateTime);
            numberOpen.Add(random.Next(40));
            numberClosed.Add(random.Next(100));

            datesDataSource.RaiseDataChanged();
            numberOpenDataSource.RaiseDataChanged();
            numberClosedDataSource.RaiseDataChanged();
            i++;
        }

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            DateTime tempDateTime = new DateTime();

            tempDateTime = DateTime.Now;
            vardatetime.Add(tempDateTime);

            numberOpen.Add(random.Next(40));
            numberClosed.Add(random.Next(100));

            i++;

            datesDataSource = new EnumerableDataSource<DateTime>(vardatetime);
            datesDataSource.SetXMapping(x => dateAxis.ConvertToDouble(x));

            numberOpenDataSource = new EnumerableDataSource<int>(numberOpen);
            numberOpenDataSource.SetYMapping(y => y);

            numberClosedDataSource = new EnumerableDataSource<int>(numberClosed);
            numberClosedDataSource.SetYMapping(y => y);

            compositeDataSource1 = new CompositeDataSource(datesDataSource, numberOpenDataSource);
            compositeDataSource2 = new CompositeDataSource(datesDataSource, numberClosedDataSource);


            plotter.AddLineGraph(compositeDataSource2, Colors.Green, 1, "Percentage2");
            plotter.Viewport.FitToView();


            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(Window1_Loaded);
            timer.IsEnabled = true;

        }

        private void btn_hrv_Click(object sender, RoutedEventArgs e)
        {
            this.hrv_grid.Visibility = Visibility.Visible;
            this.maibo_grid.Visibility = Visibility.Hidden;
            this.result_grid.Visibility = Visibility.Hidden;

            ControlTemplate temp = (ControlTemplate)this.TryFindResource("ImageButtonTemplate");

            ImageBrush img_maibo = temp.FindName("btnImg", btn_hrv) as ImageBrush;
            img_maibo.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_HRV_C.bmp"));

            ImageBrush img_hrv = temp.FindName("btnImg", btn_maibo) as ImageBrush;
            img_hrv.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_XZ_A.bmp"));

            ImageBrush img_result = temp.FindName("btnImg", btn_result) as ImageBrush;
            img_result.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_JT_A.bmp"));
        }

        private void btn_maibo_Click(object sender, RoutedEventArgs e)
        {
            this.hrv_grid.Visibility = Visibility.Hidden;
            this.maibo_grid.Visibility = Visibility.Visible;
            this.result_grid.Visibility = Visibility.Hidden;

            ControlTemplate temp = (ControlTemplate)this.TryFindResource("ImageButtonTemplate");

            ImageBrush img_maibo = temp.FindName("btnImg", btn_maibo) as ImageBrush;
            img_maibo.ImageSource =new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_XZ_C.bmp"));

            ImageBrush img_hrv = temp.FindName("btnImg", btn_hrv) as ImageBrush;
            img_hrv.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_HRV_A.bmp"));

            ImageBrush img_result = temp.FindName("btnImg", btn_result) as ImageBrush;
            img_result.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_JT_A.bmp"));
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            this.hrv_grid.Visibility = Visibility.Hidden;
            this.maibo_grid.Visibility = Visibility.Hidden;
            this.result_grid.Visibility = Visibility.Visible;

            ControlTemplate temp = (ControlTemplate)this.TryFindResource("ImageButtonTemplate");

            ImageBrush img_maibo = temp.FindName("btnImg", btn_maibo) as ImageBrush;
            img_maibo.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_XZ_A.bmp"));

            ImageBrush img_hrv = temp.FindName("btnImg", btn_hrv) as ImageBrush;
            img_hrv.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_HRV_A.bmp"));

            ImageBrush img_result = temp.FindName("btnImg", btn_result) as ImageBrush;
            img_result.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/resources/img/SPCS_XLCLS_AN_JT_C.bmp"));
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
            //this.userconfig.Visibility = Visibility.Hidden;
            //MessageBox.Show("开始播放音乐");
            this.media1.Source = new Uri("resources/mp3/background.mp3", UriKind.Relative);
            //media1.Play();
            this.media1.Play();
        }

        private void btn_set_Click(object sender, RoutedEventArgs e)
        {
            this.userconfig.Visibility = Visibility.Visible;
        }

        private void btn_zhushou_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Visible;
        }

        private void btn_tuichu_Click(object sender, RoutedEventArgs e)
        {
            this.hxcon.Visibility = Visibility.Hidden;
        }

        int img_index = 0;
        string[] imgarr = new string[4] { "/resources/img/SPCS_HXZS_SL.bmp", "/resources/img/SPCS_HXZS_SZ.bmp", "/resources/img/SPCS_HXZS_GG.bmp", "/resources/img/SPCS_HXZS_CQ.bmp" };
        string[] aviarr = new string[4] { "resources/video/huxi_shalou.avi", "resources/video/huxi_shanzi.avi", "resources/video/huxi_gangguang.avi", "resources/video/huxi_chuiqiu.avi" };
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
    }
}
