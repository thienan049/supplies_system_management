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
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTPhMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTPhMDataSet.V_DS_PHANMANH);
            cboxTenCN.SelectedIndex = 1;
            cboxTenCN.SelectedIndex = 0;
            Program.bds_dspm.DataSource = bdsVDsPM.DataSource;
            Program.bds_dspm.DataMember = bdsVDsPM.DataMember;

            this.AcceptButton = this.btnDangNhap;
            this.txtbLoginName.Text = "halg";
            this.txtbPassWord.Text = "asd";
        }
       
        private void cboxTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cboxTenCN.SelectedValue.ToString();
                Program.mChinhanh = cboxTenCN.SelectedIndex;
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
            }else if(Program.mGroup == "CHINHANH")
            {
                Program.formChinh.sttLblNhom.Text = "Nhóm: " + "Chi nhánh";
            }else if(Program.mGroup == "USER")
            {
                Program.formChinh.sttLblNhom.Text = "Nhóm: " + "User";
            }

            this.Visible = false;
            Program.formChinh.btnDangNhap.Enabled = false;
            
            Program.formChinh.btnDangXuat.Enabled = true;
            Program.formChinh.btnNV.Enabled = true;
            Program.formChinh.btnVT.Enabled = true;
            Program.formChinh.btnKho.Enabled = true;
            Program.formChinh.btnDDHPNPX.Enabled = true;
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
    }
}
