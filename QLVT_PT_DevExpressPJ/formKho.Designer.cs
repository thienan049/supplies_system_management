namespace QLVT_PT_DevExpressPJ
{
    partial class formKho
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
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKho));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatKho = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.grCtrlCN = new DevExpress.XtraEditors.GroupControl();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.grdVwKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBxCN = new System.Windows.Forms.GroupBox();
            this.panelCN = new DevExpress.Utils.Layout.StackPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTenCN_KHO = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbMaCN_Kho = new System.Windows.Forms.TextBox();
            this.txtbDiaChi = new System.Windows.Forms.TextBox();
            this.txtbTenKho = new System.Windows.Forms.TextBox();
            this.txtbMaKho = new System.Windows.Forms.TextBox();
            this.pxBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.pnBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.dhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.mainPanel = new System.Windows.Forms.Panel();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlCN)).BeginInit();
            this.grCtrlCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho)).BeginInit();
            this.grBxCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).BeginInit();
            this.panelCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhBDS)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(12, 125);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(56, 14);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOLabel.Location = new System.Drawing.Point(8, 159);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(60, 14);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên kho:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(17, 195);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 14);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(19, 90);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(49, 14);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã CN:";
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
            this.btnThemKho,
            this.btnGhiKho,
            this.btnXoaKho,
            this.btnPhucHoiKho,
            this.btnReloadKho,
            this.btnThoatKho,
            this.btnSuaKho});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(630, 191);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Caption = "Thêm";
            this.btnThemKho.Id = 0;
            this.btnThemKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKho.ImageOptions.Image")));
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKho_ItemClick);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Caption = "Sửa";
            this.btnSuaKho.Id = 6;
            this.btnSuaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.ImageOptions.Image")));
            this.btnSuaKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.ImageOptions.LargeImage")));
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKho_ItemClick);
            // 
            // btnGhiKho
            // 
            this.btnGhiKho.Caption = "Ghi";
            this.btnGhiKho.Id = 1;
            this.btnGhiKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiKho.ImageOptions.Image")));
            this.btnGhiKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhiKho.ImageOptions.LargeImage")));
            this.btnGhiKho.Name = "btnGhiKho";
            this.btnGhiKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiKho_ItemClick);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Xóa";
            this.btnXoaKho.Id = 2;
            this.btnXoaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.ImageOptions.Image")));
            this.btnXoaKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.ImageOptions.LargeImage")));
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKho_ItemClick);
            // 
            // btnPhucHoiKho
            // 
            this.btnPhucHoiKho.Caption = "Phục hồi";
            this.btnPhucHoiKho.Id = 3;
            this.btnPhucHoiKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoiKho.ImageOptions.Image")));
            this.btnPhucHoiKho.Name = "btnPhucHoiKho";
            this.btnPhucHoiKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiKho_ItemClick);
            // 
            // btnReloadKho
            // 
            this.btnReloadKho.Caption = "Reload";
            this.btnReloadKho.Id = 4;
            this.btnReloadKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadKho.ImageOptions.Image")));
            this.btnReloadKho.Name = "btnReloadKho";
            this.btnReloadKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadKho_ItemClick);
            // 
            // btnThoatKho
            // 
            this.btnThoatKho.Caption = "Thoát";
            this.btnThoatKho.Id = 5;
            this.btnThoatKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatKho.ImageOptions.Image")));
            this.btnThoatKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoatKho.ImageOptions.LargeImage")));
            this.btnThoatKho.Name = "btnThoatKho";
            this.btnThoatKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatKho_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(957, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(957, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(957, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qlvtDS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // grCtrlCN
            // 
            this.grCtrlCN.Controls.Add(this.khoGridControl);
            this.grCtrlCN.Controls.Add(this.grBxCN);
            this.grCtrlCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.grCtrlCN.Location = new System.Drawing.Point(0, 0);
            this.grCtrlCN.Name = "grCtrlCN";
            this.grCtrlCN.Size = new System.Drawing.Size(687, 422);
            this.grCtrlCN.TabIndex = 11;
            this.grCtrlCN.Text = "Danh sách kho";
            this.grCtrlCN.SizeChanged += new System.EventHandler(this.grCtrlDSKho_SizeChanged);
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBDS;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoGridControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoGridControl.Location = new System.Drawing.Point(2, 64);
            this.khoGridControl.MainView = this.grdVwKho;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(683, 356);
            this.khoGridControl.TabIndex = 11;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwKho});
            // 
            // grdVwKho
            // 
            this.grdVwKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.grdVwKho.GridControl = this.khoGridControl;
            this.grdVwKho.Name = "grdVwKho";
            this.grdVwKho.OptionsBehavior.Editable = false;
            this.grdVwKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwKho_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHO.AppearanceCell.Options.UseFont = true;
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 103;
            // 
            // colTENKHO
            // 
            this.colTENKHO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKHO.AppearanceCell.Options.UseFont = true;
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 156;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceCell.Options.UseFont = true;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 351;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMACN.AppearanceCell.Options.UseFont = true;
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // grBxCN
            // 
            this.grBxCN.Controls.Add(this.panelCN);
            this.grBxCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBxCN.Location = new System.Drawing.Point(2, 23);
            this.grBxCN.Name = "grBxCN";
            this.grBxCN.Size = new System.Drawing.Size(683, 41);
            this.grBxCN.TabIndex = 0;
            this.grBxCN.TabStop = false;
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.label2);
            this.panelCN.Controls.Add(this.cbxTenCN_KHO);
            this.panelCN.Location = new System.Drawing.Point(134, 8);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(383, 28);
            this.panelCN.TabIndex = 4;
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
            // cbxTenCN_KHO
            // 
            this.cbxTenCN_KHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN_KHO.FormattingEnabled = true;
            this.cbxTenCN_KHO.Location = new System.Drawing.Point(109, 3);
            this.cbxTenCN_KHO.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenCN_KHO.Name = "cbxTenCN_KHO";
            this.cbxTenCN_KHO.Size = new System.Drawing.Size(265, 21);
            this.cbxTenCN_KHO.TabIndex = 2;
            this.cbxTenCN_KHO.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_KHO_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureBox2);
            this.groupControl2.Controls.Add(this.pictureBox1);
            this.groupControl2.Controls.Add(mACNLabel);
            this.groupControl2.Controls.Add(this.txtbMaCN_Kho);
            this.groupControl2.Controls.Add(dIACHILabel);
            this.groupControl2.Controls.Add(this.txtbDiaChi);
            this.groupControl2.Controls.Add(tENKHOLabel);
            this.groupControl2.Controls.Add(this.txtbTenKho);
            this.groupControl2.Controls.Add(mAKHOLabel);
            this.groupControl2.Controls.Add(this.txtbMaKho);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(687, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(270, 422);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Thông tin kho";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtbMaCN_Kho
            // 
            this.txtbMaCN_Kho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBDS, "MACN", true));
            this.txtbMaCN_Kho.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaCN_Kho.Location = new System.Drawing.Point(68, 84);
            this.txtbMaCN_Kho.Name = "txtbMaCN_Kho";
            this.txtbMaCN_Kho.ReadOnly = true;
            this.txtbMaCN_Kho.Size = new System.Drawing.Size(100, 26);
            this.txtbMaCN_Kho.TabIndex = 7;
            // 
            // txtbDiaChi
            // 
            this.txtbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBDS, "DIACHI", true));
            this.txtbDiaChi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDiaChi.Location = new System.Drawing.Point(68, 189);
            this.txtbDiaChi.MaxLength = 100;
            this.txtbDiaChi.Multiline = true;
            this.txtbDiaChi.Name = "txtbDiaChi";
            this.txtbDiaChi.ReadOnly = true;
            this.txtbDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbDiaChi.Size = new System.Drawing.Size(190, 41);
            this.txtbDiaChi.TabIndex = 5;
            this.txtbDiaChi.TextChanged += new System.EventHandler(this.txtbDiaChi_TextChanged);
            // 
            // txtbTenKho
            // 
            this.txtbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBDS, "TENKHO", true));
            this.txtbTenKho.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenKho.Location = new System.Drawing.Point(68, 153);
            this.txtbTenKho.MaxLength = 30;
            this.txtbTenKho.Name = "txtbTenKho";
            this.txtbTenKho.ReadOnly = true;
            this.txtbTenKho.Size = new System.Drawing.Size(100, 26);
            this.txtbTenKho.TabIndex = 3;
            this.txtbTenKho.TextChanged += new System.EventHandler(this.txtbTenKho_TextChanged);
            // 
            // txtbMaKho
            // 
            this.txtbMaKho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBDS, "MAKHO", true));
            this.txtbMaKho.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaKho.Location = new System.Drawing.Point(68, 119);
            this.txtbMaKho.MaxLength = 4;
            this.txtbMaKho.Name = "txtbMaKho";
            this.txtbMaKho.ReadOnly = true;
            this.txtbMaKho.Size = new System.Drawing.Size(100, 26);
            this.txtbMaKho.TabIndex = 1;
            this.txtbMaKho.TextChanged += new System.EventHandler(this.txtbMaKho_TextChanged);
            // 
            // pxBDS
            // 
            this.pxBDS.DataMember = "FK_PX_Kho";
            this.pxBDS.DataSource = this.khoBDS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // pnBDS
            // 
            this.pnBDS.DataMember = "FK_PhieuNhap_Kho";
            this.pnBDS.DataSource = this.khoBDS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // dhBDS
            // 
            this.dhBDS.DataMember = "FK_DatHang_Kho";
            this.dhBDS.DataSource = this.khoBDS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupControl2);
            this.mainPanel.Controls.Add(this.grCtrlCN);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(957, 422);
            this.mainPanel.TabIndex = 17;
            // 
            // formKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(957, 454);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formKho";
            this.Text = "Quản lý kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formKho_FormClosing);
            this.Load += new System.EventHandler(this.formKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlCN)).EndInit();
            this.grCtrlCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho)).EndInit();
            this.grBxCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhBDS)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemKho;
        private DevExpress.XtraBars.BarButtonItem btnGhiKho;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoaKho;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiKho;
        private DevExpress.XtraBars.BarButtonItem btnReloadKho;
        private DevExpress.XtraBars.BarButtonItem btnThoatKho;
        private System.Windows.Forms.BindingSource khoBDS;
        private QLVTDataSet qlvtDS;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwKho;
        private DevExpress.XtraEditors.GroupControl grCtrlCN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.TextBox txtbMaCN_Kho;
        private System.Windows.Forms.TextBox txtbDiaChi;
        private System.Windows.Forms.TextBox txtbTenKho;
        private System.Windows.Forms.TextBox txtbMaKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTenCN_KHO;
        private System.Windows.Forms.BindingSource pxBDS;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource pnBDS;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource dhBDS;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnSuaKho;
        private DevExpress.Utils.Layout.StackPanel panelCN;
        private System.Windows.Forms.GroupBox grBxCN;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}