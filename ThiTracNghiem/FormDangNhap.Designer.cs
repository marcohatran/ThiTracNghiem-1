namespace ThiTracNghiem
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rgbUser = new DevExpress.XtraEditors.RadioGroup();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.cbbDanhSachPhanManh = new System.Windows.Forms.ComboBox();
            this.v_DSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet = new ThiTracNghiem.TRACNGHIEMDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbTDN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.v_DSPHANMANHTableAdapter = new ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.V_DSPHANMANHTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager1 = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 211);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtMK);
            this.panel3.Controls.Add(this.txtTenDN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rgbUser);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnDN);
            this.panel3.Controls.Add(this.cbbDanhSachPhanManh);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbMK);
            this.panel3.Controls.Add(this.lbTDN);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 517);
            this.panel3.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.EditValue = "123";
            this.txtMK.Location = new System.Drawing.Point(324, 368);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMK.Properties.Appearance.Options.UseFont = true;
            this.txtMK.Properties.PasswordChar = '*';
            this.txtMK.Properties.UseSystemPasswordChar = true;
            this.txtMK.Size = new System.Drawing.Size(592, 30);
            this.txtMK.TabIndex = 14;
            // 
            // txtTenDN
            // 
            this.txtTenDN.EditValue = "N14CDCN01 ";
            this.txtTenDN.Location = new System.Drawing.Point(324, 306);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTenDN.Properties.Appearance.Options.UseFont = true;
            this.txtTenDN.Size = new System.Drawing.Size(592, 30);
            this.txtTenDN.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "SINH VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "GIẢNG VIÊN";
            // 
            // rgbUser
            // 
            this.rgbUser.Location = new System.Drawing.Point(324, 102);
            this.rgbUser.Name = "rgbUser";
            this.rgbUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rgbUser.Properties.Appearance.Options.UseBackColor = true;
            this.rgbUser.Properties.Columns = 2;
            this.rgbUser.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbUser.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("GIANGVIEN", "GIẢNG VIÊN", true, "Giảng viên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SINHVIEN", "SINH VIÊN", true, "Sinh viên")});
            this.rgbUser.Size = new System.Drawing.Size(592, 105);
            this.rgbUser.TabIndex = 10;
            this.rgbUser.SelectedIndexChanged += new System.EventHandler(this.rgbUser_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(693, 441);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(165, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(417, 441);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(165, 50);
            this.btnDN.TabIndex = 8;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // cbbDanhSachPhanManh
            // 
            this.cbbDanhSachPhanManh.DataSource = this.v_DSPHANMANHBindingSource;
            this.cbbDanhSachPhanManh.DisplayMember = "TENCS";
            this.cbbDanhSachPhanManh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhSachPhanManh.FormattingEnabled = true;
            this.cbbDanhSachPhanManh.Location = new System.Drawing.Point(324, 243);
            this.cbbDanhSachPhanManh.Name = "cbbDanhSachPhanManh";
            this.cbbDanhSachPhanManh.Size = new System.Drawing.Size(592, 34);
            this.cbbDanhSachPhanManh.TabIndex = 7;
            this.cbbDanhSachPhanManh.ValueMember = "TENSERVER";
            // 
            // v_DSPHANMANHBindingSource
            // 
            this.v_DSPHANMANHBindingSource.DataMember = "V_DSPHANMANH";
            this.v_DSPHANMANHBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(85, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cơ sở ";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbMK.ForeColor = System.Drawing.Color.Red;
            this.lbMK.Location = new System.Drawing.Point(85, 367);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(112, 29);
            this.lbMK.TabIndex = 3;
            this.lbMK.Text = "Mật khẩu";
            // 
            // lbTDN
            // 
            this.lbTDN.AutoSize = true;
            this.lbTDN.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbTDN.ForeColor = System.Drawing.Color.Red;
            this.lbTDN.Location = new System.Drawing.Point(85, 305);
            this.lbTDN.Name = "lbTDN";
            this.lbTDN.Size = new System.Drawing.Size(174, 29);
            this.lbTDN.TabIndex = 2;
            this.lbTDN.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(217, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập hệ thống thi trắc nghiệm";
            // 
            // v_DSPHANMANHTableAdapter
            // 
            this.v_DSPHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dtsTTN;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.CAUHOITableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.CT_BAITHITableAdapter = null;
            this.tableAdapterManager1.DANGKIBODETableAdapter = null;
            this.tableAdapterManager1.GIANGDAYTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.LUACHONTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager1.TRINHDOTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbTDN;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource v_DSPHANMANHBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DSPHANMANHTableAdapter v_DSPHANMANHTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.ComboBox cbbDanhSachPhanManh;
        private DevExpress.XtraEditors.RadioGroup rgbUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DtsTTNTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}