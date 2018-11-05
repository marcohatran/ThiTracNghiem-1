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
    public class SinhVien
    {
        public static SINHVIEN GetSinhVienByMaSV(string maSV)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetSVByMaSV, maSV));
            if (myReader == null) return null;
            myReader.Read();
            SINHVIEN sv = new SINHVIEN()
            {
                MASV = myReader.GetString(0),
                HO = myReader.GetString(1),
                TEN = myReader.GetString(2),
                NGAYSINH = myReader.GetDateTime(3),
                DCHI = myReader.GetString(4),
                MALOP = myReader.GetString(5),
                PHAI = myReader.GetBoolean(6),
                EMAIL = myReader.GetString(7)
            };
            myReader.Close();
            return sv;
        }
    }
}
