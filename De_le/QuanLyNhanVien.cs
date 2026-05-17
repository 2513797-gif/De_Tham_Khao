using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace De_Le
{
    internal class QuanLyNhanVien
    {
        List<NhanVien> collection = new List<NhanVien>();
        public void NhapTuFile()
        {
            StreamReader sr = new StreamReader("NhanVien.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("HD"))
                {
                    var s = new NhanVienHopDong(line);
                    collection.Add(s);
                }
                if (line.StartsWith("BTG"))
                {
                    var s = new NhanVienBanThoiGian(line);
                    collection.Add(s);
                }
            }
        }
        public void XuatDanhSach()
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("------------------------------------------------------------------------------------");
            }
        }
        public List<NhanVienHopDong> LayDanhSachNhanVienHDTheoThang(int thang)
        {
            List<NhanVienHopDong> nv = new List<NhanVienHopDong>();
            foreach (var item in collection)
            {
                if (item is NhanVienHopDong && item.Thang == thang)
                {
                    nv.Add((NhanVienHopDong)item);
                }
            }
            return nv;
        }
        public int TimSoNgayLamViecItNhatThang(List<NhanVienHopDong> nv)
        {
            if (nv == null || nv.Count == 0)
                return -1;
            int min = nv[0].SoNgayLamViec;
            foreach (var item in nv)
            {
                if (item.SoNgayLamViec < min)
                {
                    min = item.SoNgayLamViec;
                }
            }
            return min;
        }
        public List<NhanVienHopDong> Cau2_TimNhanVienLamViecItNhatTrongThang(int thang)
        {
            List<NhanVienHopDong> KetQua = new List<NhanVienHopDong>();
            List<NhanVienHopDong> nv = LayDanhSachNhanVienHDTheoThang(thang);
            if (nv.Count == 0)
                return KetQua;
            int Min = TimSoNgayLamViecItNhatThang(nv);
            foreach (var item in nv)
            {
                if (item.SoNgayLamViec == Min)
                {
                    KetQua.Add(item);
                }
            }
            return KetQua;
        }
        public double[] TongLuongTheoThang()
        {
            double[] tongLuong = new double[13];
            foreach (NhanVien item in collection)
            {
                if (item is NhanVienHopDong)
                {
                    NhanVienHopDong nv = (NhanVienHopDong)item;
                    tongLuong[nv.Thang] += nv.Luong();
                }
            }
            return tongLuong;
        }
        public double TimLuongCaoNhat(double[] n)
        {
            double maxLuong = 0;
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > maxLuong)
                {
                    maxLuong = n[i];
                }
            }
            return maxLuong;
        }
        public List<int> Cau3_TimThangTraLuongNhanVienHDCaoNhat()
        {
            List<int> nv = new List<int>();
            double[] tong = TongLuongTheoThang();
            double maxLuong = TimLuongCaoNhat(tong);
            if (maxLuong == 0)
            {
                return nv;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (tong[i] == maxLuong)
                {
                    nv.Add(i);
                }
            }
            return nv;
        }
        public List<int> Cau4_TimThangCoNVHDLamViecItNHat()
        {
            var thongke = collection.OfType<NhanVienHopDong>()
                                    .GroupBy(nv => nv.Thang)
                                    .Select(g => new { Thang = g.Key, SoLuong = g.Count() })
                                    .ToList();
            if (!thongke.Any())
            {
                return new List<int>();
            }
            int Min = thongke.Min(x => x.Thang);
            return thongke.Where(x => x.SoLuong == Min).Select(x => x.Thang).ToList();
        }
        public int[] DemNhanVienTheoThang()
        {
            int[] demNhanVien = new int[13];
            foreach (var item in collection)
            {
                if (item is NhanVienHopDong)
                {
                    demNhanVien[item.Thang]++;
                }
            }
            return demNhanVien;
        }
        public int TimSoLuongItNhat(int[] demNhanVien)
        {
            int min = int.MaxValue;
            for (int i = 1; i <= 12; i++)
            {
                if (demNhanVien[i] > 0 && demNhanVien[i] < min)
                {
                    min = demNhanVien[i];
                }
            }
            if (min == int.MaxValue)
                return 0;
            return min;
        }
        public List<int> Cau4_TimThangCoNVHDLamViecItNHat1()
        {
            List<int> ds = new List<int>();
            int[] dem = DemNhanVienTheoThang();
            int min = TimSoLuongItNhat(dem);
            if (min == 0)
            {
                return ds;
            }
            for (int i = 1; i <= 12; i++)
            {
                if (dem[i] == min)
                {
                    ds.Add(i);
                }
            }
            return ds;
        }
        public List<int> Cau5_TimThangKhongCoNVHDLamViec()
        {
            List<int> ds = new List<int>();
            int[] dem = DemNhanVienTheoThang();
            for (int i = 1; i <= 12; i++)
            {
                if (dem[i] == 0)
                {
                    ds.Add(i);
                }
            }
            return ds;
        }
        public List<NhanVien> LayDanhSachNhanVienTheoThang(int thang)
        {
            List<NhanVien> ds = new List<NhanVien>();
            foreach(var item in collection)
            {
                if (item.Thang == thang)
                {
                    ds.Add(item);
                }    
            }   
            return ds;
        }
        public bool KiemTraTrungNgaySinh(List<NhanVien> ds)
        {
            if(ds.Count <= 1)
                return false;
            for (int i = 0; i < ds.Count -1; i++)
            {
                for(int j = i; j < ds.Count; j++)
                {
                    if (ds[i].NgayThangNamSinh.Date == ds[i + 1].NgayThangNamSinh.Date)
                    {
                        return true;
                    }
                }
            } 
            return false; 
        }
        public List<int> Cau6_TimThangNhanVienKhongCoCungNgaySinh()
        {
            List<int> KetQua = new List<int>();
            for(int i = 1; i <= 12; i++)
            {
                List<NhanVien> nv = LayDanhSachNhanVienTheoThang(i);
                if(nv.Count > 0 && KiemTraTrungNgaySinh(nv) == false)
                {
                    KetQua.Add(i);
                }    
            }   
            return KetQua;
        }
        public void SapXepNhanVienTheoThang()
        {
            collection.Sort((a,b) => a.Thang.CompareTo(b.Thang));
        }
        public void SapXepNhanVienHopDongTheoThang()
        {
            collection.Sort((a, b) => ((NhanVienHopDong)a).Thang.CompareTo(((NhanVienHopDong)b).Thang));
        }
        public List<NhanVienBanThoiGian> LayDanhSachNVBTGTheoThang(int thang)
        {
            List<NhanVienBanThoiGian> nv = new List<NhanVienBanThoiGian>();
            foreach(var item in collection)
            {
                if(item is NhanVienBanThoiGian && item.Thang == thang)
                {
                    nv.Add((NhanVienBanThoiGian)item);
                }
            }
            return nv;
        }
        public bool KiemTraCungNgaySinh(List <NhanVienBanThoiGian> ds)
        {
            if(ds.Count == 0)
            {
                return true;
            }
            for(int i = 1; i < ds.Count -1; i++)
            {
                for(int j = i; j < ds.Count; j++)
                {
                    if (ds[i].NgayThangNamSinh.Date == ds[i + 1].NgayThangNamSinh.Date)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public List<int> Cau7_TimThangNVBTGCoCungNgaySinh()
        {
            List<int> KetQua = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                List<NhanVienBanThoiGian> nv = LayDanhSachNVBTGTheoThang(i);
                if (nv.Count > 0 && KiemTraCungNgaySinh(nv) == true)
                {
                    KetQua.Add(i);
                }
            }
            return KetQua;
        }
        public List<NhanVienBanThoiGian> Cau7_TimNVBanThoiGianCungNgaySinh()
        {
            List<NhanVienBanThoiGian> listBanThoiGian = new List<NhanVienBanThoiGian>();
            foreach (NhanVien nv in collection)
            {
                if (nv is NhanVienBanThoiGian)
                {
                    listBanThoiGian.Add((NhanVienBanThoiGian)nv);
                }
            }
            List<NhanVienBanThoiGian> ketQua = new List<NhanVienBanThoiGian>();

            for (int i = 0; i < listBanThoiGian.Count; i++)
            {
                bool coNguoiTrung = false;
                for (int j = 0; j < listBanThoiGian.Count; j++)
                {
                    if (i != j && listBanThoiGian[i].NgayThangNamSinh.Date == listBanThoiGian[j].NgayThangNamSinh.Date)
                    {
                        coNguoiTrung = true;
                        break; 
                    }
                }
                if (coNguoiTrung)
                {
                    ketQua.Add(listBanThoiGian[i]);
                }
            }

            return ketQua;
        }
        public void Cau9_ThuongNgayLamViecThang12()
        {
            int soNguoiDuocThuong = 0;
            foreach (NhanVien nv in collection)
            {
                if (nv is NhanVienHopDong && nv.Thang == 12)
                {
                    NhanVienHopDong nvhd = (NhanVienHopDong)nv;
                    nvhd.SoNgayLamViec += 1; 
                    soNguoiDuocThuong++;
                }
            }
            GhiDuLieuRaFile();

            Console.WriteLine($"\n-> Da thuong 1 ngay cong cho {soNguoiDuocThuong} nhan vien hop dong trong thang 12.");
            Console.WriteLine("-> Da cap nhap du lieu vao file thanh cong!");
        }
        public void GhiDuLieuRaFile()
        {
            using (StreamWriter sw = new StreamWriter("DuLieuNhanVien.txt"))
            {
                foreach (NhanVien nv in collection)
                {
                    if (nv is NhanVienHopDong)
                    {
                        NhanVienHopDong hd = (NhanVienHopDong)nv;
                        sw.WriteLine(hd.ToString());
                    }
                    else if (nv is NhanVienBanThoiGian)
                    {
                        NhanVienBanThoiGian bt = (NhanVienBanThoiGian)nv;
                        sw.WriteLine(bt.ToString());
                    }
                }
            }
        }
    }
}
