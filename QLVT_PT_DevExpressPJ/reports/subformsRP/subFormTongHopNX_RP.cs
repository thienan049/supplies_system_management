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
    public partial class subFormTongHopNX_RP : Form
    {
        public subFormTongHopNX_RP()
        {
            InitializeComponent();
            this.AcceptButton = this.btnXem;
            this.CancelButton = this.btnThoat;
        }

        private void subFormTongHopNX_RP_Load(object sender, EventArgs e)
        {
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
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
            if (this.dateEdNgayTruoc.Text == string.Empty || this.dateEdNgaySau.Text == string.Empty)
            {
                MessageBox.Show("Chọn ngày!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                TongHopNhapXuatRP rp = null;
                rp = new TongHopNhapXuatRP(this.dateEdNgayTruoc.DateTime, this.dateEdNgaySau.DateTime);
                rp.ngayTitle.Text = "TỪ " + this.dateEdNgayTruoc.Text + " ĐẾN " + this.dateEdNgaySau.Text;
                ReportPrintTool prTl = new ReportPrintTool(rp);
                prTl.ShowPreviewDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateEdNgayTruoc_EditValueChanged(object sender, EventArgs e)
        {
            this.dateEdNgaySau.Properties.MinValue = this.dateEdNgayTruoc.DateTime;
        }
    }
}
