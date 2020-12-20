using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLVT_PT_DevExpressPJ.reports.subformsRP;
using QLVT_PT_DevExpressPJ.reports;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ReportPrintTool prTl = null;

        public formMain()
        {
            InitializeComponent();
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                formDangNhap f = new formDangNhap();
                f.MdiParent = this;
                f.Show();
            }

            this.btnDangXuat.Enabled = false;
            this.btnTaoTaiKhoan.Enabled = false;

            this.rbPgDanhMuc.Visible = false;
            this.rbPgBaoCao.Visible = false;
            
            this.KeyPreview = true;
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys.V))
        //    {
        //        this.btnNV.PerformClick();
        //        return true;
        //    }
        //    else if (keyData == (Keys.Space))
        //    {
        //        this.btnDangNhap.PerformClick();
        //        return true;
        //    }
        //    else if (keyData == (Keys.Escape))
        //    {
        //        this.btnDangXuat.PerformClick();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null)
            {
                frm.Activate();
                if(frm.Visible == false)
                {
                    frm.Visible = true;
                }
            }
            else
            {
                formDangNhap f = new formDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnDangNhap.Enabled = true;
            this.btnDangXuat.Enabled = false;
            this.btnTaoTaiKhoan.Enabled = false;

            this.rbPgDanhMuc.Visible = false;
            this.rbPgBaoCao.Visible = false;

            foreach (Form f in this.MdiChildren)
                f.Close();

            if (Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                formTaoTaiKhoan f = new formTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNV_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                formNhanVien f = new formNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formVatTu));
            if (frm != null) frm.Activate();
            else
            {
                formVatTu f = new formVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKho));
            if (frm != null) frm.Activate();
            else
            {
                formKho f = new formKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDDHPNPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDDHPNPX));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDDHPNPX = new formDDHPNPX();
                Program.formDDHPNPX.MdiParent = this;
                Program.formDDHPNPX.Show();
            }
        }

        private void btnPhLapTheoLoaiRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(subFormPhieuLap));
            if (frm != null) frm.Activate();
            else
            {
                subFormPhieuLap sfPL = new subFormPhieuLap();
                sfPL.Owner = Program.formChinh;
                sfPL.ShowDialog();
            }
        }

        private void btnDsNVRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.chosenRP = 1;
            if (Program.mGroup == "CONGTY")
            {               
                Form frm = this.CheckExists(typeof(subFormChonCN_RP));
                if (frm != null) frm.Activate();
                else
                {
                    subFormChonCN_RP sfCN = new subFormChonCN_RP();
                    sfCN.Owner = Program.formChinh;
                    sfCN.ShowDialog();
                }
            }else
            {
                try
                {
                    DsNhanVienRP rp = new DsNhanVienRP();
                    if(Program.mChinhanh == 0)
                    {
                        rp.lblTitle.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH 1";
                    }else if(Program.mChinhanh == 1)
                    {
                        rp.lblTitle.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH 2";
                    }
                    
                    prTl = new ReportPrintTool(rp);
                    prTl.ShowPreviewDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDsVTRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.chosenRP = 2;
            try
            {
                DsVatTuRP rp = new DsVatTuRP();
                prTl = new ReportPrintTool(rp);
                prTl.ShowPreviewDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDdhChuaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.chosenRP = 3;
            if (Program.mGroup == "CONGTY")
            {
                Form frm = this.CheckExists(typeof(subFormChonCN_RP));
                if (frm != null) frm.Activate();
                else
                {
                    subFormChonCN_RP sfCN = new subFormChonCN_RP();
                    sfCN.Owner = Program.formChinh;
                    sfCN.ShowDialog();
                }
            }
            else
            {
                try
                {
                    DsDDHChuaCoPnRP rp = new DsDDHChuaCoPnRP();
                    if (Program.mChinhanh == 0)
                    {
                        rp.lblTitle.Text += " CHI NHÁNH 1";
                    }
                    else if (Program.mChinhanh == 1)
                    {
                        rp.lblTitle.Text = " CHI NHÁNH 2";
                    }

                    prTl = new ReportPrintTool(rp);
                    prTl.ShowPreviewDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnNXThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(subFormNXTheoThang));
            if (frm != null) frm.Activate();
            else
            {
                subFormNXTheoThang sfNXTT = new subFormNXTheoThang();
                sfNXTT.Owner = Program.formChinh;
                sfNXTT.ShowDialog();
            }
        }

        private void btnHDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(subFormHDNV));
            if (frm != null) frm.Activate();
            else
            {
                subFormHDNV sfHDNV = new subFormHDNV();
                sfHDNV.Owner = Program.formChinh;
                sfHDNV.ShowDialog();
            }
        }

        private void btnTHNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(subFormTongHopNX_RP));
            if (frm != null) frm.Activate();
            else
            {
                subFormTongHopNX_RP sfTHNX = new subFormTongHopNX_RP();
                sfTHNX.Owner = Program.formChinh;
                sfTHNX.ShowDialog();
            }
        }
    }
}
