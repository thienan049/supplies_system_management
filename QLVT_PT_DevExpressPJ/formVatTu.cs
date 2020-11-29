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

namespace QLVT_PT_DevExpressPJ
{
    public partial class formVatTu : Form
    {
        bool isAdding = false;
        bool isEditing = false;
        string maVTSua = null;
        string tenVTSua = null;
        int editPosition = -1;
        ErrorProvider err = new ErrorProvider();
        Stack<DataTable> tableStates = new Stack<DataTable>();

        public formVatTu()
        {
            InitializeComponent();
        }

        private void formVatTu_Load(object sender, EventArgs e)
        {          
            this.qlvtDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qlvtDS.Vattu);

            // TODO: This line of code loads data into the 'qlvtDS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDS.CTDDH);

            // TODO: This line of code loads data into the 'qlvtDS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDS.CTPN);

            // TODO: This line of code loads data into the 'qlvtDS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qlvtDS.CTPX);

            if (Program.mGroup == "CONGTY")
            {
                this.btnThemVT.Enabled = false;
                this.btnSuaVT.Enabled = false;
                this.btnGhiVT.Enabled = false;
                this.btnXoaVT.Enabled = false;
                this.btnPhucHoiVT.Enabled = false;
            }
            else
            {             
                this.btnGhiVT.Enabled = false;
                this.btnPhucHoiVT.Enabled = false;
                if (Program.mGroup == "CHINHANH")
                {

                }
                else if (Program.mGroup == "USER")
                {

                }
            }
        }

        #region action buttons event handling
        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isAdding = true;
            this.vtBDS.AddNew();
            
