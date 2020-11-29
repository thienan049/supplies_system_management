namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormDDH
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormDDH));
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.dhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.txtbMaSoDDH = new System.Windows.Forms.TextBox();
            this.dateEdNgayDat = new DevExpress.XtraEditors.DateEdit();
            this.txtbNhaCC = new System.Windows.Forms.TextBox();
            this.txtbMaNV = new System.Windows.Forms.TextBox();
            this.txtbMaKho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gxBxForm_ThemDDH = new System.Windows.Forms.GroupBox();
            this.btnThemDDH = new System.Windows.Forms.Button();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.grdCtrlKho_ThemDDH = new DevExpress.XtraGrid.GridControl();
            this.grdVwKho_ThemDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBxKho_ThemDDH = new System.Windows.Forms.GroupBox();
            this.grCtrlThemDDH = new DevExpress.XtraEditors.GroupControl();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            //////////////////////////////////////////
            this.btnThoat = new System.Windows.Forms.Button();
            /////////////////////////////////////////
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayDat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayDat.Properties)).BeginInit();
            this.gxBxForm_ThemDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemDDH)).BeginInit();
            this.grBxKho_ThemDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThemDDH)).BeginInit();
            this.grCtrlThemDDH.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(35, 60);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 16);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(50, 96);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(66, 16);
            nGAYLabel.TabIndex = 3;
            nGAYLabel.Text = "Ngày đặt:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhaCCLabel.Location = new System.Drawing.Point(22, 132);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(94, 16);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(26, 168);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(90, 16);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã nhân viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(61, 204);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(55, 16);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dhBDS
            // 
            this.dhBDS.DataMember = "DatHang";
            this.dhBDS.DataSource = this.qlvtDS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // txtbMaSoDDH
            // 
            this.txtbMaSoDDH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhBDS, "MasoDDH", true));
            this.txtbMaSoDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaSoDDH.Location = new System.Drawing.Point(122, 57);
            this.txtbMaSoDDH.MaxLength = 8;
            this.txtbMaSoDDH.Name = "txtbMaSoDDH";
            this.txtbMaSoDDH.Size = new System.Drawing.Size(122, 21);
            this.txtbMaSoDDH.TabIndex = 2;
            this.txtbMaSoDDH.TextChanged += new System.EventHandler(this.txtbMaSoDDH_TextChanged);
            // 
            // dateEdNgayDat
            // 
            this.dateEdNgayDat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dhBDS, "NGAY", true));
            this.dateEdNgayDat.EditValue = null;
            this.dateEdNgayDat.Location = new System.Drawing.Point(122, 93);
            this.dateEdNgayDat.Name = "dateEdNgayDat";
            this.dateEdNgayDat.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdNgayDat.Properties.Appearance.Options.UseFont = true;
            this.dateEdNgayDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayDat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayDat.Size = new System.Drawing.Size(122, 22);
            this.dateEdNgayDat.TabIndex = 4;
            this.dateEdNgayDat.TextChanged += new System.EventHandler(this.dateEdNgayDat_TextChanged);
            // 
            // txtbNhaCC
            // 
            this.txtbNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhBDS, "NhaCC", true));
            this.txtbNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNhaCC.Location = new System.Drawing.Point(122, 129);
            this.txtbNhaCC.Name = "txtbNhaCC";
            this.txtbNhaCC.Size = new System.Drawing.Size(122, 21);
            this.txtbNhaCC.TabIndex = 5;
            this.txtbNhaCC.TextChanged += new System.EventHandler(this.txtbNhaCC_TextChanged);
            // 
            // txtbMaNV
            // 
            this.txtbMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhBDS, "MANV", true));
            this.txtbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaNV.Location = new System.Drawing.Point(122, 165);
            this.txtbMaNV.Name = "txtbMaNV";
            this.txtbMaNV.ReadOnly = true;
            this.txtbMaNV.Size = new System.Drawing.Size(122, 21);
            this.txtbMaNV.TabIndex = 7;
            // 
            // txtbMaKho
            // 
            this.txtbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dhBDS, "MAKHO", true));
            this.txtbMaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaKho.Location = new System.Drawing.Point(122, 201);
            this.txtbMaKho.Name = "txtbMaKho";
            this.txtbMaKho.ReadOnly = true;
            this.txtbMaKho.Size = new System.Drawing.Size(122, 21);
            this.txtbMaKho.TabIndex = 9;
            this.txtbMaKho.TextChanged += new System.EventHandler(this.txtbMaKho_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm đơn đặt hàng";
            // 
            // gxBxForm_ThemDDH
            // 
            this.gxBxForm_ThemDDH.Controls.Add(this.btnThemDDH);
            this.gxBxForm_ThemDDH.Controls.Add(this.label1);
            this.gxBxForm_ThemDDH.Controls.Add(mAKHOLabel);
            this.gxBxForm_ThemDDH.Controls.Add(masoDDHLabel);
            this.gxBxForm_ThemDDH.Controls.Add(this.txtbMaKho);
            this.gxBxForm_ThemDDH.Controls.Add(this.txtbMaSoDDH);
            this.gxBxForm_ThemDDH.Controls.Add(mANVLabel);
            this.gxBxForm_ThemDDH.Controls.Add(nGAYLabel);
            this.gxBxForm_ThemDDH.Controls.Add(this.txtbMaNV);
            this.gxBxForm_ThemDDH.Controls.Add(this.dateEdNgayDat);
            this.gxBxForm_ThemDDH.Controls.Add(nhaCCLabel);
            this.gxBxForm_ThemDDH.Controls.Add(this.txtbNhaCC);
            this.gxBxForm_ThemDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gxBxForm_ThemDDH.Location = new System.Drawing.Point(0, 0);
            this.gxBxForm_ThemDDH.Name = "gxBxForm_ThemDDH";
            this.gxBxForm_ThemDDH.Size = new System.Drawing.Size(308, 281);
            this.gxBxForm_ThemDDH.TabIndex = 11;
            this.gxBxForm_ThemDDH.TabStop = false;
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDDH.Location = new System.Drawing.Point(143, 237);
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.Size = new System.Drawing.Size(75, 26);
            this.btnThemDDH.TabIndex = 11;
            this.btnThemDDH.Text = "Thêm";
            this.btnThemDDH.UseVisualStyleBackColor = true;
            this.btnThemDDH.Click += new System.EventHandler(this.btnThemDDH_Click);
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
            // grdCtrlKho_ThemDDH
            // 
            this.grdCtrlKho_ThemDDH.DataSource = this.khoBDS;
            this.grdCtrlKho_ThemDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlKho_ThemDDH.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlKho_ThemDDH.MainView = this.grdVwKho_ThemDDH;
            this.grdCtrlKho_ThemDDH.Name = "grdCtrlKho_ThemDDH";
            this.grdCtrlKho_ThemDDH.Size = new System.Drawing.Size(523, 237);
            this.grdCtrlKho_ThemDDH.TabIndex = 11;
            this.grdCtrlKho_ThemDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwKho_ThemDDH});
            // 
            // grdVwKho_ThemDDH
            // 
            this.grdVwKho_ThemDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.grdVwKho_ThemDDH.GridControl = this.grdCtrlKho_ThemDDH;
            this.grdVwKho_ThemDDH.Name = "grdVwKho_ThemDDH";
            this.grdVwKho_ThemDDH.OptionsBehavior.Editable = false;
            this.grdVwKho_ThemDDH.OptionsView.ShowDetailButtons = false;
            this.grdVwKho_ThemDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwKho_ThemDDH_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 109;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 129;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 173;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 91;
            // 
            // grBxKho_ThemDDH
            // 
            this.grBxKho_ThemDDH.Controls.Add(this.grCtrlThemDDH);
            this.grBxKho_ThemDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxKho_ThemDDH.Location = new System.Drawing.Point(308, 0);
            this.grBxKho_ThemDDH.Name = "grBxKho_ThemDDH";
            this.grBxKho_ThemDDH.Size = new System.Drawing.Size(533, 281);
            this.grBxKho_ThemDDH.TabIndex = 12;
            this.grBxKho_ThemDDH.TabStop = false;
            // 
            // grCtrlThemDDH
            // 
            this.grCtrlThemDDH.Controls.Add(this.grdCtrlKho_ThemDDH);
            this.grCtrlThemDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlThemDDH.Location = new System.Drawing.Point(3, 16);
            this.grCtrlThemDDH.Name = "grCtrlThemDDH";
            this.grCtrlThemDDH.Size = new System.Drawing.Size(527, 262);
            this.grCtrlThemDDH.TabIndex = 0;
            this.grCtrlThemDDH.Text = "Danh sách kho";
            // 
            // subFormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 281);
            this.Controls.Add(this.grBxKho_ThemDDH);
            this.Controls.Add(this.gxBxForm_ThemDDH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm đơn đặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormDDH_FormClosing);
            this.Load += new System.EventHandler(this.subFormDDH_Load);
            this.Shown += new System.EventHandler(this.subFormDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dhBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayDat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayDat.Properties)).EndInit();
            this.gxBxForm_ThemDDH.ResumeLayout(false);
            this.gxBxForm_ThemDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlKho_ThemDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwKho_ThemDDH)).EndInit();
            this.grBxKho_ThemDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlThemDDH)).EndInit();
            this.grCtrlThemDDH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource dhBDS;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbMaSoDDH;
        private DevExpress.XtraEditors.DateEdit dateEdNgayDat;
        private System.Windows.Forms.TextBox txtbNhaCC;
        private System.Windows.Forms.TextBox txtbMaNV;
        private System.Windows.Forms.TextBox txtbMaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gxBxForm_ThemDDH;
        private System.Windows.Forms.BindingSource khoBDS;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.GroupBox grBxKho_ThemDDH;
        private System.Windows.Forms.Button btnThemDDH;
        private DevExpress.XtraGrid.GridControl grdCtrlKho_ThemDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwKho_ThemDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.GroupControl grCtrlThemDDH;
        private System.Windows.Forms.Button btnThoat;
    }
}