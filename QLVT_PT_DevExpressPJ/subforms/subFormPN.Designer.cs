namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormPN
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormPN));
            this.grBxKho_ThemDDH = new System.Windows.Forms.GroupBox();
            this.grCtrlKho_ThemPN = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlKho_ThemPN = new DevExpress.XtraGrid.GridControl();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.grdVwKho_ThemPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grCtrlDDH_ThemPN = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlv_DS_DDHCHUACOPN = new DevExpress.XtraGrid.GridControl();
            this.v_ds_ddhChuaCoPNBDS = new System.Windows.Forms.BindingSource(this.components);
            this.grdVwViewDSDDH_ThemPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gxBxForm_ThemPN = new System.Windows.Forms.GroupBox();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMaKho = new System.Windows.Forms.TextBox();
            this.pnBDS = new System.Windows.Forms.BindingSource(this.components);
            this.txtbMaPN = new System.Windows.Forms.TextBox();
            this.txtbMaNV = new System.Windows.Forms.TextBox();
            this.dateEdNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtbMaSoDDH = new System.Windows.Forms.TextBox();
            this.phieuNhapTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.v_ds_ddhChuaCoPNTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.V_DS_DDHCHUACOPNTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            this.grBxKho_ThemDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlKho_ThemPN)).BeginInit();
            this.grCtrlKho_ThemPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlDDH_ThemPN)).BeginInit();
            this.grCtrlDDH_ThemPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlv_DS_DDHCHUACOPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ds_ddhChuaCoPNBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwViewDSDDH_ThemPN)).BeginInit();
            this.gxBxForm_ThemPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(55, 206);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(55, 16);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(11, 62);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(99, 16);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã phiếu nhập:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(20, 170);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(90, 16);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(44, 98);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(66, 16);
            nGAYLabel.TabIndex = 3;
            nGAYLabel.Text = "Ngày lập:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhaCCLabel.Location = new System.Drawing.Point(29, 134);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(81, 16);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Mã số DDH:";
            // 
            // grBxKho_ThemDDH
            // 
            this.grBxKho_ThemDDH.Controls.Add(this.grCtrlKho_ThemPN);
            this.grBxKho_ThemDDH.Controls.Add(this.grCtrlDDH_ThemPN);
            this.grBxKho_ThemDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxKho_ThemDDH.Location = new System.Drawing.Point(271, 0);
            this.grBxKho_ThemDDH.Name = "grBxKho_ThemDDH";
            this.grBxKho_ThemDDH.Size = new System.Drawing.Size(838, 282);
            this.grBxKho_ThemDDH.TabIndex = 14;
            this.grBxKho_ThemDDH.TabStop = false;
            // 
            // grCtrlKho_ThemPN
            // 
            this.grCtrlKho_ThemPN.Controls.Add(this.grdCtrlKho_ThemPN);
            this.grCtrlKho_ThemPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlKho_ThemPN.Location = new System.Drawing.Point(384, 16);
            this.grCtrlKho_ThemPN.Name = "grCtrlKho_ThemPN";
            this.grCtrlKho_ThemPN.Size = new System.Drawing.Size(451, 263);
            this.grCtrlKho_ThemPN.TabIndex = 1;
            this.grCtrlKho_ThemPN.Text = "Danh sách kho";
            // 
            // grdCtrlKho_ThemPN
            // 
            this.grdCtrlKho_ThemPN.DataSource = this.khoBDS;
            this.grdCtrlKho_ThemPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKho_ThemPN.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlKho_ThemPN.MainView = this.grdVwKho_ThemPN;
            this.grdCtrlKho_ThemPN.Name = "grdCtrlKho_ThemPN";
            this.grdCtrlKho_ThemPN.Size = new System.Drawing.Size(447, 238);
            this.grdCtrlKho_ThemPN.TabIndex = 11;
            this.grdCtrlKho_ThemPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwKho_ThemPN});
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qlvtDS;
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdVwKho_ThemPN
            // 
            this.grdVwKho_ThemPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.grdVwKho_ThemPN.GridControl = this.grdCtrlKho_ThemPN;
            this.grdVwKho_ThemPN.Name = "grdVwKho_ThemPN";
            this.grdVwKho_ThemPN.OptionsBehavior.Editable = false;
            this.grdVwKho_ThemPN.OptionsView.ShowDetailButtons = false;
            this.grdVwKho_ThemPN.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMACN, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdVwKho_ThemPN.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwKho_ThemPN_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 85;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 178;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 327;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 95;
            // 
            // grCtrlDDH_ThemPN
            // 
            this.grCtrlDDH_ThemPN.Controls.Add(this.grdCtrlv_DS_DDHCHUACOPN);
            this.grCtrlDDH_ThemPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.grCtrlDDH_ThemPN.Location = new System.Drawing.Point(3, 16);
            this.grCtrlDDH_ThemPN.Name = "grCtrlDDH_ThemPN";
            this.grCtrlDDH_ThemPN.Size = new System.Drawing.Size(381, 263);
            this.grCtrlDDH_ThemPN.TabIndex = 0;
            this.grCtrlDDH_ThemPN.Text = "Danh sách đơn đặt hàng chưa lập phiếu nhập";
            // 
            // grdCtrlv_DS_DDHCHUACOPN
            // 
            this.grdCtrlv_DS_DDHCHUACOPN.DataSource = this.v_ds_ddhChuaCoPNBDS;
            this.grdCtrlv_DS_DDHCHUACOPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlv_DS_DDHCHUACOPN.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlv_DS_DDHCHUACOPN.MainView = this.grdVwViewDSDDH_ThemPN;
            this.grdCtrlv_DS_DDHCHUACOPN.Name = "grdCtrlv_DS_DDHCHUACOPN";
            this.grdCtrlv_DS_DDHCHUACOPN.Size = new System.Drawing.Size(377, 238);
            this.grdCtrlv_DS_DDHCHUACOPN.TabIndex = 14;
            this.grdCtrlv_DS_DDHCHUACOPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwViewDSDDH_ThemPN});
            // 
            // v_ds_ddhChuaCoPNBDS
            // 
            this.v_ds_ddhChuaCoPNBDS.DataMember = "V_DS_DDHCHUACOPN";
            this.v_ds_ddhChuaCoPNBDS.DataSource = this.qlvtDS;
            // 
            // grdVwViewDSDDH_ThemPN
            // 
            this.grdVwViewDSDDH_ThemPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO1});
            this.grdVwViewDSDDH_ThemPN.GridControl = this.grdCtrlv_DS_DDHCHUACOPN;
            this.grdVwViewDSDDH_ThemPN.Name = "grdVwViewDSDDH_ThemPN";
            this.grdVwViewDSDDH_ThemPN.OptionsBehavior.Editable = false;
            this.grdVwViewDSDDH_ThemPN.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAKHO1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdVwViewDSDDH_ThemPN.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwViewDSDDH_RowClick);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 129;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày đặt";
            this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 131;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà CC";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 215;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 95;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.Caption = "Mã kho";
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            this.colMAKHO1.Width = 115;
            // 
            // gxBxForm_ThemPN
            // 
            this.gxBxForm_ThemPN.Controls.Add(this.btnThemPN);
            this.gxBxForm_ThemPN.Controls.Add(this.label1);
            this.gxBxForm_ThemPN.Controls.Add(mAKHOLabel);
            this.gxBxForm_ThemPN.Controls.Add(masoDDHLabel);
            this.gxBxForm_ThemPN.Controls.Add(this.txtbMaKho);
            this.gxBxForm_ThemPN.Controls.Add(this.txtbMaPN);
            this.gxBxForm_ThemPN.Controls.Add(mANVLabel);
            this.gxBxForm_ThemPN.Controls.Add(nGAYLabel);
            this.gxBxForm_ThemPN.Controls.Add(this.txtbMaNV);
            this.gxBxForm_ThemPN.Controls.Add(this.dateEdNgayLap);
            this.gxBxForm_ThemPN.Controls.Add(nhaCCLabel);
            this.gxBxForm_ThemPN.Controls.Add(this.txtbMaSoDDH);
            this.gxBxForm_ThemPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxBxForm_ThemPN.Location = new System.Drawing.Point(0, 0);
            this.gxBxForm_ThemPN.Name = "gxBxForm_ThemPN";
            this.gxBxForm_ThemPN.Size = new System.Drawing.Size(271, 282);
            this.gxBxForm_ThemPN.TabIndex = 13;
            this.gxBxForm_ThemPN.TabStop = false;
            // 
            // btnThemPN
            // 
            this.btnThemPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPN.Location = new System.Drawing.Point(136, 241);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(73, 26);
            this.btnThemPN.TabIndex = 11;
            this.btnThemPN.Text = "Thêm";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm phiếu nhập";
            // 
            // txtbMaKho
            // 
            this.txtbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pnBDS, "MAKHO", true));
            this.txtbMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaKho.Location = new System.Drawing.Point(116, 203);
            this.txtbMaKho.Name = "txtbMaKho";
            this.txtbMaKho.ReadOnly = true;
            this.txtbMaKho.Size = new System.Drawing.Size(122, 21);
            this.txtbMaKho.TabIndex = 9;
            this.txtbMaKho.TextChanged += new System.EventHandler(this.txtbMaKho_TextChanged);
            // 
            // pnBDS
            // 
            this.pnBDS.DataMember = "PhieuNhap";
            this.pnBDS.DataSource = this.qlvtDS;
            // 
            // txtbMaPN
            // 
            this.txtbMaPN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pnBDS, "MAPN", true));
            this.txtbMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaPN.Location = new System.Drawing.Point(116, 59);
            this.txtbMaPN.MaxLength = 8;
            this.txtbMaPN.Name = "txtbMaPN";
            this.txtbMaPN.Size = new System.Drawing.Size(122, 21);
            this.txtbMaPN.TabIndex = 2;
            this.txtbMaPN.TextChanged += new System.EventHandler(this.txtbMaPN_TextChanged);
            // 
            // txtbMaNV
            // 
            this.txtbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pnBDS, "MANV", true));
            this.txtbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaNV.Location = new System.Drawing.Point(116, 167);
            this.txtbMaNV.Name = "txtbMaNV";
            this.txtbMaNV.ReadOnly = true;
            this.txtbMaNV.Size = new System.Drawing.Size(122, 21);
            this.txtbMaNV.TabIndex = 7;
            // 
            // dateEdNgayLap
            // 
            this.dateEdNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pnBDS, "NGAY", true));
            this.dateEdNgayLap.EditValue = null;
            this.dateEdNgayLap.Location = new System.Drawing.Point(116, 95);
            this.dateEdNgayLap.Name = "dateEdNgayLap";
            this.dateEdNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dateEdNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayLap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdNgayLap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdNgayLap.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdNgayLap.Size = new System.Drawing.Size(122, 22);
            this.dateEdNgayLap.TabIndex = 4;
            this.dateEdNgayLap.EditValueChanged += new System.EventHandler(this.dateEdNgayLap_EditValueChanged);
            this.dateEdNgayLap.TextChanged += new System.EventHandler(this.dateEdNgayLap_TextChanged);
            // 
            // txtbMaSoDDH
            // 
            this.txtbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pnBDS, "MasoDDH", true));
            this.txtbMaSoDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaSoDDH.Location = new System.Drawing.Point(116, 131);
            this.txtbMaSoDDH.Name = "txtbMaSoDDH";
            this.txtbMaSoDDH.ReadOnly = true;
            this.txtbMaSoDDH.Size = new System.Drawing.Size(122, 21);
            this.txtbMaSoDDH.TabIndex = 5;
            this.txtbMaSoDDH.TextChanged += new System.EventHandler(this.txtbMaSoDDH_TextChanged);
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HoTenNVTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // v_ds_ddhChuaCoPNTableAdapter
            // 
            this.v_ds_ddhChuaCoPNTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            // 
            // subFormPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 282);
            this.Controls.Add(this.grBxKho_ThemDDH);
            this.Controls.Add(this.gxBxForm_ThemPN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormPN_FormClosing);
            this.Load += new System.EventHandler(this.subFormPN_Load);
            this.Shown += new System.EventHandler(this.subFormPN_Shown);
            this.grBxKho_ThemDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlKho_ThemPN)).EndInit();
            this.grCtrlKho_ThemPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlDDH_ThemPN)).EndInit();
            this.grCtrlDDH_ThemPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlv_DS_DDHCHUACOPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ds_ddhChuaCoPNBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwViewDSDDH_ThemPN)).EndInit();
            this.gxBxForm_ThemPN.ResumeLayout(false);
            this.gxBxForm_ThemPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxKho_ThemDDH;
        private DevExpress.XtraGrid.GridControl grdCtrlKho_ThemPN;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwKho_ThemPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox gxBxForm_ThemPN;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMaKho;
        private System.Windows.Forms.TextBox txtbMaPN;
        private System.Windows.Forms.TextBox txtbMaNV;
        private DevExpress.XtraEditors.DateEdit dateEdNgayLap;
        private System.Windows.Forms.TextBox txtbMaSoDDH;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource pnBDS;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource khoBDS;
        private DevExpress.XtraEditors.GroupControl grCtrlKho_ThemPN;
        private DevExpress.XtraEditors.GroupControl grCtrlDDH_ThemPN;
        private System.Windows.Forms.BindingSource v_ds_ddhChuaCoPNBDS;
        private QLVTDataSetTableAdapters.V_DS_DDHCHUACOPNTableAdapter v_ds_ddhChuaCoPNTableAdapter;
        private DevExpress.XtraGrid.GridControl grdCtrlv_DS_DDHCHUACOPN;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwViewDSDDH_ThemPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private System.Windows.Forms.Button btnThoat;
    }
}