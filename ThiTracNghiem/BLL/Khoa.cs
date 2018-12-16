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
    public static class Khoa
    {
        public static KHOA GetKhoaByMaKhoa(string maKhoa)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetKhoaByMaKhoa, maKhoa.Trim()));
            if (myReader == null) return null;
            myReader.Read();
            KHOA lp = new KHOA()
            {
                MAKH = myReader.GetString(0),
                TENKH = myReader.GetString(1),
                MACS = myReader.GetString(2)
            };
            myReader.Close();
            return lp;
        }
    }
}
