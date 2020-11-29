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
    public partial class subFormCTPX : Form
    {
        public subFormCTPX()
        {
            InitializeComponent();
            this.numUDSoluong.TextChanged += new EventHandler(numUDSoLuong_TextChanged);
            this.numUDDonGia.TextChanged += new EventHandler(numUDDonGia_TextChanged);
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            this.AcceptButton = this.btnThemCTPX;
            this.CancelButton = this.btnThoat;
        }

        #region form's main processing
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Form's main processing  //////////////////////////////////////////////////////////////////////////////////
        private void subFormCTPX_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;
            this.ctpxBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_ctpxBDS();

            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);
        }

        private void subFormCTPX_Shown(object sender, EventArgs e)
        {
            Program.formDDHPNPX.Enabled = false;
            this.ctpxBDS.AddNew();
            this.txtbMaPX.Text = ((DataRowView)this.ctpxBDS[this.ctpxBDS.Position])["MAPX"].ToString().Trim();
            this.numUDSoluong.Value = 0;
            this.numUDSoluong.Value = 1;
            this.numUDDonGia.Value = 1;
            this.numUDDonGia.Value = 0;
            checkEmptyAndValid();
        }

        private void subFormCTPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ctpxBDS.CancelEdit();
            Program.formDDHPNPX.Enabled = true;
        }

        private void btnThemCTPX_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if (checkConflictedMaVT_CTPX(this.txtbMaVT.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm phiếu chi tiết cho phiếu xuất này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    ctpxBDS.EndEdit();
                    this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpxTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().CTPX);
                    this.Close();
                    Program.formDDHPNPX.reloadPX();
                }catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        #endregion

        #region additional events
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional events  //////////////////////////////////////////////////////////////////////////////////
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

        private void grdVwVattu_ThemCTPX_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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
        private bool checkConflictedMaVT_CTPX(string maVTMoi, out string conflictErr)
        {
            try
            {
                int found = this.ctpxBDS.Find("MAVT", maVTMoi);

                if (found > -1)
                {
                    conflictErr = "Mã vật tư đã tồn tại với phiếu xuất này!";
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
               this.numUDDonGia.Text == "" || this.numUDSoluong.Value == 0)
            {
                this.btnThemCTPX.Enabled = false;
            }
            else
            {
                this.btnThemCTPX.Enabled = true;
            }
        }
        #endregion
    }
}
