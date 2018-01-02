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

namespace XjHealth.page.cepin
{
    /// <summary>
    /// cepinstart.xaml 的交互逻辑
    /// </summary>
    public partial class cepinstart : Page
    {
        public int sid = 0;
        public cepinstart(int id)
        {
            InitializeComponent();
            sid = id;
            showcepindata();
        }

        public void showcepindata()
        {
            this.stitle.Content = Application.Current.Properties["stitle"];
            this.sdesc.Text = Application.Current.Properties["sdesc"].ToString();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            cepin cp = new cepin(sid); 
            NavigationService.Navigate(cp);
        }
    }
}
