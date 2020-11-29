﻿namespace QLVT_PT_DevExpressPJ.subforms
{
    partial class subFormCTPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormCTPN));
            this.grBxVattu_ThemCTPN = new System.Windows.Forms.GroupBox();
            this.grCtrlVT_ThemCTPN = new DevExpress.XtraEditors.GroupControl();
            this.grdCtrlVattu = new DevExpress.XtraGrid.GridControl();
            this.vtBDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.grdVwVattu_ThemCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBxForm_ThemCTPN = new System.Windows.Forms.GroupBox();
            this.numUDDonGia = new System.Windows.Forms.NumericUpDown();
            this.ctpnBDS = new System.Windows.Forms.BindingSource(this.components);
            this.numUDSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtbMaVT = new System.Windows.Forms.TextBox();
            this.txtbMaPN = new System.Windows.Forms.TextBox();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctpnTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.vatTuTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.VattuTableAdapter();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            maPNLabel = new System.Windows.Forms.Label();
            //////////////////////////////////////////
            this.btnThoat = new System.Windows.Forms.Button();
            /////////////////////////////////////////
            this.grBxVattu_ThemCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVT_ThemCTPN)).BeginInit();
            this.grCtrlVT_ThemCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTPN)).BeginInit();
            this.grBxForm_ThemCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpnBDS)).BeginInit();
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
            maPNLabel.Location = new System.Drawing.Point(23, 69);
            maPNLabel.Name = "maPNLabel";
            maPNLabel.Size = new System.Drawing.Size(99, 16);
            maPNLabel.TabIndex = 11;
            maPNLabel.Text = "Mã phiếu nhập:";
            // 
            // grBxVattu_ThemCTPN
            // 
            this.grBxVattu_ThemCTPN.Controls.Add(this.grCtrlVT_ThemCTPN);
            this.grBxVattu_ThemCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxVattu_ThemCTPN.Location = new System.Drawing.Point(314, 0);
            this.grBxVattu_ThemCTPN.Name = "grBxVattu_ThemCTPN";
            this.grBxVattu_ThemCTPN.Size = new System.Drawing.Size(527, 260);
            this.grBxVattu_ThemCTPN.TabIndex = 18;
            this.grBxVattu_ThemCTPN.TabStop = false;
            // 
            // grCtrlVT_ThemCTPN
            // 
            this.grCtrlVT_ThemCTPN.Controls.Add(this.grdCtrlVattu);
            this.grCtrlVT_ThemCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrlVT_ThemCTPN.Location = new System.Drawing.Point(3, 16);
            this.grCtrlVT_ThemCTPN.Name = "grCtrlVT_ThemCTPN";
            this.grCtrlVT_ThemCTPN.Size = new System.Drawing.Size(521, 241);
            this.grCtrlVT_ThemCTPN.TabIndex = 0;
            this.grCtrlVT_ThemCTPN.Text = "Danh sách vật tư";
            // 
            // grdCtrlVattu
            // 
            this.grdCtrlVattu.DataSource = this.vtBDS;
            this.grdCtrlVattu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrlVattu.Location = new System.Drawing.Point(2, 23);
            this.grdCtrlVattu.MainView = this.grdVwVattu_ThemCTPN;
            this.grdCtrlVattu.Name = "grdCtrlVattu";
            this.grdCtrlVattu.Size = new System.Drawing.Size(517, 216);
            this.grdCtrlVattu.TabIndex = 0;
            this.grdCtrlVattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVwVattu_ThemCTPN});
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
            // grdVwVattu_ThemCTPN
            // 
            this.grdVwVattu_ThemCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT});
            this.grdVwVattu_ThemCTPN.GridControl = this.grdCtrlVattu;
            this.grdVwVattu_ThemCTPN.Name = "grdVwVattu_ThemCTPN";
            this.grdVwVattu_ThemCTPN.OptionsBehavior.Editable = false;
            this.grdVwVattu_ThemCTPN.OptionsView.ShowDetailButtons = false;
            this.grdVwVattu_ThemCTPN.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdVwVattu_ThemCTPN_RowClick);
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
            // grBxForm_ThemCTPN
            // 
            this.grBxForm_ThemCTPN.Controls.Add(dONGIALabel);
            this.grBxForm_ThemCTPN.Controls.Add(this.numUDDonGia);
            this.grBxForm_ThemCTPN.Controls.Add(sOLUONGLabel);
            this.grBxForm_ThemCTPN.Controls.Add(this.numUDSoluong);
            this.grBxForm_ThemCTPN.Controls.Add(mAVTLabel);
            this.grBxForm_ThemCTPN.Controls.Add(this.txtbMaVT);
            this.grBxForm_ThemCTPN.Controls.Add(maPNLabel);
            this.grBxForm_ThemCTPN.Controls.Add(this.txtbMaPN);
            this.grBxForm_ThemCTPN.Controls.Add(this.btnThemCTPN);
            this.grBxForm_ThemCTPN.Controls.Add(this.label1);
            this.grBxForm_ThemCTPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBxForm_ThemCTPN.Location = new System.Drawing.Point(0, 0);
            this.grBxForm_ThemCTPN.Name = "grBxForm_ThemCTPN";
            this.grBxForm_ThemCTPN.Size = new System.Drawing.Size(314, 260);
            this.grBxForm_ThemCTPN.TabIndex = 17;
            this.grBxForm_ThemCTPN.TabStop = false;
            // 
            // numUDDonGia
            // 
            this.numUDDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctpnBDS, "DONGIA", true));
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
            // ctpnBDS
            // 
            this.ctpnBDS.DataMember = "CTPN";
            this.ctpnBDS.DataSource = this.qlvtDS;
            // 
            // numUDSoluong
            // 
            this.numUDSoluong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ctpnBDS, "SOLUONG", true));
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
            this.txtbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctpnBDS, "MAVT", true));
            this.txtbMaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaVT.Location = new System.Drawing.Point(128, 104);
            this.txtbMaVT.Name = "txtbMaVT";
            this.txtbMaVT.ReadOnly = true;
            this.txtbMaVT.Size = new System.Drawing.Size(123, 21);
            this.txtbMaVT.TabIndex = 13;
            this.txtbMaVT.TextChanged += new System.EventHandler(this.txtbMaVT_TextChanged);
            // 
            // txtbMaPN
            // 
            this.txtbMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ctpnBDS, "MAPN", true));
            this.txtbMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaPN.Location = new System.Drawing.Point(128, 66);
            this.txtbMaPN.Name = "txtbMaPN";
            this.txtbMaPN.ReadOnly = true;
            this.txtbMaPN.Size = new System.Drawing.Size(123, 21);
            this.txtbMaPN.TabIndex = 12;
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPN.Location = new System.Drawing.Point(151, 217);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(78, 25);
            this.btnThemCTPN.TabIndex = 11;
            this.btnThemCTPN.Text = "Thêm";
            this.btnThemCTPN.UseVisualStyleBackColor = true;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chinh Luan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thêm chi tiết phiếu nhập";
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.ctpnTableAdapter;
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
            // subFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 260);
            this.Controls.Add(this.grBxVattu_ThemCTPN);
            this.Controls.Add(this.grBxForm_ThemCTPN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm chi tiết phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.subFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.subFormCTPN_Load);
            this.Shown += new System.EventHandler(this.subFormCTPN_Shown);
            this.grBxVattu_ThemCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrlVT_ThemCTPN)).EndInit();
            this.grCtrlVT_ThemCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwVattu_ThemCTPN)).EndInit();
            this.grBxForm_ThemCTPN.ResumeLayout(false);
            this.grBxForm_ThemCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpnBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxVattu_ThemCTPN;
        private DevExpress.XtraGrid.GridControl grdCtrlVattu;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVwVattu_ThemCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private System.Windows.Forms.GroupBox grBxForm_ThemCTPN;
        private System.Windows.Forms.NumericUpDown numUDDonGia;
        private System.Windows.Forms.NumericUpDown numUDSoluong;
        private System.Windows.Forms.TextBox txtbMaVT;
        private System.Windows.Forms.TextBox txtbMaPN;
        private System.Windows.Forms.Button btnThemCTPN;
        private System.Windows.Forms.Label label1;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource ctpnBDS;
        private QLVTDataSetTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.VattuTableAdapter vatTuTableAdapter;
        private System.Windows.Forms.BindingSource vtBDS;
        private DevExpress.XtraEditors.GroupControl grCtrlVT_ThemCTPN;
        private System.Windows.Forms.Button btnThoat;
    }
}