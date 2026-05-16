using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_03
{
    internal class NhanVienKyNang
    {
        public string MaNV {  get; set; }
        public string MSKN { get; set; }
        public int MucDo {  get; set; }
        public NhanVienKyNang(string maNV, string mSKN, int mucDo)
        {
            MaNV = maNV;
            MSKN = mSKN;
            MucDo = mucDo;
        }
        public NhanVienKyNang() { }
        public NhanVienKyNang(string b)
        {
            string[] part = b.Split(',');
            MaNV = part[0];
            MSKN = part[1];
            MucDo = int.Parse(part[2]);
        }
        public string ToString()
        {
            return $"{MaNV,-5} | {MSKN,-5} | {MucDo,-5}";
        }
    }
}
