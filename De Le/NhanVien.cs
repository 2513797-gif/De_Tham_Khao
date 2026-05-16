using System;
using System.Collections.Generic;
using System.Text;

namespace De_Le
{
    internal class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgayThangnamSinh { get; set; }
        public int Thang { get; set; }
        public virtual string ToString()
        {
            return $"";
        }
    }
}
