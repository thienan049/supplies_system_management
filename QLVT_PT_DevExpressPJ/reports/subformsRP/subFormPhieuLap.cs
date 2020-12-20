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
    public partial class subFormPhieuLap : Form
    {
        public subFormPhieuLap()
        {
            InitializeComponent();
            this.AcceptButton = this.btnXem;
            this.CancelButton = this.btnThoat;
        }

        private void subFormPhieuLap_Load(object sender, EventArgs e)
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
            if (this.cbxLoaiPhieu.Text == string.Empty)
            {
                MessageBox.Show("Chọn loại phiếu!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }else if(this.cbxNam.Text == string.Empty)
            {
                MessageBox.Show("Chọn năm!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                string loaiPhieu = string.Empty;
                if (this.cbxLoaiPhieu.SelectedIndex == 0)
                {
                    loaiPhieu = "PN";
                }
                else
                {
                    loaiPhieu = "PX";
                }
                PhieuLapTrongNamTheoLoaiRP rp = new PhieuLapTrongNamTheoLoaiRP(loaiPhieu, int.Parse(this.cbxNam.Text));
                rp.lblTitle.Text = "DANH SÁCH " + this.cbxLoaiPhieu.Text.ToUpper() + " NHÂN VIÊN LẬP TRONG NĂM " + this.cbxNam.Text;
                ReportPrintTool prTl = new ReportPrintTool(rp);
                prTl.ShowPreviewDialog();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
