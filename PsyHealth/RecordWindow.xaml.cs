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

namespace PsyHealth
{
    /// <summary>
    /// RecordWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RecordWindow : Page
    {
        public RecordWindow()
        {
            InitializeComponent();
            this.dataGrid1.ItemsSource = CityInfo.GetInfo();
        }

        private void Btn_backIndex_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Index.xaml", UriKind.Relative));
        }

        private void btn_jiance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("JianceWindow.xaml", UriKind.Relative));
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XunlianWindow.xaml", UriKind.Relative));
        }

        private void btn_xuexi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XueXiWindow.xaml", UriKind.Relative));
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
