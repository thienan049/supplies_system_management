﻿using System;
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
        string maVTThem = null;

        bool isEditing = false;
        int editPosition = -1;
        string maVTSua = null;
        string tenVTSua = null;
        
        ErrorProvider err = new ErrorProvider();
        Stack<DataTable> tableStates = new Stack<DataTable>();

        #region form loading
        public formVatTu()
        {
            InitializeComponent();
            this.panelCN.Left = (this.grCtrlCN.Width / 2) - (this.panelCN.Width / 2);
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void formVatTu_Load(object sender, EventArgs e)
        {          
            this.qlvtDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLVTDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);

            // TODO: This line of code loads data into the 'qlvtDS.CTDDH' table. You can move, or remove it, as needed.
            this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctddhTableAdapter.Fill(this.qlvtDS.CTDDH);

            // TODO: This line of code loads data into the 'qlvtDS.CTPN' table. You can move, or remove it, as needed.
            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.qlvtDS.CTPN);

            // TODO: This line of code loads data into the 'qlvtDS.CTPX' table. You can move, or remove it, as needed.
            this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpxTableAdapter.Fill(this.qlvtDS.CTPX);

            cbxTenCN_VATTU.DataSource = Program.bds_dspm;
            cbxTenCN_VATTU.DisplayMember = "TENCN";
            cbxTenCN_VATTU.ValueMember = "TENSERVER";
            cbxTenCN_VATTU.SelectedIndex = Program.mChinhanh;

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
                cbxTenCN_VATTU.Enabled = false;
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

        private void formVatTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.formVTClose == false)
            {
                if (MessageBox.Show("Có thay đổi chưa được lưu hoặc tác vụ chưa hoàn thành, bạn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.formVTClose = true;
                }
            }
        }
        #endregion        

        #region action buttons event handling
        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isAdding = true;
            Program.formVTClose = false;
            this.vtBDS.AddNew();
            
            this.btnThemVT.Enabled = this.btnSuaVT.Enabled = this.btnXoaVT.Enabled = false;
            this.btnPhucHoiVT.Enabled = true;
            writableVTControl(1);
            this.cbxDonVi.Items.Insert(0, "--Chọn--");
            this.cbxDonVi.SelectedIndex = 0;
            checkEmptyAndValid();
        }

        private void btnSuaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isEditing = true;
            Program.formVTClose = false;
            maVTSua = ((DataRowView)vtBDS[vtBDS.Position])["MAVT"].ToString().Trim();
            tenVTSua = ((DataRowView)vtBDS[vtBDS.Position])["TENVT"].ToString().Trim();

            this.editPosition = vtBDS.Position;
            this.btnThemVT.Enabled = this.btnSuaVT.Enabled = this.btnXoaVT.Enabled = false;
            this.btnPhucHoiVT.Enabled = true;
            writableVTControl(1);
            checkEmptyAndValid();
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
                if(this.maVTThem == null)
                {
                    this.maVTThem = this.txtbMaVT.Text.Trim();
                }
                vtBDS.EndEdit();
                this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vatTuTableAdapter.Update(this.qlvtDS.Vattu);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                this.btnReloadVT.PerformClick();
                this.maVTThem = null;
                if (editPosition != -1)
                {
                    this.vtBDS.Position = this.editPosition;
                    this.editPosition = -1;
                }
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
                    this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vatTuTableAdapter.Update(this.qlvtDS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);
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
            if (this.isAdding == true || this.isEditing == true)
            {
                this.vtBDS.CancelEdit();
                this.qlvtDS.Vattu.RejectChanges();
                writableVTControl(0);

                if (Program.mGroup != "CONGTY")
                {
                    this.btnGhiVT.Enabled = false;
                    this.btnThemVT.Enabled = true;
                    this.btnSuaVT.Enabled = true;
                    this.btnXoaVT.Enabled = true;

                    if (tableStates.Count != 0)
                    {
                        // this.btnPhucHoiNV.Enabled = true;
                    }
                    else
                    {
                        // this.btnPhucHoiNV.Enabled = false;
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
                    Program.formVTClose = true;
                }
            }
        }

        private void btnReloadVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            writableVTControl(0);
            this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);

            this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctddhTableAdapter.Fill(this.qlvtDS.CTDDH);

            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.qlvtDS.CTPN);

            this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpxTableAdapter.Fill(this.qlvtDS.CTPX);

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

                if (this.maVTThem != null)
                {
                    this.vtBDS.Position = this.vtBDS.Find("MAVT", this.maVTThem);
                }

                this.maVTSua = null;
                this.tenVTSua = null;
                Program.formVTClose = true;
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
            checkEmptyAndValid();
        }

        private void txtbTenVT_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void cbxDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbMaVT_Validating(object sender, CancelEventArgs e)
        {
            if (!this.txtbMaVT.Text.Trim().All(char.IsLetterOrDigit))
            {
                e.Cancel = true;
               // this.txtbMaVT.Select(0, this.txtbMaVT.Text.Length);
                err.SetError(this.txtbMaVT, "Lỗi");
            }
        }

        private void txtbMaVT_Validated(object sender, EventArgs e)
        {
            err.SetError(this.txtbMaVT, String.Empty);
        }

        private void cbxDonVi_Validating(object sender, CancelEventArgs e)
        {
            if (this.cbxDonVi.GetItemText(this.cbxDonVi.SelectedItem) == "--Chọn--")
            {
                e.Cancel = true;
                err.SetError(this.cbxDonVi, "Lỗi");
                toolTipCtrller.DefaultController.ShowHint("Chọn đơn vị!", this.cbxDonVi, DevExpress.Utils.ToolTipLocation.TopRight);
            }
        }

        private void cbxDonVi_Validated(object sender, EventArgs e)
        {
            err.SetError(this.cbxDonVi, String.Empty);
        }

        private void cbxTenCN_VATTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCN_VATTU.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbxTenCN_VATTU.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.Write(ex.Message); }

            if (cbxTenCN_VATTU.SelectedIndex != Program.mChinhanh)
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
            }
            else
            {
                this.vatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vatTuTableAdapter.Fill(this.qlvtDS.Vattu);
                //if (this.cbxTenCN_VATTU.SelectedIndex == 0)
                //{
                //    pattern = "^K\\d+N1$";
                //}
                //else
                //{
                //    pattern = "^K\\d+N2$";
                //}
            }
        }

        private void grdVwVT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int columns = grdVwVT.Columns.Count();           
            bool checkEmptyCells = false;

            for (int i = 0; i < columns; i++)
            {
                if (((DataRowView)vtBDS[vtBDS.Position])[i].ToString().Trim() == string.Empty)
                {
                    checkEmptyCells = true;
                    break;
                }
            }

            if ((checkEmptyCells || (this.qlvtDS.Vattu.Count - 1) == this.vtBDS.Position) && this.isAdding == true || (this.vtBDS.Position == editPosition) && this.isEditing == true)
            {
                writableVTControl(1);
                checkEmptyAndValid();
            }
            else
            {
                writableVTControl(0);
                checkEmptyAndValid();
            }
            if (tableStates.Count != 0)
            {
                //this.btnPhucHoiVT.Enabled = true;
            }           
        }
        #endregion

        #region additional functions
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
      
        private void checkEmptyAndValid()
        {
            if (this.txtbMaVT.Text.Trim() == "" || this.txtbTenVT.Text.Trim() == "" ||
               !this.txtbMaVT.Text.Trim().All(char.IsLetterOrDigit) || 
               this.cbxDonVi.GetItemText(this.cbxDonVi.SelectedItem) == "--Chọn--" || this.txtbMaVT.ReadOnly == true)
            {
                this.btnGhiVT.Enabled = false;
                //if (tableStates.Count == 0)
                //{
                //    this.btnPhucHoiVT.Enabled = false;
                //}
            }
            else
            {
                this.btnGhiVT.Enabled = true;
                //if (tableStates.Count != 0)
                //{
                //    this.btnPhucHoiVT.Enabled = true;
                //}
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

        private void storeDtTbState()
        {
            DataTable copied = this.qlvtDS.Vattu.Copy();
            tableStates.Push(copied);
        }
        #endregion       
    }
}
