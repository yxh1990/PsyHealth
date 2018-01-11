using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MyMP3.Controls;

namespace MyMP3.Class
{
  public partial  class PlayController
    {
      public static PlayControl playControl;
      public static DispatcherTimer DT = new DispatcherTimer();
      public static WindowsMediaPlay WMP;
      public static int PlayMode = 1;
      private static bool isStop = false;

      public static void Initialize()
      {
          WMP = new WindowsMediaPlay();
          playControl = AppPropertys.mainWindow.playControl1;
          DT.Interval = TimeSpan.FromMilliseconds(100);
          DT.Tick+=new EventHandler(DT_Tick);
      }

     
      private static void DT_Tick(object sender, EventArgs e)
      {
          switch ((int)WMP.PlayState)
          {
              case 1:
                  if (!isStop)
                      PlayNext();
                  break;
              case 3:
                 
                  StartPosition = WMP.Position;                  
                  if (startPosition != 0)
                  {
                      //if (AppPropertys.notifyIcon.ContextMenu.MenuItems[0].Checked)
                      //    LrcController.lrcWindow.showLrc(startPosition * 1000 + LrcController.offsetTime);
                  }
                  if (DuringTime == 0)
                      DuringTime = WMP.During;
                  break;
          }
      }

      private static List<Song> songs = new List<Song>();
      public static List<Song> Songs
      {
          get
          {
              return songs;
          }
          set
          {
              songs = value;
          }
      }
      private static int playIndex = -1;
      public static int PlayIndex
      {
          get
          {
              return playIndex;
          }

          set
          {
              playIndex = value;
          }
      }

      private static double startPosition = 0;

      public static double StartPosition
      {
          get
          {
              return startPosition;
          }
          set
          {
              startPosition = value;
              if (duringTime > 0)
              {
                  double f = startPosition / duringTime * playControl.positionBG.Width;
                  Canvas.SetLeft(playControl.btnPostion, f);
                  playControl.positionMask.Width = f;
              }
              playControl.startTime.Text = formatTime(startPosition);
          }
      }

      public static double duringTime = 0;
      public static double DuringTime
      {
          get
          {
              return duringTime;
          }
          set
          {
              duringTime = value;
              playControl.totalTime.Text = formatTime(duringTime);
          }
      }

      public static void ReSet()
      {
          DT.Stop();
          startPosition = 0;
          duringTime = 0;

          Canvas.SetLeft(playControl.btnPostion, 0);
          playControl.startTime.Text = "00:00";
          playControl.totalTime.Text = "00:00";
          //LrcController.offsetTime = 0;

          AppPropertys.FlushMemory();
         
      }

      public static void SetPosition(double p)
      {
          WMP.Position = p;
      }

      public static void setMute()
      {
          WMP.Mute = !WMP.Mute;
          if (WMP.Mute)
          {
              playControl.imgVolume.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\Images\noVolume.png"));
              playControl.imgVolume.ToolTip = "打开声音";
          }
          else
          {
              playControl.imgVolume.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\Images\volume.png"));
              playControl.imgVolume.ToolTip = "静音";
          }
      }
      public static void PlayMusic()
      {
          if (songs.Count > playIndex && playIndex > -1)
          {
              ReSet();
              Song song = songs[playIndex];
              WMP.Open(song.Url);
              Play();
          }
      }

      public static void Play()
      {
          if (WMP.PlayState == WMPLib.WMPPlayState.wmppsUndefined)
          {
             
              PlayNext();
              return;
          }
          WMP.Play();
          DT.Start();

          AppPropertys.mainWindow.playListBox.SelectedIndex = playIndex;
          AppPropertys.mainWindow.playListBox.ScrollIntoView(AppPropertys.mainWindow.playListBox.Items[playIndex]);
          playControl.status.Text = "正在播放：" + songs[playIndex].Author + " " + songs[playIndex].Name;
          AppPropertys.notifyIcon.Text = "正在播放：" + songs[playIndex].Author + " " + songs[playIndex].Name;
          playControl.btnPlay.Text= ";";
          playControl.btnPlay.ToolTip = "停止";
          //LrcController.setPause();

          AppPropertys.IsPlaying = true;
          isStop = false;

      }

      public static void Stop()
      {
          isStop = true;
          WMP.Stop();
          playControl.btnPlay.Text = "4";
          playControl.status.Text = "播放停止";
          playControl.btnPlay.ToolTip = "播放";
      }

      public static void Pause()
      {
          WMP.Pause();
          playControl.btnPlay.Text = "4";
          playControl.status.Text = "播放暂停";
          playControl.btnPlay.ToolTip = "播放";
          AppPropertys.IsPlaying = false;
      }

      public static void PlayPrevent()
      {
          playIndex--;
          if (playIndex < 0)
              playIndex = songs.Count - 1;
          PlayMusic();
      }

      public static void PlayNext()
      {
          switch (PlayMode)
          {
              case 1:
                  playIndex++;
                  if (playIndex > songs.Count - 1)
                      playIndex = 0;
                  break;
              case 2:
                  Random rand = new Random();
                  playIndex = rand.Next(songs.Count);
                  break;
              case 3:
                  break;

          } 
          PlayMusic();
      }

      public static string formatTime(double seconds)
      {
          int m = (int)seconds / 60;
          int s = (int)seconds % 60;
          string t = (m > 9 ? m.ToString() : "0" + m.ToString()) + ":" + (s > 9 ? s.ToString() : "0" + s.ToString());
          return t;
      }

    }
}
