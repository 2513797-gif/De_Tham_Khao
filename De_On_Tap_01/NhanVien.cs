using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_01
{
    internal class NhanVien : Nguoi
    {
        public decimal Luong { get; set; }
        public string MaNhanVien { get; set; }
        public string ViTri { get; set; }

        public override void HienThiThongTin()
        {
            //    Console.WriteLine($"Ma nhan vien: {MaNhanVien}");
            //    Console.WriteLine($"Vi tri: {ViTri}");
            //    Console.WriteLine($"Luong: {Luong}");
        }

    }
}
