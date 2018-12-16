using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string ROLE = null;
        public FormMain()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            setQuyen(Program.mGroup);
        }

        public void SetUserInfo()
        {
            txtUserInfo.Caption = Program.thongtintaikhoan;
        }

        public void setQuyen(string role)
        {
            ROLE = role;
            if (role.Equals(KeyConst.Role.GIANGVIEN))      // GIẢNG VIÊN
            {
                rbpHeThong.Visible = btnQLGV.Enabled = btnQL_TH.Enabled = false;
            }
            else if (role.Equals(KeyConst.Role.SINHVIEN))    // SINH VIÊN
            {
                btn_DK_BD.Enabled = btnQL_TH.Enabled = btnQLSV.Enabled = btnQLLop.Enabled = btnQLKhoa.Enabled = btnQLGV.Enabled = false;
                rbpHeThong.Visible =btnPGV_TK.Enabled = btnMonHoc.Enabled = btnDanhSachBD.Enabled  = false;
            }
            else if(role.Equals(KeyConst.Role.KHOA))
            {
                rbpHeThong.Visible = false;
                btn_DK_BD.Enabled = false; 
            }  
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormQuanLy));
            if (frm != null) frm.Activate();
            else
            {
                FormQuanLy formQL = new FormQuanLy();
                ConfigForm(formQL);
                formQL.Show();
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.ResetAccount();
            this.Close();
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap formDN = new FormDangNhap();
                formDN.Show();
            }
        }

        private void btnQLGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiangVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiangVien frmGV = new FormGiangVien();
                ConfigForm(frmGV);
                frmGV.Show();
            }
        }

        public void ConfigForm(Form frm)
        {
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {    
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc frmMH = new FormMonHoc();
                ConfigForm(frmMH);               
                frmMH.Show();
            }
        }

        private void btnDanhSachBD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(DanhSachBoDeGVDK));
            if (frm != null) frm.Activate();
            else
            {
                DanhSachBoDeGVDK frmDKBDGV = new DanhSachBoDeGVDK();
                ConfigForm(frmDKBDGV);
                frmDKBDGV.Show();
            }
        }     

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangKyBoDe));
            if (frm != null) frm.Activate();
            else
            {
                FormDangKyBoDe frmDKBD = new FormDangKyBoDe();
                ConfigForm(frmDKBD);
                frmDKBD.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemLichThi));
            if (frm != null) frm.Activate();
            else
            {
                FormXemLichThi frmXemLichThi = new FormXemLichThi();
                ConfigForm(frmXemLichThi);
                frmXemLichThi.Show();
            }
        }
    }
}