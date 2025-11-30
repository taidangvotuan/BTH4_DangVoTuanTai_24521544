using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        string CurrentFilePath = ""; // lưu tên file hiện tại đang mở
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu font
            foreach (FontFamily font in FontFamily.Families)
                ToolStripComboBoxChinhFont.Items.Add(font.Name);

            // Chọn mặc định Tahoma
            ToolStripComboBoxChinhFont.Text = "Tahoma";

            // Đổ size
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
                ToolStripComboBoxChinhKichCo.Items.Add(s);

            ToolStripComboBoxChinhKichCo.Text = "14";

            // Đặt giá trị mặc định
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void ToolStripMenuItemTaoVBMoi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            CurrentFilePath = "";
            ToolStripComboBoxChinhFont.Text = "Tahoma";
            ToolStripComboBoxChinhKichCo.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void ToolStripMenuItemMoTapTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format|*.rtf|Text File|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = dlg.FileName;
                if (Path.GetExtension(CurrentFilePath).ToLower() == ".rtf")
                    richTextBox1.LoadFile(CurrentFilePath);
                else
                    richTextBox1.Text = File.ReadAllText(CurrentFilePath);
            }
        }

        private void ToolStripMenuItemLuuNDVanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rich Text Format|*.rtf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = dlg.FileName;
                    richTextBox1.SaveFile(CurrentFilePath);
                    MessageBox.Show("Lưu thành công!", "Thông báo");
                }
            }
            else
            {
                richTextBox1.SaveFile(CurrentFilePath);
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripComboBoxChinhFont_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ToolStripComboBoxChinhKichCo_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChangeFont()
        {
            try
            {
                string fontName = ToolStripComboBoxChinhFont.Text;
                float fontSize = float.Parse(ToolStripComboBoxChinhKichCo.Text);
                FontStyle style = richTextBox1.SelectionFont?.Style ?? FontStyle.Regular;
                richTextBox1.SelectionFont = new Font(fontName, fontSize, style);
            }
            catch 
            { 
            }
        }

        private void ToolStripMenuItemDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fd.Font;
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void ToolStripButtonItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void ToolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void ToggleStyle(FontStyle style)
        {
            if (richTextBox1.SelectionFont == null) return;
            FontStyle newStyle = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Style.HasFlag(style))
                newStyle &= ~style; // bỏ style
            else
                newStyle |= style; // thêm style

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, newStyle);
        }

        private void ToolStripButtonBlankPage_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma", 14);
            ToolStripComboBoxChinhFont.Text = "Tahoma";
            ToolStripComboBoxChinhKichCo.Text = "14";
            CurrentFilePath = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rich Text Format|*.rtf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = dlg.FileName;
                    richTextBox1.SaveFile(CurrentFilePath);
                    MessageBox.Show("Lưu thành công!", "Thông báo");
                }
            }
            else
            {
                richTextBox1.SaveFile(CurrentFilePath);
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
