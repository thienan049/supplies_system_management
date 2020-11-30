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
using System.Text.RegularExpressions;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formKho : Form
    {
        bool isAdding = false;
        bool isEditing = false;
        string pattern = null;
        string maKhoSua = null;
        string tenKhoSua = null;
        int editPosition = -1;
        public String maCNThem = "";
        ErrorProvider err = new ErrorProvider();      
        Stack<DataTable> tableStates = new Stack<DataTable>();

        public formKho()
        {
            InitializeComponent();
            this.panelCN.Left = (this.grCtrlCN.Width / 2) - (this.panelCN.Width / 2);
        }

        private void formKho_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLVTDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qlvtDS.Kho);

            // TODO: This line of code loads data into the 'qlvtDS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);

            // TODO: This line of code loads data into the 'qlvtDS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);

            // TODO: This line of code loads data into the 'qlvtDS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);
           
            cbxTenCN_KHO.DataSource = Program.bds_dspm;
            cbxTenCN_KHO.DisplayMember = "TENCN";
            cbxTenCN_KHO.ValueMember = "TENSERVER";
            cbxTenCN_KHO.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbxTenCN_KHO.Enabled = true;
                this.btnThemKho.Enabled = false;
                this.btnSuaKho.Enabled = false;
                this.btnGhiKho.Enabled = false;
                this.btnXoaKho.Enabled = false;
                this.btnPhucHoiKho.Enabled = false;
            }
            else
            {
                maCNThem = ((DataRowView)khoBDS[0])["MACN"].ToString();
                cbxTenCN_KHO.Enabled = false;
                this.btnGhiKho.Enabled = false;
                this.btnPhucHoiKho.Enabled = false;
                if (Program.mGroup == "CHINHANH")
                {

                }
                else if (Program.mGroup == "USER")
                {

                }
            }

            if (this.cbxTenCN_KHO.SelectedIndex == 0)
            {
                pattern = "^K\\d+N1$";
            }
            else
            {
                pattern = "^K\\d+N2$";
            }
        }

        private void cbxTenCN_KHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCN_KHO.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbxTenCN_KHO.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.Write(ex.Message); }

            if (cbxTenCN_KHO.SelectedIndex != Program.mChinhanh)
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.qlvtDS.Kho);
                if (this.cbxTenCN_KHO.SelectedIndex == 0)
                {
                    pattern = "^K\\d+N1$";
                }
                else
                {
                    pattern = "^K\\d+N2$";
                }
            }
        }

        #region action buttons event handling
        private void btnThemKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isAdding = true;
            //Console.WriteLine(this.qlvtDS.NhanVien.Count);
            //Console.WriteLine(this.nvBDS.Position);
            string maKhoMoi = preparedMaKho();
            this.khoBDS.AddNew();
            this.txtbMaCN_Kho.Text = maCNThem;
            this.txtbMaKho.Text = maKhoMoi;
            
            this.btnThemKho.Enabled = this.btnSuaKho.Enabled = this.btnXoaKho.Enabled = false;
            writableKhoControl(1);
            checkEmptyAndValid();
            this.txtbMaKho.Select(0, this.txtbMaKho.Text.Length);
        }

        private void btnSuaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isEditing = true;
            maKhoSua = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString().Trim();
            tenKhoSua = ((DataRowView)khoBDS[khoBDS.Position])["TENKHO"].ToString().Trim();

            this.editPosition = khoBDS.Position;
            this.btnThemKho.Enabled = this.btnSuaKho.Enabled = this.btnXoaKho.Enabled = false;
            writableKhoControl(1);
            checkEmptyAndValid();
        }

        private void btnGhiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string conflictErr;
            if (checkConflictedMaVaTenKho(this.txtbMaKho.Text.Trim(), this.txtbTenKho.Text.Trim(), out conflictErr) && conflictErr != string.Empty)
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
            }
            else
            {
                //storeDtTbState();
                khoBDS.EndEdit();
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.qlvtDS.Kho);
                this.btnReloadKho.PerformClick();
            }
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dhBDS.Count > 0)
            {
                MessageBox.Show("Kho này chứa đơn đặt hàng, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (pnBDS.Count > 0)
            {
                MessageBox.Show("Kho này chứa phiếu nhập, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (pxBDS.Count > 0)
            {
                MessageBox.Show("Kho này chứa phiếu xuất, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa kho này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string makho = string.Empty;
                try
                {
                    makho = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString();
                    khoBDS.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.qlvtDS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.qlvtDS.Kho);
                    khoBDS.Position = khoBDS.Find("MAKHO", makho);
                    return;
                }
            }
            if (khoBDS.Count == 0)
            {
                this.btnXoaKho.Enabled = false;
            }
        }

        private void btnPhucHoiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReloadKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            writableKhoControl(0);
            
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qlvtDS.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);

            if(Program.mGroup != "CONGTY")
            {
                this.btnGhiKho.Enabled = false;
                this.btnThemKho.Enabled = true;
                this.btnSuaKho.Enabled = true;
                this.btnXoaKho.Enabled = true;

                if (tableStates.Count != 0)
                {
                    this.btnPhucHoiKho.Enabled = true;
                }
                else
                {
                    this.btnPhucHoiKho.Enabled = false;
                }

                if (this.isAdding == true)
                {
                    this.isAdding = false;
                }
                if (this.isEditing == true)
                {
                    this.isEditing = false;
                }
                this.editPosition = -1;
                this.maKhoSua = null;
                this.tenKhoSua = null;
            }
        }

        private void btnThoatKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region additional events

        private void txtbMaKho_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbTenKho_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void grdVwKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.err.Dispose();
            int[] selectedRowHandles = grdVwKho.GetSelectedRows();
            int columns = grdVwKho.Columns.Count();

            bool checkEmptyAndValidCells = false;
            for (int i = 0; i < columns; i++)
            {
                if (grdVwKho.GetRowCellValue(selectedRowHandles[0], grdVwKho.Columns[i]).ToString().Trim() == "")
                {
                    checkEmptyAndValidCells = true;
                    break;
                }
            }

            if (((checkEmptyAndValidCells || (this.qlvtDS.NhanVien.Count - 1) == this.khoBDS.Position) && this.isAdding == true) || (this.khoBDS.Position == editPosition && this.isEditing == true))
            {
                writableKhoControl(1);
                checkEmptyAndValid();
            }
            else
            {
                writableKhoControl(0);
                checkEmptyAndValid();
            }

            if (tableStates.Count != 0)
            {
                this.btnPhucHoiKho.Enabled = true;
            }
        }

        private void grCtrlDSKho_SizeChanged(object sender, EventArgs e)
        {
            this.panelCN.Left = (this.grCtrlCN.Width / 2) - (this.panelCN.Width / 2);
        }
        #endregion

        #region additional funtions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional funtions  //////////////////////////////////////////////////////////////////////////////////
        private void checkEmptyAndValid()
        {           
            if (this.txtbMaKho.Text.Trim() == "" || this.txtbTenKho.Text.Trim() == "" ||
               this.txtbDiaChi.Text.Trim() == "" || this.txtbMaKho.ReadOnly == true ||
               !Regex.IsMatch(this.txtbMaKho.Text, this.pattern))
            {
                this.btnGhiKho.Enabled = false;
                if (tableStates.Count == 0)
                {
                    this.btnPhucHoiKho.Enabled = false;
                }
            }
            else
            {
                this.btnGhiKho.Enabled = true;
                if (tableStates.Count != 0)
                {
                    this.btnPhucHoiKho.Enabled = true;
                }
            }
        }

        private bool checkConflictedMaVaTenKho(string maKhoMoi, string tenKhoMoi, out string conflictErr)
        {
            try
            {
                String cmd = "exec SP_LAYMAKHO '" + maKhoMoi + "','" + tenKhoMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 3 && maKhoSua == null)
                {
                    conflictErr = "Mã kho và tên kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && maKhoSua == null)
                {
                    conflictErr = "Tên kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && maKhoSua == null)
                {
                    conflictErr = "Mã kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() != 0 && this.txtbMaKho.Text.Trim() == maKhoSua && this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = string.Empty;
                    return false;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaKho.Text.Trim() != maKhoSua && !this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Mã kho và tên kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && this.txtbMaKho.Text.Trim() != maKhoSua && !this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Tên kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaKho.Text.Trim() != maKhoSua && !this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Mã kho đã tồn tại!";
                    return true;
                }

                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaKho.Text.Trim() == maKhoSua && !this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Tên kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 3 && this.txtbMaKho.Text.Trim() != maKhoSua && this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Mã kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && !this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = "Tên kho đã tồn tại!"; 
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2 && this.txtbTenKho.Text.Trim().Equals(tenKhoSua, StringComparison.OrdinalIgnoreCase))
                {
                    conflictErr = string.Empty;
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaKho.Text.Trim() != maKhoSua)
                {
                    conflictErr = "Mã kho đã tồn tại!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && this.txtbMaKho.Text.Trim() == maKhoSua)
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

        private void writableKhoControl(int flag)
        {
            if (flag == 1)
            {
                this.txtbMaKho.ReadOnly = false;
                this.txtbTenKho.ReadOnly = false;
                this.txtbDiaChi.ReadOnly = false;
            }
            else
            {
                this.txtbMaKho.ReadOnly = true;
                this.txtbTenKho.ReadOnly = true;
                this.txtbDiaChi.ReadOnly = true;
            }

        }
        
        private void storeDtTbState()
        {
            DataTable copied = this.qlvtDS.Kho.Copy();
            tableStates.Push(copied);
        }

        private string preparedMaKho() 
        {
            this.khoBDS.Sort = "MAKHO";
            string value = ((DataRowView)this.khoBDS[this.khoBDS.Count - 1])["MAKHO"].ToString().Trim();
            if (Regex.IsMatch(value, this.pattern))
            {
                int soKhoMoi; int.TryParse(value.Substring(1, value.IndexOf("N")-1), out soKhoMoi);
                string err;
                if(soKhoMoi < 9)
                {
                    soKhoMoi += 1;
                }               
                while (soKhoMoi < 9 && checkConflictedMaVaTenKho(("K" + soKhoMoi),"", out err))
                {
                    soKhoMoi += 1;
                }
                if(this.cbxTenCN_KHO.SelectedIndex == 0)
                {
                    return "K" + (soKhoMoi) + "N1";
                }
                return "K" + (soKhoMoi) + "N2";
            }
            return string.Empty;
        }
        #endregion
    }
}
