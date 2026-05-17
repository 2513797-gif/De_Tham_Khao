using System;
using System.Collections.Generic;
using System.Text;

namespace De_Le
{
    internal class NhanVienBanThoiGian : NhanVien
    {
        public int SoGioLamViec {  get; set; }
        int donGia = 35000;
        public NhanVienBanThoiGian() { }
        public NhanVienBanThoiGian(string hoTen, DateTime ngayThangNamSinh, int thang, int soGioLamViec)
        {
            HoTen = hoTen;
            NgayThangNamSinh = ngayThangNamSinh;
            Thang = thang;
            SoGioLamViec = soGioLamViec;
        }
        public NhanVienBanThoiGian(string b)
        {
            string[] part = b.Split(',');
            HoTen = part[1];
            NgayThangNamSinh = DateTime.Parse(part[2]);
            Thang = int.Parse(part[3]);
            SoGioLamViec = int.Parse(part[4]);
        }
        public int Luong()
        {
            return SoGioLamViec * donGia;
        }
        public override string ToString()
        {
            return $"BTG | {HoTen, -20} | {NgayThangNamSinh, -25} | {Thang, -5} | {SoGioLamViec, -5} | {Luong(), -9} |";
        }
    }
}
