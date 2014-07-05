using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    [Serializable]
    public class Option
    {
        public static Option Current
        {
            get
            {
                if (field_Option == null)
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Option));
                        using (XmlReader reader = XmlReader.Create(field_OptionFilePath))
                        {
                            field_Option = serializer.Deserialize(reader) as Option;
                        }
                    }
                    catch
                    {
                        field_Option = new Option();
                    }
                }
                return field_Option;
            }
        }
        private static Option field_Option;

        private static string field_OptionFilePath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof(Option)).Location),
                    "WindStyle.WindowsLiveWriter.Plugin.SlugHelper.Config.xml");
            }
        }

        public Option()
        {
            this.Reset();
        }

        internal void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Option));
            using (XmlWriter writer = XmlWriter.Create(field_OptionFilePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        internal void Reset()
        {
            this.IgnoreWhenSlugExist = false;
        }

        [XmlElement("IgnoreWhenSlugExist")]
        public bool IgnoreWhenSlugExist { get; set; }
    }
}
