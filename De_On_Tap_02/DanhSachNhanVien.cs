using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_02
{
    internal class DanhSachNhanVien
    {
        List<INhanVien> collection = new List<INhanVien>();

        public void NhapTuFile()
        {
            StreamReader sr = new StreamReader("NhanVien.txt");
            string line;
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
                Console.WriteLine(item.ToString());
                Console.WriteLine("----------------------------------------------------------------");
            }
        }
        public void ThemThuCong()
        {
            Console.Write("Nhap so nhan vien can them: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho: ");
                string ho = Console.ReadLine();
                Console.Write("Nhap ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nhap ma nhan vien: ");
                int nhanVienID = int.Parse(Console.ReadLine());
                Console.Write("Nhap phong ban: ");
                string phong = Console.ReadLine();
                var s = new QuanLy(nhanVienID, ho, ten, phong);
                collection.Add(s);
            }
        }
        public void TimKiemNhanVienTheoPhong()
        {
            Console.Write("Nhap phong nhan vien can tim: ");
            string phong = Console.ReadLine();
            foreach (var item in collection)
            {
                if (((QuanLy)item).Phong == phong)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("-------------------");
                }
            }
        }
        //public void SapXepTheoPhong()
        //{
        //    collection.Sort((a, b) => string.Compare(((QuanLy)a).Phong, ((QuanLy)b).Phong));
        //    Console.WriteLine("Da sap xep theo phong ban!");
        //}
        public void SapXepNhanVienTheoPhong()
        {
            collection.Sort((a, b) => ((QuanLy)a).Phong.CompareTo(((QuanLy)b).Phong));
            Console.WriteLine("Da sap xep theo phong!");
        }
        public void XoaTheoPhong()
        {
            Console.Write("Nhap phong can xoa: ");
            string phong = Console.ReadLine();
            collection.RemoveAll(x => x.Phong == phong);
            Console.WriteLine("Da xoa het nhan vien cua phong " + phong);
        }
        public void SuaTenNhanVien()
        {
            Console.Write("Nhap ma nhan vien can sua: ");
            int maNhanVien = int.Parse(Console.ReadLine());
            var nv = collection.Find(x => x.NhanVienID == maNhanVien);
            if (nv != null)
            {
                Console.WriteLine("Moi ban nhap thong tin moi cho nhan vien: ");
                Console.Write("Nhap ten: ");
                ((QuanLy)nv).Ten = Console.ReadLine();
                Console.WriteLine("Da sua thong tin nhan vien " + nv.NhanVienID);
            }
        }
        public void SuaPhongNhanVien()
        {
            Console.Write("Nhap ma nhan vien can sua: ");
            int maNhanVien = int.Parse(Console.ReadLine());
            var nv = collection.Find(x => x.NhanVienID == maNhanVien);
            if (nv != null)
            {
                Console.WriteLine("Moi ban nhap thong tin moi cho nhan vien: ");
                Console.Write("nhap Phong: ");
                ((QuanLy)nv).Phong = Console.ReadLine();
                Console.WriteLine("Da sua thong tin nhan vien " + nv.NhanVienID);
            }
        }
        public void SuaHoNhanVien()
        {
            Console.Write("Nhap ma nhan vien can sua: ");
            int maNhanVien = int.Parse(Console.ReadLine());
            var nv = collection.Find(x => x.NhanVienID == maNhanVien);
            if (nv != null)
            {
                Console.WriteLine("Moi ban nhap thong tin moi cho nhan vien: ");
                Console.Write("Nhap ho: ");
                ((QuanLy)nv).Ho = Console.ReadLine();
                Console.WriteLine("Da sua thong tin nhan vien " + nv.NhanVienID);
            }
        }
        public void Luufile()
        {
            StreamWriter sw = new StreamWriter("BaoCao.txt");
            foreach (var item in collection)
            {
                sw.WriteLine($"{((QuanLy)item).NhanVienID},{((QuanLy)item).Ho},{((QuanLy)item).Ten},{((QuanLy)item).Phong}");
            }
            sw.Close();
            Console.WriteLine("Da luu danh sach nhan vien vao file!");
        }
    }
}
