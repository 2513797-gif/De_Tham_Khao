using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_04
{
    internal class XeHoi : PhuongTien, ILai
    {
        public double TocDoLai { get; set; }

        public void Lai()
        {
            Console.WriteLine($"{Ten} dang lai tren duong voi toc do: {TocDo} km/h.");
        }
        public XeHoi() { }
        public XeHoi(string ten, double tocDo, double nhienLieu, int namSanXuat, string nhaSanXuat, double kmDaDi)
        {
            Ten = ten;
            TocDo = tocDo;
            NhienLieu = nhienLieu;
            NamSanXuat = namSanXuat;
            NhaSanXuat = nhaSanXuat;
            KmDaDi = kmDaDi;
        }
        public XeHoi(string b)
        {
            string[] part = b.Split(',');
            Ten = part[1];
            TocDo = double.Parse(part[2]);
            NhienLieu = double.Parse(part[3]);
            NamSanXuat = int.Parse(part[4]);
            NhaSanXuat = part[5];
            KmDaDi = double.Parse(part[6]);
        }
        public override string ToString()
        {
            return $"Xe Hoi |{Ten}|{TocDo}|{NhienLieu}|{NamSanXuat}|{NhaSanXuat}|{KmDaDi}";
        }
        public override void Lai()
        {
            Console.WriteLine($"{Ten} Dang lai tren duong voi toc do {TocDo} km/h");
        }
        public override void HienThiHanhVi() => Lai();
       
    }
}
