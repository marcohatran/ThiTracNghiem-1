using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    static class Program
    {
        public static Form frmHienTai = null;
        public static BindingSource bds_dspm = new BindingSource();
        public static SqlConnection conn = new SqlConnection();
        public static string connstr;
        public static string servername = null;
        public static string username = null;
        public static string mlogin = null;
        public static string password = null;
        public static string database = "TRACNGHIEM";
        public static string remotelogin = "HTKN";
        public static string remotepassword = "123";
        public static string mGroup = null;
        public static string mHoten = null;
        public static string thongtintaikhoan = null;
        public static string tenDNSinhVien = "HTKNSINHVIEN";
        public static string passSupportSV = "123";
        public static string MaSVDN = null;
        public static int mChinhanh = 0;
        public static string tenCS = null;
        public static string maCS = null;
        public static string mloginDN = null;
        public static string passwordDN = null;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void ResetAccount()
        {
            bds_dspm = new BindingSource();
            conn = new SqlConnection();
            connstr = null;
            servername = null;
            username = null;
            mlogin = null;
            password = null;
            mGroup = null;
            mHoten = null;
            thongtintaikhoan = null;
            MaSVDN = null;
            mChinhanh = 0;
            tenCS = null;
            maCS = null;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
        }
    }
}
