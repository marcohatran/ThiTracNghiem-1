using System;
using System.Data;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class DanhSachBoDeGVDK : DevExpress.XtraEditors.XtraForm
    {
        private int MaBD = -1;
        private int ThoiGianThi = -1;

        public DanhSachBoDeGVDK()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            kHOABindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.dtsTTN);
        }

        private void DanhSachBoDeGVDK_Load(object sender, EventArgs e)
        {
            dtsTTN.EnforceConstraints = false;
            kHOATableAdapter.Fill(dtsTTN.KHOA);
            lOPTableAdapter.Fill(dtsTTN.LOP);
            dANGKIBODETableAdapter.Fill(dtsTTN.DANGKIBODE);
        }

        private void btnThiThu_Click()
        {
            if (MaBD != -1 && ThoiGianThi != -1)
            {
                FormThi frmTHi = new FormThi(MaBD, ThoiGianThi);
                frmTHi.WindowState = FormWindowState.Maximized;
                frmTHi.Show();
            }
        }

        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = null;

            menuItem = new ToolStripMenuItem("Thi thử");
            menuItem.Name = "THITHU";
            menuItem.Click += new EventHandler(MenuStripForThiThu_Event);
            menuStrip.Items.Add(menuItem);
            dANGKIBODEGridControl.ContextMenuStrip = menuStrip;
        }

        public void MenuStripForThiThu_Event(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;

            if (dANGKIBODEBindingSource.Current != null)
            {
                MaBD = Int32.Parse(((DataRowView)dANGKIBODEBindingSource.Current)[7].ToString().Trim());
                ThoiGianThi = Int32.Parse(((DataRowView)dANGKIBODEBindingSource.Current)[5].ToString().Trim());
                btnThiThu_Click();
            }
        }
    }
}