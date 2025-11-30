namespace Bai05
{
    partial class Form_main
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
            this.ToolStripMenuItemChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonThemMoi = new System.Windows.Forms.ToolStripButton();
            this.DataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTimKiem = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemChucNang
            // 
            this.ToolStripMenuItemChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemThemMoi,
            this.ToolStripMenuItemThoat});
            this.ToolStripMenuItemChucNang.Name = "ToolStripMenuItemChucNang";
            this.ToolStripMenuItemChucNang.Size = new System.Drawing.Size(96, 24);
            this.ToolStripMenuItemChucNang.Text = "Chức Năng";
            this.ToolStripMenuItemChucNang.Click += new System.EventHandler(this.ToolStripMenuItemChucNang_Click);
            // 
            // ToolStripMenuItemThemMoi
            // 
            this.ToolStripMenuItemThemMoi.Name = "ToolStripMenuItemThemMoi";
            this.ToolStripMenuItemThemMoi.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItemThemMoi.Text = "Thêm Mới";
            this.ToolStripMenuItemThemMoi.Click += new System.EventHandler(this.ToolStripMenuItemThemMoi_Click);
            // 
            // ToolStripMenuItemThoat
            // 
            this.ToolStripMenuItemThoat.Name = "ToolStripMenuItemThoat";
            this.ToolStripMenuItemThoat.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItemThoat.Text = "Thoát";
            this.ToolStripMenuItemThoat.Click += new System.EventHandler(this.ToolStripMenuItemThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonThemMoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // ToolStripButtonThemMoi
            // 
            this.ToolStripButtonThemMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ToolStripButtonThemMoi.Image = global::Bai05.Properties.Resources.ThemSinhVien_image;
            this.ToolStripButtonThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonThemMoi.Name = "ToolStripButtonThemMoi";
            this.ToolStripButtonThemMoi.Size = new System.Drawing.Size(124, 32);
            this.ToolStripButtonThemMoi.Text = "Thêm Mới";
            this.ToolStripButtonThemMoi.Click += new System.EventHandler(this.ToolStripButtonThemMoi_Click);
            // 
            // DataGridViewSinhVien
            // 
            this.DataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.HoTenSV,
            this.Khoa,
            this.DiemTB});
            this.DataGridViewSinhVien.Location = new System.Drawing.Point(0, 66);
            this.DataGridViewSinhVien.Name = "DataGridViewSinhVien";
            this.DataGridViewSinhVien.RowHeadersWidth = 51;
            this.DataGridViewSinhVien.RowTemplate.Height = 24;
            this.DataGridViewSinhVien.Size = new System.Drawing.Size(922, 580);
            this.DataGridViewSinhVien.TabIndex = 2;
            this.DataGridViewSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(342, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm Theo Tên";
            // 
            // TextBoxTimKiem
            // 
            this.TextBoxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTimKiem.Location = new System.Drawing.Point(494, 37);
            this.TextBoxTimKiem.Multiline = true;
            this.TextBoxTimKiem.Name = "TextBoxTimKiem";
            this.TextBoxTimKiem.Size = new System.Drawing.Size(279, 20);
            this.TextBoxTimKiem.TabIndex = 4;
            this.TextBoxTimKiem.TextChanged += new System.EventHandler(this.TextBoxTimKiem_TextChanged);
            // 
            // STT
            // 
            this.STT.FillWeight = 74F;
            this.STT.HeaderText = "Số TT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 74;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.FillWeight = 98F;
            this.MSSV.HeaderText = "Mã Số SV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 98;
            // 
            // HoTenSV
            // 
            this.HoTenSV.DataPropertyName = "HoTenSV";
            this.HoTenSV.FillWeight = 200F;
            this.HoTenSV.HeaderText = "Tên Sinh Viên";
            this.HoTenSV.MinimumWidth = 6;
            this.HoTenSV.Name = "HoTenSV";
            this.HoTenSV.Width = 200;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.FillWeight = 180F;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.Width = 180;
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.FillWeight = 88F;
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.Width = 88;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 650);
            this.Controls.Add(this.TextBoxTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChucNang;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThemMoi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView DataGridViewSinhVien;
        private System.Windows.Forms.ToolStripButton ToolStripButtonThemMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}

