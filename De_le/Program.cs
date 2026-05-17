using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using De_Le;

namespace De_Le
{
    internal class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            XuatDanhSach,
            ThemThuCong,
            TimNhanVienHDLamViecItNhatThang,
            TimThangTraLuongNVHDCaoNhat,
            TimThangCoItNVHDLamViecItNhat,
            TimThangKhongcoNVHDLamViec,
            TimThangNVKhongCoCungNgaySinh,
            LayDanhSachNhanVienTheoThang,
            SapXepNhanVienTheoThang,
            KiemTraNVBTGCoCungNgaySinh,
            ThuongNhanVienThang12VaInRaFile,

        }
        static void Main(string[] args)
        {
            QuanLyNhanVien ds = new QuanLyNhanVien();
            Menu menu = new Menu();
            do
            {
                Console.WriteLine("        Menu Chon Chuc Nang");
                Console.WriteLine("1: Nhap tu file");
                Console.WriteLine("2: Xuat Danh Sach ra mang hinh");
                Console.WriteLine("3: Them thu cong nhan vien");
                Console.WriteLine("4: Tim nhan vien lam viec it nhat thang");
                Console.WriteLine("5: Tim thang tra luong nhan vien hop dong cao nhat");
                Console.WriteLine("6: Tim thang co it nhan vien hop dong lam viec");
                Console.WriteLine("7: Tim thang khong co nhan vien hop dong lam viec");
                Console.WriteLine("8: Tim thang nhan vien khong co cung ngay sinh");
                Console.WriteLine("9: Lay danh Sach nhan vien theo thang");
                Console.WriteLine("10: Sap xep nhan vien theo thang");
                Console.WriteLine("11: Kiem tra nhan vien ban thoi gian co cung ngay sinh");
                Console.WriteLine("12: Thuong Nhan vien Lam viec thang 12 va In ra file");
                Console.WriteLine("0: Thoat\n");
                Console.Write("Chon chuc nang: ");
                menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.NhapTuFile:
                        try
                        {
                            ds.NhapTuFile();
                            Console.WriteLine("Nhap Tu file Thanh cong!");
                        }
                        catch
                        {
                            Console.WriteLine("Nhap tu file that bai!");
                        }
                        break;
                    case Menu.XuatDanhSach:
                        ds.XuatDanhSach();
                        break;
                    case Menu.ThemThuCong:
                        break;
                    case Menu.TimNhanVienHDLamViecItNhatThang:
                        Console.Write("Nhap thang can tim: ");
                        int thang = int.Parse(Console.ReadLine());
                        List<NhanVienHopDong> nv = ds.Cau2_TimNhanVienLamViecItNhatTrongThang(thang);
                        if (nv.Count == 0)
                            Console.WriteLine("Khong tim thay nhan vien nao!");
                        else
                        {
                            Console.WriteLine("--- Danh Sach nhan vien hop dong lam viet it nhat thang ---");
                            foreach(var item in nv)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine($"So ngay lam viec it nhat thang ghi nhan la: {nv[0].SoNgayLamViec}");
                        }
                        break;
                    case Menu.TimThangTraLuongNVHDCaoNhat:
                        List<int> cacThangMax = ds.Cau3_TimThangTraLuongNhanVienHDCaoNhat();
                        if (cacThangMax.Count == 0)
                            Console.WriteLine("Khong tim thay du lieu!");
                        else
                        {
                            string chuoiThang = string.Join(", ", cacThangMax);
                            Console.WriteLine($"\nThang tra luong nhan vien hop dong cao nhat la: {chuoiThang}");
                        }
                        break;
                    case Menu.TimThangCoItNVHDLamViecItNhat:
                        var s = ds.Cau4_TimThangCoNVHDLamViecItNHat1();
                        if (s.Count == 0)
                            Console.WriteLine("Khong tim thay du lieu!");
                        else
                        {
                            string cacThangMin = string.Join(", ", s);
                            Console.WriteLine($"Nhung thang co it NVHD lam viec la: {cacThangMin}");
                        }
                        break;
                    case Menu.TimThangKhongcoNVHDLamViec:
                        var n = ds.Cau5_TimThangKhongCoNVHDLamViec();
                        if (n.Count == 0)
                            Console.WriteLine("Tat ca cac thang deu co nhan vien hop dong lam viec");
                        else
                        {
                            Console.WriteLine("Cac Thang khong co nhan vien hop dong lam viec la: " + string.Join(", ", n));
                        }
                        break;
                    case Menu.TimThangNVKhongCoCungNgaySinh:
                        var a = ds.Cau6_TimThangNhanVienKhongCoCungNgaySinh();
                        if (a.Count == 0)
                            Console.WriteLine("Khong co thang nao thoa man");
                        else
                        {
                            Console.WriteLine("Thang Nhan Vien khong co cung ngay sinh la: " + string.Join(", ", a));
                        }
                        break;
                    case Menu.LayDanhSachNhanVienTheoThang:
                        Console.Write("Nhap thang can lay nhan vien: ");
                        var t = int.Parse(Console.ReadLine());
                        var a1 = ds.LayDanhSachNhanVienTheoThang(t);
                        foreach(var item in a1)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case Menu.SapXepNhanVienTheoThang:
                        ds.SapXepNhanVienTheoThang();
                        ds.XuatDanhSach();
                        break;
                    case Menu.KiemTraNVBTGCoCungNgaySinh:
                        var danhSachTrung = ds.Cau7_TimNVBanThoiGianCungNgaySinh();

                        if (danhSachTrung.Count == 0)
                        {
                            Console.WriteLine("-> Khong co nhan vien ban thoi gian nao co cung ngay sinh nhat.");
                        }
                        else
                        {
                            Console.WriteLine($"-> Da tim thay {danhSachTrung.Count} nhan vien ban thoi gian co cung ngay sinh. Danh sach chi tiet:");

                            foreach (var nv2 in danhSachTrung)
                            {
                                Console.WriteLine(nv2.ToString());
                            }
                        }
                        break;
                    case Menu.ThuongNhanVienThang12VaInRaFile:
                        ds.Cau9_ThuongNgayLamViecThang12();
                        break;

                    case Menu.Thoat:
                        break;
                    default:
                        Console.WriteLine("Loi! Vui long nhap lai!");
                        break;
                }
            }
            while (menu != Menu.Thoat);
        }
    }
}