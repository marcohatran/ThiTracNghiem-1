namespace ThiTracNghiem
{
    partial class FormMonHoc
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
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.cAUHOITableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.CAUHOITableAdapter();
            this.lUACHONTableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.LUACHONTableAdapter();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAUHOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAUHOIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCauHoi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAPAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUACHONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnLuaChon = new DevExpress.XtraEditors.PanelControl();
            this.rtbNoiDungCH = new System.Windows.Forms.RichTextBox();
            this.kHOATableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.KHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnLuaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dtsTTN;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LUACHONTableAdapter = this.lUACHONTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // lUACHONTableAdapter
            // 
            this.lUACHONTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.AllowDrop = true;
            this.mONHOCGridControl.DataSource = this.mONHOCBindingSource;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 70);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(1555, 255);
            this.mONHOCGridControl.TabIndex = 1;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colMAKH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // cAUHOIBindingSource
            // 
            this.cAUHOIBindingSource.DataMember = "FK_CAUHOI_MONHOC";
            this.cAUHOIBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // cAUHOIGridControl
            // 
            this.cAUHOIGridControl.DataSource = this.cAUHOIBindingSource;
            this.cAUHOIGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.cAUHOIGridControl.Location = new System.Drawing.Point(0, 325);
            this.cAUHOIGridControl.MainView = this.gvCauHoi;
            this.cAUHOIGridControl.Name = "cAUHOIGridControl";
            this.cAUHOIGridControl.Size = new System.Drawing.Size(969, 642);
            this.cAUHOIGridControl.TabIndex = 1;
            this.cAUHOIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCauHoi});
            // 
            // gvCauHoi
            // 
            this.gvCauHoi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACH,
            this.colNOIDUNG,
            this.colDAPAN,
            this.colTRINHDO,
            this.colMAMH1,
            this.colMAGV});
            this.gvCauHoi.GridControl = this.cAUHOIGridControl;
            this.gvCauHoi.Name = "gvCauHoi";
            this.gvCauHoi.OptionsView.ShowGroupPanel = false;
            this.gvCauHoi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCauHoi_RowClick);
            // 
            // colMACH
            // 
            this.colMACH.Caption = "Mã câu hỏi";
            this.colMACH.FieldName = "MACH";
            this.colMACH.Name = "colMACH";
            this.colMACH.Visible = true;
            this.colMACH.VisibleIndex = 0;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 1;
            // 
            // colDAPAN
            // 
            this.colDAPAN.Caption = "Đáp án";
            this.colDAPAN.FieldName = "DAPAN";
            this.colDAPAN.Name = "colDAPAN";
            this.colDAPAN.Visible = true;
            this.colDAPAN.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "Mã Môn học";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 4;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã Giảng Viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            // 
            // lUACHONBindingSource
            // 
            this.lUACHONBindingSource.DataMember = "FK_LUACHON_CAUHOI1";
            this.lUACHONBindingSource.DataSource = this.cAUHOIBindingSource;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.cbbKhoa);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1555, 70);
            this.panelControl3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(393, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DataSource = this.kHOABindingSource;
            this.cbbKhoa.DisplayMember = "TENKH";
            this.cbbKhoa.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(523, 12);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(524, 41);
            this.cbbKhoa.TabIndex = 0;
            this.cbbKhoa.ValueMember = "MAKH";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.kHOAComboBox_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dtsTTN;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pnLuaChon);
            this.panelControl1.Controls.Add(this.rtbNoiDungCH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(969, 325);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(586, 642);
            this.panelControl1.TabIndex = 4;
            // 
            // pnLuaChon
            // 
            this.pnLuaChon.AllowDrop = true;
            this.pnLuaChon.AllowTouchScroll = true;
            this.pnLuaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLuaChon.Location = new System.Drawing.Point(2, 170);
            this.pnLuaChon.Name = "pnLuaChon";
            this.pnLuaChon.Size = new System.Drawing.Size(582, 470);
            this.pnLuaChon.TabIndex = 1;
            // 
            // rtbNoiDungCH
            // 
            this.rtbNoiDungCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbNoiDungCH.EnableAutoDragDrop = true;
            this.rtbNoiDungCH.Location = new System.Drawing.Point(2, 2);
            this.rtbNoiDungCH.Name = "rtbNoiDungCH";
            this.rtbNoiDungCH.Size = new System.Drawing.Size(582, 168);
            this.rtbNoiDungCH.TabIndex = 0;
            this.rtbNoiDungCH.Text = "";
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 967);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cAUHOIGridControl);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.EnabledChanged += new System.EventHandler(this.FormMonHoc_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnLuaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DtsTTN dtsTTN;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DtsTTNTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private DtsTTNTableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.BindingSource cAUHOIBindingSource;
        private DevExpress.XtraGrid.GridControl cAUHOIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCauHoi;
        private DtsTTNTableAdapters.LUACHONTableAdapter lUACHONTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colDAPAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.BindingSource lUACHONBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DtsTTNTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.RichTextBox rtbNoiDungCH;
        private DevExpress.XtraEditors.PanelControl pnLuaChon;
    }
}