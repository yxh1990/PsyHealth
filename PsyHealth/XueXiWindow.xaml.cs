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
    /// XueXiWindow.xaml 的交互逻辑
    /// </summary>
    public partial class XueXiWindow : Page
    {
        public XueXiWindow()
        {
            InitializeComponent();
        }

        private void Btn_backIndex_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Index.xaml", UriKind.Relative));
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            this.videobgimg.Visibility = Visibility.Hidden;
            this.videoScreenMediaElement.Visibility = Visibility.Visible;

            this.btn_play.Visibility = Visibility.Hidden;
            this.btn_pause.Visibility = Visibility.Visible;

            this.btn_yinian.IsEnabled = false;
            this.btn_ganqin.IsEnabled = true;
            this.btn_huxi.IsEnabled = true;

            this.videoScreenMediaElement.Source = new Uri("resources/video/attention.AVI",UriKind.Relative);
            videoScreenMediaElement.Play();
        }

        private void btn_pause_Click(object sender, RoutedEventArgs e)
        {
            this.btn_pause.Visibility = Visibility.Hidden;
            this.btn_play.Visibility = Visibility.Visible;
            videoScreenMediaElement.Pause();
        }

        private void videoScreenMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            videoScreenMediaElement.Position = TimeSpan.Zero;
            videoScreenMediaElement.Stop();
        }

        private void btn_huxi_Click(object sender, RoutedEventArgs e)
        {

            this.videobgimg.Visibility = Visibility.Hidden;
            this.videoScreenMediaElement.Visibility = Visibility.Visible;

            this.btn_yinian.IsEnabled = true;
            this.btn_ganqin.IsEnabled = true;
            this.btn_huxi.IsEnabled = false;

            this.videoScreenMediaElement.Source = new Uri("resources/video/breathe.AVI", UriKind.Relative);
            videoScreenMediaElement.Play();
        }

        private void btn_ganqin_Click(object sender, RoutedEventArgs e)
        {

            this.videobgimg.Visibility = Visibility.Hidden;
            this.videoScreenMediaElement.Visibility = Visibility.Visible;

            this.btn_yinian.IsEnabled = true;
            this.btn_ganqin.IsEnabled = false;
            this.btn_huxi.IsEnabled = true;

            this.videoScreenMediaElement.Source = new Uri("resources/video/emotion.AVI", UriKind.Relative);
            videoScreenMediaElement.Play();
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
