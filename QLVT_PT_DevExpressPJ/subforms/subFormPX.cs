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
    public partial class subFormPX : Form
    {
        public subFormPX()
        {
            InitializeComponent();
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            this.AcceptButton = this.btnThemPX;
            this.CancelButton = this.btnThoat;           
        }

        #region form's main processing
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Form's main processing  //////////////////////////////////////////////////////////////////////////////////
        private void subFormPX_Load(object sender, EventArgs e)
        {
            this.qlvtDS.EnforceConstraints = false;
            this.pxBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_pxBDS();

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qlvtDS.Kho);
        }
        
        private void subFormPX_Shown(object sender, EventArgs e)
        {
            string maPXMoi = preparedMaPX();
            Program.formDDHPNPX.Enabled = false;
            this.pxBDS.AddNew();
            this.txtbMaPX.Text = maPXMoi;
            this.txtbMaPX.Select(0, this.txtbMaPX.Text.Length);
            this.txtbMaNV.Text = Program.username;
            this.dateEdNgayLap.EditValue = DateTime.Today;
            this.dateEdNgayLap.Select(0, this.dateEdNgayLap.Text.Length);
            this.txtbMaNV.Text = Program.username;
        }   

        private void subFormPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pxBDS.CancelEdit();
            Program.formDDHPNPX.Enabled = true;
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if (checkConflictedMaPX(this.txtbMaPX.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm phiếu xuất này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                trimValueBeforeWritting();
                pxBDS.EndEdit();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().PhieuXuat);
                this.Close();
            }
        }
        #endregion

        #region additional events
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional events  //////////////////////////////////////////////////////////////////////////////////
        private void txtbMaPX_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void dateEdNgayLap_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void dateEdNgayLap_EditValueChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbHoTenKH_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbMaKho_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void grdVwKho_ThemPX_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaKho.Text = ((DataRowView)this.khoBDS[this.khoBDS.Position])["MAKHO"].ToString().Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region additional funtions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional functions  //////////////////////////////////////////////////////////////////////////////////
        private bool checkConflictedMaPX(string maPXMoi, out string conflictErr)
        {
            try
            {
                int maPXNumber;
                int.TryParse(maPXMoi.Substring(2), out maPXNumber);
                if (maPXNumber < 10)
                {
                    maPXMoi = "PX0" + maPXNumber;
                }
                String cmd = "exec SP_LAYMAPNPX '" + "PX', '" + maPXMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 1)
                {
                    conflictErr = "Mã phiếu xuất đã tồn tại ở chi nhánh này!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2)
                {
                    conflictErr = "Mã phiếu xuất đã tồn tại ở chi nhánh khác!";
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

        private void checkEmptyAndValid()
        {
            if (this.txtbMaPX.Text.Trim() == "" || this.dateEdNgayLap.Text == "" || this.txtbHoTenKH.Text.Trim() == "" ||
                this.txtbMaKho.Text.Trim() == "" || !Regex.IsMatch(this.txtbMaPX.Text, "^PX\\d+$") ||
                !Regex.IsMatch(this.txtbHoTenKH.Text, "^([aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ']+\\s?)+$") ||
                 this.dateEdNgayLap.DateTime > DateTime.Today)
            {
                this.btnThemPX.Enabled = false;
            }
            else
            {
                this.btnThemPX.Enabled = true;
            }
        }

        private string preparedMaPX()
        {
            this.pxBDS.Sort = "MAPX";
            string value = ((DataRowView)this.pxBDS[this.pxBDS.Count - 1])["MAPX"].ToString().Trim();
            if (Regex.IsMatch(value, "^PX\\d+$"))
            {
                int soPXMoi; int.TryParse(value.Substring(2), out soPXMoi);
                string err;
                soPXMoi += 1;
                while (checkConflictedMaPX((soPXMoi < 10 ? "PX0" + soPXMoi : "PX" + soPXMoi), out err))
                {
                    soPXMoi += 1;
                }
                if (soPXMoi < 10)
                {
                    return "PX0" + (soPXMoi);
                }
                return "PX" + (soPXMoi);
            }
            return string.Empty;
        }

        private void trimValueBeforeWritting()
        {
            this.txtbHoTenKH.Text = this.txtbHoTenKH.Text.Trim();
        }
        #endregion
    }
}
