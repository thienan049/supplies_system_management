namespace QLVT_PT_DevExpressPJ.reports.subformsRP
{
    partial class subFormPhieuLap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormPhieuLap));
            this.panelCN = new DevExpress.Utils.Layout.StackPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTenCN = new System.Windows.Forms.ComboBox();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).BeginInit();
            this.panelCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCN
            // 
            this.panelCN.Controls.Add(this.label2);
            this.panelCN.Controls.Add(this.cbxTenCN);
            this.panelCN.Location = new System.Drawing.Point(69, 73);
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
            // cbxTenCN
            // 
            this.cbxTenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenCN.FormattingEnabled = true;
            this.cbxTenCN.Location = new System.Drawing.Point(109, 2);
            this.cbxTenCN.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenCN.Name = "cbxTenCN";
            this.cbxTenCN.Size = new System.Drawing.Size(265, 24);
            this.cbxTenCN.TabIndex = 2;
            this.cbxTenCN.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_SelectedIndexChanged);
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.label1);
            this.stackPanel1.Controls.Add(this.cbxLoaiPhieu);
            this.stackPanel1.Location = new System.Drawing.Point(91, 123);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(361, 28);
            this.stackPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại phiếu:";
            // 
            // cbxLoaiPhieu
            // 
            this.cbxLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiPhieu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiPhieu.FormattingEnabled = true;
            this.cbxLoaiPhieu.Items.AddRange(new object[] {
            "Phiếu nhập",
            "Phiếu xuất"});
            this.cbxLoaiPhieu.Location = new System.Drawing.Point(86, 2);
            this.cbxLoaiPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLoaiPhieu.Name = "cbxLoaiPhieu";
            this.cbxLoaiPhieu.Size = new System.Drawing.Size(265, 24);
            this.cbxLoaiPhieu.TabIndex = 2;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.label3);
            this.stackPanel2.Controls.Add(this.cbxNam);
            this.stackPanel2.Location = new System.Drawing.Point(127, 171);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(325, 28);
            this.stackPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm:";
            // 
            // cbxNam
            // 
            this.cbxNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNam.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbxNam.Location = new System.Drawing.Point(49, 3);
            this.cbxNam.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(267, 22);
            this.cbxNam.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(217, 215);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(339, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "PHIẾU LẬP THEO LOẠI";
            // 
            // subFormPhieuLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.panelCN);
            this.Controls.Add(this.stackPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subFormPhieuLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin phiếu";
            this.Load += new System.EventHandler(this.subFormPhieuLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelCN)).EndInit();
            this.panelCN.ResumeLayout(false);
            this.panelCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel panelCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTenCN;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLoaiPhieu;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
    }
}