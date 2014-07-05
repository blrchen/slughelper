using System;
using System.Collections.Generic;
using System.Text;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public class PostInfoEventArgs:EventArgs
    {
        public BlogPost Post { get; set; }
    }
}
