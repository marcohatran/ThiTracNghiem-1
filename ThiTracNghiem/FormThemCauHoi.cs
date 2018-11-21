using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        int SODA = 0;
        Form Parent = null;
        Dictionary<string, string> NoiDung = new Dictionary<string, string>();
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
            dtsTTN.EnforceConstraints = false;
            this.tRINHDOTableAdapter.Fill(this.dtsTTN.TRINHDO);
            this.cAUHOITableAdapter.Fill(this.dtsTTN.CAUHOI);
            this.lUACHONTableAdapter.Fill(this.dtsTTN.LUACHON);  
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
            SODA = soLC;
            cbbDapAn.Items.Clear();
            cbbDapAn.Enabled = true;
            for (int i = 0; i < SODA; i++)
            {
                cbbDapAn.Items.Add(KeyConst.LUACHON[i]);
            }   
            if (soLC > 28 || soLC < 0)
            {
                MessageBox.Show("Số đáp án phải nhỏ hơn 28 và lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i< soLC; i++)
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
                pnND.Name = rtbND.Name;
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
            ReLoad();
            Parent.Enabled = true;
            Parent.Focus();
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SODA == 0)
            {
                return;
            }
            
            if (rtbNoiDung.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập nội dung câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbNoiDung.Focus();
                return;
            }
            if (cbbDapAn.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đáp án của câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbDapAn.Focus();
                return;
            }
            if (SODA < 2 && SODA > 26)
            {
                MessageBox.Show("Số đáp án không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDA.Focus();
                return;
            }
            int dem = 0;
            foreach (var item in lstPanel)
            {
                foreach (var rtb in item.Controls)
                {
                    Panel pn = (Panel)rtb;
                    foreach (var it in pn.Controls)
                    {
                        if (it.GetType() == typeof(RichTextBox))
                        {
                            RichTextBox rb = (RichTextBox)it;
                            if (rb.Text.Trim() == string.Empty)
                            {
                                MessageBox.Show("Đáp án của câu " + KeyConst.LUACHON[dem] + " chưa có nội dung !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rb.Focus();
                                return;
                            }
                            NoiDung.Add(KeyConst.LUACHON[dem], rb.Text.Trim());
                            dem++;
                        }
                    }  
                }     
            }
            
            DtsTTN.CAUHOIRow cauHoiRow = dtsTTN.CAUHOI.NewCAUHOIRow();
            cauHoiRow.MAGV = txtMaGV.Text.Trim();
            cauHoiRow.MAMH = txtMaMH.Text.Trim();
            cauHoiRow.NOIDUNG = rtbNoiDung.Text.Trim();
            cauHoiRow.DAPAN = cbbDapAn.Text.Trim();
            cauHoiRow.TRINHDO = cbbTrinhDo.SelectedValue.ToString().Trim();
            dtsTTN.EnforceConstraints = false;
            dtsTTN.CAUHOI.AddCAUHOIRow(cauHoiRow);

            List<string> ndTrung = new List<string>();
            for (int i = 0; i < SODA; i++)
            {
                DtsTTN.LUACHONRow lcRow = dtsTTN.LUACHON.NewLUACHONRow();
                lcRow.MACH = cauHoiRow.MACH;
                lcRow.MALC = KeyConst.LUACHON[i];
                string nd;
                if(!NoiDung.TryGetValue(KeyConst.LUACHON[i],out nd))
                {
                    MessageBox.Show("Lỗi thêm đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReLoad();
                    return;
                }
                if (ndTrung.Contains(nd))
                {
                    MessageBox.Show("Nội dung giữa các đáp án bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NoiDung = new Dictionary<string, string>();
                    return;
                }
                ndTrung.Add(nd);
                lcRow.NOIDUNG = nd;
                dtsTTN.LUACHON.AddLUACHONRow(lcRow);
            }

            SqlTransaction st = null;
            try
            {
                if (Program.KetNoi() == 0) return;
                st = Program.conn.BeginTransaction();
                cAUHOITableAdapter.Transaction = st;
                lUACHONTableAdapter.Transaction = st;                                             
                tableAdapterManager.UpdateAll(dtsTTN);
                st.Commit();
                MessageBox.Show("Thêm câu hỏi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                ReLoad();
                Parent.Enabled = true;
                Close();
            }
            catch(Exception ex)
            {
                st.Rollback();
                MessageBox.Show("Lỗi kết nối!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReLoad();
                return;
            }   
        }
        
        public void ReLoad()
        {
            lstPanel = new List<Panel>();
            lstLC = null;        
            NoiDung = new Dictionary<string, string>();
        } 
    }
}