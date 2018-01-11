using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MyMP3.Class
{
    public partial class AppPropertys
    {
        public static MainWindow mainWindow;
        public static NotifyIcon notifyIcon = new NotifyIcon();
        public static string appPath = AppDomain.CurrentDomain.BaseDirectory;

        public static bool IsShowWindow = true;


        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);
        public static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        public static void Initialize()
        {
            MenuItem[] menuItems = new MenuItem[8];

            menuItems[0] = new MenuItem();
            menuItems[0].Text = "显示桌面歌词";
            menuItems[0].Checked = true;
            menuItems[0].Click += new EventHandler(nofityShow_Click);

            menuItems[1] = new MenuItem();
            menuItems[1].Text = "播放(&P)";
            menuItems[1].Click += new EventHandler(nofityPlay_Click);
            menuItems[2] = new MenuItem();
            menuItems[2].Text = "停止(&P)";
            menuItems[2].Click += new EventHandler(nofityStop_Click);
            menuItems[3] = new MenuItem();
            menuItems[3].Text = "上一曲(&P)";
            menuItems[3].Click += new EventHandler(nofityPlayPrevent_Click);
            menuItems[4] = new MenuItem();
            menuItems[4].Text = "下一曲(&P)";
            menuItems[4].Click += new EventHandler(nofityPlayNext_Click);

            menuItems[5] = new MenuItem();
            menuItems[5].Text = "设置(&P)";
            menuItems[6] = new MenuItem();
            menuItems[6].Text = "关于(&P)";
            menuItems[7] = new MenuItem();
            menuItems[7].Text = "退出";
            menuItems[7].Click += new EventHandler(notifyExit_Click);

            notifyIcon.ContextMenu = new ContextMenu(menuItems);
        }
        private static bool isPlaying = false;
        public static bool IsPlaying
        {
            get
            {
                return isPlaying;
            }
            set
            {
                isPlaying = value;
                if (isPlaying)
                {
                    notifyIcon.ContextMenu.MenuItems[1].Text = "暂停";
                }
                else
                {
                    notifyIcon.ContextMenu.MenuItems[1].Text = "播放";
                }
            }
        }
        /// <summary>
        /// 更改托盘图标
        /// </summary>
        /// <param name="state">状态（0：常态，1：播放，2：暂停，3：停止）</param>
        public static void ChangeNotifyIcon(int state)
        {
        }

        /// <summary>
        /// 双击托盘区事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            mainWindow.Show();
            mainWindow.Activate();
            IsShowWindow = true;
        }

        /// <summary>
        /// 单击托盘区“退出”菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void notifyExit_Click(object sender, EventArgs e)
        {
            setFreeNotifyIcon();
            Environment.Exit(0);
        }

        /// <summary>
        /// 释放托盘区图标
        /// </summary>
        public static void setFreeNotifyIcon()
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
        }

        static void nofityShow_Click(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            mi.Checked = !mi.Checked;
            
        }

        public static void nofityPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                
                PlayController.WMP.Pause();
            }
            else
            {
                PlayController.WMP.Play();
            }
        }

        public static void nofityStop_Click(object sender, EventArgs e)
        {
            PlayController.WMP.Stop();
        }

        public static void nofityPlayPrevent_Click(object sender, EventArgs e)
        {
            PlayController.PlayPrevent();
        }

        public static void nofityPlayNext_Click(object sender, EventArgs e)
        {
            PlayController.PlayNext();
        }
    }
}
