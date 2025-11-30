using System;
using System.IO;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFileNguon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxNguon.Text = fbd.SelectedPath;
            }
        }

        private void ButtonFileDich_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TextBoxDich.Text = fbd.SelectedPath;
            }
        }

        private void ButtonSaoChep_Click(object sender, EventArgs e)
        {
            string sourceFolder = TextBoxNguon.Text;
            string destFolder = TextBoxDich.Text;

            if (!Directory.Exists(sourceFolder))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!");
                return;
            }

            if (!Directory.Exists(destFolder))
            {
                MessageBox.Show("Thư mục đích không tồn tại!");
                return;
            }

            CopyAllFiles(sourceFolder, destFolder);
        }

        private void CopyAllFiles(string sourceFolder, string destFolder)
        {
            string[] files = Directory.GetFiles(sourceFolder);

            if (files.Length == 0)
            {
                MessageBox.Show("Thư mục nguồn không có tệp nào!");
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = files.Length;

            foreach (string sourceFile in files)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destFile = Path.Combine(destFolder, fileName);

                ToolStripStatusLabel1.Text = $"Đang sao chép: {destFile}";
                Application.DoEvents();

                File.Copy(sourceFile, destFile, true);

                progressBar1.Value++;
            }

            ToolStripStatusLabel1.Text = "Hoàn thành sao chép!";
            MessageBox.Show("Đã sao chép xong!", "Thông báo");
        }
    }
}
