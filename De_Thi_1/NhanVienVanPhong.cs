using System;
using System.Collections.Generic;
using System.Text;

namespace De_Thi_1
{
    internal class NhanVienVanPhong : INhanVien
    {
        List<ThongTinLuongNVVP> ds = new List<ThongTinLuongNVVP>();
        float mucLuong;
        int ngayNghi;
        public float MucLuong { get => mucLuong; set => mucLuong = value; }
        public int NgayNghi { get => ngayNghi; set => ngayNghi = value; }
        public string HoTen { get; set; }
        public int NamLamViec { get; set; }
        public void NhapChamCong(ThongTinLuongNVVP tt)
        {
            ds.Add(new ThongTinLuongNVVP() { Thang = tt.Thang, Nam = tt.Nam, SoNgayNghi = tt.SoNgayNghi });
        }
        public float TinhLuongTheoThang(int n)
        {
            float tongLuong = 0;
            foreach (var item in ds)
            {
                if (item.Thang == n)
                {
                    tongLuong += item.LayLuongTheoThang(n);
                }
            }
            return tongLuong;
        }
        public NhanVienVanPhong(string hoTen, int namLamViec, float mucLuong, int ngayNghi)
        {
            HoTen = hoTen;
            NamLamViec = namLamViec;
            MucLuong = mucLuong;
            NgayNghi = ngayNghi;
        }
        public NhanVienVanPhong()
        {
        }
        public NhanVienVanPhong(string b)
        {
            string[] part = b.Split(',');
            HoTen = part[1];
            NamLamViec = int.Parse(part[2]);
            MucLuong = float.Parse(part[3]);
            NgayNghi = int.Parse(part[4]);
        }
        public override string ToString()
        {
            return $"VP || Ho ten: {HoTen, -20} || nam lam viec: {NamLamViec, -5} || muc luong: {MucLuong, -10} || ngay nghi: {NgayNghi, -5} || ";
        }
        public int LaySoNgayNghiTheoThang(int thang)
        {
            foreach (var item in ds)
            {
                if (item.Thang == thang)
                {
                    return item.SoNgayNghi;
                }
            }
            return 0;
        }
    }
}
