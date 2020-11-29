using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLVT_PT_DevExpressPJ.subforms
{
    public partial class subFormDDH : Form
    {
        public subFormDDH()
        {
            InitializeComponent();
        }
        #region form's main processing
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Form's main processing  //////////////////////////////////////////////////////////////////////////////////
        private void subFormDDH_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;
            this.dhBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_dhBDS();

            // TODO: This line of code loads data into the 'qlvtDS.Kho' table.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qlvtDS.Kho);
        }

        private void subFormDDH_Shown(object sender, EventArgs e)
        {
            string maDDHMoi = preparedMaDDH();
            Program.formDDHPNPX.Enabled = false;
            this.dhBDS.AddNew();
            this.txtbMaSoDDH.Text = maDDHMoi;
            this.txtbMaSoDDH.Select(0, this.txtbMaSoDDH.Text.Length);
            this.txtbMaNV.Text = Program.username;
            this.dateEdNgayDat.EditValue = DateTime.Today;
            this.dateEdNgayDat.Select(0, this.dateEdNgayDat.Text.Length);
        }

        private void subFormDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dhBDS.CancelEdit();
            Program.formDDHPNPX.Enabled = true;
        }

        private void btnThemDDH_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if(checkConflictedMaDDH(this.txtbMaSoDDH.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm đơn đặt hàng này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dhBDS.EndEdit();
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().DatHang);
                this.Close();
            }
        }
        #endregion

        #region additional events
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional events  //////////////////////////////////////////////////////////////////////////////////
        private void txtbMaSoDDH_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void dateEdNgayDat_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbNhaCC_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbMaKho_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void grdVwKho_ThemDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaKho.Text = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString().Trim();
        }
        #endregion

        #region side funtions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Side funtions  //////////////////////////////////////////////////////////////////////////////////
        private bool checkConflictedMaDDH(string maSoDDHMoi, out string conflictErr)
        {
            try
            {
                String cmd = "exec SP_LAYMADDH '" + maSoDDHMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 1)
                {
                    conflictErr = "Mã số đơn đặt hàng đã tồn tại ở chi nhánh này!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2)
                {
                    conflictErr = "Mã số đơn đặt hàng đã tồn tại ở chi nhánh khác!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 0)
                {
                    conflictErr = string.Empty;
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Lỗi: " + e.Message, "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            conflictErr = string.Empty;
            return false;
        }

        private void checkEmpty()
        {
            if (this.txtbMaSoDDH.Text.Trim() == "" || this.dateEdNgayDat.Text.Trim() == "" ||
               this.txtbNhaCC.Text.Trim() == "" || this.txtbMaKho.Text.Trim() == "" ||
               !this.txtbMaSoDDH.Text.Trim().All(char.IsLetterOrDigit))
            {
                this.btnThemDDH.Enabled = false;
            }
            else
            {
                this.btnThemDDH.Enabled = true;
            }
        }

        private string preparedMaDDH()
        {
            this.dhBDS.Sort = "MASODDH";
            string value = ((DataRowView)this.dhBDS[this.dhBDS.Count - 1])["MASODDH"].ToString().Trim();
            if (Regex.IsMatch(value, "^MDDH\\d+$"))
            {
                int soDDHMoi; int.TryParse(value.Substring(4), out soDDHMoi);
                string err;
                soDDHMoi += 1;
                while (checkConflictedMaDDH(("MDDH" + soDDHMoi), out err))
                {
                    soDDHMoi += 1;
                }
                return "MDDH" + (soDDHMoi);
            }
            return string.Empty;
        }
        #endregion

    }
}
