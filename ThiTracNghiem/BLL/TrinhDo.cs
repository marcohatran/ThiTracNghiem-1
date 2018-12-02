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
    public static class TrinhDo
    {
        public static List<TRINHDO> GetAllTrinhDo()
        {
            if (Program.KetNoi() == 0) return null  ;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(KeyConst.Lenh.GetAllTrinhDo);
            if (myReader == null) return null;
            List<TRINHDO> lstTrinhDo = new List<TRINHDO>();
            while (myReader.Read())
            {
                TRINHDO td = new TRINHDO()
                {
                    MATD = myReader.GetString(0),
                    TENTD = myReader.GetString(1)
                };
                lstTrinhDo.Add(td);
            }
            myReader.Close();
            return lstTrinhDo;
        }

        public static TRINHDO GetTDByMaTD(string maTD)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetTDByMaTD,maTD));
            if (myReader == null) return null;
            TRINHDO td = null;
            while (myReader.Read())
            {
                td = new TRINHDO()
                {
                    MATD = myReader.GetString(0),
                    TENTD = myReader.GetString(1)
                };   
            }
            myReader.Close();
            return td;
        }
    }
}
