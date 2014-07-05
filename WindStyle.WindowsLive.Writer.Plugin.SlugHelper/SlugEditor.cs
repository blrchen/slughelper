using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public partial class SlugEditor : Form
    {
        public SlugEditor(BlogPost post)
        {
            InitializeComponent();

            this.postFiled = post;
            this.selectedRadioButtonField = this.rb_doNotChange;
            this.Slug = post.Slug;
        }

        private BlogPost postFiled;

        public string Slug
        {
            get { return this.tb_slug.Text.Trim(); }
            private set { this.tb_slug.Text = value; }
        }

        private SlugGeneratingRadioButton selectedRadioButtonField;

        private void tb_slug_TextChanged(object sender, EventArgs e)
        {
            if (this.selectedRadioButtonField != this.rb_custom
                && !this.Slug.Equals(this.selectedRadioButtonField.Slug, StringComparison.CurrentCultureIgnoreCase))
            {
                this.rb_custom.Checked = true;
            }
        }

        private void Generator_OnSlugGenerated(object sender, EventArgs e)
        {
            this.Slug = this.selectedRadioButtonField.Slug;
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void Generator_OnGettingPostInfo(object sender, PostInfoEventArgs e)
        {
            e.Post = this.postFiled;
        }

        private void Generator_OnGeneratingSlug(object sender, EventArgs e)
        {
            SlugGeneratingRadioButton rb = sender as SlugGeneratingRadioButton;
            if (rb.Checked && rb != this.rb_custom)
            {
                this.selectedRadioButtonField = rb;
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
            }
        }
    }
}
