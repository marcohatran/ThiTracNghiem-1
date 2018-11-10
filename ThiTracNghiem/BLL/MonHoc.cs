using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public static class MonHoc
    {
        public static string GetTenMonHocByMaMH(string maMH)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetTenMonHocByMaMH, maMH.Trim()));
            if (myReader == null) return null;
            myReader.Read();
            string tenMH = myReader.GetString(0);
            myReader.Close();
            return tenMH;
        }
    }
}
