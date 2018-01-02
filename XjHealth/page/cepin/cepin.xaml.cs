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
using XjHealth.Model;
using XjHealth.lib;
using Newtonsoft.Json.Linq;
using System.Configuration;
using XjHealth.common;
using System.Collections;
using com.force.json;

namespace XjHealth.page.cepin
{
    /// <summary>
    /// cepin.xaml 的交互逻辑
    /// </summary>
    public partial class cepin : Page
    {
        public static string Resturl;
        public int sid = 0;
        public int scount = 0;
        public JToken ScaleItemObjs;
        public int s_index = 0;
        public DateTime startTime;
        public DateTime endTime;
        public cepin(int id)
        {
            InitializeComponent();
            sid = id;
            Resturl = ConfigurationManager.AppSettings["resturl"];
            startTime = DateTime.Now;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            getScaleTests();
        }


        public void getScaleTests()
        {
            Userinfo user = App.CurrentUser;
            var client = new RestClient();
            client.EndPoint = Resturl + "/scale/"+sid;
            client.Method = HttpVerb.GET;
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);

            ScaleItemObjs = obj["scaleInfo"]["firstScaleItem"];
            scount = ScaleItemObjs.Count();
           
            createChoices();
        }

        public void createChoices()
        {
            this.cpanel.Children.RemoveRange(0,this.cpanel.Children.Count);
            this.sindex.Content = "序号:{0}/{1}".Replace("{0}", (s_index+1)+"").Replace("{1}", scount.ToString());
            var fristobj = ScaleItemObjs[s_index];
            this.stitle.Content = fristobj["text"];

            for (int t = 0; t < fristobj["scaleChoices"].Count(); t++)
            {
                XjHealth.lib.ImageButton imgbtn = new ImageButton();
                imgbtn.Template = this.Resources["ImageButtonTemplate"] as ControlTemplate;
                imgbtn.ImgPath = "/resource/img/scale_option.png";
                imgbtn.MouseOverImgPath = "/resource/img/scale_option.png";
                imgbtn.Width = 750;
                imgbtn.Height = 35;
                imgbtn.Margin = new Thickness(10);
                imgbtn.Cursor = Cursors.Hand;
                imgbtn.FontSize = 18;
                imgbtn.Foreground = new SolidColorBrush(Colors.White);
                imgbtn.Tag = fristobj["scaleChoices"][t]["id"] + "@" + fristobj["scaleChoices"][t]["score"]+"@"+ fristobj["rowNr"];
                
                imgbtn.Content = fristobj["scaleChoices"][t]["optionCaption"] + "." + fristobj["scaleChoices"][t]["visDesc"].ToString();
                imgbtn.Click += ImageButton_Click;
                this.cpanel.Children.Add(imgbtn);
            }
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        JSONArray resultAnswerList = new JSONArray();
        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            string tagstr =(string)((ImageButton)sender).Tag;
            var tagarray = tagstr.Split('@');
            JSONObject json = new JSONObject();
            json.Put("blankTest","");
            json.Put("choiceID",tagarray[0]);
            json.Put("score",tagarray[1]);
            json.Put("syn",int.Parse(tagarray[2]) - 1);

            resultAnswerList.Put(json);
            
            if (s_index >= scount-1)
            {
                saveUserChoice(resultAnswerList);
            }
            else
            {
                s_index = s_index + 1;
                createChoices();
            }
        }

        public void saveUserChoice(JSONArray resultAnswerList)
        {
            endTime = DateTime.Now;
            string starttimestr=startTime.ToString("yyyy-MM-dd HH:mm:ss");
            string endtimestr= endTime.ToString("yyyy-MM-dd HH:mm:ss");
            TimeSpan d3 = endTime.Subtract(startTime);
            string textTime = d3.Seconds.ToString();
            Userinfo user = App.CurrentUser;
            int anID = user.Id;
            int answerAge = user.Age;


            var client = new RestClient();
            client.EndPoint = Resturl + "/result/insert";
            client.Method = HttpVerb.POST;

            JSONObject rootJson = new JSONObject();
            JSONObject json = new JSONObject();
            json.Put("anID", anID);
            json.Put("answerAge",answerAge);
            json.Put("beginTime",starttimestr);
            json.Put("endTime",endtimestr);
            json.Put("scaleID", sid);
            json.Put("textTime", textTime);
            json.Put("resultAnswerList", resultAnswerList);
            rootJson.Put("result",json);
            client.PostData = rootJson.ToString();

            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);
            int rid =Convert.ToInt32(obj["id"]);

            cepinend cpend = new cepinend(rid);
            NavigationService.Navigate(cpend);
        }
    }
}
