using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.COMMON
{
    public class TietBatDau
    {
        public string Ten { get; set; }
        public int TietBD { get; set; }

        public TietBatDau(string ten, int tietBD)
        {
            Ten = ten;
            TietBD = tietBD;
        }
    }
}
