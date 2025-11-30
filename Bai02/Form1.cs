using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Timer timer;
        public Form1()
        {
            InitializeComponent();

            // Tạo và cấu hình timer
            timer = new Timer();
            timer.Interval = 100; // Cập nhật mỗi 0.1 giây
            timer.Tick += Timer_Tick;
            timer.Start(); // Bắt đầu chạy timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Hiển thị ngày giờ bằng tiếng Anh (bất kể ngôn ngữ hệ thống)
            var englishCulture = new CultureInfo("en-US");
            LabelNgayGio.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt", englishCulture);

            // Căn giữa Label trong Form
            LabelNgayGio.Left = (this.ClientSize.Width - LabelNgayGio.Width) / 2;
            LabelNgayGio.Top = (this.ClientSize.Height - LabelNgayGio.Height) / 2;
        }
    }
}
