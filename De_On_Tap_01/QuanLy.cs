using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_01
{
    internal class QuanLy : NhanVien
    {
        public string Phong { get; set; }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ten: {Ten, -20}");
            Console.WriteLine($"Tuoi: {Tuoi}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Luong: {Luong}");
            Console.WriteLine($"Ma nhan vien: {MaNhanVien}");
            Console.WriteLine($"Vi tri: {ViTri}");
            Console.WriteLine($"Phong: {Phong}");
        }
        public QuanLy(string ten, int tuoi, string diaChi, decimal luong, string maNhanVien, string viTri, string phong)
        {
            Ten = ten;
            Tuoi = tuoi;
            DiaChi = diaChi;
            Luong = luong;
            MaNhanVien = maNhanVien;
            ViTri = viTri;
            Phong = phong;
        }
        public QuanLy()
        {
        }
        public QuanLy(string b)
        {
            string[] part = b.Split(',');
            Ten = part[0];
            Tuoi = int.Parse(part[1]);
            DiaChi = part[2];
            Luong = decimal.Parse(part[3]);
            MaNhanVien = part[4];
            ViTri = part[5];
            Phong = part[6];
        }
    }
}
