using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_01
{
    internal class Nguoi
    {
        public string DiaChi { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public virtual void HienThiThongTin()
        {
            //Console.WriteLine($"Ten: {Ten}");
            //Console.WriteLine($"Tuoi: {Tuoi}");
            //Console.WriteLine($"Dia chi: {DiaChi}");
        }
    }
}
