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
using XjHealth.lib;
using com.force.json;
using Newtonsoft.Json.Linq;

namespace XjHealth.page.cepin
{
    /// <summary>
    /// cepinend.xaml 的交互逻辑
    /// </summary>
    public partial class cepinend : Page
    {
        public static string Resturl;
        public int rid = 0;
        public cepinend(int id)
        {
            InitializeComponent();
            rid = id;
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            getResult(rid);
        }
        public void getResult(int rid)
        {
            Userinfo user = App.CurrentUser;
            var client = new RestClient();
            client.EndPoint = Resturl + "/result/report";
            client.Method = HttpVerb.POST;

            JSONObject rootJson = new JSONObject();
            rootJson.Put("anId", user.Id);
            rootJson.Put("resultId", rid);
            client.PostData = rootJson.ToString();
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);

            for (int t = 0; t < obj["report"]["personTestVerdictList"].Count(); t++)
            {
               sdesc.Text = sdesc.Text + obj["report"]["personTestVerdictList"][t]["verdictName"] +"\r\n"+obj["report"]["personTestVerdictList"][t]["verdictDesc"] + "\r\n"+ obj["report"]["personTestVerdictList"][t]["proposal"] + "\r\n";
            }
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }
    }
}
