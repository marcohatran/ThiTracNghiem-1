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
    public static class GiangVien
    {
        public static int CountGV()
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountGV));
            if (myReader == null) return 0;
            myReader.Read();
            int dem = myReader.GetInt32(0);
            myReader.Close();
            return dem;
        }
        public static string TaoMaGV()
        {
            int demGV = CountGV();
            if (demGV == 0)
            {
                return "GV01";
            }
            else
            {
                if (demGV < 10)
                {
                    return ("GV0" + (demGV + 1).ToString()).Trim();
                }
                return ("GV" + (demGV + 1).ToString()).Trim();
            }
        }
        public static GIANGVIEN GetGiangVienByMa(string maGV)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetGiangVienByMa, maGV.Trim()));
            if (myReader == null) return null;
            myReader.Read();
            GIANGVIEN gv = new GIANGVIEN
            {
                MAGV = myReader.GetString(0),
                HO = myReader.GetString(1),
                TEN = myReader.GetString(2),
                HOCVI = myReader.GetString(3),
                MAKH = myReader.GetString(4),
                EMAIL = myReader.GetString(5)
            };
            myReader.Close();
            return gv;
        }
    }
}
