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
        bool flag = false;
        public FormMonHoc()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsTTN.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dtsTTN.KHOA);
            dtsTTN.EnforceConstraints = false;
            cAUHOITableAdapter.Fill(this.dtsTTN.CAUHOI);
            mONHOCTableAdapter.Fill(this.dtsTTN.MONHOC);
            lUACHONTableAdapter.Fill(this.dtsTTN.LUACHON);
            flag = true;
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
        public void MenuStripForListCauHoi_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            switch (menuItem.Name)
            {
                case KeyConst.MenuStripItemValue.THEM:
                    {
                        try
                        {
                            if (!KiemTraQuyenTaoCauHoi())
                            {
                                MessageBox.Show("Xin lỗi bạn không có giảng dạy môn này ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        FormThemCauHoi frmThemCH = new FormThemCauHoi(((DataRowView)mONHOCBindingSource.Current)[0].ToString().Trim(), Program.username, this);
                        Enabled = false;
                        frmThemCH.Show();
                        break;
                    }
                case KeyConst.MenuStripItemValue.LUU:
                    {
                        if (MessageBox.Show("Bạn có chắc chắn lưu lại dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                cAUHOIBindingSource.EndEdit();
                                cAUHOIBindingSource.ResetCurrentItem();
                                cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                                cAUHOITableAdapter.Update(dtsTTN.CAUHOI);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Không xóa được câu hỏi ? " + ex.Message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                ReLoadData();
                                return;
                            }
                        }
                        break;
                    }
                case KeyConst.MenuStripItemValue.XOA:
                    {
                        rtbNoiDungCH.Text = string.Empty;
                        pnLuaChon.Controls.Clear();
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

        public bool KiemTraQuyenTaoCauHoi()
        {
            string maMH = ((DataRowView)mONHOCBindingSource.Current)[0].ToString();
            return GiangDay.KiemTraQuyenTaoCauHoi(Program.username, maMH);
        }

        private void gvCauHoi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            pnLuaChon.Controls.Clear();
            if (flag)
            {   
                rtbNoiDungCH.Text = string.Empty;
                int maCH = Int32.Parse(((DataRowView)cAUHOIBindingSource.Current)[0].ToString().Trim());
                if (maCH == 0) return;

                CAUHOI chRow = CauHoi.GetCauHoiByMaCH(maCH);
                List<LUACHON> lstLC = CauHoi.GetLuaChonByMaCH(maCH);

                rtbNoiDungCH.AppendText(chRow.NOIDUNG);
                lstLC.OrderBy(x => x.MALC);
                foreach (LUACHON lc in lstLC)
                {           
                    RichTextBox rtb = new RichTextBox();  

                    rtb.Multiline = true;
                    rtb.Text = "Câu " + lc.MALC +" : " +lc.NOIDUNG;
                    rtb.Dock = DockStyle.Top;   
                    if (chRow.DAPAN.Equals(lc.MALC))
                    {
                        rtb.BackColor = Color.Green;
                    }                          

                    pnLuaChon.Controls.Add(rtb);
                    pnLuaChon.AutoScroll = true;
                    pnLuaChon.FireScrollEventOnMouseWheel = true;
                }
            }
        }
    }
}