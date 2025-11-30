using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form_main : Form
    {
        List<SinhVien> DanhSachSV = new List<SinhVien>();
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        private void LoadDataGridView()
        {
            DataGridViewSinhVien.Rows.Clear();

            int stt = 1;
            foreach (var sv in DanhSachSV)
                DataGridViewSinhVien.Rows.Add(stt++, sv.MSSV, sv.HoTenSV, sv.Khoa, sv.DiemTB);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripButtonThemMoi_Click(object sender, EventArgs e)
        {
            FormNhapSV f = new FormNhapSV();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DanhSachSV.Add(f.SinhVienMoi);
                LoadDataGridView();
                MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripMenuItemThemMoi_Click(object sender, EventArgs e)
        {
            FormNhapSV f = new FormNhapSV();
            if (f.ShowDialog() == DialogResult.OK)
            {
                DanhSachSV.Add(f.SinhVienMoi);
                LoadDataGridView();
                MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo");
            }
        }

        private void ToolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemChucNang_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = TextBoxTimKiem.Text.ToLower();
            var kq = DanhSachSV.Where(sv => sv.HoTenSV.ToLower().Contains(keyword)).ToList();
            HienDanhSach(kq);
        }

        // Hiển thị danh sách
        void HienDanhSach(List<SinhVien> ds)
        {
            DataGridViewSinhVien.Rows.Clear();
            int stt = 1;
            foreach (var sv in ds)
                DataGridViewSinhVien.Rows.Add(stt++, sv.MSSV, sv.HoTenSV, sv.Khoa, sv.DiemTB);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
