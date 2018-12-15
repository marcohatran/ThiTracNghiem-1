namespace ThiTracNghiem
{
    partial class DanhSachBoDeGVDK
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.cbbCoSo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dANGKIBODEGridControl = new DevExpress.XtraGrid.GridControl();
            this.dANGKIBODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUHOITHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIETBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kHOATableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.dANGKIBODETableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.DANGKIBODETableAdapter();
            this.lOPTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.LOPTableAdapter();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.cbbCoSo);
            this.pnHeader.Controls.Add(this.label3);
            this.pnHeader.Controls.Add(this.cbbLop);
            this.pnHeader.Controls.Add(this.cbbKhoa);
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1940, 81);
            this.pnHeader.TabIndex = 0;
            // 
            // cbbCoSo
            // 
            this.cbbCoSo.Font = new System.Drawing.Font("Tahoma", 25F);
            this.cbbCoSo.FormattingEnabled = true;
            this.cbbCoSo.Location = new System.Drawing.Point(169, 12);
            this.cbbCoSo.Name = "cbbCoSo";
            this.cbbCoSo.Size = new System.Drawing.Size(407, 48);
            this.cbbCoSo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cơ sở";
            // 
            // cbbLop
            // 
            this.cbbLop.DataSource = this.lOPBindingSource;
            this.cbbLop.DisplayMember = "TENLOP";
            this.cbbLop.Font = new System.Drawing.Font("Tahoma", 25F);
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(1292, 12);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(608, 48);
            this.cbbLop.TabIndex = 4;
            this.cbbLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dtsTTN;
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.kHOABindingSource;
            this.cbbKhoa.DisplayMember = "TENKH";
            this.cbbKhoa.Font = new System.Drawing.Font("Tahoma", 25F);
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(834, 12);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(300, 48);
            this.cbbKhoa.TabIndex = 2;
            this.cbbKhoa.ValueMember = "MAKH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label2.Location = new System.Drawing.Point(1191, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F);
            this.label1.Location = new System.Drawing.Point(692, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dANGKIBODEGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1940, 707);
            this.panel2.TabIndex = 1;
            // 
            // dANGKIBODEGridControl
            // 
            this.dANGKIBODEGridControl.DataSource = this.dANGKIBODEBindingSource;
            this.dANGKIBODEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dANGKIBODEGridControl.Location = new System.Drawing.Point(0, 0);
            this.dANGKIBODEGridControl.MainView = this.gridView1;
            this.dANGKIBODEGridControl.Name = "dANGKIBODEGridControl";
            this.dANGKIBODEGridControl.Size = new System.Drawing.Size(1940, 707);
            this.dANGKIBODEGridControl.TabIndex = 0;
            this.dANGKIBODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dANGKIBODEBindingSource
            // 
            this.dANGKIBODEBindingSource.DataMember = "FK_DANGKIBODE_LOP";
            this.dANGKIBODEBindingSource.DataSource = this.lOPBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colMAMH,
            this.colMAGV,
            this.colNGAYTHI,
            this.colSOCAUHOITHI,
            this.colTHOIGIAN,
            this.colTIETBATDAU,
            this.colMABODE,
            this.colNGAYDK});
            this.gridView1.GridControl = this.dANGKIBODEGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giảng viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 2;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "Ngày thi";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 3;
            // 
            // colSOCAUHOITHI
            // 
            this.colSOCAUHOITHI.Caption = "Số câu hỏi thi";
            this.colSOCAUHOITHI.FieldName = "SOCAUHOITHI";
            this.colSOCAUHOITHI.Name = "colSOCAUHOITHI";
            this.colSOCAUHOITHI.Visible = true;
            this.colSOCAUHOITHI.VisibleIndex = 4;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Thời gian thi";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 5;
            // 
            // colTIETBATDAU
            // 
            this.colTIETBATDAU.Caption = "Tiết bắt đầu";
            this.colTIETBATDAU.FieldName = "TIETBATDAU";
            this.colTIETBATDAU.Name = "colTIETBATDAU";
            this.colTIETBATDAU.Visible = true;
            this.colTIETBATDAU.VisibleIndex = 6;
            // 
            // colMABODE
            // 
            this.colMABODE.Caption = "Mã bộ đề";
            this.colMABODE.FieldName = "MABODE";
            this.colMABODE.Name = "colMABODE";
            this.colMABODE.Visible = true;
            this.colMABODE.VisibleIndex = 7;
            // 
            // colNGAYDK
            // 
            this.colNGAYDK.Caption = "Ngày đăng ký";
            this.colNGAYDK.FieldName = "NGAYDK";
            this.colNGAYDK.Name = "colNGAYDK";
            this.colNGAYDK.Visible = true;
            this.colNGAYDK.VisibleIndex = 8;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKIBODETableAdapter = this.dANGKIBODETableAdapter;
            this.tableAdapterManager.GIANGDAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dANGKIBODETableAdapter
            // 
            this.dANGKIBODETableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachBoDeGVDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1940, 788);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhSachBoDeGVDK";
            this.Text = "Danh sách các bộ đề đã đăng ký";
            this.Load += new System.EventHandler(this.DanhSachBoDeGVDK_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DtsTTNTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label2;
        private DtsTTNTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.ComboBox cbbLop;
        private DtsTTNTableAdapters.DANGKIBODETableAdapter dANGKIBODETableAdapter;
        private System.Windows.Forms.BindingSource dANGKIBODEBindingSource;
        private DevExpress.XtraGrid.GridControl dANGKIBODEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUHOITHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTIETBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMABODE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDK;
        private System.Windows.Forms.ComboBox cbbCoSo;
        private System.Windows.Forms.Label label3;
    }
}