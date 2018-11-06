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
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormQuanLy : DevExpress.XtraEditors.XtraForm
    { 
        string MACS = null;
        List<TRINHDO> lstTrinhDo = null;
        #region contructor
        public FormQuanLy()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            gv_DSKhoa.MouseEnter += gv_DSKhoa_RowCellClick;
            CreateContextMenu_Khoa();
            CreateContextMenu_Lop();
            CreateContextMenu_SV();
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
        #region menutrip
        private void CreateContextMenu_Khoa()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = null;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.THEM);
                        menuItem.Name = KeyConst.MenuStripItemValue.THEM;
                        break;
                    case 1:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.XOA);
                        menuItem.Name = KeyConst.MenuStripItemValue.XOA;
                        break;
                    case 2:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.LUU);
                        menuItem.Name = KeyConst.MenuStripItemValue.LUU;
                        break;
                }
                menuItem.Click += new EventHandler(MenuStripForListKhoa_Event);
                menuStrip.Items.Add(menuItem);
            }
            kHOAGridControl.ContextMenuStrip = menuStrip;
        }
        private void CreateContextMenu_Lop()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = null;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.THEM);
                        menuItem.Name = KeyConst.MenuStripItemValue.THEM;
                        break;
                    case 1:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.XOA);
                        menuItem.Name = KeyConst.MenuStripItemValue.XOA;
                        break;
                    case 2:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.LUU);
                        menuItem.Name = KeyConst.MenuStripItemValue.LUU;
                        break;
                }
                menuItem.Click += new EventHandler(MenuStripForListLop_Event);
                menuStrip.Items.Add(menuItem);
            }
            lOPGridControl.ContextMenuStrip = menuStrip;
        }
        private void CreateContextMenu_SV()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = null;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.THEM);
                        menuItem.Name = KeyConst.MenuStripItemValue.THEM;
                        break;
                    case 1:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.XOA);
                        menuItem.Name = KeyConst.MenuStripItemValue.XOA;
                        break;
                    case 2:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemName.LUU);
                        menuItem.Name = KeyConst.MenuStripItemValue.LUU;
                        break;
                }
                menuItem.Click += new EventHandler(MenuStripForListSV_Event);
                menuStrip.Items.Add(menuItem);
            }
            sINHVIENGridControl.ContextMenuStrip = menuStrip;
        }
        #endregion

        #region MenuStripEvent
        private void MenuStripForListKhoa_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case KeyConst.MenuStripItemValue.THEM:
                    {
                        kHOABindingSource.AddNew();
                        gv_DSKhoa.SetFocusedRowCellValue("MACS", MACS);   
                        break;
                    }
                case KeyConst.MenuStripItemValue.LUU:
                    { 
                        if(MessageBox.Show("Bạn có chắc chắn lưu lại dữ liệu ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            kHOABindingSource.EndEdit();
                            kHOABindingSource.ResetCurrentItem();
                            kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                            kHOATableAdapter.Update(dtsTTN.KHOA);
                        }  
                        break;
                    }
                case KeyConst.MenuStripItemValue.XOA:
                    {
                        kHOABindingSource.RemoveCurrent();
                        break;
                    }
            }
        }
        private void MenuStripForListLop_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case KeyConst.MenuStripItemValue.THEM:
                    {
                        lOPBindingSource.AddNew(); 
                        gv_DS_Lop.SetFocusedRowCellValue("MAKH", ((DataRowView)kHOABindingSource.Current)["MAKH"].ToString());
                        System.Windows.Forms.ComboBox cbbTrinhDo = new System.Windows.Forms.ComboBox();
                        cbbTrinhDo.DataSource = TrinhDo.GetAllTrinhDo();
                        cbbTrinhDo.DisplayMember = "TENTD";
                        cbbTrinhDo.ValueMember = "MATD";
                        lOPGridControl.Controls.Add(cbbTrinhDo);       
                        break;
                    }
                case KeyConst.MenuStripItemValue.LUU:
                    {
                        if (MessageBox.Show("Bạn có chắc chắn lưu lại dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            lOPBindingSource.EndEdit();
                            lOPBindingSource.ResetCurrentItem();
                            lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                            lOPTableAdapter.Update(dtsTTN.LOP);
                        }
                        break;
                    }
                case KeyConst.MenuStripItemValue.XOA:
                    {
                        lOPBindingSource.RemoveCurrent();
                        break;
                    }
            }
        }
        private void MenuStripForListSV_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case KeyConst.MenuStripItemValue.THEM:
                    {
                        kHOABindingSource.AddNew();
                        gv_DSKhoa.SetFocusedRowCellValue("MACS", MACS);
                        break;
                    }
                case KeyConst.MenuStripItemValue.LUU:
                    {
                        if (MessageBox.Show("Bạn có chắc chắn lưu lại dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            kHOABindingSource.EndEdit();
                            kHOABindingSource.ResetCurrentItem();
                            kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                            kHOATableAdapter.Update(dtsTTN.KHOA);
                        }
                        break;
                    }
                case KeyConst.MenuStripItemValue.XOA:
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

        private void cbbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
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