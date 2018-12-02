using System;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem
{
    public partial class FormThemGiangVien : DevExpress.XtraEditors.XtraForm
    {
        private Form Parent = null;
        private string MaKhoa = null;

        public FormThemGiangVien(string maKhoa, Form parent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cbbKhoa.Text = MaKhoa = maKhoa;
            txtMaGV.Text = GiangVien.TaoMaGV();
            txtEmail.Text = (txtMaGV.Text.Trim() == "") ? KeyConst.EmailTag.Teacher : txtMaGV.Text.Trim() + KeyConst.EmailTag.Teacher;
            Parent = parent;
        }

        private void FormThemGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsTTN.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dtsTTN.KHOA);
            gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dtsTTN.GIANGVIEN);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Parent.Enabled = true;
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn lưu lại giảng viên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DtsTTN.GIANGVIENRow gvRow = dtsTTN.GIANGVIEN.NewGIANGVIENRow();
                gvRow.MAGV = txtMaGV.Text.Trim();
                gvRow.HO = txtHoTenLot.Text;
                gvRow.TEN = txtTen.Text;
                gvRow.EMAIL = txtEmail.Text;
                gvRow.HOCVI = txtHocVi.Text;
                gvRow.MAKH = MaKhoa;
                try
                {
                    dtsTTN.GIANGVIEN.AddGIANGVIENRow(gvRow);
                    gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    gIANGVIENTableAdapter.Update(dtsTTN.GIANGVIEN);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Parent.Enabled = true;
                    Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi ! Không thể thêm giảng viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void kHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue != null)
            {
                string maKhoa = cbbKhoa.SelectedValue.ToString().Trim();
            }
        }
    }
}