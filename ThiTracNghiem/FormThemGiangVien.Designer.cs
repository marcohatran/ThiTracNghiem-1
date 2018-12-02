namespace ThiTracNghiem
{
    partial class FormThemGiangVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label eMAILLabel;
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenLot = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHocVi = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.KHOATableAdapter();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            mAGVLabel.Location = new System.Drawing.Point(48, 104);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(229, 41);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "Mã giảng viên";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            hOLabel.Location = new System.Drawing.Point(48, 188);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(212, 41);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "Họ và tên lót";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            tENLabel.Location = new System.Drawing.Point(48, 275);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(75, 41);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "Tên";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Font = new System.Drawing.Font("Tahoma", 25F);
            hOCVILabel.Location = new System.Drawing.Point(48, 362);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(111, 41);
            hOCVILabel.TabIndex = 7;
            hOCVILabel.Text = "Học vị";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            mAKHLabel.Location = new System.Drawing.Point(48, 26);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(145, 41);
            mAKHLabel.TabIndex = 9;
            mAKHLabel.Text = "Mã khoa";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            eMAILLabel.Location = new System.Drawing.Point(48, 446);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(125, 41);
            eMAILLabel.TabIndex = 11;
            eMAILLabel.Text = "EMAIL:";
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.dtsTTN;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKIBODETableAdapter = null;
            this.tableAdapterManager.GIANGDAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(320, 110);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Properties.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(721, 46);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(320, 194);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtHoTenLot.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenLot.Size = new System.Drawing.Size(721, 46);
            this.txtHoTenLot.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(320, 281);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(721, 46);
            this.txtTen.TabIndex = 6;
            // 
            // txtHocVi
            // 
            this.txtHocVi.Location = new System.Drawing.Point(320, 368);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtHocVi.Properties.Appearance.Options.UseFont = true;
            this.txtHocVi.Size = new System.Drawing.Size(721, 46);
            this.txtHocVi.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 452);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(721, 46);
            this.txtEmail.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThem.Location = new System.Drawing.Point(408, 560);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(229, 74);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThoat.Location = new System.Drawing.Point(719, 560);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(229, 74);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dtsTTN;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.kHOABindingSource;
            this.cbbKhoa.DisplayMember = "TENKH";
            this.cbbKhoa.Font = new System.Drawing.Font("Tahoma", 25F);
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(320, 23);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(721, 48);
            this.cbbKhoa.TabIndex = 14;
            this.cbbKhoa.ValueMember = "MAKH";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.kHOAComboBox_SelectedIndexChanged);
            // 
            // FormThemGiangVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 672);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.txtHoTenLot);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(hOCVILabel);
            this.Controls.Add(this.txtHocVi);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.txtEmail);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemGiangVien";
            this.Text = "FormThemGiangVien";
            this.Load += new System.EventHandler(this.FormThemGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private DtsTTNTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.TextEdit txtHoTenLot;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHocVi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DtsTTNTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.ComboBox cbbKhoa;
    }
}