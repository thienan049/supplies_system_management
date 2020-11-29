﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_PT_DevExpressPJ
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            this.btnNV.Enabled = false;
            this.btnVT.Enabled = false;
            this.btnKho.Enabled = false;
            this.btnDDHPNPX.Enabled = false;
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
            this.btnNV.Enabled = false;
            this.btnVT.Enabled = false;
            this.btnKho.Enabled = false;
            this.btnDDHPNPX.Enabled = false;

            foreach (Form f in this.MdiChildren)
                f.Close();

            if (Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
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

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }


}