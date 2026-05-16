using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_03
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh {  get; set; }
        public DateTime NgayVaoLam {  get; set; }
        public string MSCN { get; set; }
        public NhanVien(string maNV, string ho, string ten, DateTime ngaySinh, DateTime ngayVaoLam, string mSCN)
        {
            MaNV = maNV;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            NgayVaoLam = ngayVaoLam;
            MSCN = mSCN;
        }
        public NhanVien() { }
        public NhanVien(string b)
        {
            string[] part = b.Split(',');
            MaNV = part[0];
            Ho = part[1];
            Ten = part[2]; 
            NgaySinh = DateTime.Parse(part[3]);
            NgayVaoLam = DateTime.Parse(part[4]);
            MSCN = part[5];
        }
        public string ToString()
        {
            return $"{MaNV, -5} | {Ho, -10} | {Ten, -8} | {NgaySinh, -5} | {NgayVaoLam, -5} | {MSCN, -8} |";
        }
        public int SoNamLamViec => DateTime.Now.Year - NgayVaoLam.Year;
    }
}
