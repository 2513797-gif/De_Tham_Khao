using System;
using System.Collections.Generic;
using System.Text;

namespace De_Le
{
    internal class DanhSachNhanVien
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
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        public List<NhanVienHopDong> LayDanhSachNhanVienHopDong(int n)
        {
            List<NhanVienHopDong> nv = new List<NhanVienHopDong>();
            foreach (NhanVien item in collection)
            {
                if (item is NhanVienHopDong && item.Thang == n)
                {
                    nv.Add((NhanVienHopDong)item);
                }
            }
            return nv;
        }
        public int TimSoNgayLamViecItNhat(List<NhanVienHopDong> nv)
        {
            if (nv == null || nv.Count == 0)
                return -1;
            int minNgay = nv[0].SoNgayLamViec;
            foreach (NhanVienHopDong item in nv)
            {
                if (item.SoNgayLamViec < minNgay)
                {
                    minNgay = item.SoNgayLamViec;
                }
            }
            return minNgay;
        }
        public List<NhanVienHopDong> Cau2_TimThangCoSoNhanVienHopDongLamViecItNhat(int thang)
        {
            List<NhanVienHopDong> ketQua = new List<NhanVienHopDong>();
            List<NhanVienHopDong> nv = LayDanhSachNhanVienHopDong(thang);
            if (nv.Count == 0)
                return ketQua;
            int minNgay = TimSoNgayLamViecItNhat(nv);
            foreach (NhanVienHopDong item in nv)
            {
                if (item.SoNgayLamViec == minNgay)
                {
                    ketQua.Add(item);
                }
            }
            return ketQua;
        }
    }
}
