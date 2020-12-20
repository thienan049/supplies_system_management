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
    public partial class subFormNXTheoThang : Form
    {
        public subFormNXTheoThang()
        {
            InitializeComponent();
            this.AcceptButton = this.btnXem;
            this.CancelButton = this.btnThoat;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
            if (this.cbxLoaiPhieu.Text == string.Empty)
            {
                MessageBox.Show("Chọn loại phiếu!", "Lỗi lọc dữ liệu!", MessageBoxButtons.OK);
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
                string loaiPhieu = string.Empty;
                if (this.cbxLoaiPhieu.SelectedIndex == 0)
                {
                    loaiPhieu = "PN";
                }
                else
                {
                    loaiPhieu = "PX";
                }
                int thangTruoc = int.Parse(this.cbxThangTruoc.Text);
                int namTruoc = int.Parse(this.cbxNamTruoc.Text);
                int thangSau = int.Parse(this.cbxThangSau.Text);
                int namSau = int.Parse(this.cbxNamSau.Text);
                NhapXuatTheoThangRP rp = null;
                string title = null;
                if (Program.mChinhanh == 0)
                {
                    title = " CHI NHÁNH 1";
                }
                else if (Program.mChinhanh == 1)
                {
                    title = " CHI NHÁNH 2";
                }
                if (Program.mGroup == "CONGTY")
                {
                    rp = new NhapXuatTheoThangRP("CT", loaiPhieu, new DateTime(namTruoc, thangTruoc, 1), new DateTime(namSau, thangSau, 1));
                    rp.lblTitle.Text = "CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG " + this.cbxLoaiPhieu.Text.Substring(6).ToUpper() +
                                       " \nTỪ THÁNG " + thangTruoc + "-" + namTruoc + " ĐẾN THÁNG " + thangSau + "-" + namSau + " CỦA CÔNG TY";
                }else
                {
                    rp = new NhapXuatTheoThangRP("CN", loaiPhieu, new DateTime(namTruoc, thangTruoc, 1), new DateTime(namSau, thangSau, 1));
                    rp.lblTitle.Text = "CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG " + this.cbxLoaiPhieu.Text.Substring(6).ToUpper() +
                                       " \nTỪ THÁNG " + thangTruoc + "-" + namTruoc + " ĐẾN THÁNG " + thangSau + "-" + namSau + " CỦA" + title;
                }               
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
