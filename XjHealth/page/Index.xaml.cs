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
           //string resturl=ConfigurationManager.AppSettings["resturl"];
           var client = new RestClient();
           client.EndPoint = Resturl + "/person/login"; 
           client.Method = HttpVerb.POST;
            /* 
             * 错误的json格式,这种请求的发送方式会失败
             * {'name':'admin','password':'admin'} 
             * 正确的格式里面的双引号不能改成单引号
             * "{\"name\":\"admin\",\"password\":\"admin\"}"
             * obj=JObject.Parse(jsonstr)
             * 可以像js一样操作obj["pi"]["name"].ToString()
             */
            string username = this.txtusername.Text.Trim();
            string password = this.txtpassword.Password.Trim();
            client.PostData = "{\"name\":\"{0}\",\"password\":\"{1}\"}".Replace("{0}", username).Replace("{1}", password);
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
                this.btn_usertologin.Visibility = Visibility.Hidden;
                this.btn_userlogout.Visibility = Visibility.Visible;
            }

        }

        private void btn_updatepass_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient();
            client.EndPoint = Resturl + "/person/updatepwd";
            client.Method = HttpVerb.POST;
            //"\"" + dc.ColumnName + "\":\"" + dr[dc].ToString() + "\",";
            string oldpasswd = this.txtoldpasswd.Password;
            string pass1 = this.txtnewpasswd1.Password;
            string pass2 = this.txtnewpasswd2.Password;
            if(pass1 != pass2)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            client.PostData = "{\"id\":" + App.CurrentUser.Id +",\"oldPwd\":\""+ oldpasswd + "\",\"newPwd\":\"" + pass2 + "\"}";
            //MessageBox.Show(client.PostData);
            var jsonstr = client.MakeRequest();
            ResultInfo result = ub.check_user_updatepass(jsonstr);
            MessageBox.Show(result.Resultmsg);
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
