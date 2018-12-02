using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThiTracNghiem.COMMON
{
    public class KiemTraLoi
    {
        static Regex regex = null;
        public static bool KiemTraVanBanKhongSo(string data, int chieuDai)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            if(data.Length > chieuDai)
            {
                return false;
            }
            regex = new Regex(@"^(\p{L}+\s?)*$");
            return regex.IsMatch(data);
        }
    }
}
