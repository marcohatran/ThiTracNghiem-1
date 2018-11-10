using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using ThiTracNghiem.Entity;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private int FlagUser;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DSPHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DSPHANMANH);

            // Fix end
            cbbDanhSachPhanManh.SelectedIndex = rgbUser.SelectedIndex = 1;
            cbbDanhSachPhanManh.SelectedIndex = rgbUser.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (FlagUser == 0)
            {
                Program.mloginDN = Program.mlogin = txtTenDN.Text;
                Program.passwordDN = Program.password = txtMK.Text;
                Program.servername = cbbDanhSachPhanManh.SelectedValue.ToString();
                if (Program.mlogin.Trim() == "" || Program.password.Trim() == "")
                {
                    MessageBox.Show("vui lòng nhập đầy đủ tên đăng nhập và mật khẩu !", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Program.KetNoi() == 0) return;
                Program.mChinhanh = cbbDanhSachPhanManh.SelectedIndex;
                Program.tenCS = cbbDanhSachPhanManh.Text.ToString();
                SqlDataReader myReader;
                string strLenh = "EXEC sp_DANGNHAP '" + Program.mlogin + "'";

                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                Program.username = myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.mHoten = myReader.GetString(1);
                Program.mGroup = myReader.GetString(2);
                myReader.Close();
                Program.thongtintaikhoan = "Mã : " + Program.username + " - Họ tên : " + Program.mHoten + "  - Nhóm : " + Program.mGroup;
            }
            else
            {
                Program.mlogin = Program.tenDNSinhVien;
                Program.password = Program.passSupportSV;
                Program.servername = cbbDanhSachPhanManh.SelectedValue.ToString();
                Program.MaSVDN = txtTenDN.Text.Trim();
                if (Program.MaSVDN.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên !", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SINHVIEN sv = SinhVien.GetSinhVienByMaSV(Program.MaSVDN);
                if (sv == null)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại, Vui lòng nhập lại !",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.mHoten = sv.HO + " " + sv.TEN;
                Program.mGroup = KeyConst.Role.SINHVIEN;
                Program.thongtintaikhoan = "Mã sinh viên : " + sv.MASV + " - Họ tên : " + Program.mHoten + "  - Nhóm : " + Program.mGroup;
            }
            FormMain f = new FormMain();
            f.SetUserInfo();
            f.setQuyen(Program.mGroup);
            f.Show();
            this.SetVisibleCore(false);
        }

        private void rgbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlagUser = rgbUser.SelectedIndex;
            if (FlagUser == 1)
            {
                lbTDN.Text = "Mã sinh viên";
                lbMK.Visible = txtMK.Visible = false;
            }
            else
            {
                lbTDN.Text = "Tên đăng nhập";
                lbMK.Visible = txtMK.Visible = true;
            }
        }
    }
}