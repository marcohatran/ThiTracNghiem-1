using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormThemCauHoi : DevExpress.XtraEditors.XtraForm
    {
        List<Panel> lstPanel = new List<Panel>();
        List<LUACHON> lstLC = null;
        Form Parent = null;
        public FormThemCauHoi(string maMonHoc, string maGV, Form parent)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Parent = parent;
            txtMaMH.Text = maMonHoc.ToString();
            txtMaGV.Text = maGV;
            txtTenMH.Text = MonHoc.GetTenMonHocByMaMH(maMonHoc);
        }

        private void FormThemCauHoi_Load(object sender, EventArgs e)
        {
            this.tRINHDOTableAdapter.Fill(this.dtsTTN.TRINHDO);
            this.cAUHOITableAdapter.Fill(this.dtsTTN.CAUHOI);
        }


        private void txtSoDA_EditValueChanged(object sender, EventArgs e)
        {
            lstLC = new List<LUACHON>();
            for (int i = 0; i < lstPanel.Count; i++)
            {
                lstPanel[i].Dispose();
            }
            lstPanel = new List<Panel>();
            int soLC = Int32.Parse(txtSoDA.Value.ToString());
            if (soLC > 28 || soLC < 0)
            {
                MessageBox.Show("Số đáp án phải nhỏ hơn 28 và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = soLC - 1; i >= 0; i--)
            {
                LUACHON lc = new LUACHON();   
                Panel pnLC = new Panel();   

                Panel pnCau = new Panel();
                Label lbCau = new Label();
                lbCau.Text = lc.MALC = "Câu " + KeyConst.LUACHON[i];
                pnCau.Height = 15;
                lbCau.Size = pnCau.Size;
                pnCau.Controls.Add(lbCau);


                Panel pnND = new Panel();
                RichTextBox rtbND = new RichTextBox();
                rtbND.ReadOnly = false;
                rtbND.Name = KeyConst.LUACHON[i];
                rtbND.Font = new System.Drawing.Font("Time News Rowman", 20F);
                rtbND.Dock = DockStyle.Fill;
                pnND.Controls.Add(rtbND);
                pnND.Height = 150;
                pnND.Dock = DockStyle.Top;

                pnCau.Dock = DockStyle.Top;
                pnLC.Controls.Add(pnND);
                pnLC.Controls.Add(pnCau);
                          
                

                pnLC.Dock = DockStyle.Top;
                pnLstLuaChon.Controls.Add(pnLC);

                
                lstPanel.Add(pnLC);
            }
            pnLstLuaChon.AutoScroll = true;
            pnLstLuaChon.FireScrollEventOnMouseWheel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Parent.Enabled = true;
            Close();
        }
    }
}