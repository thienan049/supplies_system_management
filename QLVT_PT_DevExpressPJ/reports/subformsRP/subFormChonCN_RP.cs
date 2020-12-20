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
    public partial class subFormChonCN_RP : Form
    {
        public subFormChonCN_RP()
        {
            InitializeComponent();
            this.AcceptButton = this.btnXem;
            this.CancelButton = this.btnThoat;
        }

        private void subFormChonCN_RP_Load(object sender, EventArgs e)
        {
            cbxTenCN.DataSource = Program.bds_dspm;
            cbxTenCN.DisplayMember = "TENCN";
            cbxTenCN.ValueMember = "TENSERVER";
            cbxTenCN.SelectedIndex = Program.mChinhanh;
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
            if (Program.chosenRP == 1)
            {
                try
                {
                    DsNhanVienRP rp = new DsNhanVienRP();
                    rp.lblTitle.Text = "DANH SÁCH NHÂN VIÊN " + this.cbxTenCN.Text;
                    ReportPrintTool prTl = new ReportPrintTool(rp);
                    prTl.ShowPreviewDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }else if(Program.chosenRP == 2)
            {
                try
                {
                    DsVatTuRP rp = new DsVatTuRP();
                    ReportPrintTool prTl = new ReportPrintTool(rp);
                    prTl.ShowPreviewDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else if(Program.chosenRP == 3)
            {
                try
                {
                    DsDDHChuaCoPnRP rp = new DsDDHChuaCoPnRP();
                    rp.lblTitle.Text += " " + this.cbxTenCN.Text;
                    ReportPrintTool prTl = new ReportPrintTool(rp);
                    prTl.ShowPreviewDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
