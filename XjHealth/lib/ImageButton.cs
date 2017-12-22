using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace XjHealth.lib
{
    public class ImageButton : Button
    {
        private string m_imagepath;
        public string ImgPath
        {
            get { return m_imagepath; }
            set { m_imagepath = value; }
        }

        private string mouseover_imagepath;
        public string MouseOverImgPath
        {
            get { return mouseover_imagepath; }
            set { mouseover_imagepath = value; }
        }

        private string disable_imagepath;
        public string DisableImgPath
        {
            get { return disable_imagepath; }
            set { disable_imagepath = value; }
        }

        private string pressed_imagepath;
        public string PressedImgPath
        {
            get { return pressed_imagepath; }
            set { pressed_imagepath = value; }
        }
    }
}
