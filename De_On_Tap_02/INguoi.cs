using System;
using System.Collections.Generic;
using System.Text;

namespace De_On_Tap_02
{
    internal interface INguoi
    {
        public string Ho { get; set; }
        public string Ten { get; set;}
        public string LayTenDayDu();
    }
}
