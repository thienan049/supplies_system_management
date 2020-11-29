namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormCTPX
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
            System.Windows.Forms.Label maPNLabel;
            this.grBxVattu_ThemCTPX = new System.Windows.Forms.GroupBox();
            this.grCtrlVT_ThemCTPX = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlVattu = new DevExpress.XtraGrid.GridControl();
            this.vtBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.grdVwVattu_ThemCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBxForm_ThemCTPX = new System.Windows.Forms.GroupBox();
            this.numUDDonGia = new System.Windows.Forms.NumericUpDown();
            this.ctpxBDS = new System.Windows.Forms.BindingSource(this.components);
            this.numUDSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtbMaVT = new System.Windows.Forms.TextBox();
            this.txtbMaPX = new System.Windows.Forms.TextBox();
            this.btnThemCTPX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vatTuTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.ctpxTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTPXTableAdapter();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            maPNLabel = new System.Windows.Forms.Label();
            //////////////////////////////////////////
            this.btnThoat = new System.Windows.Forms.Button();
            /////////////////////////////////////////
            this.grBxVattu_ThemCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVT_ThemCTPX)).BeginInit();
            this.grCtrlVT_ThemCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTPX)).BeginInit();
            this.grBxForm_ThemCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(65, 182);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 14;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(58, 144);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(64, 16);
            sOLUONGLabel.TabIndex = 13;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.Location = new System.Drawing.Point(58, 107);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(64, 16);
            mAVTLabel.TabIndex = 12;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // maPNLabel
            // 
            maPNLabel.AutoSize = true;
            maPNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maPNLabel.Location = new System.Drawing.Point(29, 69);
            maPNLabel.Name = "maPNLabel";
            maPNLabel.Size = new System.Drawing.Size(93, 16);
            maPNLabel.TabIndex = 11;
            maPNLabel.Text = "Mã phiếu xuất:";
            // 
            // grBxVattu_ThemCTPX
            // 
            this.grBxVattu_ThemCTPX.Controls.Add(this.grCtrlVT_ThemCTPX);
            this.grBxVattu_ThemCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxVattu_ThemCTPX.Location = new System.Drawing.Point(314, 0);
            this.grBxVattu_ThemCTPX.Name = "grBxVattu_ThemCTPX";
            this.grBxVattu_ThemCTPX.Size = new System.Drawing.Size(512, 269);
            this.grBxVattu_ThemCTPX.TabIndex = 20;
            this.grBxVattu_ThemCTPX.TabStop = false;
            // 
            // grCtrlVT_ThemCTPX
            // 
            this.grCtrlVT_ThemCTPX.Controls.Add(this.grdCtrlVattu);
            this.grCtrlVT_ThemCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlVT_ThemCTPX.Location = new System.Drawing.Point(3, 16);
            this.grCtrlVT_ThemCTPX.Name = "grCtrlVT_ThemCTPX";
            this.grCtrlVT_ThemCTPX.Size = new System.Drawing.Size(506, 250);
            this.grCtrlVT_ThemCTPX.TabIndex = 0;
            this.grCtrlVT_ThemCTPX.Text = "Danh sách vật tư";
            // 
            // grdCtrlVattu
            // 
            this.grdCtrlVattu.DataSource = this.vtBDS;
            this.grdCtrlVattu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlVattu.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlVattu.MainView = this.grdVwVattu_ThemCTPX;
            this.grdCtrlVattu.Name = "grdCtrlVattu";
            this.grdCtrlVattu.Size = new System.Drawing.Size(502, 225);
            this.grdCtrlVattu.TabIndex = 0;
            this.grdCtrlVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwVattu_ThemCTPX});
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
            // grdVwVattu_ThemCTPX
            // 
            this.grdVwVattu_ThemCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT});
            this.grdVwVattu_ThemCTPX.GridControl = this.grdCtrlVattu;
            this.grdVwVattu_ThemCTPX.Name = "grdVwVattu_ThemCTPX";
            this.grdVwVattu_ThemCTPX.OptionsBehavior.Editable = false;
            this.grdVwVattu_ThemCTPX.OptionsView.ShowDetailButtons = false;
            this.grdVwVattu_ThemCTPX.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwVattu_ThemCTPX_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 147;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 263;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 85;
            // 
            // grBxForm_ThemCTPX
            // 
            this.grBxForm_ThemCTPX.Controls.Add(dONGIALabel);
            this.grBxForm_ThemCTPX.Controls.Add(this.numUDDonGia);
            this.grBxForm_ThemCTPX.Controls.Add(sOLUONGLabel);
            this.grBxForm_ThemCTPX.Controls.Add(this.numUDSoluong);
            this.grBxForm_ThemCTPX.Controls.Add(mAVTLabel);
            this.grBxForm_ThemCTPX.Controls.Add(this.txtbMaVT);
            this.grBxForm_ThemCTPX.Controls.Add(maPNLabel);
            this.grBxForm_ThemCTPX.Controls.Add(this.txtbMaPX);
            this.grBxForm_ThemCTPX.Controls.Add(this.btnThemCTPX);
            this.grBxForm_ThemCTPX.Controls.Add(this.label1);
            this.grBxForm_ThemCTPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBxForm_ThemCTPX.Location = new System.Drawing.Point(0, 0);
            this.grBxForm_ThemCTPX.Name = "grBxForm_ThemCTPX";
            this.grBxForm_ThemCTPX.Size = new System.Drawing.Size(314, 269);
            this.grBxForm_ThemCTPX.TabIndex = 19;
            this.grBxForm_ThemCTPX.TabStop = false;
            // 
            // numUDDonGia
            // 
            this.numUDDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctpxBDS, "DONGIA", true));
            this.numUDDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDDonGia.Location = new System.Drawing.Point(128, 180);
            this.numUDDonGia.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUDDonGia.Name = "numUDDonGia";
            this.numUDDonGia.Size = new System.Drawing.Size(123, 21);
            this.numUDDonGia.TabIndex = 15;
            this.numUDDonGia.ValueChanged += new System.EventHandler(this.numUDDonGia_ValueChanged);
            // 
            // ctpxBDS
            // 
            this.ctpxBDS.DataMember = "CTPX";
            this.ctpxBDS.DataSource = this.qlvtDS;
            // 
            // numUDSoluong
            // 
            this.numUDSoluong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctpxBDS, "SOLUONG", true));
            this.numUDSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDSoluong.Location = new System.Drawing.Point(128, 142);
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
            this.txtbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctpxBDS, "MAVT", true));
            this.txtbMaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaVT.Location = new System.Drawing.Point(128, 104);
            this.txtbMaVT.Name = "txtbMaVT";
            this.txtbMaVT.ReadOnly = true;
            this.txtbMaVT.Size = new System.Drawing.Size(123, 21);
            this.txtbMaVT.TabIndex = 13;
            this.txtbMaVT.TextChanged += new System.EventHandler(this.txtbMaVT_TextChanged);
            // 
            // txtbMaPX
            // 
            this.txtbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctpxBDS, "MAPX", true));
            this.txtbMaPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaPX.Location = new System.Drawing.Point(128, 66);
            this.txtbMaPX.Name = "txtbMaPX";
            this.txtbMaPX.ReadOnly = true;
            this.txtbMaPX.Size = new System.Drawing.Size(123, 21);
            this.txtbMaPX.TabIndex = 12;
            // 
            // btnThemCTPX
            // 
            this.btnThemCTPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPX.Location = new System.Drawing.Point(151, 217);
            this.btnThemCTPX.Name = "btnThemCTPX";
            this.btnThemCTPX.Size = new System.Drawing.Size(78, 25);
            this.btnThemCTPX.TabIndex = 11;
            this.btnThemCTPX.Text = "Thêm";
            this.btnThemCTPX.UseVisualStyleBackColor = true;
            this.btnThemCTPX.Click += new System.EventHandler(this.btnThemCTPX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm chi tiết phiếu xuất";
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.ctpxTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vatTuTableAdapter;
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // subFormCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 269);
            this.Controls.Add(this.grBxVattu_ThemCTPX);
            this.Controls.Add(this.grBxForm_ThemCTPX);
            this.Name = "subFormCTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm chi tiết phiếu xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormCTPX_FormClosing);
            this.Load += new System.EventHandler(this.subFormCTPX_Load);
            this.Shown += new System.EventHandler(this.subFormCTPX_Shown);
            this.grBxVattu_ThemCTPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVT_ThemCTPX)).EndInit();
            this.grCtrlVT_ThemCTPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTPX)).EndInit();
            this.grBxForm_ThemCTPX.ResumeLayout(false);
            this.grBxForm_ThemCTPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpxBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxVattu_ThemCTPX;
        private DevExpress.XtraEditors.GroupControl grCtrlVT_ThemCTPX;
        private DevExpress.XtraGrid.GridControl grdCtrlVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwVattu_ThemCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private System.Windows.Forms.GroupBox grBxForm_ThemCTPX;
        private System.Windows.Forms.NumericUpDown numUDDonGia;
        private System.Windows.Forms.NumericUpDown numUDSoluong;
        private System.Windows.Forms.TextBox txtbMaVT;
        private System.Windows.Forms.TextBox txtbMaPX;
        private System.Windows.Forms.Button btnThemCTPX;
        private System.Windows.Forms.Label label1;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource vtBDS;
        private QLVTDataSetTableAdapters.VattuTableAdapter vatTuTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource ctpxBDS;
        private System.Windows.Forms.Button btnThoat;
    }
}