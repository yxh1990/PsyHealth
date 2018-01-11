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
using System.IO;

namespace XjHealth.page
{
    /// <summary>
    /// Index.xaml 的交互逻辑
    /// </summary>
    public partial class Index : Page
    {
        public static string Resturl;
        public UserBLL ub = new UserBLL();
        public Index()
        {
            InitializeComponent();
            Resturl = ConfigurationManager.AppSettings["resturl"];
            this.lbl_time.Content = dateFormat.formateToday();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Userinfo user = App.CurrentUser;
            if(user.Id>0)
            {
                setenablePage();
                this.lbl_username.Content = user.LogonName;
            }
            else
            {
                setDisablePage();
            }
        }

        private void setenablePage()
        {
            this.btn_usertologin.Visibility = Visibility.Hidden;
            this.btn_userlogout.Visibility = Visibility.Visible;

            this.btn_cepin.ImgPath = "/resource/img/index_scale_A.png";
            this.btn_cepin.IsEnabled = true;

            this.btn_jiance.ImgPath = "/resource/img/index_monitor_A.png";
            this.btn_jiance.IsEnabled = true;

            this.btn_xunlian.ImgPath = "/resource/img/index_train_A.png";
            this.btn_xunlian.IsEnabled = true;

            this.btn_jilu.ImgPath = "/resource/img/index_record_A.png";
            this.btn_jilu.IsEnabled = true;

            this.btn_geren.ImgPath = "/resource/img/index_user_D.png";
            this.btn_geren.IsEnabled = true;
        }

        private void setDisablePage()
        {
            this.btn_cepin.ImgPath = "/resource/img/index_scale_D.png";
            this.btn_cepin.IsEnabled = false;

            this.btn_jiance.ImgPath = "/resource/img/index_monitor_D.png";
            this.btn_jiance.IsEnabled = false;

            this.btn_xunlian.ImgPath = "/resource/img/index_train_D.png";
            this.btn_xunlian.IsEnabled = false;

            this.btn_jilu.ImgPath = "/resource/img/index_record_D.png";
            this.btn_jilu.IsEnabled = false;

            this.btn_geren.ImgPath = "/resource/img/index_user_D.png";
            this.btn_geren.IsEnabled = false;
        }


        /// <summary>
        /// 展示用户信息
        /// </summary>
        private void displayUserinfo()
        {
            Userinfo user = App.CurrentUser;
            txt_username.Text = user.LogonName;
            txt_code.Text = user.Code;
            txt_logonName.Text = user.Name;
            txt_sex.Text = user.Sex;
            txt_nation.Text = user.Nation;
            txt_age.Text = user.Age + "";
            txt_edu.Text = user.Edu;
            txt_role.Text = user.RoleName;
        }

        private void btn_usertologin_Click(object sender, RoutedEventArgs e)
        {
            this.txtusername.Text = "";
            this.txtpassword.Password = "";

            this.loginwindow.Visibility = Visibility.Visible;
            this.txtusername.Focus();
        }

        private void btn_exitlogin_Click(object sender, RoutedEventArgs e)
        {
            this.txtusername.Text = "";
            this.txtpassword.Password = "";
            this.loginwindow.Visibility = Visibility.Hidden;
        }

        private void btn_xuexi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/xuexi/learnmain.xaml", UriKind.Relative));
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            this.txtusername.Text = "";
            this.txtpassword.Password = "";
            this.txtusername.Focus();
        }

        private void btn_geren_Click(object sender, RoutedEventArgs e)
        {
            this.loginwindow.Visibility = Visibility.Hidden;
            this.userinfowindow.Visibility = Visibility.Visible;
            displayUserinfo();
        }

        private void btn_userinfoexit_Click(object sender, RoutedEventArgs e)
        {
            this.loginwindow.Visibility = Visibility.Hidden;
            this.userinfowindow.Visibility = Visibility.Hidden;
            this.txtoldpasswd.Password = "";
            this.txtnewpasswd1.Password = "";
            this.txtnewpasswd2.Password = "";
        }

