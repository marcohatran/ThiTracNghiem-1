using System.Collections.Generic;
using System.Data.SqlClient;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public static class BoDe
    {
        public static int CountBoDe()
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountBoDe));
            if (myReader == null) return 0;
            myReader.Read();
            int dem = myReader.GetInt32(0);
            myReader.Close();
            return dem;
        }

        public static string TaoMaBD()
        {
            int demBD = CountBoDe();
            if (demBD == 0)
            {
                return "BD01";
            }
            else
            {
                if (demBD < 10)
                {
                    return ("GV0" + (demBD + 1).ToString()).Trim();
                }
                return ("GV" + (demBD + 1).ToString()).Trim();
            }
        }

        public static List<int> LayCauHoiTaoBD(string maMH, string maKhoa, string maTD, int soCauThi)
        {
            List<int> lstMaCH = new List<int>();
            if (Program.KetNoi() == 0) return lstMaCH;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.LayCauHoiTaoBD,maMH,maKhoa,maTD,soCauThi));
            if (myReader == null) return lstMaCH;
            while(myReader.Read())
            {
                int maCH = myReader.GetInt32(0);
                lstMaCH.Add(maCH);
            }  
            myReader.Close();
            return lstMaCH;
        }
    }
}