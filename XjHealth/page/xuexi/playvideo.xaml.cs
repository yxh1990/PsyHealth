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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XjHealth.page.xuexi
{
    /// <summary>
    /// 播放视频类型
    /// </summary>
   public enum videoName
    {
        yinian,
        fuxi,
        qingan
    }

    /// <summary>
    /// playvideo.xaml 的交互逻辑
    /// </summary>
    public partial class playvideo : Page
    {
        public videoName videotype = videoName.fuxi;

        public playvideo()
        {
            InitializeComponent();
        }
        
        private void btn_backbefore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/xuexi/learnmain.xaml", UriKind.Relative));
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            string videourl = "resource/video/breathe.AVI";
            switch (videotype)
            {
                case videoName.fuxi:
                    videourl = "resource/video/breathe.AVI";
                    break;
                case videoName.qingan:
                    videourl = "resource/video/emotion.AVI";
                    break;
                case videoName.yinian:
                    videourl = "resource/video/attention.AVI";
                    break;
            }
            this.videoScreenMediaElement.Source = new Uri(videourl, UriKind.Relative);
            videoScreenMediaElement.Play();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string video_id = Application.Current.Properties["video_id"].ToString();
            if(video_id == "yinian")
            {
                this.btn_yinian.ImgPath = "/resource/img/learn_ynsd_C.png";
                this.btn_yinian.IsEnabled = false;
            }
            if(video_id == "fuxi")
            {
                this.btn_fuxi.ImgPath = "/resource/img/learn_hxxz_C.png";
                this.btn_fuxi.IsEnabled = false;
            }
            if(video_id == "qingan")
            {
                this.btn_qingan.ImgPath = "/resource/img/learn_qgzy_C.png";
                this.btn_qingan.IsEnabled = false;
            }
            
        }

        private void btn_fuxi_Click(object sender, RoutedEventArgs e)
        {
            this.btn_fuxi.ImgPath = "/resource/img/learn_hxxz_C.png";
            this.btn_fuxi.IsEnabled = false;

            this.btn_yinian.IsEnabled = true;
            this.btn_qingan.IsEnabled = true;

            videotype = videoName.fuxi;

            this.videoScreenMediaElement.Stop();
        }

        private void btn_qingan_Click(object sender, RoutedEventArgs e)
        {
            this.btn_qingan.ImgPath = "/resource/img/learn_qgzy_C.png";
            this.btn_qingan.IsEnabled = false;

            this.btn_yinian.IsEnabled = true;
            this.btn_fuxi.IsEnabled = true;

            videotype = videoName.qingan;
            this.videoScreenMediaElement.Stop();
        }

        private void btn_yinian_Click(object sender, RoutedEventArgs e)
        {
            this.btn_yinian.ImgPath = "/resource/img/learn_ynsd_C.png";
            this.btn_yinian.IsEnabled = false;

            this.btn_fuxi.IsEnabled = true;
            this.btn_qingan.IsEnabled = true;

            videotype = videoName.yinian;

            this.videoScreenMediaElement.Stop();
        }
    }
}
