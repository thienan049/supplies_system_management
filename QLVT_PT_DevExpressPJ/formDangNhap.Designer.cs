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
            this.btnShowAndHidePassword = new System.Windows.Forms.Button();
            this.eyesImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnThoatDN = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtbPassWord = new System.Windows.Forms.TextBox();
            this.txtbLoginName = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.cboxTenCN = new System.Windows.Forms.ComboBox();
            this.bdsVDsPM = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTPhMDataSet = new QLVT_PT_DevExpressPJ.QLVTPhMDataSet();
            this.v_DS_PHANMANHTableAdapter = new QLVT_PT_DevExpressPJ.QLVTPhMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_PT_DevExpressPJ.QLVTPhMDataSetTableAdapters.TableAdapterManager();
            lblTenCN = new System.Windows.Forms.Label();
            this.grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVDsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTPhMDataSet)).BeginInit();
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
            this.grbDangNhap.Controls.Add(this.btnShowAndHidePassword);
            this.grbDangNhap.Controls.Add(this.btnThoatDN);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.txtbPassWord);
            this.grbDangNhap.Controls.Add(this.txtbLoginName);
            this.grbDangNhap.Controls.Add(this.lblPassWord);
            this.grbDangNhap.Controls.Add(this.lblLoginName);
            this.grbDangNhap.Controls.Add(lblTenCN);
            this.grbDangNhap.Controls.Add(this.cboxTenCN);
            this.grbDangNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDangNhap.Location = new System.Drawing.Point(12, 12);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(502, 244);
            this.grbDangNhap.TabIndex = 0;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Thông tin đăng nhập";
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
            // cboxTenCN
            // 
            this.cboxTenCN.DataSource = this.bdsVDsPM;
            this.cboxTenCN.DisplayMember = "TENCN";
            this.cboxTenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTenCN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTenCN.FormattingEnabled = true;
            this.cboxTenCN.Location = new System.Drawing.Point(123, 32);
            this.cboxTenCN.Name = "cboxTenCN";
            this.cboxTenCN.Size = new System.Drawing.Size(305, 23);
            this.cboxTenCN.TabIndex = 1;
            this.cboxTenCN.ValueMember = "TENSERVER";
            this.cboxTenCN.SelectedIndexChanged += new System.EventHandler(this.cboxTenCN_SelectedIndexChanged);
            // 
            // bdsVDsPM
            // 
            this.bdsVDsPM.DataMember = "V_DS_PHANMANH";
            this.bdsVDsPM.DataSource = this.qLVTPhMDataSet;
            // 
            // qLVTPhMDataSet
            // 
            this.qLVTPhMDataSet.DataSetName = "QLVTPhMDataSet";
            this.qLVTPhMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.ClientSize = new System.Drawing.Size(564, 300);
            this.Controls.Add(this.grbDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVDsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTPhMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangNhap;
        private QLVTPhMDataSet qLVTPhMDataSet;
        private System.Windows.Forms.BindingSource bdsVDsPM;
        private QLVTPhMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLVTPhMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboxTenCN;
        private System.Windows.Forms.Button btnThoatDN;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtbPassWord;
        private System.Windows.Forms.TextBox txtbLoginName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ImageList eyesImageList;
        private System.Windows.Forms.Button btnShowAndHidePassword;
    }
}