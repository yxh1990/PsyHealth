using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PsyHealth.lib;

namespace PsyHealth
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        // 设置的分辨率
        int fixWidth = 1024;
        int fixHeight = 768;

        int screenWidth = 0;
        int screenHeight = 0;

        //程序一退出便还原分辨率
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            //ChangeResolution ChangeRes = new ChangeResolution(screenWidth, screenHeight);
        }

        //程序一启动就设置合适分辨率
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            screenHeight = (int)SystemParameters.PrimaryScreenHeight;
            screenWidth = (int)SystemParameters.PrimaryScreenWidth;
            //ChangeResolution ChangeRes = new ChangeResolution(fixWidth, fixHeight);
        }
    }
}
