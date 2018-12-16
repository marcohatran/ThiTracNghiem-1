using System;
using System.Data;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormXemLichThi : DevExpress.XtraEditors.XtraForm
    {
        DANGKIBODE DKBD = null;
        public FormXemLichThi()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tableAdapterManager.UpdateAll(this.dtsTTN);
        }

        private void FormXemLichThi_Load(object sender, EventArgs e)
        {
            dtsTTN.EnforceConstraints = false;
            dANGKIBODETableAdapter.Fill(this.dtsTTN.DANGKIBODE);

            if(Program.mGroup == KeyConst.Role.SINHVIEN)
            {
                for (int i = 0; i < dtsTTN.DANGKIBODE.Count; i++)
                {
                    if (BangDiem.CountBangDiemByMaBDAndMaSV(dtsTTN.DANGKIBODE[i].MABODE, Program.MaSVDN) > 0)
                    {
                        dtsTTN.DANGKIBODE.RemoveDANGKIBODERow(dtsTTN.DANGKIBODE[i]);
                    }
                }
                dANGKIBODEBindingSource.DataSource = dtsTTN.DANGKIBODE;
            }
        }

        private void dANGKIBODEGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            DKBD = DangKyBoDe.GetDKBDByMaLop_MaMonHoc(((DataRowView)dANGKIBODEBindingSource.Current)[0].ToString(),
                ((DataRowView)dANGKIBODEBindingSource.Current)[1].ToString());
            LOP lop = Lop.GetLopByMaLop(DKBD.MALOP);
            KHOA khoa = Khoa.GetKhoaByMaKhoa(lop.MAKH);
            string tenMonHoc = MonHoc.GetTenMonHocByMaMH(DKBD.MAMH);
            GIANGVIEN gv = GiangVien.GetGiangVienByMa(DKBD.MAGV);

            txtHoTenGV.Text = gv.HO + " " + gv.TEN;
            txtMAGV.Text = gv.MAGV;
            txtTenKhoa.Text = khoa.TENKH;
            txtTenMonHoc.Text = tenMonHoc;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            if(DKBD != null)
            {
                FormThi frmTHi = new FormThi(DKBD.MABODE, DKBD.THOIGIAN);
                frmTHi.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn đăng ký thi !");
            }
        }
    }
}