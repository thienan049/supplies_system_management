namespace QLVT_PT_DevExpressPJ
{
    partial class formVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatVT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.vtBDS = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.grdVwVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.txtbTenVT = new System.Windows.Forms.TextBox();
            this.txtbMaVT = new System.Windows.Forms.TextBox();
            this.ctpxBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTPXTableAdapter();
            this.ctpnBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.ctddhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.grCtrlCN = new DevExpress.XtraEditors.GroupControl();
            this.grBxCN = new System.Windows.Forms.GroupBox();
            this.panelCN = new DevExpress.Utils.Layout.StackPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTenCN_VATTU = new System.Windows.Forms.ComboBox();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpnBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlCN)).BeginInit();
            this.grCtrlCN.SuspendLayout();
            this.grBxCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).BeginInit();
            this.panelCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(17, 77);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(13, 164);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(44, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT:";
            // 
            // dVTLabel1
            // 
            dVTLabel1.AutoSize = true;
            dVTLabel1.Location = new System.Drawing.Point(15, 119);
            dVTLabel1.Name = "dVTLabel1";
            dVTLabel1.Size = new System.Drawing.Size(42, 13);
            dVTLabel1.TabIndex = 6;
            dVTLabel1.Text = "Đơn vị:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemVT,
            this.btnGhiVT,
            this.btnXoaVT,
            this.btnPhucHoiVT,
            this.btnReloadVT,
            this.btnThoatVT,
            this.btnSuaVT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Thêm";
            this.btnThemVT.Id = 0;
            this.btnThemVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVT.ImageOptions.Image")));
            this.btnThemVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemVT.ImageOptions.LargeImage")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVT_ItemClick);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Caption = "Sửa";
            this.btnSuaVT.Id = 6;
            this.btnSuaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaVT.ImageOptions.Image")));
            this.btnSuaVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaVT.ImageOptions.LargeImage")));
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaVT_ItemClick);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Caption = "Ghi";
            this.btnGhiVT.Id = 1;
            this.btnGhiVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiVT.ImageOptions.Image")));
            this.btnGhiVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiVT.ImageOptions.LargeImage")));
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiVT_ItemClick);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Caption = "Xóa";
            this.btnXoaVT.Id = 2;
            this.btnXoaVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaVT.ImageOptions.Image")));
            this.btnXoaVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaVT.ImageOptions.LargeImage")));
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaVT_ItemClick);
            // 
            // btnPhucHoiVT
            // 
            this.btnPhucHoiVT.Caption = "Phục hồi";
            this.btnPhucHoiVT.Id = 3;
            this.btnPhucHoiVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiVT.ImageOptions.Image")));
            this.btnPhucHoiVT.Name = "btnPhucHoiVT";
            this.btnPhucHoiVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiVT_ItemClick);
            // 
            // btnReloadVT
            // 
            this.btnReloadVT.Caption = "Reload";
            this.btnReloadVT.Id = 4;
            this.btnReloadVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadVT.ImageOptions.Image")));
            this.btnReloadVT.Name = "btnReloadVT";
            this.btnReloadVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadVT_ItemClick);
            // 
            // btnThoatVT
            // 
            this.btnThoatVT.Caption = "Thoát";
            this.btnThoatVT.Id = 5;
            this.btnThoatVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatVT.ImageOptions.Image")));
            this.btnThoatVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatVT.ImageOptions.LargeImage")));
            this.btnThoatVT.Name = "btnThoatVT";
            this.btnThoatVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatVT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(892, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vtBDS
            // 
            this.vtBDS.DataMember = "Vattu";
            this.vtBDS.DataSource = this.qlvtDS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vtBDS;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vattuGridControl.Location = new System.Drawing.Point(2, 64);
            this.vattuGridControl.MainView = this.grdVwVT;
            this.vattuGridControl.MenuManager = this.barManager1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(675, 356);
            this.vattuGridControl.TabIndex = 5;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwVT});
            // 
            // grdVwVT
            // 
            this.grdVwVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT});
            this.grdVwVT.GridControl = this.vattuGridControl;
            this.grdVwVT.Name = "grdVwVT";
            this.grdVwVT.OptionsBehavior.Editable = false;
            this.grdVwVT.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwVT_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 118;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 456;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 252;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(dVTLabel1);
            this.groupControl1.Controls.Add(this.cbxDonVi);
            this.groupControl1.Controls.Add(tENVTLabel);
            this.groupControl1.Controls.Add(this.txtbTenVT);
            this.groupControl1.Controls.Add(mAVTLabel);
            this.groupControl1.Controls.Add(this.txtbMaVT);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(679, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 422);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin vật tư";
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vtBDS, "DVT", true));
            this.cbxDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDonVi.Enabled = false;
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Items.AddRange(new object[] {
            "Cái",
            "test"});
            this.cbxDonVi.Location = new System.Drawing.Point(61, 116);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(96, 21);
            this.cbxDonVi.TabIndex = 7;
            this.cbxDonVi.SelectedIndexChanged += new System.EventHandler(this.cbxDonVi_SelectedIndexChanged);
            this.cbxDonVi.Validating += new System.ComponentModel.CancelEventHandler(this.cbxDonVi_Validating);
            this.cbxDonVi.Validated += new System.EventHandler(this.cbxDonVi_Validated);
            // 
            // txtbTenVT
            // 
            this.txtbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vtBDS, "TENVT", true));
            this.txtbTenVT.Location = new System.Drawing.Point(61, 161);
            this.txtbTenVT.MaxLength = 30;
            this.txtbTenVT.Name = "txtbTenVT";
            this.txtbTenVT.ReadOnly = true;
            this.txtbTenVT.Size = new System.Drawing.Size(267, 21);
            this.txtbTenVT.TabIndex = 3;
            this.txtbTenVT.TextChanged += new System.EventHandler(this.txtbTenVT_TextChanged);
            this.txtbTenVT.Validating += new System.ComponentModel.CancelEventHandler(this.txtbTenVT_Validating);
            this.txtbTenVT.Validated += new System.EventHandler(this.txtbTenVT_Validated);
            // 
            // txtbMaVT
            // 
            this.txtbMaVT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vtBDS, "MAVT", true));
            this.txtbMaVT.Location = new System.Drawing.Point(61, 74);
            this.txtbMaVT.MaxLength = 4;
            this.txtbMaVT.Name = "txtbMaVT";
            this.txtbMaVT.ReadOnly = true;
            this.txtbMaVT.Size = new System.Drawing.Size(96, 21);
            this.txtbMaVT.TabIndex = 1;
            this.txtbMaVT.TextChanged += new System.EventHandler(this.txtbMaVT_TextChanged);
            this.txtbMaVT.Validating += new System.ComponentModel.CancelEventHandler(this.txtbMaVT_Validating);
            this.txtbMaVT.Validated += new System.EventHandler(this.txtbMaVT_Validated);
            // 
            // ctpxBDS
            // 
            this.ctpxBDS.DataMember = "FK_CTPX_VatTu";
            this.ctpxBDS.DataSource = this.vtBDS;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // ctpnBDS
            // 
            this.ctpnBDS.DataMember = "FK_CTPN_VatTu";
            this.ctpnBDS.DataSource = this.vtBDS;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // ctddhBDS
            // 
            this.ctddhBDS.DataMember = "FK_CTDDH_VatTu";
            this.ctddhBDS.DataSource = this.vtBDS;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // grCtrlCN
            // 
            this.grCtrlCN.Controls.Add(this.vattuGridControl);
            this.grCtrlCN.Controls.Add(this.grBxCN);
            this.grCtrlCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.grCtrlCN.Location = new System.Drawing.Point(0, 32);
            this.grCtrlCN.Name = "grCtrlCN";
            this.grCtrlCN.Size = new System.Drawing.Size(679, 422);
            this.grCtrlCN.TabIndex = 11;
            this.grCtrlCN.Text = "Danh sách vật tư";
            // 
            // grBxCN
            // 
            this.grBxCN.Controls.Add(this.panelCN);
            this.grBxCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBxCN.Location = new System.Drawing.Point(2, 23);
            this.grBxCN.Name = "grBxCN";
            this.grBxCN.Size = new System.Drawing.Size(675, 41);
            this.grBxCN.TabIndex = 0;
            this.grBxCN.TabStop = false;
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.label2);
            this.panelCN.Controls.Add(this.cbxTenCN_VATTU);
            this.panelCN.Location = new System.Drawing.Point(134, 11);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(383, 28);
            this.panelCN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên chi nhánh:";
            // 
            // cbxTenCN_VATTU
            // 
            this.cbxTenCN_VATTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN_VATTU.FormattingEnabled = true;
            this.cbxTenCN_VATTU.Location = new System.Drawing.Point(109, 3);
            this.cbxTenCN_VATTU.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenCN_VATTU.Name = "cbxTenCN_VATTU";
            this.cbxTenCN_VATTU.Size = new System.Drawing.Size(265, 21);
            this.cbxTenCN_VATTU.TabIndex = 2;
            this.cbxTenCN_VATTU.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_VATTU_SelectedIndexChanged);
            // 
            // formVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 454);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grCtrlCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formVatTu";
            this.Text = "Quản lý vật tư";
            this.Load += new System.EventHandler(this.formVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpnBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlCN)).EndInit();
            this.grCtrlCN.ResumeLayout(false);
            this.grBxCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource vtBDS;
        private QLVTDataSet qlvtDS;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnGhiVT;
        private DevExpress.XtraBars.BarButtonItem btnXoaVT;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiVT;
        private DevExpress.XtraBars.BarButtonItem btnReloadVT;
        private DevExpress.XtraBars.BarButtonItem btnThoatVT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtbMaVT;
        private System.Windows.Forms.TextBox txtbTenVT;
        private System.Windows.Forms.BindingSource ctpxBDS;
        private QLVTDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource ctpnBDS;
        private QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource ctddhBDS;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.ComboBox cbxDonVi;
        private DevExpress.XtraBars.BarButtonItem btnSuaVT;
        private System.Windows.Forms.GroupBox grBxCN;
        private DevExpress.XtraEditors.GroupControl grCtrlCN;
        private DevExpress.Utils.Layout.StackPanel panelCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTenCN_VATTU;
    }
}