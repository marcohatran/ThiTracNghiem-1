namespace ThiTracNghiem
{
    partial class FormThemLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label label1;
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource();
            this.lOPTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tRINHDOBindingSource = new System.Windows.Forms.BindingSource();
            this.tRINHDOTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.TRINHDOTableAdapter();
            this.cbbTD = new System.Windows.Forms.ComboBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpKhoa = new System.Windows.Forms.DateTimePicker();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dtsTTN;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = this.tRINHDOTableAdapter;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 20F);
            mALOPLabel.Location = new System.Drawing.Point(34, 90);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(94, 33);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "Mã lớp";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(25, 14);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(485, 40);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 20F);
            tENLOPLabel.Location = new System.Drawing.Point(34, 161);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(104, 33);
            tENLOPLabel.TabIndex = 3;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(25, 89);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(485, 40);
            this.txtMaLop.TabIndex = 4;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Tahoma", 20F);
            mAKHLabel.Location = new System.Drawing.Point(34, 19);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(115, 33);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "Mã khoa";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(25, 164);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Size = new System.Drawing.Size(485, 40);
            this.txtTenLop.TabIndex = 6;
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Tahoma", 20F);
            tRINHDOLabel.Location = new System.Drawing.Point(34, 232);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(115, 33);
            tRINHDOLabel.TabIndex = 7;
            tRINHDOLabel.Text = "Trình độ";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(mALOPLabel);
            this.panelControl1.Controls.Add(tRINHDOLabel);
            this.panelControl1.Controls.Add(mAKHLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(213, 511);
            this.panelControl1.TabIndex = 9;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.dtpKhoa);
            this.panelControl2.Controls.Add(this.cbbTD);
            this.panelControl2.Controls.Add(this.txtMaKhoa);
            this.panelControl2.Controls.Add(this.txtMaLop);
            this.panelControl2.Controls.Add(this.txtTenLop);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(213, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(543, 383);
            this.panelControl2.TabIndex = 10;
            // 
            // tRINHDOBindingSource
            // 
            this.tRINHDOBindingSource.DataMember = "TRINHDO";
            this.tRINHDOBindingSource.DataSource = this.dtsTTN;
            // 
            // tRINHDOTableAdapter
            // 
            this.tRINHDOTableAdapter.ClearBeforeFill = true;
            // 
            // cbbTD
            // 
            this.cbbTD.DataSource = this.tRINHDOBindingSource;
            this.cbbTD.DisplayMember = "TENTD";
            this.cbbTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTD.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cbbTD.FormattingEnabled = true;
            this.cbbTD.Location = new System.Drawing.Point(25, 239);
            this.cbbTD.Name = "cbbTD";
            this.cbbTD.Size = new System.Drawing.Size(485, 41);
            this.cbbTD.TabIndex = 8;
            this.cbbTD.ValueMember = "MATD";
            this.cbbTD.SelectedIndexChanged += new System.EventHandler(this.cbbTD_SelectedIndexChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.btnThoat);
            this.panelControl3.Controls.Add(this.btnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(213, 383);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(543, 128);
            this.panelControl3.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThem.Location = new System.Drawing.Point(44, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(169, 70);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThoat.Location = new System.Drawing.Point(311, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(169, 70);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 20F);
            label1.Location = new System.Drawing.Point(34, 303);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 33);
            label1.TabIndex = 8;
            label1.Text = "Khóa";
            // 
            // dtpKhoa
            // 
            this.dtpKhoa.CalendarFont = new System.Drawing.Font("Tahoma", 20F);
            this.dtpKhoa.Font = new System.Drawing.Font("Tahoma", 20F);
            this.dtpKhoa.Location = new System.Drawing.Point(25, 303);
            this.dtpKhoa.Name = "dtpKhoa";
            this.dtpKhoa.Size = new System.Drawing.Size(485, 40);
            this.dtpKhoa.TabIndex = 9;
            this.dtpKhoa.ValueChanged += new System.EventHandler(this.dtpKhoa_ValueChanged);
            // 
            // FormThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lớp mới";
            this.Load += new System.EventHandler(this.FormThemLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DtsTTNTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private DtsTTNTableAdapters.TRINHDOTableAdapter tRINHDOTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource tRINHDOBindingSource;
        private System.Windows.Forms.ComboBox cbbTD;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpKhoa;
    }
}