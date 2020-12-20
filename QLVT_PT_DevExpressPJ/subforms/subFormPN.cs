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

namespace QLVT_PT_DevExpressPJ.subforms
{
    public partial class subFormPN : Form
    {
        #region form loading
        public subFormPN()
        {
            InitializeComponent();
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            this.AcceptButton = this.btnThemPN;
            this.CancelButton = this.btnThoat;
        }
       
        private void subFormPN_Load(object sender, EventArgs e)
        {        
            this.qlvtDS.EnforceConstraints = false;
            this.pnBDS.DataSource = Program.formDDHPNPX.getFormDDHPNPX_pnBDS();

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qlvtDS.Kho);
          
            // TODO: This line of code loads data into the 'qlvtDS.V_DS_DDHCHUACOPN' table. 
            this.v_ds_ddhChuaCoPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_ds_ddhChuaCoPNTableAdapter.Fill(this.qlvtDS.V_DS_DDHCHUACOPN);
        }

        private void subFormPN_Shown(object sender, EventArgs e)
        {
            string maPNMoi = preparedMaPN();
            Program.formDDHPNPX.Enabled = false;
            this.pnBDS.AddNew();
            this.txtbMaPN.Text = maPNMoi;
            this.txtbMaPN.Select(0, this.txtbMaPN.Text.Length);
            this.txtbMaNV.Text = Program.username;
            this.dateEdNgayLap.EditValue = DateTime.Today;
            this.dateEdNgayLap.Properties.MaxValue = DateTime.Today;
            this.dateEdNgayLap.Select(0, this.dateEdNgayLap.Text.Length);
            int found = this.pnBDS.Find("MASODDH", ((DataRowView)Program.formDDHPNPX.getFormDDHPNPX_dhBDS()[Program.formDDHPNPX.getFormDDHPNPX_dhBDS().Position])["MASODDH"].ToString());
            if (found <= -1)
            {
                this.txtbMaSoDDH.Text = ((DataRowView)Program.formDDHPNPX.getFormDDHPNPX_dhBDS()[Program.formDDHPNPX.getFormDDHPNPX_dhBDS().Position])["MASODDH"].ToString().Trim();
            }          
            this.txtbMaNV.Text = Program.username;
            this.txtbMaKho.Text = ((DataRowView)Program.formDDHPNPX.getFormDDHPNPX_dhBDS()[Program.formDDHPNPX.getFormDDHPNPX_dhBDS().Position])["MAKHO"].ToString().Trim();           
        }


        private void subFormPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnBDS.CancelEdit();
            Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().PhieuNhap.RejectChanges();
            Program.formDDHPNPX.Enabled = true;
        }
        #endregion

        #region additional events
        private void btnThemPN_Click(object sender, EventArgs e)
        {
            string conflictErr = string.Empty;
            if (checkConflictedMaPN(this.txtbMaPN.Text.Trim(), out conflictErr))
            {
                MessageBox.Show(conflictErr, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Thêm phiếu nhập này?", "Xác nhận thêm dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                pnBDS.EndEdit();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Update(Program.formDDHPNPX.getFormDDHPNPX_qlvtDS().PhieuNhap);
               // MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }
       
        private void txtbMaPN_TextChanged(object sender, EventArgs e)
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

        private void txtbMaSoDDH_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void txtbMaKho_TextChanged(object sender, EventArgs e)
        {
            checkEmptyAndValid();
        }

        private void grdVwKho_ThemPN_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaKho.Text = ((DataRowView)this.khoBDS[this.khoBDS.Position])["MAKHO"].ToString().Trim();
        }

        private void grdVwViewDSDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtbMaSoDDH.Text = ((DataRowView)this.v_ds_ddhChuaCoPNBDS[this.v_ds_ddhChuaCoPNBDS.Position])["MASODDH"].ToString().Trim();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region additional funtions       
        private bool checkConflictedMaPN(string maPNMoi, out string conflictErr)
        {
            try
            {
                int maPNNumber;
                int.TryParse(maPNMoi.Substring(2), out maPNNumber);
                if (maPNNumber < 10)
                {
                    maPNMoi = "PN0" + maPNNumber;
                }
                String cmd = "exec SP_LAYMAPNPX '" +"PN', '"+ maPNMoi + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                if ((int)sqlcmd.ExecuteScalar() == 1)
                {
                    conflictErr = "Mã phiếu nhập đã tồn tại ở chi nhánh này!";
                    return true;
                }
                else if ((int)sqlcmd.ExecuteScalar() == 2)
                {
                    conflictErr = "Mã phiếu nhập đã tồn tại ở chi nhánh khác!";
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
            if (this.txtbMaPN.Text.Trim() == "" || this.dateEdNgayLap.Text == "" || this.txtbMaSoDDH.Text.Trim() == "" ||
                this.txtbMaKho.Text.Trim() == "" ||!Regex.IsMatch(this.txtbMaPN.Text, "^PN\\d+$") || 
                this.dateEdNgayLap.DateTime > DateTime.Today)
            {
                this.btnThemPN.Enabled = false;
            }
            else
            {
                this.btnThemPN.Enabled = true;
            }
        }

        private string preparedMaPN()
        {
            this.pnBDS.Sort = "MAPN";
            string value = ((DataRowView)this.pnBDS[this.pnBDS.Count - 1])["MAPN"].ToString().Trim();
            if (Regex.IsMatch(value, "^PN\\d+$")) 
            {
                int soPNMoi; int.TryParse(value.Substring(2), out soPNMoi);
                string err;
                soPNMoi += 1;
                while (checkConflictedMaPN((soPNMoi < 10 ? "PN0" + soPNMoi : "PN" + soPNMoi), out err))
                {
                    soPNMoi += 1;              
                }
                if (soPNMoi < 10)
                {
                    return "PN0" + (soPNMoi);
                }
                return "PN" + (soPNMoi);               
            }
            return string.Empty;         
        }
        #endregion       
    }
}
