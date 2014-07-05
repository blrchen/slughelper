using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    public partial class SlugOption : Form
    {
        public SlugOption()
        {
            InitializeComponent();
            this.BindControls();
        }

        private void BindControls()
        {
            this.cb_IgnoreExist.Checked = Option.Current.IgnoreWhenSlugExist;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Option.Current.IgnoreWhenSlugExist = this.cb_IgnoreExist.Checked;
            Option.Current.Save();
            this.Close();
        }
    }
}
