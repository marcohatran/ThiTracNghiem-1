using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.Entity;
using System.Linq;
using System.Drawing.Drawing2D;

namespace ThiTracNghiem
{
    public partial class FormThi : DevExpress.XtraEditors.XtraForm
    {
        private GraphicsPath mousePath;
        private Timer MyTimer = new Timer();
        private int ThoiGianThi = 10;
        private int Gio = 0;
        private int Phut = 0;
        private int Giay = 60;
        private int MaBD = -1;
        private List<HoTroLayBDThi> BDThi = null;
        private List<HoTroLayBDThi> BDThiTam = null;
        private List<HoTroLayCauHoiThi> CAUHOITHI = null;
        private Random rnd = new Random();

        public FormThi(int maBD, int thoiGianThi)
        {
            ThoiGianThi = thoiGianThi;
            MaBD = maBD;
            SetThoiGian();
            InitializeComponent();
            mousePath = new GraphicsPath();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            MyTimer.Interval = (1000); // 1 mins
            MyTimer.Tick += new EventHandler(t_Tick);
            MyTimer.Start();

            if (MaBD != -1)
            {
                BDThi = BDThiTam = BoDe.LayBDThi(MaBD);
                if (BDThi == null)
                {
                    return;
                }
                CAUHOITHI = new List<HoTroLayCauHoiThi>();
                HoTroLayCauHoiThi htCHThi = null;
                Panel pnCauHoi = null;
                int i = BDThiTam.Count;
                while (BDThiTam.Count != 0)
                {
                    htCHThi = new HoTroLayCauHoiThi();
                    int r = rnd.Next(BDThiTam.Count);
                    HoTroLayBDThi ht = BDThiTam[r];
                    CAUHOI cauHoi = CauHoi.GetCauHoiByMaCH(ht.MaCauHoi);
                    List<LUACHON> luachon = CauHoi.GetLuaChonByMaCH(ht.MaCauHoi);

                    pnCauHoi = new Panel();
                    pnCauHoi.AutoSize = true;
                    pnCauHoi.Dock = DockStyle.Top;

                    Label lb = new Label();
                    lb.AutoSize = true;
                    FontStyle newFontStyle = (FontStyle)(FontStyle.Bold);
                    lb.Font = new Font("Times New Rowman", 25, newFontStyle);
                    lb.Text = "Câu " + i + " : " + cauHoi.NOIDUNG;

                    RadioButton rGLuaChon = null;

                    foreach (LUACHON lc in luachon)
                    {
                        rGLuaChon = new RadioButton();
                        rGLuaChon.AutoSize = true;
                        rGLuaChon.Name = lc.MALC.Trim() + "-" + cauHoi.MACH.ToString().Trim();
                        rGLuaChon.Font = new Font("Times New Rowman", 25, newFontStyle);
                        // update dap an neu thay doi lua chon
                        rGLuaChon.CheckedChanged += new EventHandler(LuaChon_Click);
                        //rGLuaChon.Add(new RadioGroupItem(lc.MALC.ToString(), "Câu " + lc.MALC.ToString() + " : " + lc.NOIDUNG));
                        rGLuaChon.Text = "Câu " + lc.MALC.ToString() + " : " + lc.NOIDUNG;
                        rGLuaChon.Dock = DockStyle.Bottom;
                        rGLuaChon.Focus();
                        pnCauHoi.Controls.Add(rGLuaChon);
                    }

                    lb.Dock = DockStyle.Top;
                    pnCauHoi.Controls.Add(lb);
                    pnThi.Controls.Add(pnCauHoi);

                    htCHThi.MaCH = cauHoi.MACH;
                    htCHThi.STT = ht.SoTT;
                    htCHThi.DapAn = cauHoi.DAPAN;
                    htCHThi.STTKhiThi = i - 1;

                    CAUHOITHI.Add(htCHThi);
                    BDThiTam.RemoveAt(r);
                    i--;
                }

            }
            pnThi.AllowDrop = true;
            pnThi.AutoScroll = true;
        }

        public void SetThoiGian()
        {
            if (ThoiGianThi > 60)
            {
                Gio = ThoiGianThi / 60;
                int phutConLai = ThoiGianThi - Gio * 60;
                if (phutConLai > 0)
                {
                    // vì đã cho giay = 60 nen tru 1 phut
                    Phut = phutConLai - 1;
                }
            }
            else
            {
                Phut = ThoiGianThi - 1;
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            bool flag = false;

            if (Giay > 0)
            {
                Giay--;
                flag = true;
            }
            else if (Phut > 0)
            {
                Phut--;
                Giay = 59;
                flag = true;
            }
            else if (Gio > 0)
            {
                Gio--;
                Phut = 59;
                Giay = 59;
                flag = true;
            }
            else
            {
                if (Phut == 0 && Giay == 0)
                {
                    MyTimer.Stop();
                    MessageBox.Show("Het thoi gian lam bai.", "Thông báo !");
                    this.Close();
                }
            }
            if (flag)
            {
                //update label
                this.lbGio.Text = Gio.ToString();
                this.lbPhut.Text = Phut.ToString();
                this.lbGiay.Text = Giay.ToString();
                this.lbGio.Refresh();
                this.lbPhut.Refresh();
                this.lbGiay.Refresh();
                this.lbGio.Update();
                this.lbPhut.Update();
                this.lbGiay.Update();
            }
        }

        private void LuaChon_Click(object sender, EventArgs e)
        {
            RadioButton rGLuaChon = (RadioButton)sender;
            if (rGLuaChon.Checked == true)
            {
                rGLuaChon.BackColor = Color.YellowGreen;
            }
            else
            {
                rGLuaChon.BackColor = Color.White;
            }

            if (rGLuaChon == null && CAUHOITHI == null)
            {
                return;
            }
            string luaChon = rGLuaChon.Name.Trim().Split('-')[0];
            int maCH = Int32.Parse(rGLuaChon.Name.Trim().Split('-')[1]);
            HoTroLayCauHoiThi ht = CAUHOITHI.Where(x => x.MaCH == maCH).FirstOrDefault();
            if (ht != null)
            {
                ht.LuaChon = luaChon;
            }
            CAUHOITHI.Where(x => x.MaCH == maCH).FirstOrDefault().LuaChon = ht.LuaChon;
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            int soCauDung;
            float diem = ChamDiem(out soCauDung);
            if (MessageBox.Show("Bạn đúng " + soCauDung + " câu và được " + diem + " điểm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                XemLaiBaiThi();
            }
            Close();
        }

        public float ChamDiem(out int soCauDung)
        {
            soCauDung = 0;
            float diem = 0;
            if (CAUHOITHI == null)
            {
                MessageBox.Show("Đã có lỗi trong quá trình thi vui lòng kiểm tra kết nối!");
                return diem;
            }
            for (int i = 0; i < CAUHOITHI.Count; i++)
            {
                HoTroLayCauHoiThi ht = CAUHOITHI[i];
                if (!string.IsNullOrEmpty(ht.LuaChon))
                {
                    if (ht.LuaChon.Trim() == ht.DapAn.Trim())
                    {
                        soCauDung++;
                    }
                }
            }
            if (soCauDung != 0)
            {
                diem = (10 / CAUHOITHI.Count) * soCauDung;
            }
            return diem;
        }

        public void XemLaiBaiThi()
        {

        }
    }
}