using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace XjHealth.common
{
   public class utils
    {

        /// <summary>
        /// 动态修改模板中的图片路径属性
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="btn"></param>
        /// <param name="picurl"></param>
        public static void changeButtonBgPic(Page obj,Button btn,string picurl)
        {
            ControlTemplate temp = (ControlTemplate)obj.TryFindResource("ImageButtonTemplate");
            ImageBrush img_brush= temp.FindName("btnImg", btn) as ImageBrush;
            img_brush.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,"+picurl));
        }
    }
}
