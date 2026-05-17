using System;
using System.Collections.Generic;
using System.Text;

namespace De_Le
{
    internal class NhanVienHopDong : NhanVien
    {
        public int SoNgayLamViec{get; set;}
        int donGia = 400000;
        public NhanVienHopDong() { }
        public NhanVienHopDong(string hoTen, DateTime ngayThangNamSinh, int thang, int soNgayLamViec)
        {
            HoTen = hoTen;
            NgayThangNamSinh = ngayThangNamSinh;
            Thang = thang;
            SoNgayLamViec = soNgayLamViec;
        }
        public NhanVienHopDong(string b)
        {
            string[] part = b.Split(',');
            HoTen = part[1];
            NgayThangNamSinh = DateTime.Parse(part[2]);
            Thang = int.Parse(part[3]);
            SoNgayLamViec = int.Parse(part[4]);
        }
        public int Luong()
        {
            return SoNgayLamViec * donGia;
        }
        public override string ToString()
        {
            return $"HD  | {HoTen,-20} | {NgayThangNamSinh,-25} | {Thang,-5} | {SoNgayLamViec,-5} | {Luong(),-10}| ";
        }
    }
}
