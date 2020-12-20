using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_PT_DevExpressPJ.reports.subformsRP
{
    public partial class subFormHDNV : Form
    {
        public subFormHDNV()
        {
            InitializeComponent();
            this.AcceptButton = this.btnXem;
            this.CancelButton = this.btnThoat;
        }

        private void subFormHDNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDS.HoTenNV' table. You can move, or remove it, as needed.
            this.hoTenNVTableAdapter.Fill(this.qlvtDS.HoTenNV);
            this.qlvtDS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLVTDataSet.NhanVien' table.
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.qlvtDS.HoTenNV);

            cbxTenCN.DataSource = Program.bds_dspm;
            cbxTenCN.DisplayMember = "TENCN";
            cbxTenCN.ValueMember = "TENSERVER";
            cbxTenCN.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbxTenCN.Enabled = true;
            }
            else
            {
                cbxTenCN.Enabled = false;
            }
        }

        private void cbxTenCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxTenCN.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbxTenCN.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.Write(ex.Message); }

            if (cbxTenCN.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoTenNVTableAdapter.Fill(this.qlvtDS.HoTenNV);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {           
            if (this.cbxMaNV.Text == string.Empty)
            {
                MessageBox.Show("Chọn mã nhân viên!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }
            else if (this.cbxThangTruoc.Text == string.Empty || this.cbxThangSau.Text == string.Empty)
            {
                MessageBox.Show("Chọn tháng!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }
            else if (this.cbxNamTruoc.Text == string.Empty || this.cbxNamSau.Text == string.Empty)
            {
                MessageBox.Show("Chọn năm!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                int thangTruoc = int.Parse(this.cbxThangTruoc.Text);
                int namTruoc = int.Parse(this.cbxNamTruoc.Text);
                int thangSau = int.Parse(this.cbxThangSau.Text);
                int namSau = int.Parse(this.cbxNamSau.Text);
                HoatDongNVRP rp = null;
                rp = new HoatDongNVRP(int.Parse(cbxMaNV.Text.Trim()), new DateTime(namTruoc, thangTruoc, 1), new DateTime(namSau, thangSau, 1));                
                ReportPrintTool prTl = new ReportPrintTool(rp);
                prTl.ShowPreviewDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
