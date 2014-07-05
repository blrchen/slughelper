using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public class GoogleTranslatingRadionButton:SlugGeneratingRadioButton
    {
        protected override string GeneratingSlug(BlogPost post)
        {
            string result = TranslateByGoogle(post.Title);
            if (result == null)
            {
                MessageBox.Show("无法使用Google翻译，请检查网络连接后再行尝试。");
            }
            return result;
        }

        private static string TranslateByGoogle(string input)
        {
            try
            {
                string languagePair = "zh-CN|en";
                string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);

                WebClient webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string pageHtml = webClient.DownloadString(url);

                Match match = Regex.Match(pageHtml, "id=result_box.+>(.*?)</span></span>");
                string result = match.Groups[1].Value;
                result = HttpUtility.HtmlDecode(result);
                return  result;
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
