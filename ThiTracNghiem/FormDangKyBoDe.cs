using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.COMMON;
using ThiTracNghiem.Entity;

namespace ThiTracNghiem
{
    public partial class FormDangKyBoDe : DevExpress.XtraEditors.XtraForm
    {
        private DateTime NgayThi = DateTime.UtcNow;
        private int ThoiGianThi = 0;
        private bool flagChangeNgay = false;
        private string MaMH = null;  
        private string MaTD = null;
        private int TietBD = 0;
        private string MaKhoa = null;
        public FormDangKyBoDe()
        {
            InitializeComponent();
            if (Program.mGroup == "PHONGGIAOVU")
            {
                cbbCoSo.Enabled = true;
                cbbCoSo.DataSource = Program.bds_dspm;
                cbbCoSo.DisplayMember = "TENCS";
                cbbCoSo.ValueMember = "TENSERVER";
            }
            else
            {
                cbbCoSo.Enabled = false;
            }
        }

        public void ReloadData()
        {
            NgayThi = DateTime.UtcNow;
            ThoiGianThi = 0;
            flagChangeNgay = false;
            MaMH = null; 
            MaTD = null;
            TietBD = 0;
            txtSoCauThi.Text = string.Empty;
            txtThoiGianThi.Text = string.Empty;
        }
        public bool CheckData()
        {
            if (NgayThi < DateTime.UtcNow)
            {
                MessageBox.Show("Ngày thi không hợp lệ!", "", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(MaMH))
            {
                MessageBox.Show("Vui lòng chọn lại môn học!", "", MessageBoxButtons.OK);
                return false;
            }
            if(TietBD<1 || TietBD > 7)
            {
                MessageBox.Show("Tiết bắt đầu thi không hợp lệ!", "", MessageBoxButtons.OK);
                return false;
            }
            if(ThoiGianThi <KeyConst.THOIGIANTHITOITHIEU || ThoiGianThi > KeyConst.THOIGIANTHITOIDA)
            {
                MessageBox.Show("Thời gian thi không hợp lệ!", "", MessageBoxButtons.OK);
                return false;
            }
            if(txtSoCauThi.Value <0 || txtSoCauThi.Value > 200)
            {
                MessageBox.Show("Số câu hỏi cho một đề thi không hợp lệ!", "", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(MaKhoa))
            {
                MessageBox.Show("Không xác định được khoa phụ trách môn học!", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }  
        private void FormDangKyBoDe_Load(object sender, EventArgs e)
        {
            dtsTTN.EnforceConstraints = false;
            lOPTableAdapter.Fill(dtsTTN.LOP);
            dANGKIBODETableAdapter.Fill(dtsTTN.DANGKIBODE);
            mONHOCTableAdapter.Fill(dtsTTN.MONHOC);
            txtMaBD.Text = BoDe.TaoMaBD();
            txtMaGV.Text = Program.username;
            txtNgayDangKy.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");

            cbbCoSo.SelectedIndex = 1;
            cbbCoSo.SelectedIndex = 0;

            List<TietBatDau> lstTBD = new List<TietBatDau>();
            for (int i = 0; i < KeyConst.TIETBD.Length; i++)
            {
                TietBatDau tbd = new TietBatDau("Tiết " + (i + 1).ToString(), i+1);
                lstTBD.Add(tbd);
            }
            cbbTietBD.DataSource = lstTBD;
            cbbTietBD.DisplayMember = "Ten";
            cbbTietBD.ValueMember = "TietBD";
        }

        private void cbbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadData();
            if (cbbCoSo.SelectedValue == null ||
                cbbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (cbbCoSo.SelectedValue.ToString().Trim() != Program.servername)
            {
                Program.servername = cbbCoSo.SelectedValue.ToString().Trim();
                if (cbbCoSo.SelectedIndex == 0)
                {
                    Program.maCS = KeyConst.MaCoSo.HANOI;
                }
                else
                {
                    Program.maCS = KeyConst.MaCoSo.HCM;
                }
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
                return;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                lOPTableAdapter.Fill(dtsTTN.LOP);
                cbbMaLop.DataSource = lOPBindingSource;
                cbbMaLop.DisplayMember = "TENLOP";
                cbbMaLop.ValueMember = "MALOP";

            }
        }

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaLop.SelectedValue == null || cbbMaLop.SelectedValue.ToString() == "System.Data.DataRowView") return;
            string maLop = cbbMaLop.SelectedValue.ToString().Trim();
            SetThongTinLop(maLop);

        }

        public void SetThongTinLop(string maLop)
        {
            lbMaLop.Text = "Mã lớp : " + maLop;
            LOP lp = Lop.GetLopByMaLop(maLop);
            if (lp != null)
            {
                MaTD = lp.TRINHDO;
                KHOA khRow = Khoa.GetKhoaByMaKhoa(lp.MAKH);
                TRINHDO tdRow = TrinhDo.GetTDByMaTD(lp.TRINHDO);
                if (khRow != null)
                {
                    MaKhoa = khRow.MAKH;
                    lbKhoa.Text = "Khoa : " + khRow.TENKH;
                }
                if (tdRow != null)
                {
                    lbTrinhDo.Text = "Trình độ : " + tdRow.TENTD;
                }
                lbTenLop.Text = "Tên lớp : " + lp.TENLOP;
                mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                dtsTTN.EnforceConstraints = false;
                mONHOCTableAdapter.Fill(dtsTTN.MONHOC);

                mONHOCBindingSource.Filter = "MAKH ='" + lp.MAKH + "'";
                cbbMonHoc.DataSource = mONHOCBindingSource;
                cbbMonHoc.DisplayMember = "TENMH";
                cbbMonHoc.ValueMember = "MAMH";
            }
            lbSLSV.Text = "Số lượng sinh viên : " + Lop.CountSV(maLop).ToString().Trim();
        }

        private void cbbNgayThi_EditValueChanged(object sender, EventArgs e)
        {
            //if (!flagChangeNgay)
            //{
            //    flagChangeNgay = true;
            //    return;
            //}
            DateTime ngayThi = cbbNgayThi.DateTime;
            if (ngayThi <= DateTime.UtcNow)
            {
                MessageBox.Show("Ngày thi không hợp lệ, ngày thi phải lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                return;
            }
            NgayThi = ngayThi;
        }

        private void txtThoiGianThi_EditValueChanged(object sender, EventArgs e)
        {
            if (txtThoiGianThi.Value == 0) return;
            int tgThi;
            if (!Int32.TryParse(txtThoiGianThi.Value.ToString(), out tgThi))
            {
                return;
            }
            if (tgThi < KeyConst.THOIGIANTHITOITHIEU || tgThi > KeyConst.THOIGIANTHITOIDA)
            {
                MessageBox.Show("Thời gian thi không hợp lệ, thời gian thi phải lớn hơn " + KeyConst.THOIGIANTHITOITHIEU.ToString() + " phút " +
                     "và nhỏ hơn " + KeyConst.THOIGIANTHITOIDA.ToString() + " phút!"
                      , "", MessageBoxButtons.OK);
                return;
            }
            ThoiGianThi = tgThi;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            List<BODE> listBD = new List<BODE>();
            if (!CheckData()) return;

            int demCauHoi = CauHoi.CountCauHoiByMonHoc(MaMH, MaTD);
            if(demCauHoi < txtSoCauThi.Value)
            {
                MessageBox.Show("Số câu hỏi không đủ để tạo đề thi, môn học này chỉ có "+ demCauHoi +" câu hỏi!", "Thông báo", MessageBoxButtons.OK);
                return ;
            }
            List<int> lstMaCH = BoDe.LayCauHoiTaoBD(MaMH, MaKhoa, MaTD, (int)txtSoCauThi.Value);
            if(lstMaCH.Count == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tạo bộ đề thi, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            FormXemTruocBoDe frmXemTruocBD = new FormXemTruocBoDe(MaKhoa, MaTD, cbbMonHoc.Text,lstMaCH,(int)txtThoiGianThi.Value);
            frmXemTruocBD.Show();
        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMonHoc.SelectedValue == null || cbbMonHoc.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            MaMH = cbbMonHoc.SelectedValue.ToString().Trim();
        }

        private void cbbTietBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTietBD.SelectedValue == null 
                || cbbTietBD.SelectedValue.ToString() == "System.Data.DataRowView"
                || cbbTietBD.SelectedValue.ToString() == "ThiTracNghiem.COMMON.TietBatDau")
            {
                return;
            }
            TietBD = Int32.Parse(cbbTietBD.SelectedValue.ToString().Trim());
        }


    }
}