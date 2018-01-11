using System;
using WMPLib;

namespace MyMP3.Class
{
    public class Song
    {
        private string _pic = @"G:\Music\images\Artist\no.png";
        public string Pic
        {
            get
            {
                return _pic;
            }
            set
            {
                _pic = value;
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _url;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }
        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        private string _album;
        public string Album
        {
            get
            {
                return _album;
            }
            set
            {
                _album = value;
            }
        }

        private string _size;
        public string Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        private string _duration;
        public string Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }

        public Song()
        {
        }
        public Song(string url)
        {
            getmusicInfo(url);
        }
        private void getmusicInfo(string url)
        {
            if (string.IsNullOrEmpty(url))
                return;
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediaInfo = wmp.newMedia(url);
            _url = url;
            _name = mediaInfo.name;
            _album = mediaInfo.getItemInfo("Album");
            _duration = formatDuration(mediaInfo.duration);
            _size = formatSize(mediaInfo.getItemInfo("FileSize"));
            _author = mediaInfo.getItemInfo("Author");
            wmp.close();

        }

        private string formatSize(string size)
        {
            double s = Convert.ToDouble(size) / 1024 / 1024;
            return string.Format("{0:F2}", s) + "M";
        }

        private string formatDuration(double duration)
        {
            int m = (int)duration / 60;
            int s = (int)duration % 60;
            return (m > 9 ? m.ToString() : "0" + m.ToString()) + ":" + (s > 9 ? s.ToString() : "0" + s.ToString());
        }
    }
}
