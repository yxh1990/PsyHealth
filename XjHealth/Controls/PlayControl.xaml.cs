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
using XjHealth.lib;
using System.IO;
using Forms=System.Windows.Forms;

namespace XjHealth.Controls
{
    /// <summary>
    /// PlayControl.xaml 的交互逻辑
    /// </summary>
    public partial class PlayControl : UserControl
    {
        public PlayControl()
        {
            InitializeComponent();
        }    

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition((Rectangle)sender);
            double pos = p.X / positionBG.Width * PlayController.WMP.During;
            PlayController.WMP.Position = pos;
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition((Rectangle)sender);
            double pos = p.X / positionBG.Width * PlayController.WMP.During;
            PlayController.WMP.Position = pos;
        }

       


        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            positionBG.Width = this.ActualWidth - 10;
            position.Width = this.ActualWidth - 10;
        }

        private void position_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPostion.Visibility = Visibility.Visible;
        }

        private void position_MouseLeave(object sender, MouseEventArgs e)
        {
            btnPostion.Visibility = Visibility.Hidden;
        }

        private void positionMask_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPostion.Visibility = Visibility.Visible;
        }

        private void positionMask_MouseLeave(object sender, MouseEventArgs e)
        {
            btnPostion.Visibility = Visibility.Hidden;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            volumeMask.Width = PlayController.WMP.Volume;
            Canvas.SetLeft(btnVolume, PlayController.WMP.Volume);
        }

        private void volumeBG_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition((Rectangle)sender);
            volumeMask.Width = p.X;
            PlayController.WMP.Volume = (int)p.X;
            Canvas.SetLeft(btnVolume, p.X);
        }

        private void volumeMask_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition((Rectangle)sender);
            volumeMask.Width = p.X;
            PlayController.WMP.Volume = (int)p.X;
            Canvas.SetLeft(btnVolume, p.X);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {                
                PlayController.setMute();
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                PlayController.Stop();
            }
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                PlayController.PlayPrevent();
            }
        }

        private void btnPlay_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (btnPlay.ToolTip.ToString() != "播放")
                {
                    PlayController.Pause();
                }
                else
                {
                    PlayController.Play();
                }
            }
        }

        private void TextBlock_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                PlayController.PlayNext();
            }
        }
    }
}
