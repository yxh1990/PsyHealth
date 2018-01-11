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
using XjHealth.lib;
using System.Configuration;
using Newtonsoft.Json.Linq;
using XjHealth.BLL;
using XjHealth.Model;
using XjHealth.common;
using com.force.json;
using System.ComponentModel;

namespace XjHealth.page.record
{
    /// <summary>
    /// recordmain.xaml 的交互逻辑
    /// </summary>
    public partial class recordmain : Page
    {
        public TestReportResult Result { get; set; }
        public trainReportResult TrainResult { get; set; }
        public static string Resturl;
        public bool testflag = true;
        public recordmain()
        {
            Result = new TestReportResult();
            TrainResult = new trainReportResult();
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
        }

        public void Query(int size, int pageIndex)
        {
            if (testflag)
            {
                List<testReport> res = getUserTests();
                Result.Total = res.Count;
                Result.Reports = res.Skip((pageIndex - 1) * size).Take(size).ToList();
            }
            else
            {
                List<trainReport> tres = getUserTrianData();
                TrainResult.Total = tres.Count;
                TrainResult.Reports = tres.Skip((pageIndex - 1) * size).Take(size).ToList();
            }
        }

        private void PagingDataGrid_PagingChanged(object sender, CustomControlLibrary.PagingChangedEventArgs args)
        {
            testflag = true;
            Query(args.PageSize, args.PageIndex);
        }

        private void PagingDataGrid2_PagingChanged(object sender, CustomControlLibrary.PagingChangedEventArgs args)
        {
            testflag = false;
            Query(args.PageSize, args.PageIndex);
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void btn_cepin_Click(object sender, RoutedEventArgs e)
        {
            testflag = true;
            this.dataGrid1.Visibility = Visibility.Hidden;
            this.dataGrid2.Visibility = Visibility.Visible;
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            testflag = true;
            this.dataGrid1.Visibility = Visibility.Visible;
            this.dataGrid2.Visibility = Visibility.Hidden;
        }

        public List<trainReport> getUserTrianData()
        {
            var client = new RestClient();
            Userinfo user = App.CurrentUser;
            client.EndPoint = Resturl + "/train/list/"+ user.Id;
            client.Method = HttpVerb.GET;

            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);
            var trainDataList = obj["trainDataList"];

            List<trainReport> trainList = new List<trainReport>();
            for (int t = 0; t < trainDataList.Count(); t++)
            {
                trainList.Add(new trainReport()
                {
                    userId = trainDataList[t]["userId"].ToString(),
                    mood = trainDataList[t]["mood"].ToString(),
                    trainName = trainDataList[t]["trainName"].ToString(),
                    healthId = trainDataList[t]["healthId"].ToString(),
                    trainId = trainDataList[t]["trainId"].ToString(),
                    trainTime = trainDataList[t]["trainTime"].ToString(),
                    trainCostTime = trainDataList[t]["trainCostTime"].ToString(),
                    stress = trainDataList[t]["stress"].ToString(),
                    heartBeat = trainDataList[t]["heartBeat"].ToString()
                });
            }
            return trainList;
        }

        public List<testReport> getUserTests()
        {
            var client = new RestClient();
            Userinfo user = App.CurrentUser;
            client.EndPoint = Resturl + "/results/" + user.Id;
            client.Method = HttpVerb.GET;

            var jsonstr = client.MakeRequest();

            var obj = JObject.Parse(jsonstr);
            var testReportList = obj["testReportList"];

            List<testReport> testreports = new List<testReport>();
            for (int t=0;t<testReportList.Count();t++)
            {
                testreports.Add(new testReport() {
                    scaleListName = testReportList[t]["scaleListName"].ToString(),
                    scaleTestDateTime = testReportList[t]["scaleTestDateTime"].ToString(),
                    scaleTestTime = testReportList[t]["scaleTestTime"].ToString(),
                    resultId = testReportList[t]["resultId"].ToString()
                });
            }
            return testreports;
        }

        private void btn_replay_Click(object sender, RoutedEventArgs e)
        {
            Button btnreplay = (Button)sender;
            int hid = int.Parse(btnreplay.Tag.ToString());
            replay re = new replay(hid, "heartBeatList");
            NavigationService.Navigate(re);
        }

        private void btn_report_Click(object sender, RoutedEventArgs e)
        {
            Button btnreport = (Button)sender;
            string id=btnreport.Tag.ToString();
            getxunliandata(id);
            this.grid_testreport.Visibility = Visibility.Visible;
        }

        private void getxunliandata(string rid)
        {
            var client = new RestClient();
            client.EndPoint = Resturl+"/train/report/"+ rid;
            client.Method = HttpVerb.GET;
            var jsonstr = client.MakeRequest();
            var obj = JObject.Parse(jsonstr);

            this.traincon.Content = obj["tr"]["trainName"];
            this.traindu.Content = obj["tr"]["hard"];
            this.trainstartTime.Content = obj["tr"]["beginTime"];
            this.trainendTime.Content = obj["tr"]["endTime"];
            this.txtcon.Text= "综合评价分数\r\n\0" + obj["tr"]["scoreDesc"] + "\r\n\r\n稳定指数\r\n\0" + obj["tr"]["proposal"]+ "\r\n\r\n情绪指数\r\n\0" + obj["tr"]["estimate"];
        }

        private void btn_testAnswer_Click(object sender, RoutedEventArgs e)
        {
            Button btnanswer = (Button)sender;
            int aid = int.Parse(btnanswer.Tag.ToString());
            string time = btnanswer.Uid.ToString();
            answerreport ap = new answerreport(aid,time);
            NavigationService.Navigate(ap);
        }

        private void btn_testReport_Click(object sender, RoutedEventArgs e)
        {
            Button btntestreport= (Button)sender;
            int tid = int.Parse(btntestreport.Tag.ToString());
            trainreport tr = new trainreport(tid);
            NavigationService.Navigate(tr);
        }

        private void btn_guanbi_Click(object sender, RoutedEventArgs e)
        {
            this.grid_testreport.Visibility = Visibility.Hidden;
        }
    }

    public class TestReportResult:INotifyPropertyChanged
    {
        public int _total;
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    RaisePropertyChanged("Total");
                }
            }
        }

        private List<testReport> _reports;
        public List<testReport> Reports
        {
            get
            {
                return _reports;
            }
            set
            {
                if (_reports != value)
                {
                    _reports = value;
                    RaisePropertyChanged("Reports");
                }
            }
        }

        public TestReportResult()
        {
            Reports = new List<testReport>();
        }

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class testReport
    {
        public string scaleListName { get; set; }
        public string scaleTestDateTime { get; set; }
        public string scaleTestTime { get; set;  }
        public string resultId { get; set; }
    }

    public class trainReport
    {
        public string userId { get; set; }
        public string trainName { get; set; }
        public string mood { get; set; }
        public string trainId { get; set; }
        public string trainTime { get; set; }
        public string trainCostTime { get; set; }
        public string stress { get; set; }
        public string heartBeat { get; set; }
        public string healthId { get; set; }
    }

    public class trainReportResult : INotifyPropertyChanged
    {
        public int _total;
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    RaisePropertyChanged("Total");
                }
            }
        }

        private List<trainReport> _reports;
        public List<trainReport> Reports
        {
            get
            {
                return _reports;
            }
            set
            {
                if (_reports != value)
                {
                    _reports = value;
                    RaisePropertyChanged("Reports");
                }
            }
        }

        public trainReportResult()
        {
            Reports = new List<trainReport>();
        }

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
