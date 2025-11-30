namespace Bai05
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenSV { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }

        public SinhVien() { }

        public SinhVien(string ma, string ten, string khoa, double dtb)
        {
            MSSV = ma;
            HoTenSV = ten;
            Khoa = khoa;
            DiemTB = dtb;
        }
    }
}
