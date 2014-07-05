using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public class SlugGeneratingRadioButton : RadioButton
    {
        public string Slug { get; private set; }

        public event EventHandler<PostInfoEventArgs> OnGettingPostInfo;
        public event EventHandler OnGeneratingSlug;
        public event EventHandler OnSlugGenerated;

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if (this.DesignMode || !this.Checked)
                return;

            if (this.OnGeneratingSlug != null)
                this.OnGeneratingSlug(this, EventArgs.Empty);

            if (this.Slug == null)
            {
                PostInfoEventArgs args = new PostInfoEventArgs();
                if (this.OnGettingPostInfo != null)
                {
                    this.OnGettingPostInfo(this, args);
                    string slug = this.GeneratingSlug(args.Post);
                    this.Slug = StringHelper.Parse(slug);
                }

            }
            if (this.OnSlugGenerated != null)
                this.OnSlugGenerated(this, EventArgs.Empty);
        }

        protected virtual string GeneratingSlug(BlogPost post) 
        {
            return post.Slug;
        }
    }
}
