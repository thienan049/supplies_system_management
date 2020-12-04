namespace QLVT_PT_DevExpressPJ
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDHPNPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhLapTheoLoaiRP = new DevExpress.XtraBars.BarButtonItem();
            this.btnDsNVRP = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageLogin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonLoginGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonLogoutGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.nhanvienRibbPgGr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.vattuRibbPgGr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.khoRibbPgGr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.hdphieuPgGr = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttLblMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttLblHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttLblNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDsVTRP = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnNV,
            this.btnVT,
            this.btnKho,
            this.btnDDHPNPX,
            this.btnPhLapTheoLoaiRP,
            this.btnDsNVRP,
            this.btnDsVTRP});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 33;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageLogin,
            this.ribbonPageQT,
            this.ribbonPage1});
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.Size = new System.Drawing.Size(782, 158);
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân Viên";
            this.btnNV.Id = 19;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.Name = "btnNV";
            this.btnNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick_1);
            // 
            // btnVT
            // 
            this.btnVT.Caption = "Vật tư";
            this.btnVT.Id = 20;
            this.btnVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVT.ImageOptions.Image")));
            this.btnVT.Name = "btnVT";
            this.btnVT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVT_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 21;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.Name = "btnKho";
            this.btnKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDDHPNPX
            // 
            this.btnDDHPNPX.Caption = "Đơn đặt hàng | Phiếu nhập | Phiếu xuất";
            this.btnDDHPNPX.Id = 22;
            this.btnDDHPNPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDDHPNPX.ImageOptions.Image")));
            this.btnDDHPNPX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDDHPNPX.ImageOptions.LargeImage")));
            this.btnDDHPNPX.Name = "btnDDHPNPX";
            this.btnDDHPNPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDHPNPX_ItemClick);
            // 
            // btnPhLapTheoLoaiRP
            // 
            this.btnPhLapTheoLoaiRP.Caption = "Phiếu lập trong năm theo loại";
            this.btnPhLapTheoLoaiRP.Id = 30;
            this.btnPhLapTheoLoaiRP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhLapTheoLoaiRP.ImageOptions.Image")));
            this.btnPhLapTheoLoaiRP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhLapTheoLoaiRP.ImageOptions.LargeImage")));
            this.btnPhLapTheoLoaiRP.Name = "btnPhLapTheoLoaiRP";
            this.btnPhLapTheoLoaiRP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhLapTheoLoaiRP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhLapTheoLoaiRP_ItemClick);
            // 
            // btnDsNVRP
            // 
            this.btnDsNVRP.Caption = "Danh sách nhân viên";
            this.btnDsNVRP.Id = 31;
            this.btnDsNVRP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDsNVRP.ImageOptions.Image")));
            this.btnDsNVRP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDsNVRP.ImageOptions.LargeImage")));
            this.btnDsNVRP.Name = "btnDsNVRP";
            this.btnDsNVRP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDsNVRP_ItemClick);
            // 
            // ribbonPageLogin
            // 
            this.ribbonPageLogin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonLoginGroup,
            this.ribbonLogoutGroup});
            this.ribbonPageLogin.Name = "ribbonPageLogin";
            this.ribbonPageLogin.Text = "Login";
            // 
            // ribbonLoginGroup
            // 
            this.ribbonLoginGroup.ItemLinks.Add(this.btnDangNhap);
            this.ribbonLoginGroup.Name = "ribbonLoginGroup";
            this.ribbonLoginGroup.Text = "Login";
            // 
            // ribbonLogoutGroup
            // 
            this.ribbonLogoutGroup.ItemLinks.Add(this.btnDangXuat);
            this.ribbonLogoutGroup.Name = "ribbonLogoutGroup";
            this.ribbonLogoutGroup.Text = "Logout";
            // 
            // ribbonPageQT
            // 
            this.ribbonPageQT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.nhanvienRibbPgGr,
            this.vattuRibbPgGr,
            this.khoRibbPgGr,
            this.hdphieuPgGr});
            this.ribbonPageQT.Name = "ribbonPageQT";
            this.ribbonPageQT.Text = "Quản trị";
            // 
            // nhanvienRibbPgGr
            // 
            this.nhanvienRibbPgGr.ItemLinks.Add(this.btnNV);
            this.nhanvienRibbPgGr.Name = "nhanvienRibbPgGr";
            this.nhanvienRibbPgGr.Text = "Nhân viên";
            // 
            // vattuRibbPgGr
            // 
            this.vattuRibbPgGr.ItemLinks.Add(this.btnVT);
            this.vattuRibbPgGr.Name = "vattuRibbPgGr";
            this.vattuRibbPgGr.Text = "Vật tư";
            // 
            // khoRibbPgGr
            // 
            this.khoRibbPgGr.ItemLinks.Add(this.btnKho);
            this.khoRibbPgGr.Name = "khoRibbPgGr";
            this.khoRibbPgGr.Text = "Kho";
            // 
            // hdphieuPgGr
            // 
            this.hdphieuPgGr.ItemLinks.Add(this.btnDDHPNPX);
            this.hdphieuPgGr.Name = "hdphieuPgGr";
            this.hdphieuPgGr.Text = "Hóa đơn và phiếu";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Báo cáo";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhLapTheoLoaiRP);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDsNVRP);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Báo cáo";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttLblMaNV,
            this.sttLblHoTen,
            this.sttLblNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttLblMaNV
            // 
            this.sttLblMaNV.Name = "sttLblMaNV";
            this.sttLblMaNV.Size = new System.Drawing.Size(42, 17);
            this.sttLblMaNV.Text = "MANV";
            // 
            // sttLblHoTen
            // 
            this.sttLblHoTen.Name = "sttLblHoTen";
            this.sttLblHoTen.Size = new System.Drawing.Size(46, 17);
            this.sttLblHoTen.Text = "HOTEN";
            // 
            // sttLblNhom
            // 
            this.sttLblNhom.Name = "sttLblNhom";
            this.sttLblNhom.Size = new System.Drawing.Size(45, 17);
            this.sttLblNhom.Text = "NHOM";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDsVTRP);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo cáo";
            // 
            // btnDsVTRP
            // 
            this.btnDsVTRP.Caption = "Danh sách vật tư";
            this.btnDsVTRP.Id = 32;
            this.btnDsVTRP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnDsVTRP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnDsVTRP.Name = "btnDsVTRP";
            this.btnDsVTRP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDsVTRP_ItemClick);
            // 
            // formMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("formMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLoginGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel sttLblMaNV;
        public System.Windows.Forms.ToolStripStatusLabel sttLblHoTen;
        public System.Windows.Forms.ToolStripStatusLabel sttLblNhom;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonLogoutGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup nhanvienRibbPgGr;
        public DevExpress.XtraBars.BarButtonItem btnNV;
        public DevExpress.XtraBars.BarButtonItem btnVT;
        public DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup hdphieuPgGr;
        public DevExpress.XtraBars.BarButtonItem btnDDHPNPX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup vattuRibbPgGr;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup khoRibbPgGr;
        private DevExpress.XtraBars.BarButtonItem btnPhLapTheoLoaiRP;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDsNVRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDsVTRP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

