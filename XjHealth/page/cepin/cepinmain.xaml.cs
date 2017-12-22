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
    /// cepinmain.xaml 的交互逻辑
    /// </summary>
    public partial class cepinmain : Page
    {
        public cepinmain()
        {
            InitializeComponent();
        }

        private void btn_backmain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/Index.xaml", UriKind.Relative));
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("page/cepin/cepinstart.xaml", UriKind.Relative));
        }
    }
}
