using System;
using System.Collections.Generic;
using System.Text;

namespace De_Thi_1
{
    internal class DanhSachNhanVien
    {
        List<INhanVien> collection = new List<INhanVien>();

        public void NhapTuFile()
        {
            using (StreamReader sr = new StreamReader("NhanVien.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("VP"))
                    {
                        var s = new NhanVienVanPhong(line);
                        collection.Add(s);
                    }
                    else if (line.StartsWith("SX"))
                    {
                        var s = new NhanVienSanXuat(line);
                        collection.Add(s);
                    }
                }
            }
        }

        public void XuatDanhSach()
        {
            foreach(var item in collection)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            }
        }
        public void NhapThuCong()
        {
            Console.Write("Nhap so nhan vien can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap loai nhan vien (VP/SX): ");
                string loai = Console.ReadLine();
                if (loai == "VP")
                {
                    Console.Write("Nhap ho ten: ");
                    string hoTen = Console.ReadLine();
                    Console.Write("Nhap nam lam viec: ");
                    int namLamViec = int.Parse(Console.ReadLine());
                    Console.Write("Nhap muc luong: ");
                    float mucLuong = float.Parse(Console.ReadLine());
                    Console.Write("Nhap so ngay nghi: ");
                    int ngayNghi = int.Parse(Console.ReadLine());
                    var nv = new NhanVienVanPhong(hoTen, namLamViec, mucLuong, ngayNghi);
                    collection.Add(nv);
                }
                else if (loai == "SX")
                {
                    Console.Write("Nhap ho ten: ");
                    string hoTen = Console.ReadLine();
                    Console.Write("Nhap nam lam viec: ");
                    int namLamViec = int.Parse(Console.ReadLine());
                    var nv = new NhanVienSanXuat(hoTen, namLamViec);
                    collection.Add(nv);
                }
                else
                {
                    Console.WriteLine("Loai nhan vien khong hop le!");
                }
            }
        }
        // 1. Tìm nhân viên có mức lương thấp nhất (Do tính lương cần tháng nên ta truyền tham số tháng)
        public void TimNhanVienCoLuongThapNhat(int thang)
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            INhanVien nvMin = collection[0];
            float minLuong = nvMin.TinhLuongTheoThang(thang);

            foreach (var nv in collection)
            {
                float luong = nv.TinhLuongTheoThang(thang);
                // Kiểm tra xem ai có lương thấp hơn mức min hiện tại
                if (luong < minLuong)
                {
                    minLuong = luong;
                    nvMin = nv;
                }
            }
            Console.WriteLine($"=> Nhân viên có lương thấp nhất tháng {thang} là: {nvMin.HoTen} (Lương: {minLuong:N0} VNĐ)");
        }

        // 2. Tìm nhân viên nghỉ nhiều ngày nhất trong tháng x
        public void TimNhanVienNghiNhieuNhatTrongThang(int thang)
        {
            int maxNgayNghi = -1;
            NhanVienVanPhong nvMax = null;

            foreach (var nv in collection)
            {
                // Chỉ Nhân viên văn phòng mới có dữ liệu ngày nghỉ theo tháng
                if (nv is NhanVienVanPhong)
                {
                    NhanVienVanPhong nvvp = (NhanVienVanPhong)nv;
                    int ngayNghi = nvvp.LaySoNgayNghiTheoThang(thang);

                    if (ngayNghi > maxNgayNghi)
                    {
                        maxNgayNghi = ngayNghi;
                        nvMax = nvvp;
                    }
                }
            }

            if (nvMax != null && maxNgayNghi > 0)
                Console.WriteLine($"=> NV nghỉ nhiều nhất tháng {thang} là: {nvMax.HoTen} ({maxNgayNghi} ngày)");
            else
                Console.WriteLine($"=> Không có thông tin ngày nghỉ nào trong tháng {thang}.");
        }

        // 3. Tìm nhân viên văn phòng có lương cao nhất
        public void TimNhanVienVanPhongCoLuongCaoNhat(int thang)
        {
            float maxLuong = -1;
            NhanVienVanPhong nvMax = null;

            foreach (var nv in collection)
            {
                // Lọc ra nhân viên văn phòng
                if (nv is NhanVienVanPhong)
                {
                    NhanVienVanPhong nvvp = (NhanVienVanPhong)nv;
                    float luong = nvvp.TinhLuongTheoThang(thang);

                    if (luong > maxLuong)
                    {
                        maxLuong = luong;
                        nvMax = nvvp;
                    }
                }
            }

            if (nvMax != null)
                Console.WriteLine($"=> NV Văn phòng có lương cao nhất tháng {thang}: {nvMax.HoTen} (Lương: {maxLuong:N0} VNĐ)");
            else
                Console.WriteLine("=> Không có nhân viên văn phòng nào trong danh sách.");
        }

        // 4. Tính tổng ngày nghỉ của tất cả nhân viên trong tháng 5
        public void TinhTongNgayNghiThang5()
        {
            int tongNgayNghi = 0;
            foreach (var nv in collection)
            {
                // Chỉ cộng dồn ngày nghỉ của các NV Văn phòng
                if (nv is NhanVienVanPhong)
                {
                    NhanVienVanPhong nvvp = (NhanVienVanPhong)nv;
                    tongNgayNghi += nvvp.LaySoNgayNghiTheoThang(5);
                }
            }
            Console.WriteLine($"=> Tổng số ngày nghỉ của tất cả nhân viên trong tháng 5 là: {tongNgayNghi} ngày.");
        }

        // 5. Tìm tất cả nhân viên sản xuất có thâm niên làm việc là 2 năm
        public void TimNVSanXuatThamNien2Nam()
        {
            int namHienTai = DateTime.Now.Year;
            bool timThay = false;

            Console.WriteLine("--- DANH SÁCH NV SẢN XUẤT CÓ THÂM NIÊN 2 NĂM ---");
            foreach (var nv in collection)
            {
                if (nv is NhanVienSanXuat)
                {
                    // Thâm niên = Năm hiện tại - Năm bắt đầu làm việc
                    int thamNien = namHienTai - nv.NamLamViec;
                    if (thamNien == 2)
                    {
                        Console.WriteLine($"- {nv.HoTen} (Năm vào làm: {nv.NamLamViec})");
                        timThay = true;
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine("=> Không tìm thấy nhân viên sản xuất nào có thâm niên đúng 2 năm.");
            }
        }
    }
}
