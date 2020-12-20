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

namespace QLVT_PT_DevExpressPJ.subforms
{
    public partial class subFormCTDDH : Form
    {
        #region form loading
        public subFormCTDDH()
        {        
            InitializeComponent();
            this.numUDSoluong.TextChanged += new EventHandler(numUDSoLuong_TextChanged);
            this.numUDDonGia.TextChanged += new EventHandler(numUDDonGia_TextChanged);
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            this.AcceptButton = this.btnThemCTDDH;
            this.CancelButton = this.btnThoat;
        }
        
        private void subFormCTDDH_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;
            this.ctddhBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_ctddhBDS();

            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);
        }

        private void subFormCTDDH_Shown(object sender, EventArgs e)
        {
            Program.formDDHPNPX.Enabled = false;
            this.ctddhBDS.AddNew();
            this.txtbMaSoDDH.Text = ((DataRowView)this.ctddhBDS[this.ctddhBDS.Position])["MASODDH"].ToString().Trim();
            this.numUDSoluong.Value = 0;
            this.numUDDonGia.Value = 0;
            checkEmptyAndValid();
        }

        private void subFormCTDDH_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ctddhBDS.CancelEdit();
            Program.formDDHPNPX.Enabled = true;
        }
        #endregion

        #region additional events
        private void btnThemCTDDH_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if (checkConflictedMaVT_CTDDH(this.txtbMaVT.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm phiếu chi tiết cho đơn đặt hàng này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ctddhBDS.EndEdit();
                this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctddhTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().CTDDH);
                //MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                this.Close();
                Program.formDDHPNPX.reloadDDH();
            }
        }

        private void txtbMaVT_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void numUDSoLuong_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void numUDDonGia_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void numUDSoluong_ValueChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void numUDDonGia_ValueChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }
       
        private void grdVwVattu_ThemCTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaVT.Text = ((DataRowView)vtBDS[vtBDS.Position])["MAVT"].ToString().Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region additional funtions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional functions  //////////////////////////////////////////////////////////////////////////////////
        private bool checkConflictedMaVT_CTDDH(string maVTMoi, out string conflictErr)
        {
            try
            {
                int found = this.ctddhBDS.Find("MAVT", maVTMoi);

                if (found > -1)
                {
                    conflictErr = "Mã vật tư đã tồn tại với đơn đặt hàng này!";
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

        private void checkEmptyAndValid()
        {
            if (this.txtbMaVT.Text.Trim() == "" || this.numUDSoluong.Text == "" ||
               this.numUDDonGia.Text == "" || this.numUDSoluong.Value == 0 || this.numUDDonGia.Value == 0)
            {
                this.btnThemCTDDH.Enabled = false;
            }
            else
            {
                this.btnThemCTDDH.Enabled = true;
            }
        }
        #endregion
    }
}
