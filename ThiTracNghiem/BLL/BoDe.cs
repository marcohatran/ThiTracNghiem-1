using System.Collections.Generic;
using System.Data.SqlClient;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem.BLL
{
    public static class BoDe
    {
        public static int CountBoDe()
        {
            if (Program.KetNoi() == 0) throw new System.Exception();
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountBoDe));
            if (myReader == null) throw new System.Exception();
            myReader.Read();
            int dem = myReader.GetInt32(0);
            myReader.Close();
            return dem;
        }

        public static int TaoMaBD()
        {
            int demBD = CountBoDe();   
            return demBD+1;  
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