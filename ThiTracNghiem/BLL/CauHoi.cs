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
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetLuaChonByMaCH,maCH));
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

        public static CAUHOI GetCauHoiByMaCH(int maCH)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetCauHoiByMaCH, maCH));
            if (myReader == null) return null;
            myReader.Read();

            CAUHOI ch = new CAUHOI
            {
                MACH = myReader.GetInt32(0),
                NOIDUNG = myReader.GetString(1),
                DAPAN = myReader.GetString(2),
                TRINHDO = myReader.GetString(3),
                MAMH = myReader.GetString(4),
                MAGV = myReader.GetString(5)
            };    
            myReader.Close();
            return ch;
        }
    }
}