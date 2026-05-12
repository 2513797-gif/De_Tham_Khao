using System;
using System.Collections.Generic;
using System.Text;

namespace De_Thi_1
{
    internal interface INhanVien
    {
        public string HoTen { get; set; }
        public int NamLamViec { get; set; }

        public virtual float TinhLuongTheoThang(int n)
        {
            return 0;
        }
        public virtual string ToString()
        {
            return "";
        }
    }
}
