using System.Data.SqlClient;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem.BLL
{
    public class DangKyBoDe
    {
        public static DANGKIBODE GetDKBDByMaLop_MaMonHoc(string maLop, string maMonHoc)
        {
            if (Program.KetNoi() == 0) return null;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.GetDKBDByMaLop_MaMonHoc, maLop.Trim(), maMonHoc.Trim()));
            if (myReader == null) return null;
            myReader.Read();
            DANGKIBODE dk = new DANGKIBODE
            {
                MALOP = myReader.GetString(0),
                MAMH = myReader.GetString(1),
                MAGV = myReader.GetString(2),
                NGAYTHI = myReader.GetDateTime(3),
                SOCAUHOITHI = myReader.GetInt32(4),
                THOIGIAN = myReader.GetInt32(5),
                TIETBATDAU = myReader.GetInt32(6),
                MABODE = myReader.GetInt32(7),
                NGAYDK = myReader.GetDateTime(8)
            };
            myReader.Close();
            return dk;
        }
    }
}