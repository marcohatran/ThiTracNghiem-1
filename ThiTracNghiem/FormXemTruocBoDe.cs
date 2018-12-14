using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormXemTruocBoDe : Form
    {
        private string MAKHOA = null;
        private string MATRINHDO = null;
        private List<int> LISTMACH = null;
        private string TTENMH = null;
        private int THOIGIANTHI = 0;

        public FormXemTruocBoDe(string maKhoa, string maTrinhDo, string tenMH, List<int> lstMaCH, int thoiGianThi)
        {
            MAKHOA = maKhoa;
            MATRINHDO = maTrinhDo;
            LISTMACH = lstMaCH;
            TTENMH = tenMH;
            THOIGIANTHI = thoiGianThi;
            InitializeComponent();
            SetData();
        }

        public void SetData()
        {
            if (LISTMACH.Count == 0) return;
            lblTenMonHoc.Text = "XE TRƯỚC BỘ ĐỀ MÔN : " + TTENMH;
            KHOA kh = Khoa.GetKhoaByMaKhoa(MAKHOA);
            lblTenKhoa.Text = "KHOA : " + kh.TENKH;
            lblTrinhDo.Text = TrinhDo.GetTDByMaTD(MATRINHDO).TENTD;
            lblThongTinBD.Text = "Thời gian : " + THOIGIANTHI.ToString() + " phút";

            RichTextBox rtbCau = new RichTextBox();
            CAUHOI ch = null;
            List<LUACHON> lc = null;
            for (int i = 0; i < LISTMACH.Count; i++)
            {
                ch = CauHoi.GetCauHoiByMaCH(LISTMACH[i]);
                if (rtbCau.Text.Trim() == string.Empty)
                {
                    rtbCau.Text = "Câu " + (i + 1).ToString() + " : ";
                    rtbCau.AppendText(Environment.NewLine + "    " + ch.NOIDUNG);
                }
                else
                {
                    rtbCau.AppendText(Environment.NewLine + "Câu " + (i + 1).ToString() + " : " + ch.NOIDUNG);
                }
                lc = CauHoi.GetLuaChonByMaCH(LISTMACH[i]);
                for (int j = 0; j < lc.Count; j++)
                {
                    rtbCau.AppendText(Environment.NewLine + "     Câu " + KeyConst.LUACHON[j] + " : " + lc[j].NOIDUNG);
                }
            }
            rtbCau.Dock = DockStyle.Fill;
            FontStyle newFontStyle = (FontStyle)(FontStyle.Bold);
            rtbCau.Font = new Font("Times New Rowman", 25, newFontStyle);
            pnBaiThi.AutoScroll = true;
            rtbCau.SelectionStart = 0;
            pnBaiThi.Controls.Add(rtbCau);
        }
            
    }
}