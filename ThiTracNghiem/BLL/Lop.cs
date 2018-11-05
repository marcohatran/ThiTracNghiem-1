using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public static class Lop
    {
        public static int CountLopByMaKhoa(string maKhoa)
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountLopByMaKhoa, maKhoa));
            if (myReader == null) return 0;
            myReader.Read();
            int countResult = myReader.GetInt32(0);
            myReader.Close();
            return countResult;
        }
    }
}