            this.btnThemVT.Enabled = this.btnSuaVT.Enabled = this.btnXoaVT.Enabled = false;
            writableVTControl(1);
            this.cbxDonVi.Items.Insert(0, "--Chọn--");
            this.cbxDonVi.SelectedIndex = 0;
            checkEmpty();
        }

        private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isEditing = true;
            maVTSua = ((DataRowView)vtBDS[vtBDS.Position])["MAVT"].ToString().Trim();
            tenVTSua = ((DataRowView)vtBDS[vtBDS.Position])["TENVT"].ToString().Trim();

            this.editPosition = vtBDS.Position;
            this.btnThemVT.Enabled = this.btnSuaVT.Enabled = this.btnXoaVT.Enabled = false;
            writableVTControl(1);
            checkEmpty();
        }

        private void btnGhiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string conflictErr;
            if (checkConflictedMaVaTenVT(this.txtbMaVT.Text.Trim(), this.txtbTenVT.Text.Trim(), out conflictErr) && conflictErr != string.Empty)
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
            }
            else
            {
                vtBDS.EndEdit();
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.qlvtDS.Vattu);
                this.btnReloadVT.PerformClick();              
            }                      
        }
   
        private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ctddhBDS.Count > 0)
            {
                MessageBox.Show("Vật tư này đã được đặt hàng, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (ctpnBDS.Count > 0)
            {
                MessageBox.Show("Vật tư này đã được lập phiếu nhập, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (ctpxBDS.Count > 0)
            {
                MessageBox.Show("Vật tư này đã được lập phiếu xuất, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa vật tư này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int mavt = 0;
                try
                {
                    int.TryParse(((DataRowView)vtBDS[vtBDS.Position])["MAVT"].ToString(), out mavt);
                    vtBDS.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.qlvtDS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.qlvtDS.Vattu);
                    vtBDS.Position = vtBDS.Find("MAVT", mavt);
                    return;
                }
            }
            if (vtBDS.Count == 0)
            {
                this.btnXoaVT.Enabled = false;
            }
        }

        private void btnPhucHoiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReloadVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            writableVTControl(0);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qlvtDS.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDS.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDS.CTPN);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qlvtDS.CTPX);

            if(Program.mGroup != "CONGTY")
            {
                this.btnGhiVT.Enabled = false;
                this.btnThemVT.Enabled = true;
                this.btnSuaVT.Enabled = true;
                this.btnXoaVT.Enabled = true;

                if (tableStates.Count != 0)
                {
                    this.btnPhucHoiVT.Enabled = true;
                }
                else
                {
                    this.btnPhucHoiVT.Enabled = false;
                }

                if (this.isAdding == true)
                {
                    this.isAdding = false;
                }
                if (this.isEditing == true)
                {
                    this.isEditing = false;
                }

                if (this.cbxDonVi.GetItemText(this.cbxDonVi.Items[0]) == "--Chọn--")
                {
                    this.cbxDonVi.Items.RemoveAt(0);
                }

                this.editPosition = -1;
                this.maVTSua = null;
                this.tenVTSua = null;
            }       
            this.err.Dispose();    
        }

        private void btnThoatVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        #endregion

        #region additional events
        private void txtbMaVT_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbTenVT_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void cbxDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbMaVT_Validating(object sender, CancelEventArgs e)
        {
            if (!this.txtbMaVT.Text.Trim().All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
                this.txtbMaVT.Select(0, this.txtbMaVT.Text.Length);
                err.SetError(this.txtbMaVT, "Lỗi");
            }
        }

        private void txtbMaVT_Validated(object sender, EventArgs e)
        {
            err.SetError(this.txtbMaVT, String.Empty);
        }

        private void txtbTenVT_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtbTenVT_Validated(object sender, EventArgs e)
        {
            err.SetError(this.txtbMaVT, String.Empty);
        }

        private void cbxDonVi_Validating(object sender, CancelEventArgs e)
        {
            if (this.cbxDonVi.GetItemText(this.cbxDonVi.SelectedItem) == "--Chọn--")
            {
                e.Cancel = true;
                err.SetError(this.cbxDonVi, "Lỗi");
            }
        }

        private void cbxDonVi_Validated(object sender, EventArgs e)
        {
            err.SetError(this.cbxDonVi, String.Empty);
        }

        private void grdVwVT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] selectedRowHandles = grdVwVT.GetSelectedRows();
            int columns = grdVwVT.Columns.Count();

            bool checkEmptyCells = false;
            for (int i = 0; i < columns; i++)
            {
                if (grdVwVT.GetRowCellValue(selectedRowHandles[0], grdVwVT.Columns[i]).ToString().Trim() == "")
                {
                    checkEmptyCells = true;
                    break;
                }
            }

            if ((checkEmptyCells || (this.qlvtDS.Vattu.Count - 1) == this.vtBDS.Position) && this.isAdding == true || (this.vtBDS.Position == editPosition) && this.isEditing == true)
            {
                writableVTControl(1);
                checkEmpty();
            }
            else
            {
                writableVTControl(0);
                checkEmpty();
            }

            if (tableStates.Count != 0)
            {
                this.btnPhucHoiVT.Enabled = true;
            }
        }
        #endregion

        #region side functions
        private bool checkConflictedMaVaTenVT(string maVTMoi, string tenVTMoi, out string conflictErr)
        {
            try
            {
                String cmd = "exec SP_LAYMAVT '" + maVTMoi + "','" + tenVTMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 3 && maVTSua == null)
                {
                    conflictErr = "Mã vật tư và tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && maVTSua == null)
                {
                    conflictErr = "Tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && maVTSua == null)
                {
                    conflictErr = "Mã vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() != 0 && this.txtbMaVT.Text.Trim() == maVTSua && this.txtbTenVT.Text.Trim() == tenVTSua)
                {
                    conflictErr = string.Empty;
                    return false;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaVT.Text.Trim() != maVTSua && this.txtbTenVT.Text.Trim() != tenVTSua)
                {
                    conflictErr = "Mã vật tư và tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && this.txtbMaVT.Text.Trim() != maVTSua && this.txtbTenVT.Text.Trim() != tenVTSua)
                {
                    conflictErr = "Tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaVT.Text.Trim() != maVTSua && this.txtbTenVT.Text.Trim() != tenVTSua)
                {
                    conflictErr = "Mã vật tư đã tồn tại!";
                    return true;
                }

                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaVT.Text.Trim() == maVTSua && this.txtbTenVT.Text.Trim() != tenVTSua)
                {
                    conflictErr = "Tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaVT.Text.Trim() != maVTSua && this.txtbTenVT.Text.Trim() == tenVTSua)
                {
                    conflictErr = "Mã vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && this.txtbTenVT.Text.Trim() != tenVTSua)
                {
                    conflictErr = "Tên vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && this.txtbTenVT.Text.Trim() == tenVTSua)
                {
                    conflictErr = string.Empty;
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaVT.Text.Trim() != maVTSua)
                {
                    conflictErr = "Mã vật tư đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaVT.Text.Trim() == maVTSua)
                {
                    conflictErr = string.Empty;
                    return true;
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
            if (this.txtbMaVT.Text.Trim() == "" || this.txtbTenVT.Text.Trim() == "" ||
               !this.txtbMaVT.Text.Trim().All(char.IsLetterOrDigit) || 
               this.cbxDonVi.GetItemText(this.cbxDonVi.SelectedItem) == "--Chọn--" || this.txtbMaVT.ReadOnly == true)
            {
                this.btnGhiVT.Enabled = false;
                if (tableStates.Count == 0)
                {
                    this.btnPhucHoiVT.Enabled = false;
                }
            }
            else
            {
                this.btnGhiVT.Enabled = true;
                if (tableStates.Count != 0)
                {
                    this.btnPhucHoiVT.Enabled = true;
                }
            }
        }

        private void writableVTControl(int flag)
        {
            if (flag == 1)
            {
                this.txtbMaVT.ReadOnly = false;
                this.txtbTenVT.ReadOnly = false;
                this.cbxDonVi.Enabled = true;
            }
            else
            {
                this.txtbMaVT.ReadOnly = true;
                this.txtbTenVT.ReadOnly = true;
                this.cbxDonVi.Enabled = false;
            }
        }
        #endregion

        private void storeDtTbState()
        {
            DataTable copied = this.qlvtDS.Vattu.Copy();
            tableStates.Push(copied);
        }     
    }
}
