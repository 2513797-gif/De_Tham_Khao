using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using De_On_Tap_02;

namespace De_On_Tap_02
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            ThemThuCong,
            XuatDanhSach,
            TimKiem,
            SapXep,
            Xoa,
            Sua,
            Luu,
        }
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            Console.WriteLine("   Menu Quan Ly Nhan Vien");
            Console.WriteLine("1: Nhap tu file");
            Console.WriteLine("2: Them nhan vien thu cong ");
            Console.WriteLine("3: Xuat danh sach ra mang hinh");
            Console.WriteLine("4: Tim Kiem nhan vien theo yeu cau");
            Console.WriteLine("5: Sap xep nhan vien theo yeu cau");
            Console.WriteLine("6: Xoa nhan vien theo yeu cau");
            Console.WriteLine("7: Sua nhan vien");
            Console.WriteLine("8: Luu danh sach nhan vien vao file");
            Console.WriteLine("0: Thoat");
            Menu Chose = new Menu();
            do
            {
                Console.Write("Chon chuc nang: ");
                Chose = (Menu)int.Parse(Console.ReadLine());
                switch (Chose)
                {
                    case Menu.NhapTuFile:
                        try
                        {
                            ds.NhapTuFile();
                            Console.WriteLine("Da nhap tu file thanh cong!");
                        }
                        catch
                        {
                            Console.WriteLine("Nhap tu file that bai!");
                        }
                        break;
                    case Menu.ThemThuCong:
                        ds.ThemThuCong();
                        break;
                    case Menu.XuatDanhSach:
                        ds.XuatDanhSach();
                        break;
                    case Menu.TimKiem:
                        ds.TimKiemNhanVienTheoPhong();
                        break;
                    case Menu.SapXep:
                        ds.SapXepNhanVienTheoPhong();
                        break;
                    case Menu.Xoa:
                        ds.XoaTheoPhong();
                        break;
                    case Menu.Sua:
                        Console.WriteLine("  Chon Chuc Nang Sua");
                        Console.WriteLine("1: Sua ten nhan vien theo ma");
                        Console.WriteLine("2: Sua ho nhan vien theo ma");
                        Console.WriteLine("3: Sua phong nhan vien theo ma");
                        Console.Write("Chon chuc nang: ");
                        int chose = int.Parse(Console.ReadLine());
                        if(chose == 1)
                        {
                            ds.SuaTenNhanVien();
                        }
                        else if(chose == 2)
                        {
                            ds.SuaHoNhanVien();
                        }
                        else if(chose == 3)
                        {
                            ds.SuaPhongNhanVien();
                        }
                        else
                        {
                            Console.WriteLine("Chuc nang khong hop le!");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("LOI! CHUC NANG KHONG HOP LE!");
                        break;

                }
            }
            while (Chose != Menu.Thoat);
        }
    }
}

