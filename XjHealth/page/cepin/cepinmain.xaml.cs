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
using System.Configuration;
using XjHealth.Model;
using XjHealth.common;
using XjHealth.lib;
using Newtonsoft.Json.Linq;

namespace XjHealth.page.cepin
{
    /// <summary>
    /// cepinmain.xaml 的交互逻辑
    /// </summary>
    public partial class cepinmain : Page
    {
        public static string Resturl;
        public List<int> sids=new List<int>();
        public cepinmain()
        {
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            int sid = 0;
            string btnname = ((ImageButton)sender).Name;
            if (btnname == "btnTest1")
            {
                Application.Current.Properties["stitle"] = this.title0.Content;
                Application.Current.Properties["sdesc"] = this.desc0.Text;
                sid = sids[0];
            }
            else if (btnname == "btnTest2")
            {
                Application.Current.Properties["stitle"] = this.title1.Content;
                Application.Current.Properties["sdesc"] = this.desc1.Text;
                sid = sids[1];
            }
            else if (btnname == "btnTest3")
            {
                Application.Current.Properties["stitle"] = this.title2.Content;
                Application.Current.Properties["sdesc"] = this.desc2.Text;
                sid = sids[2];
            }
            else if (btnname == "btnTest4")
            {
                Application.Current.Properties["stitle"] = this.title3.Content;
                Application.Current.Properties["sdesc"] = this.desc3.Text;
                sid = sids[3];
            }
            cepinstart cp = new cepinstart(sid);
            NavigationService.Navigate(cp);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            getScales();
        }

        public void getScales()
        {
            Userinfo user = App.CurrentUser;
            var client = new RestClient();
            client.EndPoint = Resturl + "/scale/scales";
            client.Method = HttpVerb.POST;
            client.PostData = "{\"userId\":\"{0}\",\"roleId\":\"{1}\"}".Replace("{0}", user.Id.ToString()).Replace("{1}", user.RoleId.ToString());
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);
            for (int t=0;t<obj["scaleBasicInfos"].Count();t++)
            {
                 sids.Add(Convert.ToInt32(obj["scaleBasicInfos"][t]["id"]));
                ((Label)this.FindName("title"+t)).Content = obj["scaleBasicInfos"][t]["name"].ToString().Substring(0,6);
                ((TextBlock)this.FindName("desc" + t)).Text = obj["scaleBasicInfos"][t]["scaleDesc"].ToString().Substring(0,110);
            }
        }
    }
}
