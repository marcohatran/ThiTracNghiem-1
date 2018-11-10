using System;
using System.Data;
using System.Windows.Forms;
using ThiTracNghiem.BLL;

namespace ThiTracNghiem
{
    public partial class FormThemLop : Form
    {   

        public FormThemLop(string maKhoa)
        {
            InitializeComponent();   
            txtMaKhoa.Text = maKhoa;
        }

        private void FormThemLop_Load(object sender, EventArgs e)
        {
            dtsTTN.EnforceConstraints = false;
            tRINHDOTableAdapter.Fill(this.dtsTTN.TRINHDO);
            lOPTableAdapter.Fill(this.dtsTTN.LOP);
        }
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsTTN);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.frmHienTai.Enabled = true;      
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {       
            DtsTTN.LOPRow lop = dtsTTN.LOP.NewLOPRow();
            lop[0] = txtMaLop.Text;
            lop[1] = txtTenLop.Text;
            lop[2] = txtMaKhoa.Text;
            lop[3] = cbbTD.SelectedValue;
            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(lop[i].ToString().Trim()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");
                }
            }
            try
            {
                dtsTTN.LOP.AddLOPRow(lop);
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTableAdapter.Update(dtsTTN.LOP);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm lớp, vui lòng thử lại !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void cbbTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = Lop.TaoMaLop(txtMaKhoa.Text, cbbTD.SelectedValue.ToString().Trim(), dtpKhoa.Value.Year.ToString().Trim());
        }

        private void dtpKhoa_ValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Text = Lop.TaoMaLop(txtMaKhoa.Text, cbbTD.SelectedValue.ToString().Trim(), dtpKhoa.Value.Year.ToString().Trim());
        }
    }
}