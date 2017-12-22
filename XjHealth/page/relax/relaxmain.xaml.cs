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

namespace XjHealth.page.relax
{
    /// <summary>
    /// relaxmain.xaml 的交互逻辑
    /// </summary>
    public partial class relaxmain : Page
    {
        public relaxmain()
        {
            InitializeComponent();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("5555");
            //this.btn_minxiang.ImgPath = "/resource/img/relax_mxfs_B.png";
        }

        private void btn_minxiang_Click(object sender, RoutedEventArgs e)
        {
            minxiangpanel.Visibility = Visibility.Visible;
            jrfspanel.Visibility = Visibility.Hidden;
            yyfspanel.Visibility = Visibility.Hidden;

            utils.changeButtonBgPic(this, btn_jrfs, "/resource/img/relax_jrfs_A.png");
            utils.changeButtonBgPic(this, btn_minxiang, "/resource/img/relax_mxfs_C.png");
            utils.changeButtonBgPic(this, btn_yyfs, "/resource/img/relax_yyfs_A.png");

        }

        private void btn_jrfs_Click(object sender, RoutedEventArgs e)
        {
            minxiangpanel.Visibility = Visibility.Hidden;
            jrfspanel.Visibility = Visibility.Visible;
            yyfspanel.Visibility = Visibility.Hidden;


            /* 
             * 这样修改模板中的背景图片无效
              this.btn_jrfs.ImgPath = "/resource/img/relax_jrfs_C.png";
            */
            utils.changeButtonBgPic(this, btn_jrfs, "/resource/img/relax_jrfs_C.png");
            utils.changeButtonBgPic(this, btn_minxiang, "/resource/img/relax_mxfs_A.png");
            utils.changeButtonBgPic(this, btn_yyfs, "/resource/img/relax_yyfs_A.png");
        }

        private void btn_yyfs_Click(object sender, RoutedEventArgs e)
        {
            minxiangpanel.Visibility = Visibility.Hidden;
            jrfspanel.Visibility = Visibility.Hidden;
            yyfspanel.Visibility = Visibility.Visible;

            utils.changeButtonBgPic(this, btn_jrfs, "/resource/img/relax_jrfs_A.png");
            utils.changeButtonBgPic(this, btn_minxiang, "/resource/img/relax_mxfs_A.png");
            utils.changeButtonBgPic(this, btn_yyfs, "/resource/img/relax_yyfs_C.png");
        }
    }
}
