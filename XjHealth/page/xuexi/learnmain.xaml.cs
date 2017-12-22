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

namespace XjHealth.page.xuexi
{
    /// <summary>
    /// learnmain.xaml 的交互逻辑
    /// </summary>
    public partial class learnmain : Page
    {
        public learnmain()
        {
            InitializeComponent();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void btn_yinian_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["video_id"] = "yinian";
            NavigationService.Navigate(new Uri("page/xuexi/playvideo.xaml", UriKind.Relative));
        }

        private void btn_fuxi_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["video_id"] = "fuxi";
            NavigationService.Navigate(new Uri("page/xuexi/playvideo.xaml", UriKind.Relative));
        }

        private void btn_qingan_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["video_id"] = "qingan";
            NavigationService.Navigate(new Uri("page/xuexi/playvideo.xaml", UriKind.Relative));
        }
    }
}
