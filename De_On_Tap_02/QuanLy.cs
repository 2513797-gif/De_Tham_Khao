using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_02
{
    internal class QuanLy : INhanVien, INguoi
    {
        public int NhanVienID { get; set; }
        public string Phong { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }

        public string LayTenDayDu()
        {
            return $"Ho ten: {Ho} {Ten} || ";
        }

        public string ThongTinChiTiet()
        {
           return $"Nhan vien ID: {NhanVienID} || Phong: {Phong}";
        } 
        public string ToString()
        {
            return $"Ma nhan vien: {NhanVienID} || Ho ten: {Ho} {Ten, -5} || Phong: {Phong}";
        }
        public QuanLy()
        {
        }
        public QuanLy(int nhanVienID, string ho, string ten, string phong)
        {
           this.NhanVienID = nhanVienID;
            this.Ho = ho;
            this.Ten = ten;
            this.Phong = phong;
        }
        public QuanLy(string b)
        {
            string[] part = b.Split(',');
            NhanVienID = int.Parse(part[0]);
            Ho = part[1];
            Ten = part[2];
            Phong = part[3];
        }
    }
}
