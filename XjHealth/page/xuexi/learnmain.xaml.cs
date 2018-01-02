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
using XjHealth.lib;
using System.Configuration;

namespace XjHealth.page.xuexi
{
    /// <summary>
    /// learnmain.xaml 的交互逻辑
    /// </summary>
    public partial class learnmain : Page
    {
        public static string Resturl;
        public learnmain()
        {
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void btn_fuxi_Click(object sender, RoutedEventArgs e)
        {
            getResourceByChannelId(4);
        }

        public void getResourceByChannelId(int channelId)
        {
            var client = new RestClient();
            client.EndPoint = Resturl + "/channel/" + channelId;
            client.Method = HttpVerb.GET;
            var jsonstr = client.MakeRequest();
            playvideo pv = new playvideo(jsonstr);
            NavigationService.Navigate(pv);
        }

        private void btn_minxiang_Click(object sender, RoutedEventArgs e)
        {
            getResourceByChannelId(5);
        }

        private void btn_fasong_Click(object sender, RoutedEventArgs e)
        {
            getResourceByChannelId(6);
        }
    }
}
