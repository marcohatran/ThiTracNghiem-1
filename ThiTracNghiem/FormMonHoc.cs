using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormMonHoc : Form
    {
        string MaKhoa = null;
        public FormMonHoc()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsTTN.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dtsTTN.KHOA);
            cAUHOITableAdapter.Fill(this.dtsTTN.CAUHOI);
            mONHOCTableAdapter.Fill(this.dtsTTN.MONHOC);
            lUACHONTableAdapter.Fill(this.dtsTTN.LUACHON);
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
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemNameCauHoi.THEM);
                        menuItem.Name = KeyConst.MenuStripItemValue.THEM;
                        break;

                    case 1:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemNameCauHoi.XOA);
                        menuItem.Name = KeyConst.MenuStripItemValue.XOA;
                        break;

                    case 2:
                        menuItem = new ToolStripMenuItem(KeyConst.MenuStripItemNameCauHoi.LUU);
                        menuItem.Name = KeyConst.MenuStripItemValue.LUU;
                        break;
                }
                menuItem.Click += new EventHandler(MenuStripForListCauHoi_Event);
                menuStrip.Items.Add(menuItem);
            }
            cAUHOIGridControl.ContextMenuStrip = menuStrip;
        }
        private void gridView2_MouseEnter(object sender, EventArgs e)
        {    
            DtsTTN.CAUHOIRow chRow = (DtsTTN.CAUHOIRow)cAUHOIBindingSource.Current;
            if (chRow == null) return;
            List<LUACHON> lstLC = CauHoi.GetLuaChonByMaCH(chRow.MACH);

            rtbNoiDungCH.AppendText(chRow.NOIDUNG);
            lstLC.OrderBy(x => x.MALC);
            foreach (LUACHON lc in lstLC)
            {
                Panel pnAll = new Panel();
                Panel pnLC = new Panel();
                Panel pnNDLC = new Panel();
                Label lbTenCH = new Label();
                RichTextBox rtb = new RichTextBox();

                lbTenCH.Dock = DockStyle.Fill;
                lbTenCH.Text = "Câu " + lc.MALC;
                pnLC.Controls.Add(lbTenCH);
                pnLC.Dock = DockStyle.Left;
                pnAll.Controls.Add(pnLC);

                rtb.Multiline = true;
                rtb.Text = lc.NOIDUNG;
                rtb.Dock = DockStyle.Fill;
                pnNDLC.Controls.Add(rtb);

                if (chRow.DAPAN.Equals(lc.MALC))
                {
                    pnAll.BackColor = Color.Green;
                }
                pnAll.Controls.Add(pnNDLC);
                pnAll.Dock = DockStyle.Top;

                pnLuaChon.Controls.Add(pnAll);
            }  
        }

        public void MenuStripForListCauHoi_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case KeyConst.MenuStripItemValue.THEM:
                    {
                        FormThemCauHoi frmThemCH = new FormThemCauHoi(((DataRowView)mONHOCBindingSource.Current)[0].ToString().Trim(), Program.username, this);
                        Enabled = false;
                        frmThemCH.Show();
                        break;
                    }
                case KeyConst.MenuStripItemValue.LUU:
                    {
                        if (MessageBox.Show("Bạn có chắc chắn lưu lại dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cAUHOIBindingSource.EndEdit();
                            cAUHOIBindingSource.ResetCurrentItem();
                            cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                            cAUHOITableAdapter.Update(dtsTTN.CAUHOI);
                        }
                        break;
                    }
                case KeyConst.MenuStripItemValue.XOA:
                    {
                        cAUHOIBindingSource.RemoveCurrent();
                        break;
                    }
            }
        }

        private void FormMonHoc_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == true)
            {
                ReLoadData();
            }
        }

        public void ReLoadData()
        {
            cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            cAUHOITableAdapter.Fill(this.dtsTTN.CAUHOI);
            mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            mONHOCTableAdapter.Fill(this.dtsTTN.MONHOC);
            lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            lUACHONTableAdapter.Fill(this.dtsTTN.LUACHON);
        }

        private void kHOAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue == null || cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            MaKhoa = cbbKhoa.SelectedValue.ToString().Trim();
            mONHOCBindingSource.Filter = "MAKH ='" + MaKhoa + "'";
        }
    }
}