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
using XjHealth.common;
using System.Configuration;
using com.force.json;
using XjHealth.Model;
using System.IO;
using XjHealth.lib;
using Newtonsoft.Json.Linq;
using mshtml;


namespace XjHealth.page.relax
{
    /// <summary>
    /// relaxmain.xaml 的交互逻辑
    /// </summary>
    public partial class relaxmain : Page
    {
        public static string Resturl;
        public relaxmain()
        {
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private string getFileDir()
        {
            System.IO.DirectoryInfo topDir = System.IO.Directory.GetParent(System.Environment.CurrentDirectory);
            string path1 = topDir.Parent.FullName;
            return path1;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Userinfo user = App.CurrentUser;
            string path1 = getFileDir();
            string path2 = @"\page\html\musicList.html";
            string pagePath = path1 + path2;
            WriteDatajs();
            webBrowser1.ObjectForScripting = new OprateBasic(this);
            webBrowser1.Navigate(pagePath);

        }

        private void WriteDatajs()
        {
            Userinfo user = App.CurrentUser;
            string path1 = getFileDir();
            string path2 = @"\page\html\js\music.js";
            string filePath = path1 + path2;
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            var client = new RestClient();
            client.EndPoint = Resturl + "/channel/7";
            client.Method = HttpVerb.GET;
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("var reqin=" + obj);
            sw.Flush();


            var qinsu = new RestClient();
            qinsu.EndPoint = Resturl + "/channel/8";
            qinsu.Method = HttpVerb.GET;
            jsonstr = qinsu.MakeRequest();
            obj = JObject.Parse(jsonstr);
            sw.Write(";var qinsu=" + obj);
            sw.Flush();

            var kuaile = new RestClient();
            kuaile.EndPoint = Resturl + "/channel/9";
            kuaile.Method = HttpVerb.GET;
            jsonstr = kuaile.MakeRequest();
            obj = JObject.Parse(jsonstr);
            sw.Write(";var kuaile="+obj);
            sw.Flush();

            var qinxin = new RestClient();
            qinxin.EndPoint = Resturl + "/channel/10";
            qinxin.Method = HttpVerb.GET;
            jsonstr = qinxin.MakeRequest();
            obj = JObject.Parse(jsonstr);
            sw.Write(";var qinxin="+obj);
            sw.Flush();

            var fansong = new RestClient();
            fansong.EndPoint = Resturl + "/channel/11";
            fansong.Method = HttpVerb.GET;
            jsonstr = fansong.MakeRequest();
            obj = JObject.Parse(jsonstr);
            sw.Write(";var fansong="+obj);
            sw.Flush();

            sw.Close();
            fs.Close();
        }

        public void PlayMusic(string url)
        {
            this.videoplayer.Source = new Uri(url, UriKind.RelativeOrAbsolute);
            videoplayer.Play();
        }

        public void PauseMusic()
        {
            videoplayer.Pause();
        }

        public void ChangePage(string titles,string urls)
        {
            MusicPlayer mp = new MusicPlayer(titles,urls);
            NavigationService.Navigate(mp);
            //NavigationService.Navigate(new Uri("page/relax/MusicPlayer.xaml", UriKind.Relative));
        }

        #region 无用
        private void player_MediaEnded(object sender, RoutedEventArgs e)
        {
            //设置一下视频进度，确保从头开始播放
            MessageBox.Show("播放完毕.....");
            playlist.Position = TimeSpan.Zero;
            playlist.Source = new Uri("http://123.57.26.108:8080/bio/assets/resource/music/assion/c06n6W2Esbc1.mp3", UriKind.RelativeOrAbsolute);
            playlist.Play();
        }

        private void myMediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            //playlist.Source= new Uri("resource/video/fuxi.mp4", UriKind.RelativeOrAbsolute);
            //playlist.Play();
        }

        #endregion
    }

    [System.Runtime.InteropServices.ComVisible(true)]
    public class OprateBasic
    {
        private relaxmain instance;
        public OprateBasic(relaxmain instance)
        {
            this.instance = instance;
        }

        public void PlayMusic(string url)
        {
            instance.PlayMusic(url);
        }

        public void PauseMusic()
        {
            instance.PauseMusic();
        }

        public void ChangePage(string titles,string urls)
        {
            instance.ChangePage(titles,urls);
        }
    }
}
