namespace Bai06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSaoChep = new System.Windows.Forms.Button();
            this.ButtonFileDich = new System.Windows.Forms.Button();
            this.ButtonFileNguon = new System.Windows.Forms.Button();
            this.TextBoxDich = new System.Windows.Forms.TextBox();
            this.TextBoxNguon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSaoChep);
            this.groupBox1.Controls.Add(this.ButtonFileDich);
            this.groupBox1.Controls.Add(this.ButtonFileNguon);
            this.groupBox1.Controls.Add(this.TextBoxDich);
            this.groupBox1.Controls.Add(this.TextBoxNguon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(63, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // ButtonSaoChep
            // 
            this.ButtonSaoChep.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonSaoChep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaoChep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonSaoChep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSaoChep.Location = new System.Drawing.Point(242, 136);
            this.ButtonSaoChep.Name = "ButtonSaoChep";
            this.ButtonSaoChep.Size = new System.Drawing.Size(172, 32);
            this.ButtonSaoChep.TabIndex = 6;
            this.ButtonSaoChep.Text = "Sao chép";
            this.ButtonSaoChep.UseVisualStyleBackColor = true;
            this.ButtonSaoChep.Click += new System.EventHandler(this.ButtonSaoChep_Click);
            // 
            // ButtonFileDich
            // 
            this.ButtonFileDich.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonFileDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFileDich.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonFileDich.Location = new System.Drawing.Point(642, 84);
            this.ButtonFileDich.Name = "ButtonFileDich";
            this.ButtonFileDich.Size = new System.Drawing.Size(58, 28);
            this.ButtonFileDich.TabIndex = 5;
            this.ButtonFileDich.Text = "...";
            this.ButtonFileDich.UseVisualStyleBackColor = true;
            this.ButtonFileDich.Click += new System.EventHandler(this.ButtonFileDich_Click);
            // 
            // ButtonFileNguon
            // 
            this.ButtonFileNguon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonFileNguon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFileNguon.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonFileNguon.Location = new System.Drawing.Point(642, 37);
            this.ButtonFileNguon.Name = "ButtonFileNguon";
            this.ButtonFileNguon.Size = new System.Drawing.Size(58, 28);
            this.ButtonFileNguon.TabIndex = 4;
            this.ButtonFileNguon.Text = "...";
            this.ButtonFileNguon.UseVisualStyleBackColor = true;
            this.ButtonFileNguon.Click += new System.EventHandler(this.ButtonFileNguon_Click);
            // 
            // TextBoxDich
            // 
            this.TextBoxDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDich.Location = new System.Drawing.Point(242, 84);
            this.TextBoxDich.Name = "TextBoxDich";
            this.TextBoxDich.ReadOnly = true;
            this.TextBoxDich.Size = new System.Drawing.Size(391, 27);
            this.TextBoxDich.TabIndex = 3;
            // 
            // TextBoxNguon
            // 
            this.TextBoxNguon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNguon.Location = new System.Drawing.Point(242, 37);
            this.TextBoxNguon.Name = "TextBoxNguon";
            this.TextBoxNguon.ReadOnly = true;
            this.TextBoxNguon.Size = new System.Drawing.Size(391, 27);
            this.TextBoxNguon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(63, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(119, 20);
            this.ToolStripStatusLabel1.Text = "Đang Sao Chép :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sao chép tập tin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonFileDich;
        private System.Windows.Forms.Button ButtonFileNguon;
        private System.Windows.Forms.TextBox TextBoxDich;
        private System.Windows.Forms.TextBox TextBoxNguon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button ButtonSaoChep;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    }
}

