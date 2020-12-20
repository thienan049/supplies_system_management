namespace QLVT_PT_DevExpressPJ.reports.subformsRP
{
    partial class subFormTongHopNX_RP
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
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEdNgaySau = new DevExpress.XtraEditors.DateEdit();
            this.btnXem = new System.Windows.Forms.Button();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdNgayTruoc = new DevExpress.XtraEditors.DateEdit();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCN = new DevExpress.Utils.Layout.StackPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxTenCN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgaySau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgaySau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayTruoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayTruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).BeginInit();
            this.panelCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.label4);
            this.stackPanel3.Controls.Add(this.dateEdNgaySau);
            this.stackPanel3.Location = new System.Drawing.Point(317, 113);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(185, 28);
            this.stackPanel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến ngày:";
            // 
            // dateEdNgaySau
            // 
            this.dateEdNgaySau.EditValue = null;
            this.dateEdNgaySau.Location = new System.Drawing.Point(80, 4);
            this.dateEdNgaySau.Name = "dateEdNgaySau";
            this.dateEdNgaySau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdNgaySau.Properties.Appearance.Options.UseFont = true;
            this.dateEdNgaySau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgaySau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgaySau.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdNgaySau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdNgaySau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdNgaySau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdNgaySau.Properties.MinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateEdNgaySau.Size = new System.Drawing.Size(90, 20);
            this.dateEdNgaySau.TabIndex = 9;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(236, 157);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.label1);
            this.stackPanel2.Controls.Add(this.dateEdNgayTruoc);
            this.stackPanel2.Location = new System.Drawing.Point(140, 113);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(171, 28);
            this.stackPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày:";
            // 
            // dateEdNgayTruoc
            // 
            this.dateEdNgayTruoc.EditValue = null;
            this.dateEdNgayTruoc.Location = new System.Drawing.Point(72, 4);
            this.dateEdNgayTruoc.Name = "dateEdNgayTruoc";
            this.dateEdNgayTruoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdNgayTruoc.Properties.Appearance.Options.UseFont = true;
            this.dateEdNgayTruoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayTruoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdNgayTruoc.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdNgayTruoc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdNgayTruoc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdNgayTruoc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdNgayTruoc.Properties.MinValue = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateEdNgayTruoc.Size = new System.Drawing.Size(90, 20);
            this.dateEdNgayTruoc.TabIndex = 8;
            this.dateEdNgayTruoc.EditValueChanged += new System.EventHandler(this.dateEdNgayTruoc_EditValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(364, 157);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "TỔNG HỢP NHẬP XUẤT";
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.label7);
            this.panelCN.Controls.Add(this.cbxTenCN);
            this.panelCN.Location = new System.Drawing.Point(104, 75);
            this.panelCN.Name = "panelCN";
            this.panelCN.Size = new System.Drawing.Size(398, 28);
            this.panelCN.TabIndex = 19;
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
            this.cbxTenCN.Size = new System.Drawing.Size(274, 22);
            this.cbxTenCN.TabIndex = 2;
            this.cbxTenCN.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_SelectedIndexChanged);
            // 
            // subFormTongHopNX_RP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 199);
            this.Controls.Add(this.panelCN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stackPanel3);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.stackPanel2);
            this.Controls.Add(this.btnThoat);
            this.Name = "subFormTongHopNX_RP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tổng hợp nhập xuất theo ngày";
            this.Load += new System.EventHandler(this.subFormTongHopNX_RP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgaySau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgaySau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayTruoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdNgayTruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXem;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private DevExpress.Utils.Layout.StackPanel panelCN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTenCN;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdNgaySau;
        private DevExpress.XtraEditors.DateEdit dateEdNgayTruoc;
    }
}