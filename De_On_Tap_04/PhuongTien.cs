using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_04
{
    internal class PhuongTien
    {
        public string Ten { get; set; }
        public double TocDo { get; set; }
        public double NhienLieu { get; set; }
        public int NamSanXuat { get; set; }
        public string NhaSanXuat { get; set; }
        public double KmDaDi { get; set; }
        public void TangToc(double luong)
        {
            if (luong < 0)
                Console.WriteLine("Luong tang toc khong hop le!");
            else
            {
                TocDo += luong;
                Console.WriteLine($"{Ten} toc do da tang them {luong} km/h | Toc do hien tai: {TocDo} Km/h");
            }
        }
        public void DoNhienLieu(double luong)
        {
            if (luong < 0) Console.WriteLine("Luong nhien lieu khong hop le!");
            else
            {
                NhienLieu += luong;
                Console.WriteLine($"{Ten} da do them {luong}L | Nhien lieu hien tai: {NhienLieu}");
            }
        }
        public void DiChuyen(double soKm)
        {
            if (soKm < 0)
                Console.WriteLine("So km khong hop le!");
            else
            {
                KmDaDi += soKm;
                Console.WriteLine($"{Ten} da di them {soKm} | Tong: {KmDaDi}");
            }
        }
        public virtual void HienThiHanhVi() { }
        public virtual string ToString()
        {
            return $"";
        }
    }
}
