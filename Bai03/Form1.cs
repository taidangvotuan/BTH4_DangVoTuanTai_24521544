using System;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer(); // bộ đếm thời gian
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cập nhật thời gian mỗi giây
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật ngày giờ hiện tại lên StatusStrip
            ToolStripStatusLabelNgayGio.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") +
" - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ToolStripStatusLabelNgayGio_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Media files|*.mp3;*.mp4;*.avi;*.mpeg;*.wav;*.midi";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
