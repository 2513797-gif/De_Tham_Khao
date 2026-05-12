using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using De_Tham_Khao_03;

namespace De_Tham_Khao_03
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            Xuat,
            ThemThuCong,


        }
        static void Main(string[] args)
        {
            DanhSachPhuongTien ds = new DanhSachPhuongTien();
            ds.NhapTuFile();
            ds.XuatDanhSach();
        }
    }
}