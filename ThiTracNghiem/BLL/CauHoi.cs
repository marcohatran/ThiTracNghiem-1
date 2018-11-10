using System.Collections.Generic;
using System.Data.SqlClient;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem.BLL
{
    public static class CauHoi
    {
        public static List<LUACHON> GetLuaChonByMaCH(int maCH)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetLuaChonByMaCH));
            if (myReader == null) return null;
            List<LUACHON> lstLC = new List<LUACHON>();
            while (myReader.Read())
            {
                LUACHON lc = new LUACHON
                {
                    MALC = myReader.GetString(0),
                    MACH = myReader.GetInt32(1),
                    NOIDUNG = myReader.GetString(2)
                };
                lstLC.Add(lc);
            }
            myReader.Close();
            return lstLC;
        }
    }
}