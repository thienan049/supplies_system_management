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
    public partial class formDangNhap : Form
    {
        CheckBox lastChecked;

        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTPhMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qlvt_PM_DS.V_DS_PHANMANH);
            this.chbxCN.Checked = true;
            lastChecked = chbxCN;
            cbxTenCN.SelectedIndex = 1;
            cbxTenCN.SelectedIndex = 0;
            Program.bds_dspm.DataSource = dsPM_BDS.DataSource;
            Program.bds_dspm.DataMember = dsPM_BDS.DataMember;

            this.AcceptButton = this.btnDangNhap;           
        }
       
        private void cboxTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbxTenCN.SelectedValue.ToString();
                Program.mChinhanh = cbxTenCN.SelectedIndex;
                if(this.cbxTenCN.SelectedIndex == 0)
                {
                    if (this.chbxCTY.Checked)
                    {
                        setLogin("anlg", "asd");
                    }
                    else if (this.chbxCN.Checked)
                    {
                        setLogin("halg", "asd");
                    }
                    else if (this.chbxUSR.Checked)
                    {
                        setLogin("tranglg", "asd");
                    }
                }else
                {
                    if (this.chbxCTY.Checked)
                    {
                        setLogin("tra2lg", "asd");
                    }
                    else if (this.chbxCN.Checked)
                    {
                        setLogin("ha2lg", "asd");
                    }
                    else if (this.chbxUSR.Checked)
                    {
                        setLogin("thai2lg", "asd");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtbLoginName.Focus();
                return;
            }
            if (txtbPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtbLoginName.Focus();
                return;
            }
            Program.mlogin = txtbLoginName.Text;
            Program.password = txtbPassWord.Text;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            if(Program.KetNoi() != 0)
            {
                MessageBox.Show("Đăng nhập thành công.", "", MessageBoxButtons.OK);
            }else
            {
                return;
            }

            SqlDataReader myReader;
            String cmd = "exec SP_THONGTINDANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(cmd);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản của bạn không có quyền truy cập dữ liệu.", "Lỗi quyền truy cập", MessageBoxButtons.OK);
                return;
            }

            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();

            Program.formChinh.sttLblMaNV.Text = "Mã nhân viên: " + Program.username;
            Program.formChinh.sttLblHoTen.Text = "Họ tên: " + Program.mHoten;
            if(Program.mGroup == "CONGTY")
            {
                Program.formChinh.sttLblNhom.Text = "Nhóm: " + "Công ty";
                Program.formChinh.btnTaoTaiKhoan.Enabled = true;
            }
            else if(Program.mGroup == "CHINHANH")
            {
                Program.formChinh.sttLblNhom.Text = "Nhóm: " + "Chi nhánh";
                Program.formChinh.btnTaoTaiKhoan.Enabled = true;
            }
            else if(Program.mGroup == "USER")
            {
                Program.formChinh.sttLblNhom.Text = "Nhóm: " + "User";
                Program.formChinh.btnTaoTaiKhoan.Enabled = false;
            }

            this.Visible = false;
            Program.formChinh.btnDangNhap.Enabled = false;            
            Program.formChinh.btnDangXuat.Enabled = true;
            //Program.formChinh.btnNV.Enabled = true;
            //Program.formChinh.btnVT.Enabled = true;
            //Program.formChinh.btnKho.Enabled = true;
            //Program.formChinh.btnDDHPNPX.Enabled = true;

            //Program.formChinh.btnPhLapTheoLoaiRP.Enabled = true;
            //Program.formChinh.btnDsNVRP.Enabled = true;
            //Program.formChinh.btnDsVTRP.Enabled = true;
            //Program.formChinh.btnDdhChuaPN.Enabled = true;
            //Program.formChinh.btnNXThang.Enabled = true;
            //Program.formChinh.btnHDNV.Enabled = true;
            Program.formChinh.rbPgDanhMuc.Visible = true;
            Program.formChinh.rbPgBaoCao.Visible = true;
        }

        private void btnThoatDN_Click(object sender, EventArgs e)
        {
            Close();           
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

        private void chbxCTY_Click(object sender, EventArgs e)
        {
            checkChecked(sender);
            if (this.cbxTenCN.SelectedIndex == 0)
            {
                setLogin("anlg", "asd");
            }
            else
            {
                setLogin("tra2lg", "asd");
            }
        }

        private void chbxCN_Click(object sender, EventArgs e)
        {
            checkChecked(sender);
            if (this.cbxTenCN.SelectedIndex == 0)
            {
                setLogin("halg", "asd");
            }
            else
            {
                setLogin("ha2lg", "asd");
            }
        }

        private void chbxUSR_Click(object sender, EventArgs e)
        {
            checkChecked(sender);
            if (this.cbxTenCN.SelectedIndex == 0)
            {
                setLogin("tranglg", "asd");
            }
            else
            {
                setLogin("thai2lg", "asd");
            }
        }

        private void checkChecked(object sender)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null)
                lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void setLogin(string login, string password)
        {       
            this.txtbLoginName.Text = login;
            this.txtbPassWord.Text = password;
        }
    }
}
