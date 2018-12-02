using System;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;

namespace ThiTracNghiem
{
    public partial class FromThemSinhVien : Form
    {
        private bool FlagThem = false;
        private bool FlagChangeNgaySinh = false;
        public FromThemSinhVien(string maLop)
        {
            InitializeComponent();
            txtMaLop.Text = maLop;
            txtMaSV.Text = SinhVien.TaoMaSV(maLop);
            txtEmail.Text = (txtMaSV.Text.Trim() == "") ? KeyConst.EmailTag.Student : txtMaSV.Text.Trim() + KeyConst.EmailTag.Student;
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsTTN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.frmHienTai.Enabled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FlagThem)
            {
                DtsTTN.SINHVIENRow svRow = dtsTTN.SINHVIEN.NewSINHVIENRow();
                svRow.MALOP = txtMaLop.Text.Trim();
                svRow.MASV = txtMaSV.Text;
                svRow.HO = txtHo.Text;
                svRow.TEN = txtTen.Text;
                svRow.PHAI = cePhai.Checked;
                svRow.NGAYSINH = dtpkNgaySinh.Value;
                svRow.EMAIL = txtEmail.Text;
                svRow.DCHI = txtDiaChi.Text;
                try
                {
                    dtsTTN.EnforceConstraints = false;
                    dtsTTN.SINHVIEN.AddSINHVIENRow(svRow);
                    sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    sINHVIENTableAdapter.Update(dtsTTN.SINHVIEN);
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm sinh viên, vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program.frmHienTai.Enabled = true;
                Close();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHo.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập họ và tên lót cho sinh viên ");
                return;
            }
            if (string.IsNullOrEmpty(txtTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên ");
                return;
            }
            if (dtpkNgaySinh.Value.Year > (DateTime.UtcNow.Year - 18))
            {
                MessageBox.Show("Ngày sinh của sinh viên không hợp lệ");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập email của sinh viên ");
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của sinh viên ");
                return;
            }
            FlagThem = true;
        }

        private void dtpkNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if(!FlagChangeNgaySinh)
            {
                FlagChangeNgaySinh = true;
                return;
            }
            if(DateTime.UtcNow.Year - dtpkNgaySinh.Value.Year < 18)
            {
                MessageBox.Show("Ngày sinh của sinh viên phải đủ 18 tuổi !");
                return;
            }
        }
    }
}