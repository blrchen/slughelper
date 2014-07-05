using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public class SameAsTitleRadionButton : SlugGeneratingRadioButton
    {
        protected override string GeneratingSlug(BlogPost post)
        {
            return post.Title;
        }
    }
}
