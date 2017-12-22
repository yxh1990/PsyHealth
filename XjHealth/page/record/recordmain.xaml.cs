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

namespace XjHealth.page.record
{
    /// <summary>
    /// recordmain.xaml 的交互逻辑
    /// </summary>
    public partial class recordmain : Page
    {
        public recordmain()
        {
            InitializeComponent();
            this.dataGrid1.ItemsSource = CityInfo.GetInfo();
            this.dataGrid2.ItemsSource = CityInfo.GetInfo();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void btn_cepin_Click(object sender, RoutedEventArgs e)
        {
            btntoolbar1.Visibility = Visibility.Hidden;
            btn_cepin.Visibility = Visibility.Hidden;
            btntoolbar2.Visibility = Visibility.Visible;
            btn_xunlian.Visibility = Visibility.Visible;

            this.dataGrid1.Visibility = Visibility.Hidden;
            this.dataGrid2.Visibility = Visibility.Visible;
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            btntoolbar1.Visibility = Visibility.Visible;
            btn_cepin.Visibility = Visibility.Visible;
            btntoolbar2.Visibility = Visibility.Hidden;
            btn_xunlian.Visibility = Visibility.Hidden;

            this.dataGrid1.Visibility = Visibility.Visible;
            this.dataGrid2.Visibility = Visibility.Hidden;
        }

        private void btn_replay_Click(object sender, RoutedEventArgs e)
        {
            Button btnreplay = (Button)sender;
            MessageBox.Show("回放"+ btnreplay.Tag+"");
        }

        private void btn_report_Click(object sender, RoutedEventArgs e)
        {
            Button btnreport = (Button)sender;
            MessageBox.Show("训练报告" + btnreport.Tag + "");
        }

        private void btn_testAnswer_Click(object sender, RoutedEventArgs e)
        {
            Button btnanswer = (Button)sender;
            MessageBox.Show("答卷" + btnanswer.Tag + "");
        }

        private void btn_testReport_Click(object sender, RoutedEventArgs e)
        {
            Button btntestreport= (Button)sender;
            MessageBox.Show("测评报告" + btntestreport.Tag + "");
        }
    }

    public class CityInfo
    {
        public string AddrName { get; set; }
        public string CityName { get; set; }
        public string TelNum { get; set; }
        public double TotalSum { get; set; }
        public static List<CityInfo> GetInfo()
        {
            return new List<CityInfo>()
            {
                new CityInfo() { AddrName="湖北", CityName = "武汉", TelNum="123", TotalSum = 1.23  },
                new CityInfo() { AddrName="广东", CityName = "广州", TelNum="234", TotalSum = 1.23 },
                new CityInfo() { AddrName="广西", CityName = "南宁", TelNum="0152", TotalSum = 1.23 },
                new CityInfo() { AddrName="湖南", CityName = "长沙", TelNum="0123", TotalSum = 1.23 },
                new CityInfo() { AddrName="江西", CityName = "南昌", TelNum="123", TotalSum = 10.23 }
            };
        }


    }
}
