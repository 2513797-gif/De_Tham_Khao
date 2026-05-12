using System;
using System.Collections.Generic;
using System.Text;

namespace De_Tham_Khao_03
{
    internal interface IPhuongTien
    {
        public string Ten { get; set; }
        public int TocDo { get; set; }
        public double NhienLieu {get; set;}
        public double SoKMDaDi { get; set; }
        public int NamSanXuat { get; set; }
        public string NhaSanXuat { get; set; }
        public void TangToc(double giaToc) { }
        public void DoNhienLieu(double luong) { }
        public string HienThiThongTin()
        {
            return "";
        }
    }
}
