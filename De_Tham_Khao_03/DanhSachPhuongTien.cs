using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace De_Tham_Khao_03
{
    internal class DanhSachPhuongTien
    {
        List<IPhuongTien> collection = new List<IPhuongTien>();

        public void NhapTuFile()
        {
            StreamReader sr = new StreamReader("PhuongTien.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if(line.StartsWith("TauNgam"))
                {
                    var s = new TauNgam(line);
                    collection.Add(s);
                }
                else if(line.StartsWith("ThuyPhiCo"))
                {
                    var s = new ThuyPhiCo(line);
                    collection.Add(s);
                }   
                else if(line.StartsWith("Thuyen"))
                {
                    var s = new Thuyen(line);
                    collection.Add(s);
                }
                else if(line.StartsWith("Xe"))
                {
                    var s = new XeHoi(line);
                    collection.Add(s);
                } 
                    
            }    
        }
        public void XuatDanhSach()
        {
            foreach(var item in collection)
            {
                Console.WriteLine(item.HienThiThongTin());
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
