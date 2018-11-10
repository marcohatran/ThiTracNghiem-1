using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;

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
            if(demGV == 0)
            {
                return "GV01";
            }
            else
            {
                if (demGV < 10)
                {
                    return ("GV0" + (demGV+1).ToString()).Trim();
                }
                return ("GV" + (demGV + 1).ToString()).Trim();
            }
        }
    }
}
