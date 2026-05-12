using System;
using System.Collections.Generic;
using System.Text;

namespace De_Tham_Khao_03
{
    internal class Thuyen : IThuyen, IPhuongTien
    {
        public string Ten { get; set ; }
        public int TocDo { get; set; }
        public double NhienLieu { get; set; }
        public double SoKMDaDi { get; set; }
        public int NamSanXuat { get; set; }
        public string NhaSanXuat { get; set; }

        public void Noi()
        {
            Console.WriteLine($"Thuyen dang noi co ten la {Ten} thuoc hang {NhaSanXuat}");
        }
        public Thuyen(string ten = null, int tocDo = 0, double nhienLieu = 0, double soKMDaDi = 0, int namSanXuat = 0, string nhaSanXuat = null)
        {
            Ten = ten;
            TocDo = tocDo;
            NhienLieu = nhienLieu;
            SoKMDaDi = soKMDaDi;
            NamSanXuat = namSanXuat;
            NhaSanXuat = nhaSanXuat;
        }
        public Thuyen (string b)
        {
            string[] part = b.Split(',');
            Ten = part[1];
            TocDo = int.Parse(part[2]);
            NhienLieu = double.Parse(part[3]);
            SoKMDaDi = double.Parse(part[4]);
            NamSanXuat = int.Parse(part[5]);
            NhaSanXuat = part[6];
        }
        public string HienThiThongTin()
        {
            return $"Thuyen: {Ten} || Toc do: {TocDo} || Nhien lieu: {NhienLieu} || So Km: {SoKMDaDi} || NSX: {NamSanXuat} || NSX: {NhaSanXuat}";
        }
        public void TangToc(double GiaToc)
        {
            TocDo += (int)GiaToc;
        }
        public void DoNhienLieu(double luong)
        {
            NhienLieu += luong;
        }
    }
}
