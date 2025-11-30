using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class FormNhapSV : Form
    {
        public SinhVien SinhVienMoi { get; private set; }

        public FormNhapSV()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonThemMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(TextBoxMSSV.Text) ||
                string.IsNullOrWhiteSpace(TextBoxHoTen.Text) ||
                string.IsNullOrWhiteSpace(TextBoxDiemTB.Text) ||
                ComboBoxKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra điểm hợp lệ
            if (!double.TryParse(TextBoxDiemTB.Text, out double diem))
            {
                MessageBox.Show("Điểm trung bình phải là số!");
                return;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!");
                return;
            }

            // Tạo sinh viên mới
            SinhVienMoi = new SinhVien
            {
                MSSV = TextBoxMSSV.Text.Trim(),
                HoTenSV = TextBoxHoTen.Text.Trim(),
                Khoa = ComboBoxKhoa.SelectedItem.ToString(),
                DiemTB = double.Parse(TextBoxDiemTB.Text.Trim())
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
