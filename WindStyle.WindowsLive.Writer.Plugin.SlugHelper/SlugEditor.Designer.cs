namespace WindStyle.WindowsLiveWriter.Plugin.SlugHelper
{
    partial class SlugEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_slug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_custom = new System.Windows.Forms.RadioButton();
            this.rb_live = new WindStyle.WindowsLiveWriter.Plugin.SlugHelper.WindowsLiveTranslatingRadionButton();
            this.rb_doNotChange = new WindStyle.WindowsLiveWriter.Plugin.SlugHelper.SlugGeneratingRadioButton();
            this.rb_google = new WindStyle.WindowsLiveWriter.Plugin.SlugHelper.GoogleTranslatingRadionButton();
            this.rb_sameAsTitle = new WindStyle.WindowsLiveWriter.Plugin.SlugHelper.SameAsTitleRadionButton();
            this.rb_Pinyin = new WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PinyinConveringRadionButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(321, 222);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(402, 222);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tb_slug
            // 
            this.tb_slug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_slug.Location = new System.Drawing.Point(14, 24);
            this.tb_slug.Name = "tb_slug";
            this.tb_slug.Size = new System.Drawing.Size(463, 21);
            this.tb_slug.TabIndex = 11;
            this.tb_slug.TextChanged += new System.EventHandler(this.tb_slug_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "本文的Slug为：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_live);
            this.groupBox1.Controls.Add(this.rb_custom);
            this.groupBox1.Controls.Add(this.rb_doNotChange);
            this.groupBox1.Controls.Add(this.rb_google);
            this.groupBox1.Controls.Add(this.rb_sameAsTitle);
            this.groupBox1.Controls.Add(this.rb_Pinyin);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slug生成选项";
            // 
            // rb_custom
            // 
            this.rb_custom.AutoSize = true;
            this.rb_custom.Location = new System.Drawing.Point(28, 130);
            this.rb_custom.Name = "rb_custom";
            this.rb_custom.Size = new System.Drawing.Size(59, 16);
            this.rb_custom.TabIndex = 29;
            this.rb_custom.TabStop = true;
            this.rb_custom.Text = "自定义";
            this.rb_custom.UseVisualStyleBackColor = true;
            // 
            // rb_live
            // 
            this.rb_live.AutoSize = true;
            this.rb_live.Location = new System.Drawing.Point(28, 108);
            this.rb_live.Name = "rb_live";
            this.rb_live.Size = new System.Drawing.Size(155, 16);
            this.rb_live.TabIndex = 30;
            this.rb_live.TabStop = true;
            this.rb_live.Text = "使用微软Bing翻译为英文";
            this.rb_live.UseVisualStyleBackColor = true;
            this.rb_live.OnSlugGenerated += new System.EventHandler(this.Generator_OnSlugGenerated);
            this.rb_live.OnGeneratingSlug += new System.EventHandler(this.Generator_OnGeneratingSlug);
            this.rb_live.OnGettingPostInfo += new System.EventHandler<WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PostInfoEventArgs>(this.Generator_OnGettingPostInfo);
            // 
            // rb_doNotChange
            // 
            this.rb_doNotChange.AutoSize = true;
            this.rb_doNotChange.Checked = true;
            this.rb_doNotChange.Location = new System.Drawing.Point(28, 20);
            this.rb_doNotChange.Name = "rb_doNotChange";
            this.rb_doNotChange.Size = new System.Drawing.Size(59, 16);
            this.rb_doNotChange.TabIndex = 28;
            this.rb_doNotChange.TabStop = true;
            this.rb_doNotChange.Text = "不更改";
            this.rb_doNotChange.UseVisualStyleBackColor = true;
            this.rb_doNotChange.OnSlugGenerated += new System.EventHandler(this.Generator_OnSlugGenerated);
            this.rb_doNotChange.OnGeneratingSlug += new System.EventHandler(this.Generator_OnGeneratingSlug);
            this.rb_doNotChange.OnGettingPostInfo += new System.EventHandler<WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PostInfoEventArgs>(this.Generator_OnGettingPostInfo);
            // 
            // rb_google
            // 
            this.rb_google.AutoSize = true;
            this.rb_google.Location = new System.Drawing.Point(28, 86);
            this.rb_google.Name = "rb_google";
            this.rb_google.Size = new System.Drawing.Size(143, 16);
            this.rb_google.TabIndex = 16;
            this.rb_google.Text = "使用Google翻译为英文";
            this.rb_google.UseVisualStyleBackColor = true;
            this.rb_google.OnSlugGenerated += new System.EventHandler(this.Generator_OnSlugGenerated);
            this.rb_google.OnGeneratingSlug += new System.EventHandler(this.Generator_OnGeneratingSlug);
            this.rb_google.OnGettingPostInfo += new System.EventHandler<WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PostInfoEventArgs>(this.Generator_OnGettingPostInfo);
            // 
            // rb_sameAsTitle
            // 
            this.rb_sameAsTitle.AutoSize = true;
            this.rb_sameAsTitle.Location = new System.Drawing.Point(28, 42);
            this.rb_sameAsTitle.Name = "rb_sameAsTitle";
            this.rb_sameAsTitle.Size = new System.Drawing.Size(83, 16);
            this.rb_sameAsTitle.TabIndex = 17;
            this.rb_sameAsTitle.Text = "同标题一致";
            this.rb_sameAsTitle.UseVisualStyleBackColor = true;
            this.rb_sameAsTitle.OnSlugGenerated += new System.EventHandler(this.Generator_OnSlugGenerated);
            this.rb_sameAsTitle.OnGeneratingSlug += new System.EventHandler(this.Generator_OnGeneratingSlug);
            this.rb_sameAsTitle.OnGettingPostInfo += new System.EventHandler<WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PostInfoEventArgs>(this.Generator_OnGettingPostInfo);
            // 
            // rb_Pinyin
            // 
            this.rb_Pinyin.AutoSize = true;
            this.rb_Pinyin.Location = new System.Drawing.Point(28, 64);
            this.rb_Pinyin.Name = "rb_Pinyin";
            this.rb_Pinyin.Size = new System.Drawing.Size(107, 16);
            this.rb_Pinyin.TabIndex = 15;
            this.rb_Pinyin.Text = "转换为中文拼音";
            this.rb_Pinyin.UseVisualStyleBackColor = true;
            this.rb_Pinyin.OnSlugGenerated += new System.EventHandler(this.Generator_OnSlugGenerated);
            this.rb_Pinyin.OnGeneratingSlug += new System.EventHandler(this.Generator_OnGeneratingSlug);
            this.rb_Pinyin.OnGettingPostInfo += new System.EventHandler<WindStyle.WindowsLiveWriter.Plugin.SlugHelper.PostInfoEventArgs>(this.Generator_OnGettingPostInfo);
            // 
            // SlugEditor
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(490, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_slug);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SlugEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slug编辑器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_slug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private PinyinConveringRadionButton rb_Pinyin;
        private GoogleTranslatingRadionButton rb_google;
        private SameAsTitleRadionButton rb_sameAsTitle;
        private SlugGeneratingRadioButton rb_doNotChange;
        private System.Windows.Forms.RadioButton rb_custom;
        private WindowsLiveTranslatingRadionButton rb_live;
    }
}