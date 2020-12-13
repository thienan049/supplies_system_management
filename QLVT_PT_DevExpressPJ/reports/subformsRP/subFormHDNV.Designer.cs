namespace QLVT_PT_DevExpressPJ.reports.subformsRP
{
    partial class subFormHDNV
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
            System.Windows.Forms.Label hOTENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormHDNV));
            this.label1 = new System.Windows.Forms.Label();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxThangSau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNamSau = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxThangTruoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNamTruoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager();
            this.panelCN = new DevExpress.Utils.Layout.StackPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTenCN = new System.Windows.Forms.ComboBox();
            this.hotenNVBDS = new System.Windows.Forms.BindingSource(this.components);
            this.hoTenNVTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.HoTenNVTableAdapter();
            this.hOTENLabel1 = new System.Windows.Forms.Label();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).BeginInit();
            this.panelCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotenNVBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.label4);
            this.stackPanel3.Controls.Add(this.cbxThangSau);
            this.stackPanel3.Controls.Add(this.label5);
            this.stackPanel3.Controls.Add(this.cbxNamSau);
            this.stackPanel3.Location = new System.Drawing.Point(186, 195);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(314, 28);
            this.stackPanel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến tháng:";
            // 
            // cbxThangSau
            // 
            this.cbxThangSau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThangSau.FormattingEnabled = true;
            this.cbxThangSau.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThangSau.Location = new System.Drawing.Point(88, 2);
            this.cbxThangSau.Margin = new System.Windows.Forms.Padding(4);
            this.cbxThangSau.Name = "cbxThangSau";
            this.cbxThangSau.Size = new System.Drawing.Size(79, 23);
            this.cbxThangSau.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm:";
            // 
            // cbxNamSau
            // 
            this.cbxNamSau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNamSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamSau.FormattingEnabled = true;
            this.cbxNamSau.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbxNamSau.Location = new System.Drawing.Point(220, 2);
            this.cbxNamSau.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNamSau.Name = "cbxNamSau";
            this.cbxNamSau.Size = new System.Drawing.Size(82, 23);
            this.cbxNamSau.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(278, 245);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.label3);
            this.stackPanel2.Controls.Add(this.cbxThangTruoc);
            this.stackPanel2.Controls.Add(this.label6);
            this.stackPanel2.Controls.Add(this.cbxNamTruoc);
            this.stackPanel2.Location = new System.Drawing.Point(193, 156);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(307, 28);
            this.stackPanel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ tháng:";
            // 
            // cbxThangTruoc
            // 
            this.cbxThangTruoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThangTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThangTruoc.FormattingEnabled = true;
            this.cbxThangTruoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThangTruoc.Location = new System.Drawing.Point(80, 2);
            this.cbxThangTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxThangTruoc.Name = "cbxThangTruoc";
            this.cbxThangTruoc.Size = new System.Drawing.Size(80, 23);
            this.cbxThangTruoc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Năm:";
            // 
            // cbxNamTruoc
            // 
            this.cbxNamTruoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNamTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamTruoc.FormattingEnabled = true;
            this.cbxNamTruoc.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbxNamTruoc.Location = new System.Drawing.Point(213, 2);
            this.cbxNamTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNamTruoc.Name = "cbxNamTruoc";
            this.cbxNamTruoc.Size = new System.Drawing.Size(82, 23);
            this.cbxNamTruoc.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(406, 245);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.label2);
            this.stackPanel1.Controls.Add(this.cbxMaNV);
            this.stackPanel1.Controls.Add(hOTENLabel);
            this.stackPanel1.Controls.Add(this.hOTENLabel1);
            this.stackPanel1.Location = new System.Drawing.Point(168, 116);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(491, 28);
            this.stackPanel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên:";
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.label7);
            this.panelCN.Controls.Add(this.cbxTenCN);
            this.panelCN.Location = new System.Drawing.Point(163, 75);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(337, 28);
            this.panelCN.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên chi nhánh:";
            // 
            // cbxTenCN
            // 
            this.cbxTenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenCN.FormattingEnabled = true;
            this.cbxTenCN.Location = new System.Drawing.Point(109, 3);
            this.cbxTenCN.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenCN.Name = "cbxTenCN";
            this.cbxTenCN.Size = new System.Drawing.Size(216, 22);
            this.cbxTenCN.TabIndex = 2;
            this.cbxTenCN.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_SelectedIndexChanged);
            // 
            // hotenNVBDS
            // 
            this.hotenNVBDS.DataMember = "HoTenNV";
            this.hotenNVBDS.DataSource = this.qlvtDS;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(191, 7);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(53, 14);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "Họ tên:";
            // 
            // hOTENLabel1
            // 
            this.hOTENLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotenNVBDS, "HOTEN", true));
            this.hOTENLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENLabel1.Location = new System.Drawing.Point(250, 5);
            this.hOTENLabel1.Name = "hOTENLabel1";
            this.hOTENLabel1.Size = new System.Drawing.Size(238, 18);
            this.stackPanel1.SetStretched(this.hOTENLabel1, true);
            this.hOTENLabel1.TabIndex = 5;
            this.hOTENLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.DataSource = this.hotenNVBDS;
            this.cbxMaNV.DisplayMember = "MANV";
            this.cbxMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(104, 3);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(81, 22);
            this.cbxMaNV.TabIndex = 6;
            this.cbxMaNV.ValueMember = "MANV";
            // 
            // subFormHDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 292);
            this.Controls.Add(this.panelCN);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.stackPanel3);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.stackPanel2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormHDNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê hoạt động nhân viên theo tháng";
            this.Load += new System.EventHandler(this.subFormHDNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotenNVBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxThangSau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNamSau;
        private System.Windows.Forms.Button btnXem;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxThangTruoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxNamTruoc;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.Label label2;
        private QLVTDataSet qlvtDS;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.Utils.Layout.StackPanel panelCN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTenCN;
        private System.Windows.Forms.BindingSource hotenNVBDS;
        private QLVTDataSetTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private System.Windows.Forms.Label hOTENLabel1;
        private System.Windows.Forms.ComboBox cbxMaNV;
    }
}