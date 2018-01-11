using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyMP3.Class;
using System.Windows.Threading;
using Forms = System.Windows.Forms;
using System.IO;
using System.Xml;


namespace MyMP3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppPropertys.mainWindow = this;
            AppPropertys.Initialize();
            PlayController.Initialize();
        }
        private void MouseDown_Window(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MouseDown_Minimize(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.Hide();
                AppPropertys.IsShowWindow = false;
            }
        }

        private void MouseDown_Close(object sender, MouseButtonEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlayList(AppPropertys.appPath + @"\playlist\default.xml");
            PlayController.PlayIndex = 0;
            PlayController.PlayMusic();

        }


        private void playListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (PlayController.PlayIndex != playListBox.SelectedIndex)
            {
                PlayController.PlayIndex = playListBox.SelectedIndex;
                PlayController.PlayMusic();
            }
        }


        private void openFolder(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles("*.mp3", SearchOption.AllDirectories);
            if (files != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppPropertys.appPath + @"\playlist\default.xml");
                XmlNode root = xmlDoc.SelectSingleNode("MusicList");

                foreach (FileInfo file in files)
                {
                    string f = file.FullName;
                    Song s = new Song(f);
                    if (s.Author != null)
                        if (File.Exists(@"G:\Music\images\Artist\" + s.Author + ".jpg"))
                            s.Pic = @"G:\Music\images\Artist\" + s.Author + ".jpg";
                    if (s.Album != null)
                        if (File.Exists(@"G:\Music\images\Artist\" + s.Album + ".jpg"))
                            s.Pic = @"G:\Music\images\Artist\" + s.Album + ".jpg";
                    XmlElement xe1 = xmlDoc.CreateElement("Song");
                    xe1.SetAttribute("Name", s.Name);
                    xe1.SetAttribute("Url", s.Url);
                    xe1.SetAttribute("Album", s.Album);
                    xe1.SetAttribute("Author", s.Author);
                    xe1.SetAttribute("Duration", s.Duration);
                    xe1.SetAttribute("Pic", s.Pic);
                    xe1.SetAttribute("Size", s.Size);
                    root.AppendChild(xe1);
                    PlayController.Songs.Add(s);
                    playListBox.Items.Add(s);
                }
                xmlDoc.Save(AppPropertys.appPath + @"\playlist\default.xml");
            }
        }

        private void LoadPlayList(string xmlFileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFileName);
            XmlNode root = xmlDoc.SelectSingleNode("MusicList");
            foreach (XmlElement node in root)
            {
                Song s = new Song();
                s.Name = node.GetAttribute("Name");
                s.Url = node.GetAttribute("Url");
                s.Author = node.GetAttribute("Author");
                s.Album = node.GetAttribute("Album");
                s.Duration = node.GetAttribute("Duration");
                s.Size = node.GetAttribute("Size");
                s.Pic = node.GetAttribute("Pic");
                PlayController.Songs.Add(s);
                playListBox.Items.Add(s);
            }
        }
   
        private void Maximize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
                Maximize.Text = "2";
                Maximize.ToolTip = "还原";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                Maximize.Text = "1";
                Maximize.ToolTip = "最大化";
            }
        }

        private void logoIco_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void Window_Activated(object sender, EventArgs e)
        {
            AppPropertys.IsShowWindow = true;
        }

        private void fileOpen_Click(object sender, RoutedEventArgs e)
        {
            string[] files = File_Open("所有音频文件|*.mp3;*.WMV;*.WMA;*.WAV;*.MID;*.M4A|MP3|*.MP3|WMV|*.WMV|MID|*.MID|WAV|*.WAV|WMA|*.WMA", true);
            if (files != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppPropertys.appPath + @"\playlist\default.xml");
                XmlNode root = xmlDoc.SelectSingleNode("MusicList");

                foreach (string f in files)
                {
                    Song s = new Song(f);
                    if (s.Author != null)
                        if (File.Exists(@"G:\Music\images\Artist\" + s.Author + ".jpg"))
                            s.Pic = @"G:\Music\images\Artist\" + s.Author + ".jpg";
                    if (s.Album != null)
                        if (File.Exists(@"G:\Music\images\Artist\" + s.Album + ".jpg"))
                            s.Pic = @"G:\Music\images\Artist\" + s.Album + ".jpg";
                    XmlElement xe1 = xmlDoc.CreateElement("Song");
                    xe1.SetAttribute("Name", s.Name);
                    xe1.SetAttribute("Url", s.Url);
                    xe1.SetAttribute("Album", s.Album);
                    xe1.SetAttribute("Author", s.Author);
                    xe1.SetAttribute("Duration", s.Duration);
                    xe1.SetAttribute("Pic", s.Pic);
                    xe1.SetAttribute("Size", s.Size);
                    root.AppendChild(xe1);
                    PlayController.Songs.Add(s);
                    playListBox.Items.Add(s);
                }
                xmlDoc.Save(AppPropertys.appPath + @"\playlist\default.xml");
            }
        }

        private string[] File_Open(string filter, bool multiselect)
        {
            string[] files = null;
            Forms.OpenFileDialog OFD = new Forms.OpenFileDialog();
            OFD.Multiselect = multiselect;
            OFD.Filter = filter;
            if (OFD.ShowDialog() == Forms.DialogResult.OK)
            {
                files = OFD.FileNames;
            }
            OFD.Dispose();
            return files;
        }

        private void playlistOpen_Click(object sender, RoutedEventArgs e)
        {
            Forms.OpenFileDialog OFD = new Forms.OpenFileDialog();
            OFD.Multiselect = true;
            OFD.Filter = "播放列表文件|*.XML";
            if (OFD.ShowDialog() == Forms.DialogResult.OK)
            {
                LoadPlayList(OFD.FileName);
            }
            OFD.Dispose();

        }

        private void Menu_Initialized(object sender, EventArgs e)
        {
            //设置右键菜单为null   
            this.Menu.ContextMenu = null;
        }

        private void Menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                //目标   
                this.mainMenu.PlacementTarget = this.Menu;
                //位置   
                this.mainMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Top;
                //显示菜单   
                this.mainMenu.IsOpen = true;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AppPropertys.notifyExit_Click(sender, e);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确实要清空播放列表吗？", "软件提示：", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                playListBox.Items.Clear();
                PlayController.Songs.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppPropertys.appPath + @"\playlist\default.xml");
                XmlNode root = xmlDoc.SelectSingleNode("/MusicList");
                foreach (XmlNode Node in xmlDoc.SelectNodes("/MusicList/Song"))
                    root.RemoveChild(Node);
                xmlDoc.Save(AppPropertys.appPath + @"\playlist\default.xml");
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