        private void btn_userchangepass_Click(object sender, RoutedEventArgs e)
        {
            this.btntoolbar1.Visibility = Visibility.Hidden;
            this.btn_userchangepass.Visibility = Visibility.Hidden;
            this.btntoolbar2.Visibility = Visibility.Visible;
            this.btn_userinfo.Visibility = Visibility.Visible;
            this.grid_changepasswd.Visibility = Visibility.Visible;
            this.grid_userinfo.Visibility = Visibility.Hidden;
        }

        private void btn_userinfo_Click(object sender, RoutedEventArgs e)
        {
            this.btntoolbar1.Visibility = Visibility.Visible;
            this.btn_userchangepass.Visibility = Visibility.Visible;
            this.btntoolbar2.Visibility = Visibility.Hidden;
            this.btn_userinfo.Visibility = Visibility.Hidden;
            this.grid_changepasswd.Visibility = Visibility.Hidden;
            this.grid_userinfo.Visibility = Visibility.Visible;
            displayUserinfo();
        }

        private void btn_cepin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/cepin/cepinmain.xaml", UriKind.Relative));
        }

        private void btn_fangsong_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/relax/relaxmain.xaml", UriKind.Relative));
        }

        private void btn_xunlian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/train/trainmain.xaml", UriKind.Relative));
        }

        private void btn_jilu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/record/recordmain.xaml", UriKind.Relative));
        }

        private void btn_jiance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/jiance/jiancemain.xaml", UriKind.Relative));
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
           var client = new RestClient();
           client.EndPoint = Resturl + "/person/login"; 
           client.Method = HttpVerb.POST;
          
           string username = this.txtusername.Text.Trim();
           string password = this.txtpassword.Password.Trim();

            JSONObject json = new JSONObject();
            json.Put("name", username);
            json.Put("password", password);
            client.PostData = json.ToString();
            
            var jsonstr = client.MakeRequest();
            ResultInfo result = ub.check_user_login(jsonstr);
            if (result.Resultmsg!="")
            {
                MessageBox.Show(result.Resultmsg);
            }
            else
            {   
                //用户登录成功
                this.loginwindow.Visibility = Visibility.Hidden;
                this.lbl_username.Content = username;
                setenablePage();
            }

        }

        private void btn_updatepass_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient();
            client.EndPoint = Resturl + "/person/updatepwd";
            client.Method = HttpVerb.POST;
            string oldpasswd = this.txtoldpasswd.Password;
            string pass1 = this.txtnewpasswd1.Password;
            string pass2 = this.txtnewpasswd2.Password;
            if(pass1 != pass2)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            client.PostData = "{\"id\":" + App.CurrentUser.Id +",\"oldPwd\":\""+ oldpasswd + "\",\"newPwd\":\"" + pass2 + "\"}";
            var jsonstr = client.MakeRequest();
            ResultInfo result = ub.check_user_updatepass(jsonstr);
            if (result.Id == "0")
            {
               this.loginwindow.Visibility = Visibility.Hidden;
               this.userinfowindow.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("退出登录");
            this.loginoutwindow.Visibility = Visibility.Visible;
            this.userinfowindow.Visibility = Visibility.Hidden;
        }

        private void btn_exitcancle_Click(object sender, RoutedEventArgs e)
        {
            this.loginoutwindow.Visibility = Visibility.Hidden;
        }

        private void btn_exitok_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentUser = new Userinfo();
            this.loginoutwindow.Visibility = Visibility.Hidden;
            this.btn_usertologin.Visibility = Visibility.Visible;
            this.btn_userlogout.Visibility = Visibility.Hidden;
            lbl_username.Content = "游客";
            setDisablePage();
        }

        private void btn_cancelupdatepass_Click(object sender, RoutedEventArgs e)
        {
            this.userinfowindow.Visibility = Visibility.Hidden;
            this.txtoldpasswd.Password = "";
            this.txtnewpasswd1.Password = "";
            this.txtnewpasswd2.Password = "";
        }
    }
}
