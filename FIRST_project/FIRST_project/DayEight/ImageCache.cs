using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayEight
{
    internal class ImageCache
    {
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if (_logoBytes == null)
                {
                    _logoBytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                }
                return _logoBytes;
            }
        }
    }

}