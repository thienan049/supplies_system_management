namespace QLVT_PT_DevExpressPJ
{
    partial class formTaoTaiKhoan
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
            System.Windows.Forms.Label lblTenCN;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTaoTaiKhoan));
            this.eyesImageList = new System.Windows.Forms.ImageList(this.components);
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.v_DSRoles_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDS = new QLVT_PT_DevExpressPJ.QLVTDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDUserID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAndHidePassword = new System.Windows.Forms.Button();
            this.btnThoatDN = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.txtbPassWord = new System.Windows.Forms.TextBox();
            this.txtbLoginName = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.cbxTenCN_TTK = new System.Windows.Forms.ComboBox();
            this.v_DS_ROLESTableAdapter = new QLVT_PT_DevExpressPJ.QLVTDataSetTableAdapters.V_DS_ROLESTableAdapter();
            lblTenCN = new System.Windows.Forms.Label();
            this.grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSRoles_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDUserID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenCN
            // 
            lblTenCN.AutoSize = true;
            lblTenCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            lblTenCN.Location = new System.Drawing.Point(12, 35);
            lblTenCN.Name = "lblTenCN";
            lblTenCN.Size = new System.Drawing.Size(105, 17);
            lblTenCN.TabIndex = 0;
            lblTenCN.Text = "Tên Chi Nhánh:";
            // 
            // eyesImageList
            // 
            this.eyesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eyesImageList.ImageStream")));
            this.eyesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.eyesImageList.Images.SetKeyName(0, "non-eye 22x22.png");
            this.eyesImageList.Images.SetKeyName(1, "eye 22x22.png");
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDangNhap.Controls.Add(this.cbxRoles);
            this.grbDangNhap.Controls.Add(this.label2);
            this.grbDangNhap.Controls.Add(this.numUDUserID);
            this.grbDangNhap.Controls.Add(this.label1);
            this.grbDangNhap.Controls.Add(this.btnShowAndHidePassword);
            this.grbDangNhap.Controls.Add(this.btnThoatDN);
            this.grbDangNhap.Controls.Add(this.btnTaoTaiKhoan);
            this.grbDangNhap.Controls.Add(this.txtbPassWord);
            this.grbDangNhap.Controls.Add(this.txtbLoginName);
            this.grbDangNhap.Controls.Add(this.lblPassWord);
            this.grbDangNhap.Controls.Add(this.lblLoginName);
            this.grbDangNhap.Controls.Add(lblTenCN);
            this.grbDangNhap.Controls.Add(this.cbxTenCN_TTK);
            this.grbDangNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDangNhap.Location = new System.Drawing.Point(12, 12);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(486, 274);
            this.grbDangNhap.TabIndex = 1;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Thông tin tài khoản mới";
            // 
            // cbxRoles
            // 
            this.cbxRoles.DataSource = this.v_DSRoles_BDS;
            this.cbxRoles.DisplayMember = "TEN";
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(292, 161);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(136, 24);
            this.cbxRoles.TabIndex = 13;
            this.cbxRoles.ValueMember = "GIATRI";
            // 
            // v_DSRoles_BDS
            // 
            this.v_DSRoles_BDS.DataMember = "V_DS_ROLES";
            this.v_DSRoles_BDS.DataSource = this.qlvtDS;
            // 
            // qlvtDS
            // 
            this.qlvtDS.DataSetName = "QLVTDataSet";
            this.qlvtDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(231, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vai trò:";
            // 
            // numUDUserID
            // 
            this.numUDUserID.Location = new System.Drawing.Point(123, 161);
            this.numUDUserID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDUserID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDUserID.Name = "numUDUserID";
            this.numUDUserID.Size = new System.Drawing.Size(92, 23);
            this.numUDUserID.TabIndex = 11;
            this.numUDUserID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID:";
            // 
            // btnShowAndHidePassword
            // 
            this.btnShowAndHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAndHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowAndHidePassword.FlatAppearance.BorderSize = 0;
            this.btnShowAndHidePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowAndHidePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowAndHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAndHidePassword.ImageIndex = 0;
            this.btnShowAndHidePassword.ImageList = this.eyesImageList;
            this.btnShowAndHidePassword.Location = new System.Drawing.Point(434, 121);
            this.btnShowAndHidePassword.Name = "btnShowAndHidePassword";
            this.btnShowAndHidePassword.Size = new System.Drawing.Size(30, 23);
            this.btnShowAndHidePassword.TabIndex = 9;
            this.btnShowAndHidePassword.UseMnemonic = false;
            this.btnShowAndHidePassword.UseVisualStyleBackColor = false;
            this.btnShowAndHidePassword.Click += new System.EventHandler(this.btnShowAndHidePassword_Click);
            // 
            // btnThoatDN
            // 
            this.btnThoatDN.BackColor = System.Drawing.Color.White;
            this.btnThoatDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoatDN.Location = new System.Drawing.Point(310, 206);
            this.btnThoatDN.Name = "btnThoatDN";
            this.btnThoatDN.Size = new System.Drawing.Size(75, 31);
            this.btnThoatDN.TabIndex = 7;
            this.btnThoatDN.Text = "Thoát";
            this.btnThoatDN.UseVisualStyleBackColor = false;
            this.btnThoatDN.Click += new System.EventHandler(this.btnThoatDN_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnTaoTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(151, 206);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(92, 31);
            this.btnTaoTaiKhoan.TabIndex = 6;
            this.btnTaoTaiKhoan.Text = "Đăng ký";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // txtbPassWord
            // 
            this.txtbPassWord.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassWord.Location = new System.Drawing.Point(123, 119);
            this.txtbPassWord.Name = "txtbPassWord";
            this.txtbPassWord.PasswordChar = '*';
            this.txtbPassWord.Size = new System.Drawing.Size(305, 24);
            this.txtbPassWord.TabIndex = 5;
            // 
            // txtbLoginName
            // 
            this.txtbLoginName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoginName.Location = new System.Drawing.Point(123, 77);
            this.txtbLoginName.Name = "txtbLoginName";
            this.txtbLoginName.Size = new System.Drawing.Size(305, 24);
            this.txtbLoginName.TabIndex = 4;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassWord.Location = new System.Drawing.Point(12, 125);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(73, 17);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "Mật khẩu:";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoginName.Location = new System.Drawing.Point(12, 81);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(75, 17);
            this.lblLoginName.TabIndex = 2;
            this.lblLoginName.Text = "Tài khoản:";
            // 
            // cbxTenCN_TTK
            // 
            this.cbxTenCN_TTK.DisplayMember = "TENCN";
            this.cbxTenCN_TTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN_TTK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenCN_TTK.FormattingEnabled = true;
            this.cbxTenCN_TTK.Location = new System.Drawing.Point(123, 32);
            this.cbxTenCN_TTK.Name = "cbxTenCN_TTK";
            this.cbxTenCN_TTK.Size = new System.Drawing.Size(305, 23);
            this.cbxTenCN_TTK.TabIndex = 1;
            this.cbxTenCN_TTK.ValueMember = "TENSERVER";
            this.cbxTenCN_TTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenCN_TTK_SelectedIndexChanged);
            // 
            // v_DS_ROLESTableAdapter
            // 
            this.v_DS_ROLESTableAdapter.ClearBeforeFill = true;
            // 
            // formTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 328);
            this.Controls.Add(this.grbDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoTaiKhoan";
            this.Text = "Đăng Ký Tài Khoản ";
            this.Load += new System.EventHandler(this.formTaoTaiKhoan_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSRoles_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDUserID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList eyesImageList;
        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.Button btnShowAndHidePassword;
        private System.Windows.Forms.Button btnThoatDN;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.TextBox txtbPassWord;
        private System.Windows.Forms.TextBox txtbLoginName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ComboBox cbxTenCN_TTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDUserID;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.Label label2;
        private QLVTDataSet qlvtDS;
        private System.Windows.Forms.BindingSource v_DSRoles_BDS;
        private QLVTDataSetTableAdapters.V_DS_ROLESTableAdapter v_DS_ROLESTableAdapter;
    }
}