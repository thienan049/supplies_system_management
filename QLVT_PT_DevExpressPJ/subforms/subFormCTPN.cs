using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PT_DevExpressPJ.subforms
{
    public partial class subFormCTPN : Form
    {
        public subFormCTPN()
        {
            InitializeComponent();
            this.numUDSoluong.TextChanged += new EventHandler(numUDSoLuong_TextChanged);
            this.numUDDonGia.TextChanged += new EventHandler(numUDDonGia_TextChanged);
        }
        #region form's main processing
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Form's main processing  //////////////////////////////////////////////////////////////////////////////////
        private void subFormCTPN_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;
            this.ctpnBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_ctpnBDS();

            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);
        }

        private void subFormCTPN_Shown(object sender, EventArgs e)
        {
            Program.formDDHPNPX.Enabled = false;
            this.ctpnBDS.AddNew();
            this.txtbMaPN.Text = ((DataRowView)this.ctpnBDS[this.ctpnBDS.Position])["MAPN"].ToString().Trim();
            this.numUDSoluong.Value = 0;
            this.numUDDonGia.Value = 0;
            checkEmpty();
        }

        private void subFormCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ctpnBDS.CancelEdit();
            Program.formDDHPNPX.Enabled = true;
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if (checkConflictedMaVT_CTPN(this.txtbMaVT.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm phiếu chi tiết cho phiếu nhập này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ctpnBDS.EndEdit();
                this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpnTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().CTPN);
                this.Close();
                Program.formDDHPNPX.reloadPN();
            }
        }
        #endregion

        #region additional events
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional events  //////////////////////////////////////////////////////////////////////////////////
        private void txtbMaVT_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void numUDSoLuong_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void numUDDonGia_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void numUDSoluong_ValueChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void numUDDonGia_ValueChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void grdVwVattu_ThemCTPN_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaVT.Text = ((DataRowView)vtBDS[vtBDS.Position])["MAVT"].ToString().Trim();
        }
        #endregion

        #region additional funtions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional functions  //////////////////////////////////////////////////////////////////////////////////
        private bool checkConflictedMaVT_CTPN(string maVTMoi, out string conflictErr)
        {
            try
            {
                int found = this.ctpnBDS.Find("MAVT", maVTMoi);

                if (found > -1)
                {
                    conflictErr = "Mã vật tư đã tồn tại với phiếu nhập này!";
                    return true;
                }
                else
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
            if (this.txtbMaVT.Text.Trim() == "" || this.numUDSoluong.Text == "" ||
               this.numUDDonGia.Text == "" || this.numUDSoluong.Value == 0)
            {
                this.btnThemCTPN.Enabled = false;
            }
            else
            {
                this.btnThemCTPN.Enabled = true;
            }
        }
        #endregion
    }
}
