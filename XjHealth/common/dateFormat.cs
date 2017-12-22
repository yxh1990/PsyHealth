using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjHealth.common
{
    public class dateFormat
    {
        public static string formateToday()
        {
            DateTime d = DateTime.Now;
            string s = d.ToString("yyyy年MM月dd日");
            return s;
        }
    }
}
