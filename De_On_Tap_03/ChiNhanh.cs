using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_03
{
    internal class ChiNhanh
    {
        public string MSCN {  get; set; }
        public string TenCN {  get; set; }
        public ChiNhanh() { }
        public ChiNhanh(string mSCN, string tenCN)
        {
            MSCN = mSCN;
            TenCN = tenCN;
        }
        public ChiNhanh(string b)
        {
            string[] part = b.Split(',');
            MSCN = part[0];
            TenCN = part[1];
        }
        public string ToString()
        {
            return $"{MSCN} | {TenCN}";
        }
    }
}
