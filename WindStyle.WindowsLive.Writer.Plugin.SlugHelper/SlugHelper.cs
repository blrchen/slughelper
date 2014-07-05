using System;
using System.Collections.Generic;
using System.Text;
using WindowsLive.Writer.Api;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    [WriterPlugin("e80701bd-ac61-4436-99ba-bdedbbb708a8",
        "Slug补全插件",
        PublisherUrl = "http://windstyle.cn",
        ImagePath = "Resources.slughelper.png",
        Description = "在发布之前帮您补全Slug，让日志的URL更加友好。",
        HasEditableOptions = true)]
    public class SlugHelper : PublishNotificationHook
    {
        public override bool OnPrePublish(IWin32Window dialogOwner, IProperties properties, IPublishingContext publishingContext, bool publish)
        {
            Assembly assembly = Assembly.LoadFile(Path.Combine(Application.StartupPath, "WindowsLive.Writer.Extensibility.dll"));
            Type postType = assembly.GetType("WindowsLive.Writer.Extensibility.BlogClient.BlogPost");
            object postObj = Convert.ChangeType(publishingContext.PostInfo, postType);
            PropertyInfo slugProp = postType.GetProperty("Slug");
            string slug = slugProp.GetValue(postObj, null) as string;
            string title = postType.GetProperty("Title").GetValue(postObj, null) as string;

            if (Option.Current.IgnoreWhenSlugExist && !string.IsNullOrEmpty(slug))
                return true;

            SlugEditor se = new SlugEditor(new BlogPost()
                                            {
                                                Title = title, 
                                                Slug = slug
                                            });

            var result = se.ShowDialog();
            if (result == DialogResult.OK)
            {
                slugProp.SetValue(postObj, se.Slug, null);
                return true;
            }
            else
            {
                return false;
            }

        }

        public override void EditOptions(IWin32Window dialogOwner)
        {
            SlugOption option = new SlugOption();
            option.ShowDialog();
        }
    }
}
