using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using De_On_Tap_01;

namespace De_On_Tap_01
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            NhapThuCong,
            XuatDanhSach,
            TimKiem,
            sapXep,
            Xoa,
            Sua,
            Luu,

        }
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();

            //Console.WriteLine("=====================================");
            //Console.WriteLine("=     Menu Quan Ly Nhan Vien        =");
            //Console.WriteLine("=====================================");
            //Console.WriteLine("| 1. Nhap tu file                   |");
            //Console.WriteLine("| 2. Nhap thu cong                  |");
            //Console.WriteLine("| 3. Xuat danh sach                 |");
            //Console.WriteLine("| 4. Tim kiem                       |");
            //Console.WriteLine("| 5. Sap xep                        |");
            //Console.WriteLine("| 6. Xoa                            |");
            //Console.WriteLine("| 7. Sua                            |");
            //Console.WriteLine("| 0. Thoat                          |");
            //Console.WriteLine("=====================================");

            Menu menu = new Menu();
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("=     Menu Quan Ly Nhan Vien        =");
                Console.WriteLine("=====================================");
                Console.WriteLine("| 1. Nhap tu file                   |");
                Console.WriteLine("| 2. Nhap thu cong                  |");
                Console.WriteLine("| 3. Xuat danh sach                 |");
                Console.WriteLine("| 4. Tim kiem nhan vien             |");
                Console.WriteLine("| 5. Sap xep nhan vien              |");
                Console.WriteLine("| 6. Xoa nhan vien                  |");
                Console.WriteLine("| 7. Sua nhan vien                  |");
                Console.WriteLine("| 8. Luu danh sach nhan vien        |");
                Console.WriteLine("| 0. Thoat                          |");
                Console.WriteLine("=====================================");
                Console.Write("Chon chuc nang: ");
                menu = (Menu)int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case Menu.NhapTuFile:
                       try
                        {
                            ds.NhapTuFile();
                            Console.WriteLine("Nhap tu file thanh cong!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Loi! Doc file that bai!");
                        }
                        break;
                    case Menu.NhapThuCong:
                        ds.NhapThuCong();
                        ds.XuatDanhSach();
                        break;
                    case Menu.XuatDanhSach:
                        ds.XuatDanhSach();
                        break;
                    case Menu.TimKiem:
                        Console.WriteLine("   Menu Chuc Nang Tim Kiem");
                        Console.WriteLine("1: Tim kiem nhan vien theo ten");
                        Console.WriteLine("2: Tim kiem nhan vien theo tuoi");
                        Console.WriteLine("3: Tim kiem nhan vien theo dia chi");
                        Console.WriteLine("4: Tim kiem nhan vien theo phong");
                        Console.WriteLine("5: Tim kiem nhan vien theo luong");
                        Console.WriteLine("6: Tim kiem nhan vien theo vi tri");
                        Console.WriteLine("7: Tim kiem nhan vien theo ma nhan vien");
                        Console.WriteLine("0: Thoat");
                        Console.Write("Chon chuc nang tim kiem: ");
                        int chose = int.Parse(Console.ReadLine());
                        switch(chose)
                        {
                            case 1:
                                ds.TimKiemTheoTen();
                                break;
                            case 2:
                                ds.TimKiemTheoTuoi();
                                break;
                            case 3:
                                ds.TimKiemTheoDiaChi();
                                break;
                            case 4:
                                ds.TimKiemTheoPhong();
                                break;
                            case 5:
                                ds.TimKiemTheoLuong();
                                break;
                            case 6:
                                ds.TimKiemTheoViTri();
                                break;
                            case 7:
                                ds.TimKiemTheoMaNhanVien();
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("LOI! khong hop le!");
                                break;
                        }
                        break;
                    case Menu.sapXep:
                        Console.WriteLine("    Menu Sap Xep Nhan Vien");
                        Console.WriteLine("1: Sap xep theo ten");
                        Console.WriteLine("2: Sap xep theo tuoi");
                        Console.WriteLine("3: Sap xep theo Luong");
                        Console.WriteLine("4: Sap xep theo phong");
                        Console.WriteLine("0: Thoat");
                        Console.Write("Chon chuc nang sap xep: ");
                        int chon = int.Parse(Console.ReadLine());
                        switch(chon)
                        {
                            case 1:
                                ds.SapXepNhanVienTheoTen();
                                ds.XuatDanhSach();
                                break;
                            case 2:
                                ds.SapXepNhanVienTheoTuoi();
                                ds.XuatDanhSach();
                                break;
                            case 3:
                                ds.SapXepNhanVienTheoLuong();
                                ds.XuatDanhSach();
                                break;
                            case 4:
                                ds.SapXepNhanVienTheoPhong();
                                ds.XuatDanhSach();
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("LOI! khong hop le!");
                                break;
                        }
                        break;
                    case Menu.Xoa:
                        Console.WriteLine("  Menu Chuc Nang Xoa");
                        Console.WriteLine("1: Xoa theo ten");
                        Console.WriteLine("2: Xoa theo tuoi");
                        Console.WriteLine("3: Xoa theo phong");
                        Console.WriteLine("0: Thoat");
                        Console.WriteLine("Chon chuc nang xoa: ");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            ds.XoaNhanVienTheoTen();
                            ds.XuatDanhSach();
                        }
                        else if (n == 2)
                        {
                            ds.XoaNhanVienTheoTuoi();
                            ds.XuatDanhSach();
                        }
                        else if (n == 3)
                        {
                            ds.XoaNhanVienTheoPhong();
                            ds.XuatDanhSach();
                        }
                        else
                            break;
                        break;
                    case Menu.Sua:
                        Console.WriteLine("  Menu Chuc Nang Sua");
                        Console.WriteLine("1: Sua ten nhan vien ");
                        Console.WriteLine("2: Sua luong nhan vien");
                        Console.WriteLine("3: Sua phong nhan vien");
                        Console.WriteLine("0: Thoat");
                        Console.Write("Chon chuc nang sua: ");
                        int chon1 = int.Parse(Console.ReadLine());
                        if (chon1 == 1)
                            ds.SuaTenNhanVienTheoMa();
                        else if(chon1 == 2)
                            ds.SuaLuongNhanVienTheoMa();
                        else if(chon1 == 3)
                            ds.SuaPhongNhanVienTheoMa();
                        else
                            Console.WriteLine("LOI! khong hop le!");
                        break;
                    case Menu.Luu:
                        try
                        {
                            ds.Luufile();
                            Console.WriteLine("Da luu danh sach nhan vien vao file!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Loi! Luu file that bai!");
                        }
                        break;
                }
            }
            while (menu != Menu.Thoat);
        }
    }
}