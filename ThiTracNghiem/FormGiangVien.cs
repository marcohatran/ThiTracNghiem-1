using System;

namespace ThiTracNghiem
{
    public partial class FormGiangVien : DevExpress.XtraEditors.XtraForm
    {
        private string MaKhoa = null;

        public FormGiangVien()
        {
            InitializeComponent();
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            kHOATableAdapter.Fill(this.dtsTTN.KHOA);
            gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            gIANGVIENTableAdapter.Fill(this.dtsTTN.GIANGVIEN);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue == null || cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            MaKhoa = cbbKhoa.SelectedValue.ToString().Trim();
            gIANGVIENBindingSource.Filter = "MAKH ='" + MaKhoa + "'";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThemGiangVien frmAddGV = new FormThemGiangVien(MaKhoa, this);
            Enabled = false;
            frmAddGV.Show();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIANGVIENBindingSource.RemoveCurrent();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            if (Program.KetNoi() == 0) return;
            gIANGVIENTableAdapter.Update(dtsTTN.GIANGVIEN);
        }

        private void FormGiangVien_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == true)
            {
                kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                kHOATableAdapter.Fill(this.dtsTTN.KHOA);
                gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                gIANGVIENTableAdapter.Fill(this.dtsTTN.GIANGVIEN);
            }
        }
    }
}