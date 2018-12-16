using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public class ChiTietBaiThi
    {
        public static int TaoMaBaiThi()
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(KeyConst.Lenh.TaoMaBaiThi);
            if (myReader == null) return 0;
            myReader.Read();
            int dem = myReader.GetInt32(0);
            myReader.Close();
            return dem+1;
        }
    }
}
