using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_03
{
    internal class KyNang
    {
        public string MSKN { get; set; }
        public string TenKN {  get; set; }
        public KyNang(string mSKN, string tenKN)
        {
            MSKN = mSKN;
            TenKN = tenKN;
        }
        public KyNang() { }
        public KyNang(string b)
        {
            string[] part = b.Split(',');
            MSKN = part[0];
            TenKN = part[1];
        }
        public string ToString()
        {
            return $"{MSKN} | {TenKN}";
        }
    }
}
