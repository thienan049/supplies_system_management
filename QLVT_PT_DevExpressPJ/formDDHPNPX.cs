using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVT_PT_DevExpressPJ.subforms;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formDDHPNPX : Form
    {
        int currentPositionDH = -1;
        int currentPositionPN = -1;
        int currentPositionPX = -1;
        //bool isLoadedPN = false;
        bool isLoadedPX = false;

        public formDDHPNPX()
        {
            InitializeComponent();
        }

        #region form's main processing
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Form's main processing  //////////////////////////////////////////////////////////////////////////////////
        private void formDDHPNPX_Load(object sender, EventArgs e)
        {
            qlvtDS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLVTDataSet.DatHang' table.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);
            // TODO: This line of code loads data into the 'qlvtDS.CTDDH' table. 
            this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctddhTableAdapter.Fill(this.qlvtDS.CTDDH);

            // TODO: This line of code loads data into the 'qlvtDS.PhieuNhap' table.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);
            // TODO: This line of code loads data into the 'qlvtDS.CTPN' table.
            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.qlvtDS.CTPN);
            //this.isLoadedPN = true;

            this.grBxPN.Visible = false;
            this.grBxPX.Visible = false;
            this.grBxDDH.Dock = DockStyle.Fill;

            if (Program.mGroup == "CONGTY")
            {
                this.ddhContextMenu.Enabled = false;
                this.ctddhContextMenu.Enabled = false;
                this.pnContextMenu.Enabled = false;
                this.ctpnContextMenu.Enabled = false;
                this.pxContextMenu.Enabled = false;
                this.ctpxContextMenu.Enabled = false;
            }
            else
            {
                this.ddhContextMenu.Enabled = true;
                this.ctddhContextMenu.Enabled = true;
                this.pnContextMenu.Enabled = true;
                this.ctpnContextMenu.Enabled = true;
                this.pxContextMenu.Enabled = true;
                this.ctpxContextMenu.Enabled = true;
                if (Program.mGroup == "CHINHANH")
                {

                }
                else if (Program.mGroup == "USER")
                {

                }
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grBxDDH.Dock = DockStyle.Top;

            if (this.grBxPN.Visible == false)
            {
                this.grBxPN.Visible = true;
                this.grBxPN.Dock = DockStyle.Fill;
                this.grBxPX.Visible = false;
            }else
            {
                this.grBxPN.Visible = false;
                this.grBxDDH.Dock = DockStyle.Fill;
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.grBxDDH.Dock = DockStyle.Top;

            if (this.grBxPX.Visible == false)
            {
                if (isLoadedPX == false)
                {
                    // TODO: This line of code loads data into the 'qlvtDS.PhieuXuat' table.
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);
                    // TODO: This line of code loads data into the 'qlvtDS.CTPX' table.
                    this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpxTableAdapter.Fill(this.qlvtDS.CTPX);
                    this.isLoadedPX = true;
                }
                this.grBxPX.Visible = true;
                this.grBxPX.Dock = DockStyle.Fill;
                this.grBxPN.Visible = false;
            }else
            {
                this.grBxPX.Visible = false;
                this.grBxDDH.Dock = DockStyle.Fill;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.grBxDDH.Visible == true)
            {
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);
                this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctddhTableAdapter.Fill(this.qlvtDS.CTDDH);
            }

            if(this.grBxPN.Visible == true)
            {
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);
                this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpnTableAdapter.Fill(this.qlvtDS.CTPN);
            }

            if(this.grBxPX.Visible == true)
            {
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);
                this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpxTableAdapter.Fill(this.qlvtDS.CTPX);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region don dat hang
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Đơn đặt hàng  //////////////////////////////////////////////////////////////////////////////////
        private void ddhContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.ddhContextMenu.Close();
            if (ddhContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                subFormDDH sfDDH = new subFormDDH();
                sfDDH.Owner = Program.formChinh;
                sfDDH.ShowDialog();
            }
            else if (ddhContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionDH = dhBDS.Position;
                subFormCTDDH sfCTDDH = new subFormCTDDH();
                sfCTDDH.Owner = Program.formChinh;
                sfCTDDH.ShowDialog();
            }
            else if (ddhContextMenu.Items.IndexOf(e.ClickedItem) == 2)
            {
                subFormPN sfPN = new subFormPN();
                sfPN.Owner = Program.formChinh;
                sfPN.ShowDialog();
            }
            else if (ddhContextMenu.Items.IndexOf(e.ClickedItem) == 3)
            {
                xoaDonDatHang();
            }
        }

        private void ddhContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.dhBDS.Count == 0)
            {
                this.ddhContextMenu.Items[3].Visible = false;
            }
            else
            {
                this.ddhContextMenu.Items[3].Visible = true;
            }
            int found = this.pnBDS.Find("MASODDH", ((DataRowView)dhBDS[dhBDS.Position])["MASODDH"].ToString());
            if (found > -1)
            {
                this.ddhContextMenu.Items[2].Visible = false;
            }else
            {
                this.ddhContextMenu.Items[2].Visible = true;
            }
        }

        private void xoaDonDatHang()
        {
            if (ctddhBDS_DDH.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng đã kê khai chi tiết, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa đơn đặt hàng này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maddh = string.Empty;
                try
                {
                    maddh = ((DataRowView)dhBDS[dhBDS.Position])["MASODDH"].ToString();
                    dhBDS.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.qlvtDS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);
                    dhBDS.Position = dhBDS.Find("MASODDH", maddh);
                    return;
                }
            }
        }
        #endregion

        #region chi tiet don dat hang
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Chi tiết đơn đặt hàng  //////////////////////////////////////////////////////////////////////////////////
        private void ctddhContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.ctddhContextMenu.Close();
            if (ctddhContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                this.currentPositionDH = dhBDS.Position;
                subFormCTDDH sfCTDDH = new subFormCTDDH();
                sfCTDDH.Owner = Program.formChinh;
                sfCTDDH.ShowDialog();
            }
            else if (ctddhContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionDH = dhBDS.Position;
                xoaChiTietDonDatHang();
            }
        }

        private void ctddhContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.ctddhBDS_DDH.Count == 0)
            {
                this.ctddhContextMenu.Items[1].Visible = false;
            }
            else
            {
                this.ctddhContextMenu.Items[1].Visible = true;
            }
        }

        private void xoaChiTietDonDatHang()
        {
            //if (this.ctddhBDS_DDH.Count == 0)
            //{
            //    MessageBox.Show("Không tồn tại phiếu để xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
            //    return;
            //}
            if (MessageBox.Show("Bạn muốn xóa chi tiết đơn đặt hàng này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mactddh = string.Empty;
                try
                {
                    mactddh = ((DataRowView)ctddhBDS_DDH[ctddhBDS_DDH.Position])["MASODDH"].ToString();
                    ctddhBDS_DDH.RemoveCurrent();
                    this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctddhTableAdapter.Update(this.qlvtDS.CTDDH);
                    this.reloadDDH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.ctddhTableAdapter.Fill(this.qlvtDS.CTDDH);
                    ctddhBDS_DDH.Position = ctddhBDS_DDH.Find("MASODDH", mactddh);
                    return;
                }
            }
        }
        #endregion

        #region phieu nhap
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Phiếu nhập  //////////////////////////////////////////////////////////////////////////////////
        private void pnContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.pnContextMenu.Close();
            if (pnContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                subFormPN sfPN = new subFormPN();
                sfPN.Owner = Program.formChinh;
                sfPN.ShowDialog();
            }
            else if (pnContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionPN = pnBDS.Position;
                subFormCTPN sfCTPN = new subFormCTPN();
                sfCTPN.Owner = Program.formChinh;
                sfCTPN.ShowDialog();
            }
            else if (pnContextMenu.Items.IndexOf(e.ClickedItem) == 2)
            {
                xoaPhieuNhap();
            }
        }

        private void pnContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.pnBDS.Count == 0)
            {
                this.pnContextMenu.Items[2].Visible = false;
            }
            else
            {
                this.pnContextMenu.Items[2].Visible = true;
            }
        }

        private void xoaPhieuNhap()
        {
            if (ctpnBDS_PN.Count > 0)
            {
                MessageBox.Show("Phiếu nhập đã kê khai chi tiết, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa phiếu nhập này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mapn = string.Empty;
                try
                {
                    mapn = ((DataRowView)pnBDS[pnBDS.Position])["MAPN"].ToString();
                    pnBDS.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.qlvtDS.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);
                    pnBDS.Position = pnBDS.Find("MAPN", mapn);
                    return;
                }
            }
        }
        #endregion

        #region chi tiet phieu nhap
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Chi tiết phiếu nhập  //////////////////////////////////////////////////////////////////////////////////
        private void ctpnContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.ctpnContextMenu.Close();
            if (ctpnContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                this.currentPositionPN = pnBDS.Position;
                subFormCTPN sfCTPN = new subFormCTPN();
                sfCTPN.Owner = Program.formChinh;
                sfCTPN.ShowDialog();
            }
            else if (ctpnContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionPN = pnBDS.Position;
                xoaChiTietPhieuNhap();
            }
        }

        private void ctpnContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.ctpnBDS_PN.Count == 0)
            {
                this.ctpnContextMenu.Items[1].Visible = false;
            }
            else
            {
                this.ctpnContextMenu.Items[1].Visible = true;
            }
        }

        private void xoaChiTietPhieuNhap()
        {
            if (MessageBox.Show("Bạn muốn xóa chi tiết phiếu nhập này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mactpn = string.Empty;
                try
                {
                    mactpn = ((DataRowView)ctpnBDS_PN[ctpnBDS_PN.Position])["MAPN"].ToString();
                    ctpnBDS_PN.RemoveCurrent();
                    this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpnTableAdapter.Update(this.qlvtDS.CTPN);
                    this.reloadPN();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.ctpnTableAdapter.Fill(this.qlvtDS.CTPN);
                    ctpnBDS_PN.Position = ctpnBDS_PN.Find("MAPN", mactpn);
                    return;
                }
            }
        }
        #endregion

        #region phieu xuat
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Phiếu xuất  //////////////////////////////////////////////////////////////////////////////////
        private void pxContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.pxContextMenu.Close();
            if (pxContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                subFormPX sfPX = new subFormPX();
                sfPX.Owner = Program.formChinh;
                sfPX.ShowDialog();
            }
            else if (pxContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionPX = pxBDS.Position;
                subFormCTPX sfCTPX = new subFormCTPX();
                sfCTPX.Owner = Program.formChinh;
                sfCTPX.ShowDialog();
            }
            else if (pxContextMenu.Items.IndexOf(e.ClickedItem) == 2)
            {
                xoaPhieuXuat();
            }
        }

        private void pxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.pxBDS.Count == 0)
            {
                this.pnContextMenu.Items[2].Visible = false;
            }
            else
            {
                this.pnContextMenu.Items[2].Visible = true;
            }
        }

        private void xoaPhieuXuat()
        {
            if (ctpxBDS_PX.Count > 0)
            {
                MessageBox.Show("Phiếu xuất đã kê khai chi tiết, không thể xóa!", "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa phiếu xuất này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mapx = string.Empty;
                try
                {
                    mapx = ((DataRowView)pxBDS[pxBDS.Position])["MAPX"].ToString();
                    pxBDS.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.qlvtDS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);
                    pxBDS.Position = pxBDS.Find("MAPX", mapx);
                    return;
                }
            }
        }
        #endregion

        #region chi tiet phieu xuat
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Chi tiết phiếu xuất  //////////////////////////////////////////////////////////////////////////////////
        private void ctpxContextMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            this.ctpxContextMenu.Close();
            if (ctpxContextMenu.Items.IndexOf(e.ClickedItem) == 0)
            {
                this.currentPositionPX = pxBDS.Position;
                subFormCTPX sfCTPX = new subFormCTPX();
                sfCTPX.Owner = Program.formChinh;
                sfCTPX.ShowDialog();
            }
            else if (ctpxContextMenu.Items.IndexOf(e.ClickedItem) == 1)
            {
                this.currentPositionPX = pxBDS.Position;
                xoaChiTietPhieuXuat();
            }
        }

        private void ctpxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (this.ctpxBDS_PX.Count == 0)
            {
                this.ctpxContextMenu.Items[1].Visible = false;
            }
            else
            {
                this.ctpxContextMenu.Items[1].Visible = true;
            }
        }

        private void xoaChiTietPhieuXuat()
        {
            if (MessageBox.Show("Bạn muốn xóa chi tiết phiếu xuất này?", "Xác nhận xóa dữ liệu", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mactpx = string.Empty;
                try
                {
                    mactpx = ((DataRowView)ctpxBDS_PX[ctpxBDS_PX.Position])["MAPX"].ToString();
                    ctpxBDS_PX.RemoveCurrent();
                    this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ctpxTableAdapter.Update(this.qlvtDS.CTPX);
                    this.reloadPX();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa dữ liệu", MessageBoxButtons.OK);
                    this.ctpxTableAdapter.Fill(this.qlvtDS.CTPX);
                    ctpxBDS_PX.Position = ctpxBDS_PX.Find("MAPX", mactpx);
                    return;
                }
            }
        }
        #endregion

        #region get binding sources/dataset
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Get binding sources/ dataset  //////////////////////////////////////////////////////////////////////////////////
        public BindingSource getFormDDHPNPX_dhBDS()
        {
            return this.dhBDS;
        }

        public BindingSource getFormDDHPNPX_ctddhBDS()
        {
            return this.ctddhBDS_DDH;
        }

        public BindingSource getFormDDHPNPX_pnBDS()
        {
            return this.pnBDS;
        }

        public BindingSource getFormDDHPNPX_ctpnBDS()
        {
            return this.ctpnBDS_PN;
        }

        public BindingSource getFormDDHPNPX_pxBDS()
        {
            return this.pxBDS;
        }

        public BindingSource getFormDDHPNPX_ctpxBDS()
        {
            return this.ctpxBDS_PX;
        }

        public QLVTDataSet getFormDDHPNPX_qlvtDS()
        {
            return this.qlvtDS;
        }
        #endregion

        #region additional functions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////  Additional functions  //////////////////////////////////////////////////////////////////////////////////
        public void reloadDDH()
        {
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDS.DatHang);
            if (currentPositionDH != -1)
            {
                this.dhBDS.Position = currentPositionDH;
            }
        }

        public void reloadPN()
        {
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDS.PhieuNhap);
            if (currentPositionPN != -1)
            {
                this.pnBDS.Position = currentPositionPN;
            }
        }

        public void reloadPX()
        {
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qlvtDS.PhieuXuat);
            if (currentPositionPX != -1)
            {
                this.pxBDS.Position = currentPositionPX;
            }
        }
        #endregion       
    }
}
