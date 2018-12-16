using System.Data.SqlClient;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public class BangDiem
    {
        public static int CountBangDiemByMaBDAndMaSV(int maBD, string maSV)
        {
            if (Program.KetNoi() == 0) return 0;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(string.Format(KeyConst.Lenh.CountBangDiemByMaBDAndMaSV, maBD, maSV.Trim()));
            if (myReader == null) return 0;
            myReader.Read();
            int dem = myReader.GetInt32(0);
            myReader.Close();
            return dem;
        }
    }
}