using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using De_Thi_1;

namespace De_Thi_1
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            NhapThuCong,
            XuatDanhSach,
            TimNhanVienCoLuongThapNhat,
            TimNhanVienNghiNhieuNhatTrongThang,
            TimNhanVienVanPhongCoLuongCaoNhat,
            TinhTongNgayNghiCuaNhanVien,
            TimNhanVienSanXuatLamViec2Nam,

        }
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            
            Menu menu = new Menu();
            do
                {
                Console.WriteLine("    Menu Quan Ly Nhan Vien");
                Console.WriteLine("1. Nhap tu file");
                Console.WriteLine("2. Nhap thu cong");
                Console.WriteLine("3. Xuat danh sach");
                Console.WriteLine("4. Tim nhan vien co luong thap nhat");
                Console.WriteLine("5. Tim nhan vien nghi nhieu nhat trong thang");
                Console.WriteLine("6. Tim nhan vien van phong co luong cao nhat");
                Console.WriteLine("7. Tinh tong ngay nghi cua nhan vien");
                Console.WriteLine("8. Tim nhan vien san xuat lam viec 2 nam");
                Console.WriteLine("0: Thoat");
                Console.Write("Chon chuc nang: ");
                menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.NhapTuFile:
                        try
                        {
                            ds.NhapTuFile();
                            Console.WriteLine("Nhap tu file thanh cong!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("LOI! " + ex.Message);
                        }
                        break;
                    case Menu.NhapThuCong:
                        ds.NhapThuCong();
                        break;
                    case Menu.XuatDanhSach:
                        ds.XuatDanhSach();
                        break;
                    case Menu.TimNhanVienCoLuongThapNhat:
                        Console.Write("Nhập tháng cần xem lương: ");
                        int thangLuongThap = int.Parse(Console.ReadLine());
                        ds.TimNhanVienCoLuongThapNhat(thangLuongThap);
                        break;

                    case Menu.TimNhanVienNghiNhieuNhatTrongThang:
                        Console.Write("Nhập tháng cần kiểm tra ngày nghỉ: ");
                        int thangNghi = int.Parse(Console.ReadLine());
                        ds.TimNhanVienNghiNhieuNhatTrongThang(thangNghi);
                        break;

                    case Menu.TimNhanVienVanPhongCoLuongCaoNhat:
                        Console.Write("Nhập tháng cần xem lương: ");
                        int thangVPMax = int.Parse(Console.ReadLine());
                        ds.TimNhanVienVanPhongCoLuongCaoNhat(thangVPMax);
                        break;

                    case Menu.TinhTongNgayNghiCuaNhanVien:
                        ds.TinhTongNgayNghiThang5(); // Đề bài yêu cầu cố định tháng 5
                        break;

                    case Menu.TimNhanVienSanXuatLamViec2Nam:
                        ds.TimNVSanXuatThamNien2Nam();
                        break;
                    default:
                        Console.WriteLine("LOI! Lua chon khong hop le.");
                        break;
                }
            } while (menu != Menu.Thoat);
        }
    }
}