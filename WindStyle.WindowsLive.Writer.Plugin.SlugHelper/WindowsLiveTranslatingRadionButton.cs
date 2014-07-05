using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web;
using System.IO;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public class WindowsLiveTranslatingRadionButton : SlugGeneratingRadioButton
    {
        protected override string GeneratingSlug(BlogPost post)
        {
            string result = TranslateByWindowsLive(post.Title);
            if (result == null)
            {
                MessageBox.Show("无法使用Windows Live翻译，请检查网络连接后再行尝试。");
            }
            return result;
        }

        private static string TranslateByWindowsLive(string input)
        {
            string translateUri = "http://api.microsofttranslator.com/V1/Http.svc/Translate?appId=41B9E8BF927882751EF56254F5A5FB89441E1BD1&from=zh-cn&to=en";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(translateUri);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "text/plain";
            byte[] bytes = Encoding.UTF8.GetBytes(input);

            httpWebRequest.ContentLength = bytes.Length;
            using (Stream os = httpWebRequest.GetRequestStream())
            {
                os.Write(bytes, 0, bytes.Length);
            }

            try
            {
                WebResponse response = httpWebRequest.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
            catch
            {
                return null;
            }
        }

    }
}
