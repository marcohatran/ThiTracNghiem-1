using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.BLL;

namespace ThiTracNghiem
{
    public partial class FormQuanLy : DevExpress.XtraEditors.XtraForm
    {
        string MACS = null;
        #region contructor
        public FormQuanLy()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            gv_DSKhoa.MouseEnter += gv_DSKhoa_RowCellClick;
            CreateContextMenu();
            setQuyen();
        }
        #endregion
        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            v_DSPHANMANHTableAdapter.Fill(tRACNGHIEMDataSet.V_DSPHANMANH);
            kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            kHOATableAdapter.Fill(dtsTTN.KHOA);
            lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            lOPTableAdapter.Fill(dtsTTN.LOP);
            sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            sINHVIENTableAdapter.Fill(dtsTTN.SINHVIEN);
        }

        public void setQuyen()
        {
            switch (Program.mGroup)
            {
                case KeyConst.Role.GIANGVIEN:
                    cbbCoSo.Enabled = false;
                    break;
                case KeyConst.Role.SINHVIEN:
                    cbbCoSo.Enabled = false;
                    break;
                case KeyConst.Role.KHOA:
                    cbbCoSo.Enabled = false;
                    break;
                case KeyConst.Role.PHONGGIAOVU:
                    break;
            }
        }

        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = null;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        menuItem = new ToolStripMenuItem("Thêm khoa mới");
                        menuItem.Name = "mntThemKhoa";
                        break;
                    case 1:
                        menuItem = new ToolStripMenuItem("Xóa khoa");
                        menuItem.Name = "mntXoaKhoa";
                        break;
                    case 2:
                        menuItem = new ToolStripMenuItem("Lưu");
                        menuItem.Name = "mntLuu";
                        break;
                }
                menuItem.Click += new EventHandler(MenuStripForListKhoa_Exit);
                menuStrip.Items.Add(menuItem);
            }
            kHOAGridControl.ContextMenuStrip = menuStrip;
        }

        #region MenuStripDSKhoa
        private void MenuStripForListKhoa_Exit(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case "mntThemKhoa":
                    {
                        kHOABindingSource.AddNew();
                        gv_DSKhoa.SetFocusedRowCellValue("MACS", MACS);
                        break;
                    }
                case "mntLuu":
                    {
                        kHOABindingSource.EndEdit();
                        kHOABindingSource.ResetCurrentItem();
                        kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        kHOATableAdapter.Update(dtsTTN.KHOA);
                        break;
                    }
                case "mntXoaKhoa":
                    {
                        kHOABindingSource.RemoveCurrent();
                        break;
                    }
            }
        }
        #endregion    

        private void gv_DSKhoa_RowCellClick(object sender, EventArgs e)
        {
            txtSoLuongGV.Text = dtsTTN.GIANGVIEN.Count.ToString();
            txtMaKhoa.Text = ((DataRowView)kHOABindingSource.Current)[0].ToString();
            txtSoLuongLop.Text = Lop.CountLopByMaKhoa(txtMaKhoa.Text.Trim()).ToString();
            txtTenKhoa.Text = ((DataRowView)kHOABindingSource.Current)[1].ToString();
            if (((DataRowView)kHOABindingSource.Current)[0].ToString() == "CS1")
            {
                txtTenCS.Text = tRACNGHIEMDataSet.V_DSPHANMANH[0].TENCS;
            }
            else
            {
                txtTenCS.Text = tRACNGHIEMDataSet.V_DSPHANMANH[1].TENCS;
            }

        }

        public void SetThongTinKhoa(string maKhoa, string TenKhoa)
        {

        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoSo.SelectedValue == null || cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cbbCoSo.SelectedValue.ToString();
            if (cbbCoSo.SelectedIndex == 0)
            {
                MACS = KeyConst.MaCoSo.HANOI;
            }
            else
            {
                MACS = KeyConst.MaCoSo.HCM;
            }
            if (cbbCoSo.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                dtsTTN.EnforceConstraints = false;
                kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                kHOATableAdapter.Fill(dtsTTN.KHOA);
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTableAdapter.Fill(dtsTTN.LOP);
                sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                sINHVIENTableAdapter.Fill(dtsTTN.SINHVIEN);
                Program.maCS = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();
            }
        }
    }
}