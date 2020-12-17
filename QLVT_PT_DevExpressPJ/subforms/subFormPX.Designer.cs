namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormPX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormPX));
            this.grBxKho_ThemPX = new System.Windows.Forms.GroupBox();
            this.grCtrlKho_ThemPX = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlKho_ThemPX = new DevExpress.XtraGrid.GridControl();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.grdVwKho_ThemPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gxBxForm_ThemPX = new System.Windows.Forms.GroupBox();
            this.btnThemPX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMaKho = new System.Windows.Forms.TextBox();
            this.pxBDS = new System.Windows.Forms.BindingSource(this.components);
            this.txtbMaPX = new System.Windows.Forms.TextBox();
            this.txtbMaNV = new System.Windows.Forms.TextBox();
            this.dateEdNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtbHoTenKH = new System.Windows.Forms.TextBox();
            this.khoTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.phieuXuatTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            this.grBxKho_ThemPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlKho_ThemPX)).BeginInit();
            this.grCtrlKho_ThemPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemPX)).BeginInit();
            this.gxBxForm_ThemPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBDS)).BeginInit();
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
            masoDDHLabel.Location = new System.Drawing.Point(17, 62);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(93, 16);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã phiếu xuất:";
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
            nhaCCLabel.Location = new System.Drawing.Point(39, 136);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(71, 16);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Họ tên KH:";
            // 
            // grBxKho_ThemPX
            // 
            this.grBxKho_ThemPX.Controls.Add(this.grCtrlKho_ThemPX);
            this.grBxKho_ThemPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxKho_ThemPX.Location = new System.Drawing.Point(274, 0);
            this.grBxKho_ThemPX.Name = "grBxKho_ThemPX";
            this.grBxKho_ThemPX.Size = new System.Drawing.Size(545, 282);
            this.grBxKho_ThemPX.TabIndex = 16;
            this.grBxKho_ThemPX.TabStop = false;
            // 
            // grCtrlKho_ThemPX
            // 
            this.grCtrlKho_ThemPX.Controls.Add(this.grdCtrlKho_ThemPX);
            this.grCtrlKho_ThemPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlKho_ThemPX.Location = new System.Drawing.Point(3, 16);
            this.grCtrlKho_ThemPX.Name = "grCtrlKho_ThemPX";
            this.grCtrlKho_ThemPX.Size = new System.Drawing.Size(539, 263);
            this.grCtrlKho_ThemPX.TabIndex = 1;
            this.grCtrlKho_ThemPX.Text = "Danh sách kho";
            // 
            // grdCtrlKho_ThemPX
            // 
            this.grdCtrlKho_ThemPX.DataSource = this.khoBDS;
            this.grdCtrlKho_ThemPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKho_ThemPX.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlKho_ThemPX.MainView = this.grdVwKho_ThemPX;
            this.grdCtrlKho_ThemPX.Name = "grdCtrlKho_ThemPX";
            this.grdCtrlKho_ThemPX.Size = new System.Drawing.Size(535, 238);
            this.grdCtrlKho_ThemPX.TabIndex = 11;
            this.grdCtrlKho_ThemPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwKho_ThemPX});
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
            // grdVwKho_ThemPX
            // 
            this.grdVwKho_ThemPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.grdVwKho_ThemPX.GridControl = this.grdCtrlKho_ThemPX;
            this.grdVwKho_ThemPX.Name = "grdVwKho_ThemPX";
            this.grdVwKho_ThemPX.OptionsBehavior.Editable = false;
            this.grdVwKho_ThemPX.OptionsView.ShowDetailButtons = false;
            this.grdVwKho_ThemPX.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMACN, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grdVwKho_ThemPX.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwKho_ThemPX_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 73;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 136;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 396;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 80;
            // 
            // gxBxForm_ThemPX
            // 
            this.gxBxForm_ThemPX.Controls.Add(this.btnThemPX);
            this.gxBxForm_ThemPX.Controls.Add(this.label1);
            this.gxBxForm_ThemPX.Controls.Add(mAKHOLabel);
            this.gxBxForm_ThemPX.Controls.Add(masoDDHLabel);
            this.gxBxForm_ThemPX.Controls.Add(this.txtbMaKho);
            this.gxBxForm_ThemPX.Controls.Add(this.txtbMaPX);
            this.gxBxForm_ThemPX.Controls.Add(mANVLabel);
            this.gxBxForm_ThemPX.Controls.Add(nGAYLabel);
            this.gxBxForm_ThemPX.Controls.Add(this.txtbMaNV);
            this.gxBxForm_ThemPX.Controls.Add(this.dateEdNgayLap);
            this.gxBxForm_ThemPX.Controls.Add(nhaCCLabel);
            this.gxBxForm_ThemPX.Controls.Add(this.txtbHoTenKH);
            this.gxBxForm_ThemPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxBxForm_ThemPX.Location = new System.Drawing.Point(0, 0);
            this.gxBxForm_ThemPX.Name = "gxBxForm_ThemPX";
            this.gxBxForm_ThemPX.Size = new System.Drawing.Size(274, 282);
            this.gxBxForm_ThemPX.TabIndex = 15;
            this.gxBxForm_ThemPX.TabStop = false;
            // 
            // btnThemPX
            // 
            this.btnThemPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPX.Location = new System.Drawing.Point(136, 241);
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.Size = new System.Drawing.Size(73, 26);
            this.btnThemPX.TabIndex = 11;
            this.btnThemPX.Text = "Thêm";
            this.btnThemPX.UseVisualStyleBackColor = true;
            this.btnThemPX.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm phiếu xuất";
            // 
            // txtbMaKho
            // 
            this.txtbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxBDS, "MAKHO", true));
            this.txtbMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaKho.Location = new System.Drawing.Point(116, 203);
            this.txtbMaKho.Name = "txtbMaKho";
            this.txtbMaKho.ReadOnly = true;
            this.txtbMaKho.Size = new System.Drawing.Size(122, 21);
            this.txtbMaKho.TabIndex = 9;
            this.txtbMaKho.TextChanged += new System.EventHandler(this.txtbMaKho_TextChanged);
            // 
            // pxBDS
            // 
            this.pxBDS.DataMember = "PhieuXuat";
            this.pxBDS.DataSource = this.qlvtDS;
            // 
            // txtbMaPX
            // 
            this.txtbMaPX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxBDS, "MAPX", true));
            this.txtbMaPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaPX.Location = new System.Drawing.Point(116, 59);
            this.txtbMaPX.MaxLength = 8;
            this.txtbMaPX.Name = "txtbMaPX";
            this.txtbMaPX.Size = new System.Drawing.Size(122, 21);
            this.txtbMaPX.TabIndex = 2;
            this.txtbMaPX.TextChanged += new System.EventHandler(this.txtbMaPX_TextChanged);
            // 
            // txtbMaNV
            // 
            this.txtbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxBDS, "MANV", true));
            this.txtbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaNV.Location = new System.Drawing.Point(116, 167);
            this.txtbMaNV.Name = "txtbMaNV";
            this.txtbMaNV.ReadOnly = true;
            this.txtbMaNV.Size = new System.Drawing.Size(122, 21);
            this.txtbMaNV.TabIndex = 7;
            // 
            // dateEdNgayLap
            // 
            this.dateEdNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pxBDS, "NGAY", true));
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
            // txtbHoTenKH
            // 
            this.txtbHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pxBDS, "HOTENKH", true));
            this.txtbHoTenKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbHoTenKH.Location = new System.Drawing.Point(116, 131);
            this.txtbHoTenKH.Name = "txtbHoTenKH";
            this.txtbHoTenKH.Size = new System.Drawing.Size(122, 23);
            this.txtbHoTenKH.TabIndex = 5;
            this.txtbHoTenKH.TextChanged += new System.EventHandler(this.txtbHoTenKH_TextChanged);
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
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            // 
            // subFormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 282);
            this.Controls.Add(this.grBxKho_ThemPX);
            this.Controls.Add(this.gxBxForm_ThemPX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormPX_FormClosing);
            this.Load += new System.EventHandler(this.subFormPX_Load);
            this.Shown += new System.EventHandler(this.subFormPX_Shown);
            this.grBxKho_ThemPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlKho_ThemPX)).EndInit();
            this.grCtrlKho_ThemPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemPX)).EndInit();
            this.gxBxForm_ThemPX.ResumeLayout(false);
            this.gxBxForm_ThemPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayLap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxKho_ThemPX;
        private DevExpress.XtraEditors.GroupControl grCtrlKho_ThemPX;
        private DevExpress.XtraGrid.GridControl grdCtrlKho_ThemPX;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwKho_ThemPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox gxBxForm_ThemPX;
        private System.Windows.Forms.Button btnThemPX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMaKho;
        private System.Windows.Forms.TextBox txtbMaPX;
        private System.Windows.Forms.TextBox txtbMaNV;
        private DevExpress.XtraEditors.DateEdit dateEdNgayLap;
        private System.Windows.Forms.TextBox txtbHoTenKH;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource khoBDS;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource pxBDS;
        private System.Windows.Forms.Button btnThoat;
    }
}