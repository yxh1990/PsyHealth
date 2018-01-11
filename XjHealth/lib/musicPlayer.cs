using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace XjHealth.lib
{
    public class MusicPlay
    {
        public enum PlayState : int
        {
            stoped = 0,
            playing = 1,
            paused = 2
        }
        private MediaPlayer player = null;
        private Uri musicfile;
        private PlayState state;

        public Uri MusicFile
        {
            set
            {
                musicfile = value;
            }
            get
            {
                return musicfile;
            }
        }

        public DispatcherTimer dt = null;
        public MusicPlay()
        {
            player = new MediaPlayer();
        }
        public MusicPlay(Uri file)
        {
            Load(file);
        }

        public void Load(Uri file)
        {
            player = new MediaPlayer();
            MusicFile = file;
            player.Open(musicfile);
        }

        public void Play()
        {
            player.Play();
            dt.Start();
            state = PlayState.playing;
        }
        public void Pause()
        {
            player.Pause();
            state = PlayState.paused;
        }
        public void Stop()
        {
            player.Stop();
            state = PlayState.stoped;
        }
        public string GetMusicTitle()
        {
            string title = player.Source.ToString();
            return title.Substring(title.LastIndexOf("/") + 1, title.Length - title.LastIndexOf("/") - 1);
            //return "";
        }
        public TimeSpan GetMusicDuringTime()
        {
            while (!player.NaturalDuration.HasTimeSpan)
            {
                if (player.NaturalDuration.HasTimeSpan)
                {
                    return player.NaturalDuration.TimeSpan;
                }
            }
            return new TimeSpan();

        }
        public void SetPosition(TimeSpan tp)
        {
            player.Position = tp;
        }
        public TimeSpan GetPosition()
        {
            return player.Position;
        }
        public void SetVolume(double volume)
        {
            player.Volume = volume;
        }
        public double GetVolume(double volume)
        {
            return player.Volume;
        }
        public PlayState GetPlayState()
        {
            return state;
        }
        public void SetPlayState(PlayState state)
        {
            if (state == PlayState.playing)
            {
                this.Play();
            }
            else if (state == PlayState.paused)
            {
                this.Pause();
            }
            else if (state == PlayState.stoped)
            {
                this.Stop();
            }
        }
    }
}