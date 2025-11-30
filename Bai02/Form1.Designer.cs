namespace Bai02
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
            this.LabelNgayGio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNgayGio
            // 
            this.LabelNgayGio.AutoSize = true;
            this.LabelNgayGio.Location = new System.Drawing.Point(206, 203);
            this.LabelNgayGio.Name = "LabelNgayGio";
            this.LabelNgayGio.Size = new System.Drawing.Size(95, 16);
            this.LabelNgayGio.TabIndex = 0;
            this.LabelNgayGio.Text = "LabelNgayGio";
            this.LabelNgayGio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelNgayGio.Click += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.LabelNgayGio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Simple Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNgayGio;
    }
}

