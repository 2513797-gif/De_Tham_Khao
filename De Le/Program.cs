using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using De Le;

namespace De Le
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            XuatDanhSach,
            TimNhanVienTheoLoai,

        }
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();

            Menu menu = new Menu();
            do
            {
                Console.WriteLine("     Menu Chon Chuc Nang Nhan Vien ");
                Console.WriteLine("1: Nhap Tu File");
                Console.WriteLine("2: Xuat Danh Sach Nhan vien");
                Console.WriteLine("3: Tim nhan vien theo loai ");
                Console.WriteLine("0: Thoat");

                Console.Write("Chon chuc nang: ");
                menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.NhapTuFile:
                        try
                        {
                            ds.NhapTuFile();
                            Console.WriteLine("Nhap tu file thanh cong");
                        }
                        catch
                        {
                            Console.WriteLine("Nhap tu file that bai!");
                        }
                        break;
                    case Menu.XuatDanhSach:
                        ds.XuatDanhSach();
                        break;
                    case Menu.TimNhanVienTheoLoai:
                        break;
                    case Menu.Thoat:
                        break;
                    default:
                        Console.WriteLine("LOI!");
                        continue;
                }
            }
            while (menu != Menu.Thoat);
        }
    }
}