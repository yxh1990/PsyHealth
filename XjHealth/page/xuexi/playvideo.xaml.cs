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
using XjHealth.lib;
using Newtonsoft.Json.Linq;
using System.Configuration;
using XjHealth.Model;
using com.force.json;

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
        public static string Resturl;
        public string jstr = "";
        public string videourl = "";
        public playvideo(string jsonstr)
        {
            InitializeComponent();
            jstr = jsonstr;
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }
        
        private void btn_backbefore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/xuexi/learnmain.xaml", UriKind.Relative));
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            this.videoScreenMediaElement.Source = new Uri(videourl, UriKind.RelativeOrAbsolute);
            videoScreenMediaElement.Play();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            var obj = JObject.Parse(jstr);
            var psyResourceList = obj["flashChannelInfo"]["psyResourceList"];

            btn_yinian.Content = psyResourceList[0]["resourceTitle"].ToString();
            btn_yinian.Content = "意念锁定";
            btn_yinian.Tag = psyResourceList[0]["resourceId"].ToString();
            btn_fuxi.Content = "呼吸谐振";
            btn_fuxi.Tag = psyResourceList[1]["resourceId"].ToString();
            btn_qingan.Content = "情感转移";
            btn_qingan.Tag = psyResourceList[2]["resourceId"].ToString();
        }

        public string getvideourl(string resourceId)
        {
            var client = new RestClient();
            Userinfo user = App.CurrentUser;
            client.EndPoint = Resturl + "/resource/visit";
            client.Method = HttpVerb.POST;

            JSONObject json = new JSONObject();
            json.Put("resourceId", resourceId);
            json.Put("userId", user.Id);

            client.PostData = json.ToString();
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);
            //MessageBox.Show(jsonstr);

            return obj["detailInfo"]["resourcePath"].ToString();
        }

        private void btn_fuxi_Click(object sender, RoutedEventArgs e)
        {
            this.btn_fuxi.ImgPath = "/resource/img/learn_ynsd_C.png";
            this.btn_fuxi.IsEnabled = false;

            this.btn_yinian.IsEnabled = true;
            this.btn_qingan.IsEnabled = true;

            string resourceId = ((ImageButton)sender).Tag.ToString();
            videourl = "resource/video/fuxi.mp4";

            this.videoScreenMediaElement.Source = new Uri(videourl, UriKind.RelativeOrAbsolute);
            videoScreenMediaElement.Play();

            //this.videoScreenMediaElement.Stop();
        }

        private void btn_qingan_Click(object sender, RoutedEventArgs e)
        {
            this.btn_qingan.ImgPath = "/resource/img/learn_ynsd_C.png";
            this.btn_qingan.IsEnabled = false;

            this.btn_yinian.IsEnabled = true;
            this.btn_fuxi.IsEnabled = true;

            string resourceId = ((ImageButton)sender).Tag.ToString();
            //videourl = getvideourl(resourceId);
            videourl = "resource/video/qinggan.mp4";

            this.videoScreenMediaElement.Source = new Uri(videourl, UriKind.RelativeOrAbsolute);
            videoScreenMediaElement.Play();

            //this.videoScreenMediaElement.Stop();
        }

        private void btn_yinian_Click(object sender, RoutedEventArgs e)
        {
            this.btn_yinian.ImgPath = "/resource/img/learn_ynsd_C.png";
            this.btn_yinian.IsEnabled = false;

            this.btn_fuxi.IsEnabled = true;
            this.btn_qingan.IsEnabled = true;

            string resourceId = ((ImageButton)sender).Tag.ToString();
            //videourl = getvideourl(resourceId);
            videourl = "resource/video/yinian.mp4";

            this.videoScreenMediaElement.Source = new Uri(videourl, UriKind.RelativeOrAbsolute);
            videoScreenMediaElement.Play();

            //this.videoScreenMediaElement.Stop();
        }
    }
}
