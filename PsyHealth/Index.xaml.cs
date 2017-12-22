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
    /// Index.xaml 的交互逻辑
    /// </summary>
    public partial class Index : Page
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Btn_about_Click(object sender, RoutedEventArgs e)
        {
            this.ImgInfo.Visibility = Visibility.Visible;
            this.btnHideImgInfo.Visibility = Visibility.Visible;
        }

        private void Btn_btnHideImgInfo_Click(object sender, RoutedEventArgs e)
        {
            this.ImgInfo.Visibility = Visibility.Hidden;
            this.btnHideImgInfo.Visibility = Visibility.Hidden;
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.exitInfo.Visibility = Visibility.Visible;
            this.btnOkExit.Visibility = Visibility.Visible;
            this.btnCancelExit.Visibility = Visibility.Visible;
        }

        private void Btn_btnOkExit_Click(object sender, RoutedEventArgs e)
        {
            //this.exitInfo.Visibility = Visibility;
            Application.Current.Shutdown();
        }

        private void Btn_btnCancelExit_Click(object sender, RoutedEventArgs e)
        {
            //this.exitInfo.Visibility = Visibility;
            this.exitInfo.Visibility = Visibility.Hidden;
            this.btnOkExit.Visibility = Visibility.Hidden;
            this.btnCancelExit.Visibility = Visibility.Hidden;
        }

        private void Btn_user_Click(object sender, RoutedEventArgs e)
        {
            this.userlist.Visibility = Visibility.Visible;
            this.Btn_user_exit.Visibility = Visibility.Visible;
        }

        private void Btn_user_exit_Click(object sender, RoutedEventArgs e)
        {
            this.userlist.Visibility = Visibility.Hidden;
            this.Btn_user_exit.Visibility = Visibility.Hidden;
        }

        private void btn_xuexi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XuexiWindow.xaml", UriKind.Relative));
        }

        private void btn_jiance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("JianceWindow.xaml", UriKind.Relative));
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("XunlianWindow.xaml", UriKind.Relative));
        }

        private void btn_jilu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RecordWindow.xaml", UriKind.Relative));
        }
    }
}
