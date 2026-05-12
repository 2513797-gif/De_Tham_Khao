using System;
using System.Collections.Generic;
using System.Text;

namespace De_Thi_1
{
    internal class NhanVienSanXuat : INhanVien
    {
        List<ThongTinLuongNVSanXuat> ds = new List<ThongTinLuongNVSanXuat>();
        public string HoTen { get; set;  }
        public int NamLamViec { get; set; }
        public void NhapChamCong(ThongTinLuongNVSanXuat tt)
        {
            ds.Add(new ThongTinLuongNVSanXuat() { Thang = tt.Thang, Nam = tt.Nam, SoSanPham = tt.SoSanPham });
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
        public NhanVienSanXuat(string hoTen, int namLamViec)
        {
            HoTen = hoTen;
            NamLamViec = namLamViec;
        }
        public NhanVienSanXuat()
        {
        }
        public NhanVienSanXuat(string b)
        {
            string[] part = b.Split(',');
            HoTen = part[1];
            NamLamViec = int.Parse(part[2]);
        }
        public override string ToString()
        {
            return $"SX || Ho ten: {HoTen, -20} || nam lam viec: {NamLamViec, -5} || ";
        }
    }
}
