using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MyMP3.Class
{
   public class WindowsMediaPlay
    {
       private WindowsMediaPlayer WMP=new WindowsMediaPlayer();
       private string musicName;
       public WindowsMediaPlay()
       {
           
       }

       public void Open(string filename)
       {
           musicName = filename;
           if (musicName != null)
           {
               WMP.URL = musicName;
               Play();
           }
       }

       public void Play()
       {
           WMP.controls.play();
       }

       public void Stop()
       {
           WMP.controls.stop();
       }

       public void Pause()
       {
           WMP.controls.pause();
       }

       public double During
       {
           get
           {
               return WMP.currentMedia.duration;
           }
       }

       public double Position
       {
           get
           {
               return WMP.controls.currentPosition;
           }
           set
           {
               WMP.controls.currentPosition = value;
           }
       }
       public int Volume
       {
           get
           {
               return WMP.settings.volume;
           }
           set
           {
               WMP.settings.volume = value;
           }
       }

       public bool Mute
       {
           get
           {
               return WMP.settings.mute;
           }
           set
           {
               WMP.settings.mute = value;
           }
       }

       public WMPPlayState PlayState
       {
           get
           {
               return WMP.playState;
           }
       }       
    }
}
