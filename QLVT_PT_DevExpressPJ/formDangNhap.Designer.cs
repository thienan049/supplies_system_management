namespace QLVT_PT_DevExpressPJ
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chbxCTY = new System.Windows.Forms.CheckBox();
            this.chbxCN = new System.Windows.Forms.CheckBox();
            this.chbxUSR = new System.Windows.Forms.CheckBox();
            this.btnShowAndHidePassword = new System.Windows.Forms.Button();
            this.eyesImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnThoatDN = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtbPassWord = new System.Windows.Forms.TextBox();
            this.txtbLoginName = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.cbxTenCN = new System.Windows.Forms.ComboBox();
            this.dsPM_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.qlvt_PM_DS = new QLVT_PT_DevExpressPJ.QLVTPhMDataSet();
            this.v_DS_PHANMANHTableAdapter = new QLVT_PT_DevExpressPJ.QLVTPhMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTPhMDataSetTableAdapters.TableAdapterManager();
            lblTenCN = new System.Windows.Forms.Label();
            this.grbDangNhap.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPM_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvt_PM_DS)).BeginInit();
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
            // grbDangNhap
            // 
            this.grbDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDangNhap.Controls.Add(this.flowLayoutPanel1);
            this.grbDangNhap.Controls.Add(this.btnShowAndHidePassword);
            this.grbDangNhap.Controls.Add(this.btnThoatDN);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.txtbPassWord);
            this.grbDangNhap.Controls.Add(this.txtbLoginName);
            this.grbDangNhap.Controls.Add(this.lblPassWord);
            this.grbDangNhap.Controls.Add(this.lblLoginName);
            this.grbDangNhap.Controls.Add(lblTenCN);
            this.grbDangNhap.Controls.Add(this.cbxTenCN);
            this.grbDangNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDangNhap.Location = new System.Drawing.Point(12, 12);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(625, 244);
            this.grbDangNhap.TabIndex = 0;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Thông tin đăng nhập";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chbxCTY);
            this.flowLayoutPanel1.Controls.Add(this.chbxCN);
            this.flowLayoutPanel1.Controls.Add(this.chbxUSR);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(434, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 24);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // chbxCTY
            // 
            this.chbxCTY.AutoSize = true;
            this.chbxCTY.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxCTY.Location = new System.Drawing.Point(3, 3);
            this.chbxCTY.Name = "chbxCTY";
            this.chbxCTY.Size = new System.Drawing.Size(50, 19);
            this.chbxCTY.TabIndex = 0;
            this.chbxCTY.Text = "CTY";
            this.chbxCTY.UseVisualStyleBackColor = true;
            this.chbxCTY.Click += new System.EventHandler(this.chbxCTY_Click);
            // 
            // chbxCN
            // 
            this.chbxCN.AutoSize = true;
            this.chbxCN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxCN.Location = new System.Drawing.Point(59, 3);
            this.chbxCN.Name = "chbxCN";
            this.chbxCN.Size = new System.Drawing.Size(43, 19);
            this.chbxCN.TabIndex = 1;
            this.chbxCN.Text = "CN";
            this.chbxCN.UseVisualStyleBackColor = true;
            this.chbxCN.Click += new System.EventHandler(this.chbxCN_Click);
            // 
            // chbxUSR
            // 
            this.chbxUSR.AutoSize = true;
            this.chbxUSR.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxUSR.Location = new System.Drawing.Point(108, 3);
            this.chbxUSR.Name = "chbxUSR";
            this.chbxUSR.Size = new System.Drawing.Size(49, 19);
            this.chbxUSR.TabIndex = 2;
            this.chbxUSR.Text = "USR";
            this.chbxUSR.UseVisualStyleBackColor = true;
            this.chbxUSR.Click += new System.EventHandler(this.chbxUSR_Click);
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
            this.btnShowAndHidePassword.Location = new System.Drawing.Point(434, 136);
            this.btnShowAndHidePassword.Name = "btnShowAndHidePassword";
            this.btnShowAndHidePassword.Size = new System.Drawing.Size(30, 23);
            this.btnShowAndHidePassword.TabIndex = 9;
            this.btnShowAndHidePassword.UseMnemonic = false;
            this.btnShowAndHidePassword.UseVisualStyleBackColor = false;
            this.btnShowAndHidePassword.Click += new System.EventHandler(this.btnShowAndHidePassword_Click);
            // 
            // eyesImageList
            // 
            this.eyesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eyesImageList.ImageStream")));
            this.eyesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.eyesImageList.Images.SetKeyName(0, "non-eye 22x22.png");
            this.eyesImageList.Images.SetKeyName(1, "eye 22x22.png");
            // 
            // btnThoatDN
            // 
            this.btnThoatDN.BackColor = System.Drawing.Color.White;
            this.btnThoatDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoatDN.Location = new System.Drawing.Point(315, 180);
            this.btnThoatDN.Name = "btnThoatDN";
            this.btnThoatDN.Size = new System.Drawing.Size(75, 31);
            this.btnThoatDN.TabIndex = 7;
            this.btnThoatDN.Text = "Thoát";
            this.btnThoatDN.UseVisualStyleBackColor = false;
            this.btnThoatDN.Click += new System.EventHandler(this.btnThoatDN_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.White;
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangNhap.Location = new System.Drawing.Point(156, 180);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(92, 31);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtbPassWord
            // 
            this.txtbPassWord.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassWord.Location = new System.Drawing.Point(123, 134);
            this.txtbPassWord.Name = "txtbPassWord";
            this.txtbPassWord.PasswordChar = '*';
            this.txtbPassWord.Size = new System.Drawing.Size(305, 24);
            this.txtbPassWord.TabIndex = 5;
            // 
            // txtbLoginName
            // 
            this.txtbLoginName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoginName.Location = new System.Drawing.Point(123, 83);
            this.txtbLoginName.Name = "txtbLoginName";
            this.txtbLoginName.Size = new System.Drawing.Size(305, 24);
            this.txtbLoginName.TabIndex = 4;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassWord.Location = new System.Drawing.Point(12, 137);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(73, 17);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "Mật khẩu:";
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoginName.Location = new System.Drawing.Point(12, 86);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(75, 17);
            this.lblLoginName.TabIndex = 2;
            this.lblLoginName.Text = "Tài khoản:";
            // 
            // cbxTenCN
            // 
            this.cbxTenCN.DataSource = this.dsPM_BDS;
            this.cbxTenCN.DisplayMember = "TENCN";
            this.cbxTenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenCN.FormattingEnabled = true;
            this.cbxTenCN.Location = new System.Drawing.Point(123, 32);
            this.cbxTenCN.Name = "cbxTenCN";
            this.cbxTenCN.Size = new System.Drawing.Size(305, 23);
            this.cbxTenCN.TabIndex = 1;
            this.cbxTenCN.ValueMember = "TENSERVER";
            this.cbxTenCN.SelectedIndexChanged += new System.EventHandler(this.cboxTenCN_SelectedIndexChanged);
            // 
            // dsPM_BDS
            // 
            this.dsPM_BDS.DataMember = "V_DS_PHANMANH";
            this.dsPM_BDS.DataSource = this.qlvt_PM_DS;
            // 
            // qlvt_PM_DS
            // 
            this.qlvt_PM_DS.DataSetName = "QLVTPhMDataSet";
            this.qlvt_PM_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_PT_DevExpressPJ.QLVTPhMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 300);
            this.Controls.Add(this.grbDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPM_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvt_PM_DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangNhap;
        private QLVTPhMDataSet qlvt_PM_DS;
        private System.Windows.Forms.BindingSource dsPM_BDS;
        private QLVTPhMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTPhMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxTenCN;
        private System.Windows.Forms.Button btnThoatDN;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtbPassWord;
        private System.Windows.Forms.TextBox txtbLoginName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ImageList eyesImageList;
        private System.Windows.Forms.Button btnShowAndHidePassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chbxCTY;
        private System.Windows.Forms.CheckBox chbxCN;
        private System.Windows.Forms.CheckBox chbxUSR;
    }
}