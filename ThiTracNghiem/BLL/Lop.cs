using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

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

        public static string TaoMaLop(string maKhoa, string maTD, string khoa)
        {
            int countLop = CountLopByMaKhoa(maKhoa);
            if(countLop == 0 )
            {
                return maTD.Substring(0, 1) + khoa.Substring(2, 2) + maTD.Substring(0,2) + maKhoa.Substring(0, 2) + "01";
            }
            return maTD.Substring(0, 1) + khoa.Substring(2, 2) + maTD.Substring(0, 2) + maKhoa.Substring(0, 2) + (countLop + 1).ToString().Trim();
        }

        public static List<LOP> GetListLopByMaKhoa(string maKhoa)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetListLopByMaKhoa, maKhoa));
            if (myReader == null) return null;
            List<LOP> lstLop = new List<LOP>();
            int dem = 0;
            while (myReader.Read())
            {
                LOP l = new LOP
                {
                  MAKH = myReader.GetString(dem),
                  MALOP = myReader.GetString(dem +1),
                  TENLOP = myReader.GetString(dem+2),
                  TRINHDO = myReader.GetString(dem+3)
                };
                lstLop.Add(l);
                dem += 1;
            }  
            myReader.Close();
            return lstLop;
        }

        public static LOP GetLopByMaLop(string maLop)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetLopByMaLop, maLop.Trim()));
            if (myReader == null) return null;
            myReader.Read();
            LOP lp = new LOP()
            {
                MALOP = myReader.GetString(0),
                TENLOP = myReader.GetString(1),
                MAKH = myReader.GetString(2),
                TRINHDO = myReader.GetString(3)

            };
            myReader.Close();
            return lp;
        }

        public static int CountSV(string maLop)
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountSV, maLop));
            if (myReader == null) return 0;
            myReader.Read();
            int countResult = myReader.GetInt32(0);
            myReader.Close();
            return countResult;
        }
    }
}
