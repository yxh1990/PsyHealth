using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace XjHealth.common
{
   public static class utils
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

        /// <summary>
        /// 将List转换成DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                dt.Columns.Add(property.Name, property.PropertyType);
            }
            object[] values = new object[properties.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }
    }
}
