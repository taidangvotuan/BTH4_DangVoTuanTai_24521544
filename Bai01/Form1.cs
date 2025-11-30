using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Demo Nhấn bàn phím và chuột";
            this.Width = 600;
            this.Height = 400;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Cho phép form nhận sự kiện bàn phím
            this.KeyPreview = true;

            Label labelInfo = new Label();
            labelInfo.Dock = DockStyle.Fill;
            labelInfo.Font = new System.Drawing.Font("Consolas", 12);
            labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelInfo.Text = "Hãy nhấn phím hoặc click chuột trong cửa sổ này";
            this.Controls.Add(labelInfo);

            // Sự kiện bàn phím
            this.KeyDown += (s, e) =>
            {
                int asciiCode = e.KeyValue;
                string charText = Convert.ToChar(asciiCode).ToString();

                labelInfo.Text =
                    $"Bàn phím:\n" + $"Phím: {e.KeyCode}\n" + $"Ký tự: {charText}\n" + 
                    $"Mã ASCII: {asciiCode}\n" + $"Key Code: {(int)e.KeyCode}";
            };

            // Sự kiện chuột
            labelInfo.MouseDown += (s, e) =>
            {
                string MouseButton = "";
                if (e.Button == MouseButtons.Left)
                    MouseButton = "Chuột trái";
                else if (e.Button == MouseButtons.Right)
                    MouseButton = "Chuột phải";
                else if (e.Button == MouseButtons.Middle)
                    MouseButton = "Chuột giữa";

                labelInfo.Text = $" Chuột:\n" + $"{MouseButton} được nhấn tại ({e.X}, {e.Y})";
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
