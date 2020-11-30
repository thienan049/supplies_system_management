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
using System.Globalization;
using System.Text.RegularExpressions;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formNhanVien : Form
    {
        bool isAdding = false;
        bool isEditing = false;
        int maNVSua = -1;
        int editPosition = -1;
        public String maCNThem = string.Empty;
        ErrorProvider err = new ErrorProvider();
        Stack<DataTable> tableStates = new Stack<DataTable>();

        public formNhanVien()
        {
            InitializeComponent();
            this.panelCN.Left = (this.grCtrlCN.Width / 2) - (this.panelCN.Width / 2);
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        
        private void formNV_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qlvtDS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qlvtDS.NhanVien);

            // TODO: This line of code loads data into the 'qlvtDS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);

            // TODO: This line of code loads data into the 'qlvtDS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);

            // TODO: This line of code loads data into the 'qlvtDS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);

            // TODO: This line of code loads data into the 'qlvtDS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDS.CTDDH);

            // TODO: This line of code loads data into the 'qlvtDS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDS.CTPN);

            // TODO: This line of code loads data into the 'qlvtDS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qlvtDS.CTPX);
            

            cbxTenCN_NV.DataSource = Program.bds_dspm;
            cbxTenCN_NV.DisplayMember = "TENCN";
            cbxTenCN_NV.ValueMember = "TENSERVER";
            cbxTenCN_NV.SelectedIndex = Program.mChinhanh;

            this.lblHint.Visible = false;
            if(Program.mGroup == "CONGTY")
            {
                cbxTenCN_NV.Enabled = true;
                this.btnThemNV.Enabled = false;
                this.btnSuaNV.Enabled = false;
                this.btnGhiNV.Enabled = false;
                this.btnXoaNV.Enabled = false;
                this.btnPhucHoiNV.Enabled = false;
            }else
            {
                //cnGrCtrl.Visible = false;
                maCNThem = ((DataRowView)nvBDS[0])["MACN"].ToString();
                cbxTenCN_NV.Enabled = false;
                this.btnGhiNV.Enabled = false;
                this.btnPhucHoiNV.Enabled = false;
                if (Program.mGroup == "CHINHANH")
                {

                }else if(Program.mGroup == "USER")
                {

                }
            }
        }

        private void cbxTenCN_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCN_NV.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbxTenCN_NV.SelectedValue.ToString();
            }
            catch (Exception ex){ Console.Write(ex.Message); }
                      
            if(cbxTenCN_NV.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối đến chi nhánh!", "", MessageBoxButtons.OK);
            }else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.qlvtDS.NhanVien);
               
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);
               
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);
            }
        }

        #region action buttons event handling
        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isAdding = true;
            //Console.WriteLine(this.qlvtDS.NhanVien.Count);
            //Console.WriteLine(this.nvBDS.Position);
            this.nvBDS.AddNew();
            this.txtbMaCN_NV.Text = maCNThem;
        
            this.lblHint.Visible = true;
            this.btnThemNV.Enabled = this.btnSuaNV.Enabled = this.btnXoaNV.Enabled = false;
            writableNVControl(1);
            checkEmpty();
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isEditing = true;
            int.TryParse(((DataRowView)nvBDS[nvBDS.Position])["MANV"].ToString(), out maNVSua);

            this.editPosition = nvBDS.Position;
            this.btnThemNV.Enabled = this.btnSuaNV.Enabled = this.btnXoaNV.Enabled = false;
            writableNVControl(1);
            checkEmpty();
        }

        private void btnGhiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkConflictedMaNV(this.txtbMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            else
            {
               // storeDtTbState();
                nvBDS.EndEdit();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.qlvtDS.NhanVien);
                this.btnReloadNV.PerformClick();          
            }
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dhBDS.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã lập đơn đặt hàng, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if(pnBDS.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã lập phiếu nhập, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (pxBDS.Count > 0)
            {
                MessageBox.Show("Nhân viên này đã lập phiếu xuất, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int manv = 0;
                try
                {                 
                    int.TryParse(((DataRowView)nvBDS[nvBDS.Position])["MANV"].ToString(), out manv);
                    nvBDS.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.qlvtDS.NhanVien);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.qlvtDS.NhanVien);
                    nvBDS.Position = nvBDS.Find("MANV", manv);
                    return;
                }
            }
            if(nvBDS.Count == 0)
            {
                this.btnXoaNV.Enabled = false;
            }
        }

        private void btnPhucHoiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(tableStates.Count != 0)
            {
                this.qlvtDS.NhanVien.Clear();
                this.qlvtDS.NhanVien.Merge(tableStates.Pop());
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.qlvtDS.NhanVien);
            }else
            {
                this.btnPhucHoiNV.Enabled = false;
            }
        }
        
        private void btnReloadNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            writableNVControl(0);
            this.lblHint.Visible = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qlvtDS.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDS.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDS.CTPN);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qlvtDS.CTPX);

            if (Program.mGroup != "CONGTY")
            {
                this.btnGhiNV.Enabled = false;
                this.btnThemNV.Enabled = true;
                this.btnSuaNV.Enabled = true;
                this.btnXoaNV.Enabled = true;

                if (tableStates.Count != 0)
                {
                    this.btnPhucHoiNV.Enabled = true;
                }
                else
                {
                    this.btnPhucHoiNV.Enabled = false;
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
                this.maNVSua = -1;
            }
            this.err.Dispose();          
        }
        
        private void btnThoatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region additional events
        private void txtbMaNV_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();           
        }

        private void txtbHo_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbTen_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void dateEdNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbLuong_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }

        private void txtbMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (!this.txtbMaNV.Text.All(char.IsDigit)) 
            {
                e.Cancel = true;
                this.txtbMaNV.Select(0, this.txtbMaNV.Text.Length);
                this.err.SetIconPadding(this.txtbMaNV, -20);
                err.SetError(this.txtbMaNV, "Lỗi");
                toolTipCtrller.DefaultController.ShowHint("Chỉ nhập số!", this.txtbMaNV, DevExpress.Utils.ToolTipLocation.TopRight);
            }
        }

        private void txtbMaNV_Validated(object sender, EventArgs e)
        {
            err.Dispose();
        }

        private void txtbLuong_Validating(object sender, CancelEventArgs e)
        {
            long luong;
            long.TryParse(this.txtbLuong.Text.Trim(), out luong);
            if (luong < 4000000)
            {
                e.Cancel = true; 
                this.txtbLuong.Select(0, this.txtbLuong.Text.Length);
                this.err.SetIconPadding(this.txtbLuong, -20);
                this.err.SetError(this.txtbLuong, "Lỗi");
                toolTipCtrller.DefaultController.ShowHint("Lương >= 4.000.000!", this.txtbLuong, DevExpress.Utils.ToolTipLocation.TopRight);
            }
        }

        private void txtbLuong_Validated(object sender, EventArgs e)
        {
            err.Dispose();
        }

        private void txtbHo_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(this.txtbHo.Text, Program.namePattern))
            {
                e.Cancel = true;
                this.txtbHo.Select(0, this.txtbHo.Text.Length);
                this.err.SetIconPadding(this.txtbHo, -20);
                err.SetError(this.txtbHo, "Lỗi");
                toolTipCtrller.DefaultController.ShowHint("Họ không hợp lệ!", this.txtbHo, DevExpress.Utils.ToolTipLocation.TopRight);
            }
        }

        private void txtbHo_Validated(object sender, EventArgs e)
        {
            err.SetError(this.txtbHo, String.Empty);
        }

        private void txtbTen_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(this.txtbTen.Text, Program.namePattern))
            {
                e.Cancel = true;
                this.txtbTen.Select(0, this.txtbTen.Text.Length);
                this.err.SetIconPadding(this.txtbTen, -20);
                err.SetError(this.txtbTen, "Lỗi");
                toolTipCtrller.DefaultController.ShowHint("Tên không hợp lệ!", this.txtbTen, DevExpress.Utils.ToolTipLocation.TopRight);
            }
        }

        private void txtbTen_Validated(object sender, EventArgs e)
        {
            err.SetError(this.txtbTen, String.Empty);
        }

        private void grdVwNV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {         
            this.err.Dispose();
            int[] selectedRowHandles = grdVwNV.GetSelectedRows();
            int columns = grdVwNV.Columns.Count();

            bool checkEmptyCells = false;
            for (int i = 0; i < columns; i++)
            {
                try
                {
                    if (grdVwNV.GetRowCellValue(selectedRowHandles[0], grdVwNV.Columns[i]).ToString().Trim() == "")
                    {
                        checkEmptyCells = true;
                        break;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            if (((checkEmptyCells || (this.qlvtDS.NhanVien.Count - 1) == this.nvBDS.Position) && this.isAdding == true) || (this.nvBDS.Position == editPosition && this.isEditing == true))
            {
                writableNVControl(1);
                checkEmpty();
            }
            else
            {
                writableNVControl(0);
                checkEmpty();
            }

            if (tableStates.Count != 0)
            {
                this.btnPhucHoiNV.Enabled = true;
            }
        }

        private void cnGrCtrl_SizeChanged(object sender, EventArgs e)
        {
            this.panelCN.Left = (this.grCtrlCN.Width / 2) - (this.panelCN.Width / 2);
        }
        #endregion

        #region additional functions
        private void checkEmpty()
        {
            long luong;
            long.TryParse(this.txtbLuong.Text.Trim(), out luong);
            if (this.txtbMaNV.Text.Trim() == "" || this.txtbHo.Text.Trim() == "" ||
               this.txtbTen.Text.Trim() == "" || this.dateEdNgaySinh.Text == "" ||
               (this.txtbLuong.Text.Trim() == "" || luong < 4000000) || this.txtbDiaChi.Text.Trim() == "" ||
               !this.txtbMaNV.Text.Trim().All(char.IsDigit) || !Regex.IsMatch(this.txtbHo.Text, Program.namePattern) ||
               !Regex.IsMatch(this.txtbTen.Text, Program.namePattern) || this.txtbMaNV.ReadOnly == true)
            {
                this.btnGhiNV.Enabled = false;
                if (tableStates.Count == 0)
                {
                    this.btnPhucHoiNV.Enabled = false;
                }
            }
            else
            {
                this.btnGhiNV.Enabled = true;
                if(tableStates.Count != 0)
                {
                    this.btnPhucHoiNV.Enabled = true;
                }
                
            }
        }

        private bool checkConflictedMaNV(String maNVMoi)
        {
            try
            {
                String cmd = "exec SP_LAYMANV '" + maNVMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 1 && maNVSua == -1)
                {
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && maNVSua != -1 && this.txtbMaNV.Text != maNVSua.ToString())
                {
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 1 && maNVSua != -1 && this.txtbMaNV.Text == maNVSua.ToString())
                {
                    return false;
                }
                    
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Lỗi: " + e.Message, "Có lỗi xảy ra", MessageBoxButtons.OK); 
            }
            return false;
        }

        private void writableNVControl(int flag)
        {
            if(flag == 1)
            {
                this.txtbMaNV.ReadOnly = false;
                this.txtbHo.ReadOnly = false;
                this.txtbTen.ReadOnly = false;
                this.dateEdNgaySinh.ReadOnly = false;
                this.txtbLuong.ReadOnly = false;
                this.txtbDiaChi.ReadOnly = false;
            }
            else
            {
                this.txtbMaNV.ReadOnly = true;
                this.txtbHo.ReadOnly = true;
                this.txtbTen.ReadOnly = true;
                this.dateEdNgaySinh.ReadOnly = true;
                this.txtbLuong.ReadOnly = true;
                this.txtbDiaChi.ReadOnly = true;
            }
            
        }
        #endregion

        private void storeDtTbState()
        {
            DataTable copied = this.qlvtDS.NhanVien.Copy();
            tableStates.Push(copied);

        }       
    }
}
