namespace Bai05
{
    partial class FormNhapSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxMSSV = new System.Windows.Forms.TextBox();
            this.TextBoxHoTen = new System.Windows.Forms.TextBox();
            this.TextBoxDiemTB = new System.Windows.Forms.TextBox();
            this.ComboBoxKhoa = new System.Windows.Forms.ComboBox();
            this.ButtonThemMoi = new System.Windows.Forms.Button();
            this.ButtonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(69, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(70, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(70, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm TB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TextBoxMSSV
            // 
            this.TextBoxMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxMSSV.Location = new System.Drawing.Point(221, 58);
            this.TextBoxMSSV.Name = "TextBoxMSSV";
            this.TextBoxMSSV.Size = new System.Drawing.Size(267, 22);
            this.TextBoxMSSV.TabIndex = 4;
            // 
            // TextBoxHoTen
            // 
            this.TextBoxHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxHoTen.Location = new System.Drawing.Point(222, 110);
            this.TextBoxHoTen.Name = "TextBoxHoTen";
            this.TextBoxHoTen.Size = new System.Drawing.Size(362, 22);
            this.TextBoxHoTen.TabIndex = 5;
            // 
            // TextBoxDiemTB
            // 
            this.TextBoxDiemTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDiemTB.Location = new System.Drawing.Point(222, 214);
            this.TextBoxDiemTB.Name = "TextBoxDiemTB";
            this.TextBoxDiemTB.Size = new System.Drawing.Size(128, 22);
            this.TextBoxDiemTB.TabIndex = 6;
            this.TextBoxDiemTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ComboBoxKhoa
            // 
            this.ComboBoxKhoa.FormattingEnabled = true;
            this.ComboBoxKhoa.Items.AddRange(new object[] {
            "Công nghệ phần mềm",
            "Mạng máy tính & truyền thông",
            "Hệ thống thông tin",
            "Khoa học & kỹ thuật thông tin",
            "Kỹ thuật máy tính",
            "Khoa học máy tính"});
            this.ComboBoxKhoa.Location = new System.Drawing.Point(222, 160);
            this.ComboBoxKhoa.Name = "ComboBoxKhoa";
            this.ComboBoxKhoa.Size = new System.Drawing.Size(362, 24);
            this.ComboBoxKhoa.TabIndex = 7;
            // 
            // ButtonThemMoi
            // 
            this.ButtonThemMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ButtonThemMoi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonThemMoi.Location = new System.Drawing.Point(354, 275);
            this.ButtonThemMoi.Name = "ButtonThemMoi";
            this.ButtonThemMoi.Size = new System.Drawing.Size(125, 36);
            this.ButtonThemMoi.TabIndex = 8;
            this.ButtonThemMoi.Text = "Thêm Mới";
            this.ButtonThemMoi.UseVisualStyleBackColor = false;
            this.ButtonThemMoi.Click += new System.EventHandler(this.ButtonThemMoi_Click);
            // 
            // ButtonThoat
            // 
            this.ButtonThoat.BackColor = System.Drawing.Color.Coral;
            this.ButtonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonThoat.Location = new System.Drawing.Point(492, 275);
            this.ButtonThoat.Name = "ButtonThoat";
            this.ButtonThoat.Size = new System.Drawing.Size(92, 36);
            this.ButtonThoat.TabIndex = 9;
            this.ButtonThoat.Text = "Thoát";
            this.ButtonThoat.UseVisualStyleBackColor = false;
            this.ButtonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // FormNhapSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 336);
            this.Controls.Add(this.ButtonThoat);
            this.Controls.Add(this.ButtonThemMoi);
            this.Controls.Add(this.ComboBoxKhoa);
            this.Controls.Add(this.TextBoxDiemTB);
            this.Controls.Add(this.TextBoxHoTen);
            this.Controls.Add(this.TextBoxMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNhapSV";
            this.Text = "Thêm Sinh Viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxMSSV;
        private System.Windows.Forms.TextBox TextBoxHoTen;
        private System.Windows.Forms.TextBox TextBoxDiemTB;
        private System.Windows.Forms.ComboBox ComboBoxKhoa;
        private System.Windows.Forms.Button ButtonThemMoi;
        private System.Windows.Forms.Button ButtonThoat;
    }
}