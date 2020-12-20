using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formTaoTaiKhoan : Form
    {
        #region form loading
        public formTaoTaiKhoan()
        {
            InitializeComponent();
            this.AcceptButton = this.btnTaoTaiKhoan;
        }

        private void formTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.V_DS_ROLES' table. You can move, or remove it, as needed.
            this.v_DS_ROLESTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_ROLESTableAdapter.Fill(this.qlvtDS.V_DS_ROLES);

            cbxTenCN_TTK.DataSource = Program.bds_dspm;
            cbxTenCN_TTK.DisplayMember = "TENCN";
            cbxTenCN_TTK.ValueMember = "TENSERVER";
            cbxTenCN_TTK.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbxTenCN_TTK.Enabled = true;
                this.v_DSRoles_BDS.RemoveAt(v_DSRoles_BDS.Find("GIATRI", "CHINHANH"));
                this.v_DSRoles_BDS.RemoveAt(v_DSRoles_BDS.Find("GIATRI", "USER"));
            }
            else
            {
                cbxTenCN_TTK.Enabled = false;
                if (Program.mGroup == "CHINHANH")
                {
                    this.v_DSRoles_BDS.RemoveAt(v_DSRoles_BDS.Find("GIATRI", "CONGTY"));
                }
            }
        }
        #endregion

        #region additional events
        private void cbxTenCN_TTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCN_TTK.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbxTenCN_TTK.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.Write(ex.Message); }

            if (cbxTenCN_TTK.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối đến chi nhánh!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi tạo tài khoản", MessageBoxButtons.OK);
                txtbLoginName.Focus();
                return;
            }
            if (txtbPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi tạo tài khoản", MessageBoxButtons.OK);
                txtbLoginName.Focus();
                return;
            }
            string conflictErr = string.Empty;
            if (checkConflictedMaNV(this.numUDUserID.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            try
            {
                String cmd = "exec SP_TAOTAIKHOAN '" + this.txtbLoginName.Text.Trim() + "', '"
                           + this.txtbPassWord.Text.Trim() + "', '" + this.numUDUserID.Text + "', '" + this.cbxRoles.SelectedValue.ToString() + "'";
                Program.ExecSqlNonQuery(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoatDN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAndHidePassword_Click(object sender, EventArgs e)
        {
            if (this.btnShowAndHidePassword.ImageIndex == 0)
            {
                this.btnShowAndHidePassword.ImageIndex = 1;
                this.txtbPassWord.PasswordChar = '\0';
            }
            else
            {
                this.btnShowAndHidePassword.ImageIndex = 0;
                this.txtbPassWord.PasswordChar = '*';
            }
        }
        #endregion

        #region additional functions
        private bool checkConflictedMaNV(String userID, out string conflictErr)
        {
            try
            {
                String cmd = "exec SP_LAYMANV '" + userID + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 0)
                {
                    conflictErr = "ID không hợp lệ(không tồn tại)!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1)
                {
                    if (this.cbxTenCN_TTK.SelectedIndex == 0)
                    {
                        conflictErr = string.Empty;
                        return false;
                    }
                    else
                    {
                        conflictErr = "ID không thuộc chi nhánh này!";
                        return true;
                    }
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2)
                {
                    if (this.cbxTenCN_TTK.SelectedIndex == 0)
                    {
                        conflictErr = "ID không thuộc chi nhánh này!";
                        return true;
                    }
                    else
                    {
                        conflictErr = string.Empty;
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Lỗi: " + e.Message, "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            conflictErr = string.Empty;
            return false;
        }
        #endregion
    }
}

