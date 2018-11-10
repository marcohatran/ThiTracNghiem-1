namespace ThiTracNghiem
{
    partial class FormThemCauHoi
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
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label dAPANLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.cAUHOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAUHOITableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.CAUHOITableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.txtDapAn = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDA = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnListLC = new DevExpress.XtraEditors.PanelControl();
            this.tRINHDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRINHDOTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.TRINHDOTableAdapter();
            this.cbbTrinhDo = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnLstLuaChon = new DevExpress.XtraEditors.PanelControl();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            dAPANLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDapAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnListLC)).BeginInit();
            this.pnListLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnLstLuaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAUHOIBindingSource
            // 
            this.cAUHOIBindingSource.DataMember = "CAUHOI";
            this.cAUHOIBindingSource.DataSource = this.dtsTTN;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CAUHOITableAdapter = this.cAUHOITableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKIBODETableAdapter = null;
            this.tableAdapterManager.GIANGDAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = this.tRINHDOTableAdapter;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            nOIDUNGLabel.Location = new System.Drawing.Point(128, 530);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(154, 41);
            nOIDUNGLabel.TabIndex = 3;
            nOIDUNGLabel.Text = "Nội dung";
            // 
            // dAPANLabel
            // 
            dAPANLabel.AutoSize = true;
            dAPANLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            dAPANLabel.Location = new System.Drawing.Point(128, 272);
            dAPANLabel.Name = "dAPANLabel";
            dAPANLabel.Size = new System.Drawing.Size(127, 41);
            dAPANLabel.TabIndex = 5;
            dAPANLabel.Text = "Đáp án";
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(502, 271);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtDapAn.Properties.Appearance.Options.UseFont = true;
            this.txtDapAn.Size = new System.Drawing.Size(669, 46);
            this.txtDapAn.TabIndex = 6;
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            tRINHDOLabel.Location = new System.Drawing.Point(128, 357);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(144, 41);
            tRINHDOLabel.TabIndex = 7;
            tRINHDOLabel.Text = "Trình độ";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            mAMHLabel.Location = new System.Drawing.Point(128, 111);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(203, 41);
            mAMHLabel.TabIndex = 9;
            mAMHLabel.Text = "Mã môn học";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(502, 110);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtMaMH.Properties.Appearance.Options.UseFont = true;
            this.txtMaMH.Properties.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(669, 46);
            this.txtMaMH.TabIndex = 10;
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Tahoma", 25F);
            mAGVLabel.Location = new System.Drawing.Point(128, 32);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(229, 41);
            mAGVLabel.TabIndex = 11;
            mAGVLabel.Text = "Mã giảng viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(502, 31);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Properties.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(669, 46);
            this.txtMaGV.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 25F);
            label1.Location = new System.Drawing.Point(128, 445);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 41);
            label1.TabIndex = 13;
            label1.Text = "Số đáp án";
            // 
            // txtSoDA
            // 
            this.txtSoDA.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtSoDA.Location = new System.Drawing.Point(502, 444);
            this.txtSoDA.Name = "txtSoDA";
            this.txtSoDA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtSoDA.Properties.Appearance.Options.UseFont = true;
            this.txtSoDA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoDA.Properties.MaxValue = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.txtSoDA.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtSoDA.Size = new System.Drawing.Size(669, 46);
            this.txtSoDA.TabIndex = 14;
            this.txtSoDA.EditValueChanged += new System.EventHandler(this.txtSoDA_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.rtbNoiDung);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.txtTenMH);
            this.panelControl1.Controls.Add(label3);
            this.panelControl1.Controls.Add(this.cbbTrinhDo);
            this.panelControl1.Controls.Add(nOIDUNGLabel);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.txtMaGV);
            this.panelControl1.Controls.Add(this.txtSoDA);
            this.panelControl1.Controls.Add(mAGVLabel);
            this.panelControl1.Controls.Add(this.txtMaMH);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(tRINHDOLabel);
            this.panelControl1.Controls.Add(dAPANLabel);
            this.panelControl1.Controls.Add(this.txtDapAn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1216, 845);
            this.panelControl1.TabIndex = 15;
            // 
            // pnListLC
            // 
            this.pnListLC.Controls.Add(this.pnLstLuaChon);
            this.pnListLC.Controls.Add(this.panelControl2);
            this.pnListLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListLC.Location = new System.Drawing.Point(1216, 0);
            this.pnListLC.Name = "pnListLC";
            this.pnListLC.Size = new System.Drawing.Size(591, 845);
            this.pnListLC.TabIndex = 16;
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
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.DataSource = this.tRINHDOBindingSource;
            this.cbbTrinhDo.DisplayMember = "TENTD";
            this.cbbTrinhDo.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(502, 362);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.Size = new System.Drawing.Size(669, 41);
            this.cbbTrinhDo.TabIndex = 14;
            this.cbbTrinhDo.ValueMember = "MATD";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(587, 75);
            this.panelControl2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.Location = new System.Drawing.Point(225, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lựa chọn";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(502, 190);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtTenMH.Properties.Appearance.Options.UseFont = true;
            this.txtTenMH.Properties.ReadOnly = true;
            this.txtTenMH.Size = new System.Drawing.Size(669, 46);
            this.txtTenMH.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 25F);
            label3.Location = new System.Drawing.Point(128, 191);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(216, 41);
            label3.TabIndex = 15;
            label3.Text = "Tên môn học";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnThoat);
            this.panelControl3.Controls.Add(this.btnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 755);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1216, 90);
            this.panelControl3.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThem.Location = new System.Drawing.Point(566, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(245, 65);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnThoat.Location = new System.Drawing.Point(894, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(245, 65);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnLstLuaChon
            // 
            this.pnLstLuaChon.AllowDrop = true;
            this.pnLstLuaChon.AllowTouchScroll = true;
            this.pnLstLuaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLstLuaChon.FireScrollEventOnMouseWheel = true;
            this.pnLstLuaChon.InvertTouchScroll = true;
            this.pnLstLuaChon.Location = new System.Drawing.Point(2, 77);
            this.pnLstLuaChon.Name = "pnLstLuaChon";
            this.pnLstLuaChon.Size = new System.Drawing.Size(587, 766);
            this.pnLstLuaChon.TabIndex = 1;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNoiDung.Location = new System.Drawing.Point(502, 532);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(669, 196);
            this.rtbNoiDung.TabIndex = 18;
            this.rtbNoiDung.Text = "";
            // 
            // FormThemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 845);
            this.Controls.Add(this.pnListLC);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemCauHoi";
            this.Text = "FormThemCauHoi";
            this.Load += new System.EventHandler(this.FormThemCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDapAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnListLC)).EndInit();
            this.pnListLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnLstLuaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource cAUHOIBindingSource;
        private DtsTTNTableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtDapAn;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraEditors.SpinEdit txtSoDA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pnListLC;
        private DtsTTNTableAdapters.TRINHDOTableAdapter tRINHDOTableAdapter;
        private System.Windows.Forms.BindingSource tRINHDOBindingSource;
        private System.Windows.Forms.ComboBox cbbTrinhDo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.PanelControl pnLstLuaChon;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
    }
}