using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XjHealth.Model;

namespace XjHealth
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static Userinfo CurrentUser = new Userinfo();
        public static ShowtbType stype=ShowtbType.hr;
    }

    public enum ShowtbType
    {
        hr,
        hrv,
        stress,
        mood
    }
}
