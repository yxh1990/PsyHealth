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
using System.IO;
using XjHealth.Model;
using XjHealth.lib;
using Newtonsoft.Json.Linq;
using System.Configuration;
using com.force.json;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using System.Windows.Threading;
using System.Diagnostics;

namespace XjHealth.page.record
{
    /// <summary>
    /// replay.xaml 的交互逻辑
    /// </summary>
    public partial class replay : Page
    {
        public int hid = 0;
        public string tbname = "";
        public static string Resturl;
        public List<int> ypoints = new List<int>();

        private ObservableDataSource<Point> dataSource = new ObservableDataSource<Point>();
        private DispatcherTimer timer = new DispatcherTimer();
        private int i = 0;
        public replay(int id,string typename)
        {
            hid = id;
            tbname = typename;
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
            ypoints = GetYpoints();
        }

        private List<int> GetYpoints()
        {
            var client = new RestClient();
            client.EndPoint = Resturl +"/train/back/"+hid;
            client.Method = HttpVerb.GET;
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);

            List<int> points = new List<int>();
            var lists = obj["tb"][tbname];
            for(int t=0;t<lists.Count();t++)
            {
                points.Add(int.Parse(lists[t].ToString()));
            }
            return points;
        }

        private void AnimatedPlot(object sender, EventArgs e)
        {
            double x = i;
            double y = ypoints[i];

            Point point = new Point(x, y);
            dataSource.AppendAsync(base.Dispatcher, point);
            i++;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            plotter.AddLineGraph(dataSource, Colors.Red, 2, tbname.Replace("List",""));
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(AnimatedPlot);
            timer.IsEnabled = true;
            plotter.Viewport.FitToView();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/record/recordmain.xaml", UriKind.Relative));
        }

        private void btn_stress_Click(object sender, RoutedEventArgs e)
        {
            replay re = new replay(hid, "stressList");
            NavigationService.Navigate(re);
        }

        private void btn_hrv_Click(object sender, RoutedEventArgs e)
        {
            replay re = new replay(hid, "hrvList");
            NavigationService.Navigate(re);
        }

        private void btn_mood_Click(object sender, RoutedEventArgs e)
        {
            replay re = new replay(hid, "moodList");
            NavigationService.Navigate(re);
        }

        private void btn_hr_Click(object sender, RoutedEventArgs e)
        {
            replay re = new replay(hid, "signalList");
            NavigationService.Navigate(re);
        }
    }
}
