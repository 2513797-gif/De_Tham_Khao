using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_02
{
    internal interface INhanVien
    {
        public int NhanVienID { get; set; }
        public string Phong { get; set; }
        public string ThongTinChiTiet();
        public string ToString()
        {
            return "";
        }
    }
}
