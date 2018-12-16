namespace ThiTracNghiem
{
    partial class FormXemLichThi
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
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label label1;
            this.dtsTTN = new ThiTracNghiem.DtsTTN();
            this.tableAdapterManager = new ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dANGKIBODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKIBODETableAdapter = new ThiTracNghiem.DtsTTNTableAdapters.DANGKIBODETableAdapter();
            this.dANGKIBODEGridControl = new DevExpress.XtraGrid.GridControl();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenGV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.btnThi = new System.Windows.Forms.Button();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsTTN
            // 
            this.dtsTTN.DataSetName = "DtsTTN";
            this.dtsTTN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiem.DtsTTNTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dANGKIBODEGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 742);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 742);
            this.panel2.TabIndex = 1;
            // 
            // dANGKIBODEBindingSource
            // 
            this.dANGKIBODEBindingSource.DataMember = "DANGKIBODE";
            this.dANGKIBODEBindingSource.DataSource = this.dtsTTN;
            // 
            // dANGKIBODETableAdapter
            // 
            this.dANGKIBODETableAdapter.ClearBeforeFill = true;
            // 
            // dANGKIBODEGridControl
            // 
            this.dANGKIBODEGridControl.DataSource = this.dANGKIBODEBindingSource;
            this.dANGKIBODEGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dANGKIBODEGridControl.Location = new System.Drawing.Point(0, 0);
            this.dANGKIBODEGridControl.MainView = this.gridView1;
            this.dANGKIBODEGridControl.Name = "dANGKIBODEGridControl";
            this.dANGKIBODEGridControl.Size = new System.Drawing.Size(1124, 742);
            this.dANGKIBODEGridControl.TabIndex = 0;
            this.dANGKIBODEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dANGKIBODEGridControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dANGKIBODEGridControl_MouseClick);
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
            this.colSOCAUHOITHI.Caption = "Số câu hỏi";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnThi);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(tENKHLabel);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.txtMAGV);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHoTenGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 742);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn thi";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            mAGVLabel.Location = new System.Drawing.Point(137, 50);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(134, 24);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã giảng viên";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(377, 47);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Size = new System.Drawing.Size(259, 30);
            this.txtMAGV.TabIndex = 1;
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            hOLabel.Location = new System.Drawing.Point(137, 110);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(208, 24);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên giảng viên :";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(377, 107);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtHoTenGV.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenGV.Size = new System.Drawing.Size(259, 30);
            this.txtHoTenGV.TabIndex = 3;
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            tENKHLabel.Location = new System.Drawing.Point(137, 171);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(112, 24);
            tENKHLabel.TabIndex = 4;
            tENKHLabel.Text = "Tên khoa : ";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(377, 168);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(259, 30);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15F);
            label1.Location = new System.Drawing.Point(137, 230);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 24);
            label1.TabIndex = 6;
            label1.Text = "Tên môn học : ";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(377, 227);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTenMonHoc.Properties.Appearance.Options.UseFont = true;
            this.txtTenMonHoc.Size = new System.Drawing.Size(259, 30);
            this.txtTenMonHoc.TabIndex = 7;
            // 
            // btnThi
            // 
            this.btnThi.BackColor = System.Drawing.Color.Lime;
            this.btnThi.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btnThi.Location = new System.Drawing.Point(399, 339);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(224, 111);
            this.btnThi.TabIndex = 8;
            this.btnThi.Text = "Bắt đầu thi";
            this.btnThi.UseVisualStyleBackColor = false;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // FormXemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormXemLichThi";
            this.Text = "Xem lịch thi";
            this.Load += new System.EventHandler(this.FormXemLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsTTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKIBODEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonHoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DtsTTN dtsTTN;
        private DtsTTNTableAdapters.TableAdapterManager tableAdapterManager;
        private DtsTTNTableAdapters.DANGKIBODETableAdapter dANGKIBODETableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.TextEdit txtHoTenGV;
        private System.Windows.Forms.Button btnThi;
        private DevExpress.XtraEditors.TextEdit txtTenMonHoc;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
    }
}