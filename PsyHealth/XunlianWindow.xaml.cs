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
    /// XunlianWindow.xaml 的交互逻辑
    /// </summary>
    public partial class XunlianWindow : Page
    {
        public XunlianWindow()
        {
            InitializeComponent();
        }

        private void Btn_backIndex_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Index.xaml", UriKind.Relative));
        }

        private void btn_jilu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RecordWindow.xaml", UriKind.Relative));
        }

        private void btn_jiance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("JianceWindow.xaml", UriKind.Relative));
        }

        private void btn_xuexi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XueXiWindow.xaml", UriKind.Relative));
        }

        private void btn_puti_MouseEnter(object sender, MouseEventArgs e)
        {
            this.gamepic.Source = new BitmapImage(new Uri("/resources/img/SPCS_XLZX_YST_PTS.bmp", UriKind.Relative));
        }

        private void btn_shejian_MouseEnter(object sender, MouseEventArgs e)
        {
            this.gamepic.Source = new BitmapImage(new Uri("/resources/img/SPCS_XLZX_YST_SJ.bmp", UriKind.Relative));
        }
        private void btn_fb_MouseEnter(object sender, MouseEventArgs e)
        {
            this.gamepic.Source = new BitmapImage(new Uri("/resources/img/SPCS_XLZX_YST_JYFB.bmp", UriKind.Relative));
        }
        private void btn_sq_MouseEnter(object sender, MouseEventArgs e)
        {
            this.gamepic.Source = new BitmapImage(new Uri("/resources/img/SPCS_XLZX_YST_XLSQ.bmp", UriKind.Relative));
        }
    }
}
