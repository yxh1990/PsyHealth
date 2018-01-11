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
using System.IO;
using XjHealth.Model;
using XjHealth.lib;
using Newtonsoft.Json.Linq;
using System.Configuration;
using com.force.json;

namespace XjHealth.page.record
{
    /// <summary>
    /// trainreport.xaml 的交互逻辑
    /// </summary>
    public partial class trainreport : Page
    {
        public int tid = 0;
        public static string Resturl;
        public trainreport(int id)
        {
            InitializeComponent();
            tid = id;
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Userinfo user = App.CurrentUser;
            string path1 = getFileDir();
            string path2 = @"\page\html\report.html?uid="+user.Id;
            string pagePath = path1 + path2;
            WriteDatajs();
            webBrowser1.Navigate(pagePath);
        }

        private string getFileDir()
        {
            System.IO.DirectoryInfo topDir = System.IO.Directory.GetParent(System.Environment.CurrentDirectory);
            string path1 = topDir.Parent.FullName;
            return path1;
        }

        private void WriteDatajs()
        {
            Userinfo user = App.CurrentUser;
            string path1 = getFileDir();
            string path2 = @"\page\html\js\config_{0}.js".Replace("{0}", user.Id.ToString());
            string filePath = path1 + path2;
            FileStream fs = new FileStream(filePath,FileMode.Create,FileAccess.Write);

            
            var client = new RestClient();
            client.EndPoint = Resturl + "/result/report";
            client.Method = HttpVerb.POST;

            JSONObject json = new JSONObject();
            json.Put("anId", user.Id);
            json.Put("resultId", tid);
            client.PostData = json.ToString();
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);

            StreamWriter sw = new StreamWriter(fs);
            sw.Write("var result="+obj);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/record/recordmain.xaml", UriKind.Relative));
        }
    }
}
