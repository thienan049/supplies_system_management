namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormCTDDH
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormCTDDH));
            this.grBxVattu_ThemCTDDH = new System.Windows.Forms.GroupBox();
            this.grCtrlVattu = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlVattu = new DevExpress.XtraGrid.GridControl();
            this.vtBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.grdVwVattu_ThemCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBxForm_ThemCTDDH = new System.Windows.Forms.GroupBox();
            this.numUDDonGia = new System.Windows.Forms.NumericUpDown();
            this.ctddhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.numUDSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtbMaVT = new System.Windows.Forms.TextBox();
            this.txtbMaSoDDH = new System.Windows.Forms.TextBox();
            this.btnThemCTDDH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctddhTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.vatTuTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            this.grBxVattu_ThemCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVattu)).BeginInit();
            this.grCtrlVattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTDDH)).BeginInit();
            this.grBxForm_ThemCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(64, 181);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 14;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(57, 143);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(64, 16);
            sOLUONGLabel.TabIndex = 13;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(57, 106);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(64, 16);
            mAVTLabel.TabIndex = 12;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(40, 68);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 16);
            masoDDHLabel.TabIndex = 11;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // grBxVattu_ThemCTDDH
            // 
            this.grBxVattu_ThemCTDDH.Controls.Add(this.grCtrlVattu);
            this.grBxVattu_ThemCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxVattu_ThemCTDDH.Location = new System.Drawing.Point(314, 0);
            this.grBxVattu_ThemCTDDH.Name = "grBxVattu_ThemCTDDH";
            this.grBxVattu_ThemCTDDH.Size = new System.Drawing.Size(527, 262);
            this.grBxVattu_ThemCTDDH.TabIndex = 16;
            this.grBxVattu_ThemCTDDH.TabStop = false;
            // 
            // grCtrlVattu
            // 
            this.grCtrlVattu.Controls.Add(this.grdCtrlVattu);
            this.grCtrlVattu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlVattu.Location = new System.Drawing.Point(3, 16);
            this.grCtrlVattu.Name = "grCtrlVattu";
            this.grCtrlVattu.Size = new System.Drawing.Size(521, 243);
            this.grCtrlVattu.TabIndex = 0;
            this.grCtrlVattu.Text = "Danh sách vật tư";
            // 
            // grdCtrlVattu
            // 
            this.grdCtrlVattu.DataSource = this.vtBDS;
            this.grdCtrlVattu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlVattu.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlVattu.MainView = this.grdVwVattu_ThemCTDDH;
            this.grdCtrlVattu.Name = "grdCtrlVattu";
            this.grdCtrlVattu.Size = new System.Drawing.Size(517, 218);
            this.grdCtrlVattu.TabIndex = 0;
            this.grdCtrlVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwVattu_ThemCTDDH});
            // 
            // vtBDS
            // 
            this.vtBDS.DataMember = "Vattu";
            this.vtBDS.DataSource = this.qlvtDS;
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdVwVattu_ThemCTDDH
            // 
            this.grdVwVattu_ThemCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT});
            this.grdVwVattu_ThemCTDDH.GridControl = this.grdCtrlVattu;
            this.grdVwVattu_ThemCTDDH.Name = "grdVwVattu_ThemCTDDH";
            this.grdVwVattu_ThemCTDDH.OptionsBehavior.Editable = false;
            this.grdVwVattu_ThemCTDDH.OptionsView.ShowDetailButtons = false;
            this.grdVwVattu_ThemCTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwVattu_ThemCTDDH_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 86;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 307;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 101;
            // 
            // grBxForm_ThemCTDDH
            // 
            this.grBxForm_ThemCTDDH.Controls.Add(dONGIALabel);
            this.grBxForm_ThemCTDDH.Controls.Add(this.numUDDonGia);
            this.grBxForm_ThemCTDDH.Controls.Add(sOLUONGLabel);
            this.grBxForm_ThemCTDDH.Controls.Add(this.numUDSoluong);
            this.grBxForm_ThemCTDDH.Controls.Add(mAVTLabel);
            this.grBxForm_ThemCTDDH.Controls.Add(this.txtbMaVT);
            this.grBxForm_ThemCTDDH.Controls.Add(masoDDHLabel);
            this.grBxForm_ThemCTDDH.Controls.Add(this.txtbMaSoDDH);
            this.grBxForm_ThemCTDDH.Controls.Add(this.btnThemCTDDH);
            this.grBxForm_ThemCTDDH.Controls.Add(this.label1);
            this.grBxForm_ThemCTDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBxForm_ThemCTDDH.Location = new System.Drawing.Point(0, 0);
            this.grBxForm_ThemCTDDH.Name = "grBxForm_ThemCTDDH";
            this.grBxForm_ThemCTDDH.Size = new System.Drawing.Size(314, 262);
            this.grBxForm_ThemCTDDH.TabIndex = 15;
            this.grBxForm_ThemCTDDH.TabStop = false;
            // 
            // numUDDonGia
            // 
            this.numUDDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctddhBDS, "DONGIA", true));
            this.numUDDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDDonGia.Location = new System.Drawing.Point(127, 179);
            this.numUDDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUDDonGia.Name = "numUDDonGia";
            this.numUDDonGia.Size = new System.Drawing.Size(123, 21);
            this.numUDDonGia.TabIndex = 15;
            this.numUDDonGia.ValueChanged += new System.EventHandler(this.numUDDonGia_ValueChanged);
            // 
            // ctddhBDS
            // 
            this.ctddhBDS.DataMember = "CTDDH";
            this.ctddhBDS.DataSource = this.qlvtDS;
            // 
            // numUDSoluong
            // 
            this.numUDSoluong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctddhBDS, "SOLUONG", true));
            this.numUDSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDSoluong.Location = new System.Drawing.Point(127, 141);
            this.numUDSoluong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUDSoluong.Name = "numUDSoluong";
            this.numUDSoluong.Size = new System.Drawing.Size(123, 21);
            this.numUDSoluong.TabIndex = 14;
            this.numUDSoluong.ThousandsSeparator = true;
            this.numUDSoluong.ValueChanged += new System.EventHandler(this.numUDSoluong_ValueChanged);
            // 
            // txtbMaVT
            // 
            this.txtbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctddhBDS, "MAVT", true));
            this.txtbMaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaVT.Location = new System.Drawing.Point(127, 103);
            this.txtbMaVT.Name = "txtbMaVT";
            this.txtbMaVT.ReadOnly = true;
            this.txtbMaVT.Size = new System.Drawing.Size(123, 21);
            this.txtbMaVT.TabIndex = 13;
            this.txtbMaVT.TextChanged += new System.EventHandler(this.txtbMaVT_TextChanged);
            // 
            // txtbMaSoDDH
            // 
            this.txtbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctddhBDS, "MasoDDH", true));
            this.txtbMaSoDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaSoDDH.Location = new System.Drawing.Point(127, 65);
            this.txtbMaSoDDH.Name = "txtbMaSoDDH";
            this.txtbMaSoDDH.ReadOnly = true;
            this.txtbMaSoDDH.Size = new System.Drawing.Size(123, 21);
            this.txtbMaSoDDH.TabIndex = 12;
            // 
            // btnThemCTDDH
            // 
            this.btnThemCTDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTDDH.Location = new System.Drawing.Point(153, 218);
            this.btnThemCTDDH.Name = "btnThemCTDDH";
            this.btnThemCTDDH.Size = new System.Drawing.Size(76, 26);
            this.btnThemCTDDH.TabIndex = 11;
            this.btnThemCTDDH.Text = "Thêm";
            this.btnThemCTDDH.UseVisualStyleBackColor = true;
            this.btnThemCTDDH.Click += new System.EventHandler(this.btnThemCTDDH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm chi tiết đơn đặt hàng";
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.ctddhTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vatTuTableAdapter;
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            // 
            // subFormCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 262);
            this.Controls.Add(this.grBxVattu_ThemCTDDH);
            this.Controls.Add(this.grBxForm_ThemCTDDH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormCTDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm chi tiết đơn đặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormCTDDH_FormClosing);
            this.Load += new System.EventHandler(this.subFormCTDDH_Load);
            this.Shown += new System.EventHandler(this.subFormCTDDH_Shown);
            this.grBxVattu_ThemCTDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVattu)).EndInit();
            this.grCtrlVattu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTDDH)).EndInit();
            this.grBxForm_ThemCTDDH.ResumeLayout(false);
            this.grBxForm_ThemCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxVattu_ThemCTDDH;
        private DevExpress.XtraGrid.GridControl grdCtrlVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwVattu_ThemCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private System.Windows.Forms.GroupBox grBxForm_ThemCTDDH;
        private System.Windows.Forms.NumericUpDown numUDDonGia;
        private System.Windows.Forms.NumericUpDown numUDSoluong;
        private System.Windows.Forms.TextBox txtbMaVT;
        private System.Windows.Forms.TextBox txtbMaSoDDH;
        private System.Windows.Forms.Button btnThemCTDDH;
        private System.Windows.Forms.Label label1;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource ctddhBDS;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.VattuTableAdapter vatTuTableAdapter;
        private System.Windows.Forms.BindingSource vtBDS;
        private DevExpress.XtraEditors.GroupControl grCtrlVattu;
        private System.Windows.Forms.Button btnThoat;
    }
}