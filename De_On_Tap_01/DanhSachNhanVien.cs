using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace De_On_Tap_01
{
    internal class DanhSachNhanVien
    {
        List<Nguoi> collection = new List<Nguoi>();
        public void NhapTuFile()
        {
            //using (var sr = new StreamReader("NhanVien.txt"))
            //{
            //    string line = sr.ReadLine();
            //    while(line != null)
            //    {
            //        var s = new QuanLy(line);
            //        collection.Add(s);
            //    }
            //}
            StreamReader sr = new StreamReader("NhanVien.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                var s = new QuanLy(line);
                collection.Add(s);
            }
        }
        public void XuatDanhSach()
        {
            foreach (var item in collection)
            {
                item.HienThiThongTin();
                Console.WriteLine("-------------------");
            }
        }
        public void NhapThuCong()
        {
            Console.Write("Nhap so luong nhan vien can them: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin nhan vien thu {i + 1}: ");
                Console.WriteLine("Ten: ");
                string ten = Console.ReadLine();
                Console.WriteLine("Tuoi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Dia chi: ");
                string diaChi = Console.ReadLine();
                Console.WriteLine("Luong: ");
                decimal luong = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ma nhan vien: ");
                string maNhanVien = Console.ReadLine();
                Console.WriteLine("Vi tri: ");
                string viTri = Console.ReadLine();
                Console.WriteLine("Phong: ");
                string phong = Console.ReadLine();
                var s = new QuanLy(ten, tuoi, diaChi, luong, maNhanVien, viTri, phong);
                collection.Add(s);
            }
            Console.WriteLine("Nhap xong!");
        }
        public void TimKiemTheoTen()
        {
            Console.Write("Nhap ten nhan vien can tim: ");
            string ten = Console.ReadLine();
            foreach (var item in collection)
            {
                if (item.Ten == ten)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoTuoi()
        {
            Console.Write("Nhap tuoi Nhan vien can tim: ");
            int tuoi = int.Parse(Console.ReadLine());
            foreach (var item in collection)
            {
                if (item.Tuoi == tuoi)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoDiaChi()
        {
            Console.Write("Nhap dia chi nhan vien can tim: ");
            string diachi = Console.ReadLine();
            foreach (var item in collection)
            {
                if (item.DiaChi == diachi)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoPhong()
        {
            Console.Write("Nhap phong nhan vien can tim: ");
            string phong = Console.ReadLine();
            foreach(var item in collection)
            {
                if (((QuanLy)item).Phong == phong)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoLuong()
        {
            Console.Write("Nhap Luong nhan vien can tim: ");
            decimal luong = decimal.Parse(Console.ReadLine());
            foreach (var item in collection)
            {
                if (((NhanVien)item).Luong == luong)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoViTri()
        {
            Console.Write("Nhap vi tri nhan vien can tim: ");
            string viTri = Console.ReadLine();
            foreach(var item in collection)
            {
                if(((NhanVien)item).ViTri == viTri)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("-------------------");
                }
            }
        }
        public void TimKiemTheoMaNhanVien()
        {
            Console.WriteLine("Nhap ma nhan vien can tim: ");
            string maNhanVien = Console.ReadLine();
            foreach(var item in collection)
            {
                if(((NhanVien)item).MaNhanVien == maNhanVien)
                {
                    item.HienThiThongTin();
                    Console.WriteLine("---------------");
                }
            }
        }
        public void SapXepNhanVienTheoTen()
        {
            collection.Sort((a, b) => a.Ten.CompareTo(b.Ten));
            Console.WriteLine("Da sap xep theo ten!");
        }
        public void SapXepNhanVienTheoTuoi()
        {
            collection.Sort((a, b) => a.Tuoi.CompareTo(b.Tuoi));
            Console.WriteLine("Da sap xep theo tuoi!");
        }
        public void SapXepNhanVienTheoLuong()
        {
            collection.Sort((a, b) => ((NhanVien)a).Luong.CompareTo(((NhanVien)b).Luong));
            Console.WriteLine("Da sap xep theo luong!");
        }
        public void SapXepNhanVienTheoPhong()
        {
            collection.Sort((a, b) => ((QuanLy)a).Phong.CompareTo(((QuanLy)b).Phong));
            Console.WriteLine("Da sap xep theo phong!");
        }
        public void XoaNhanVienTheoTen()
        {
            Console.WriteLine("Nhap ten nhan vien can xoa: ");
            string ten = Console.ReadLine();
            collection.RemoveAll(x => x.Ten == ten);
            Console.WriteLine("Da xoa nhan vien co ten " + ten);
        }
        public void XoaNhanVienTheoTuoi()
        {
            Console.WriteLine("Nhap tuoi nhan vien can xoa: ");
            int tuoi = int.Parse(Console.ReadLine());
            collection.RemoveAll(x => x.Tuoi == tuoi);
            Console.WriteLine($"Da xoa nhan vien co tuoi: {tuoi}");
        }
        public void XoaNhanVienTheoPhong()
        {
            Console.WriteLine("Nhap phong nhan vien can xoa: ");
            string phong = Console.ReadLine();
            collection.RemoveAll(x => ((QuanLy)x).Phong == phong);
            Console.WriteLine($"Da xoa nhan vien co phong: {phong}");
        }

        public void SuaNhanVien()
        {
            Console.WriteLine("Nhap ten nhan vien can sua: ");
            string ten = Console.ReadLine();
            var nv = collection.Find(x => x.Ten == ten);
            if (nv != null)
            {
                Console.WriteLine("Nhap thong tin moi: ");
                Console.WriteLine("Ten: ");
                nv.Ten = Console.ReadLine();
                Console.WriteLine("Tuoi: ");
                nv.Tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Dia chi: ");
                nv.DiaChi = Console.ReadLine();
                Console.WriteLine("Luong: ");
                ((NhanVien)nv).Luong = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ma nhan vien: ");
                ((NhanVien)nv).MaNhanVien = Console.ReadLine();
                Console.WriteLine("Vi tri: ");
                ((NhanVien)nv).ViTri = Console.ReadLine();
                Console.WriteLine("Phong: ");
                ((QuanLy)nv).Phong = Console.ReadLine();
                Console.WriteLine("Da sua thong tin nhan vien co ten " + ten);
            }
            else
            {
                Console.WriteLine("Khong tim thay nhan vien co ten " + ten);
            }
        }
    }
}
