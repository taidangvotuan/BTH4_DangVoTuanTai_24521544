namespace Bai04
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTaoVBMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMoTapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemLuuNDVanBan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonBlankPage = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripComboBoxChinhFont = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripComboBoxChinhKichCo = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHeThong,
            this.ToolStripMenuItemDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToolStripMenuItemHeThong
            // 
            this.ToolStripMenuItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTaoVBMoi,
            this.ToolStripMenuItemMoTapTin,
            this.toolStripSeparator1,
            this.ToolStripMenuItemLuuNDVanBan,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemHeThong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ToolStripMenuItemHeThong.Name = "ToolStripMenuItemHeThong";
            this.ToolStripMenuItemHeThong.Size = new System.Drawing.Size(91, 25);
            this.ToolStripMenuItemHeThong.Text = "Hệ thống";
            this.ToolStripMenuItemHeThong.Click += new System.EventHandler(this.ToolStripMenuItemHeThong_Click);
            // 
            // ToolStripMenuItemTaoVBMoi
            // 
            this.ToolStripMenuItemTaoVBMoi.Image = global::Bai04.Properties.Resources.NewText_image;
            this.ToolStripMenuItemTaoVBMoi.Name = "ToolStripMenuItemTaoVBMoi";
            this.ToolStripMenuItemTaoVBMoi.Size = new System.Drawing.Size(336, 26);
            this.ToolStripMenuItemTaoVBMoi.Text = "Tạo văn bản mới              Ctrl+N";
            this.ToolStripMenuItemTaoVBMoi.Click += new System.EventHandler(this.ToolStripMenuItemTaoVBMoi_Click);
            // 
            // ToolStripMenuItemMoTapTin
            // 
            this.ToolStripMenuItemMoTapTin.Image = global::Bai04.Properties.Resources.Folder_image;
            this.ToolStripMenuItemMoTapTin.Name = "ToolStripMenuItemMoTapTin";
            this.ToolStripMenuItemMoTapTin.Size = new System.Drawing.Size(336, 26);
            this.ToolStripMenuItemMoTapTin.Text = "Mở tập tin";
            this.ToolStripMenuItemMoTapTin.Click += new System.EventHandler(this.ToolStripMenuItemMoTapTin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(333, 6);
            // 
            // ToolStripMenuItemLuuNDVanBan
            // 
            this.ToolStripMenuItemLuuNDVanBan.Image = global::Bai04.Properties.Resources.Save_image;
            this.ToolStripMenuItemLuuNDVanBan.Name = "ToolStripMenuItemLuuNDVanBan";
            this.ToolStripMenuItemLuuNDVanBan.Size = new System.Drawing.Size(336, 26);
            this.ToolStripMenuItemLuuNDVanBan.Text = "Lưu nội dung văn bản       Ctrl+S";
            this.ToolStripMenuItemLuuNDVanBan.Click += new System.EventHandler(this.ToolStripMenuItemLuuNDVanBan_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(336, 26);
            this.ToolStripMenuItemExit.Text = "Thoát";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemDinhDang
            // 
            this.ToolStripMenuItemDinhDang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ToolStripMenuItemDinhDang.Name = "ToolStripMenuItemDinhDang";
            this.ToolStripMenuItemDinhDang.Size = new System.Drawing.Size(99, 25);
            this.ToolStripMenuItemDinhDang.Text = "Định dạng";
            this.ToolStripMenuItemDinhDang.Click += new System.EventHandler(this.ToolStripMenuItemDinhDang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonBlankPage,
            this.ToolStripButtonSave,
            this.toolStripSeparator2,
            this.ToolStripComboBoxChinhFont,
            this.ToolStripComboBoxChinhKichCo,
            this.ToolStripButtonBold,
            this.ToolStripButtonItalic,
            this.ToolStripButtonUnderline,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButtonBlankPage
            // 
            this.ToolStripButtonBlankPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonBlankPage.Image = global::Bai04.Properties.Resources.NewText_image;
            this.ToolStripButtonBlankPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonBlankPage.Name = "ToolStripButtonBlankPage";
            this.ToolStripButtonBlankPage.Size = new System.Drawing.Size(29, 25);
            this.ToolStripButtonBlankPage.Text = "Tạo văn bản mới";
            this.ToolStripButtonBlankPage.Click += new System.EventHandler(this.ToolStripButtonBlankPage_Click);
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSave.Image = global::Bai04.Properties.Resources.Save_image;
            this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new System.Drawing.Size(29, 25);
            this.ToolStripButtonSave.Text = "Lưu nội dung văn bản";
            this.ToolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // ToolStripComboBoxChinhFont
            // 
            this.ToolStripComboBoxChinhFont.Name = "ToolStripComboBoxChinhFont";
            this.ToolStripComboBoxChinhFont.Size = new System.Drawing.Size(180, 28);
            this.ToolStripComboBoxChinhFont.Click += new System.EventHandler(this.ToolStripComboBoxChinhFont_Click);
            // 
            // ToolStripComboBoxChinhKichCo
            // 
            this.ToolStripComboBoxChinhKichCo.Name = "ToolStripComboBoxChinhKichCo";
            this.ToolStripComboBoxChinhKichCo.Size = new System.Drawing.Size(90, 28);
            this.ToolStripComboBoxChinhKichCo.Click += new System.EventHandler(this.ToolStripComboBoxChinhKichCo_Click);
            // 
            // ToolStripButtonBold
            // 
            this.ToolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonBold.Image = global::Bai04.Properties.Resources.Bold_image;
            this.ToolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonBold.Name = "ToolStripButtonBold";
            this.ToolStripButtonBold.Size = new System.Drawing.Size(29, 25);
            this.ToolStripButtonBold.Text = "Tô đậm văn bản";
            this.ToolStripButtonBold.Click += new System.EventHandler(this.ToolStripButtonBold_Click);
            // 
            // ToolStripButtonItalic
            // 
            this.ToolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonItalic.Image = global::Bai04.Properties.Resources.Italic_image;
            this.ToolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonItalic.Name = "ToolStripButtonItalic";
            this.ToolStripButtonItalic.Size = new System.Drawing.Size(29, 25);
            this.ToolStripButtonItalic.Text = "In nghiêng văn bản";
            this.ToolStripButtonItalic.Click += new System.EventHandler(this.ToolStripButtonItalic_Click);
            // 
            // ToolStripButtonUnderline
            // 
            this.ToolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonUnderline.Image = global::Bai04.Properties.Resources.Underline_image;
            this.ToolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonUnderline.Name = "ToolStripButtonUnderline";
            this.ToolStripButtonUnderline.Size = new System.Drawing.Size(29, 25);
            this.ToolStripButtonUnderline.Text = "Gạch chân văn bản";
            this.ToolStripButtonUnderline.Click += new System.EventHandler(this.ToolStripButtonUnderline_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(972, 429);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 492);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHeThong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDinhDang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonBlankPage;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBoxChinhFont;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBoxChinhKichCo;
        private System.Windows.Forms.ToolStripButton ToolStripButtonBold;
        private System.Windows.Forms.ToolStripButton ToolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton ToolStripButtonUnderline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTaoVBMoi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMoTapTin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLuuNDVanBan;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

