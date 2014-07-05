using System;
using System.Collections.Generic;
using System.Text;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    internal static class StringHelper
    {
        internal static string Parse(string slug)
        {
            if (string.IsNullOrEmpty(slug))
            {
                return string.Empty;
            }
            else
            {
                return ParseSymbol(slug);
            }
        }

        private static string ParseSymbol(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (Char.IsLetterOrDigit(ch))
                    sb.Append(ch);
                else
                    sb.Append('-');
            }
            string result = sb.ToString();
            while (result.Contains("--"))
            {
                result = result.Replace("--", "-");
            }

            if (result.EndsWith("-"))
                result = result.Remove(result.Length - 1);

            return result;
        }
    }
}
