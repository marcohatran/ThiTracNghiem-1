using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem.BLL
{
    public static class GiangDay
    {
        public static bool KiemTraQuyenTaoCauHoi(string maGV, string maMH)
        {
            int result;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = KeyConst.Lenh.KiemTraQuyenTaoCauHoi;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAGV", SqlDbType.VarChar).Value = maGV.Trim();
            cmd.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = maMH.Trim();
            cmd.Parameters.Add("@VALUE", SqlDbType.Bit).Direction = ParameterDirection.Output;
            result = Program.ExecuteReader(cmd);
            int kq = Convert.ToInt32(cmd.Parameters["@VALUE"].Value);
            return (kq==1)?true : false;
        }   
    }
}
