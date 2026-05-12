using System;
using System.Collections.Generic;
using System.Text;

namespace De_Tham_Khao_03
{
    internal class TauNgam :  ITauNgam, IPhuongTien
    {
        public string Ten { get; set; }
        public int TocDo { get; set; }
        public double NhienLieu { get; set; }
        public double SoKMDaDi { get; set; }
        public int NamSanXuat { get; set; }
        public string NhaSanXuat { get; set; }
        public void Lan()
        {
            Console.WriteLine($"Tau co ten {Ten} dang lan voi toc do {TocDo} ");
        }
        public void Noi()
        {
            Console.WriteLine($"Tau co ten {Ten} Dang noi, nhien lieu hien tai {NhienLieu}");
        }
        public TauNgam() { }

        public TauNgam(string ten, int tocDo, double nhienLieu, double soKMDaDi, int namSanXuat, string nhaSanXuat)
        {
            Ten = ten;
            TocDo = tocDo;
            NhienLieu = nhienLieu;
            SoKMDaDi = soKMDaDi;
            NamSanXuat = namSanXuat;
            NhaSanXuat = nhaSanXuat;
        }
        public TauNgam(string b)
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
            return $"Tau: {Ten} || Toc do: {TocDo} || Nhien lieu: {NhienLieu} || So Km:  {SoKMDaDi}  || NSX:  {NamSanXuat}  || NSX:  {NhaSanXuat}";
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
