namespace QLVT_PT_DevExpressPJ.reports
{
    partial class TongHopNhapXuatRP
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField4 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(32.55214F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongHopNhapXuatRP));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell14 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource_THNX = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.calFieldTyleNhap = new DevExpress.XtraReports.UI.CalculatedField();
            this.calFieldTyleXuat = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.ngayTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 6F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.pageInfo1.StylePriority.UseFont = false;
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 6.00001F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(324.9999F, 23F);
            this.pageInfo2.StylePriority.UseFont = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTab1});
            this.Detail.HeightF = 236.9792F;
            this.Detail.Name = "Detail";
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabDataCell1,
            this.crossTabHeaderCell2,
            this.crossTabHeaderCell3,
            this.crossTabHeaderCell14,
            this.crossTabHeaderCell1,
            this.crossTabHeaderCell4,
            this.crossTabDataCell2,
            this.crossTabHeaderCell5,
            this.crossTabDataCell3,
            this.crossTabHeaderCell6,
            this.crossTabDataCell4,
            this.crossTabHeaderCell8,
            this.crossTabTotalCell1,
            this.crossTabTotalCell3,
            this.crossTabTotalCell4,
            this.crossTabTotalCell5});
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(105.8389F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(177.2383F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(84.8392F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(177.241F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(84.84254F)});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "NHAP";
            crossTabDataField2.FieldName = "calFieldTyleNhap";
            crossTabDataField3.FieldName = "XUAT";
            crossTabDataField4.FieldName = "calFieldTyleXuat";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1,
            crossTabDataField2,
            crossTabDataField3,
            crossTabDataField4});
            this.xrCrossTab1.DataMember = "SP_TONGHOPNHAPXUAT";
            this.xrCrossTab1.DataSource = this.sqlDataSource_THNX;
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrCrossTab1.Name = "xrCrossTab1";
            crossTabRowDefinition1.Visible = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            crossTabRowDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(32.55688F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(32.55214F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(32.55214F)});
            crossTabRowField1.FieldName = "NGAY";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.xrCrossTab1.SizeF = new System.Drawing.SizeF(630F, 130.2133F);
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.ColumnIndex = 1;
            this.crossTabDataCell1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.RowIndex = 2;
            this.crossTabDataCell1.TextFormatString = "{0:#,##0.0}";
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.ColumnIndex = 1;
            this.crossTabHeaderCell2.ColumnSpan = 4;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.RowIndex = 0;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.RowIndex = 2;
            this.crossTabHeaderCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.crossTabHeaderCell3.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // crossTabHeaderCell14
            // 
            this.crossTabHeaderCell14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.crossTabHeaderCell14.ColumnIndex = 0;
            this.crossTabHeaderCell14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell14.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell14.Name = "crossTabHeaderCell14";
            this.crossTabHeaderCell14.RowIndex = 0;
            this.crossTabHeaderCell14.RowSpan = 2;
            this.crossTabHeaderCell14.Text = "NGÀY";
            this.crossTabHeaderCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.crossTabHeaderCell1.ColumnIndex = 1;
            this.crossTabHeaderCell1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell1.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 1;
            this.crossTabHeaderCell1.Text = "NHẬP";
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.crossTabHeaderCell4.ColumnIndex = 3;
            this.crossTabHeaderCell4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell4.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 1;
            this.crossTabHeaderCell4.Text = "XUẤT";
            this.crossTabHeaderCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell2
            // 
            this.crossTabDataCell2.ColumnIndex = 3;
            this.crossTabDataCell2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabDataCell2.Name = "crossTabDataCell2";
            this.crossTabDataCell2.RowIndex = 2;
            this.crossTabDataCell2.TextFormatString = "{0:#,##0.0}";
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.crossTabHeaderCell5.ColumnIndex = 2;
            this.crossTabHeaderCell5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell5.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.RowIndex = 1;
            this.crossTabHeaderCell5.Text = "TỶ LỆ";
            this.crossTabHeaderCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell3
            // 
            this.crossTabDataCell3.ColumnIndex = 2;
            this.crossTabDataCell3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabDataCell3.Name = "crossTabDataCell3";
            this.crossTabDataCell3.RowIndex = 2;
            this.crossTabDataCell3.TextFormatString = "{0:0.00%}";
            // 
            // crossTabHeaderCell6
            // 
            this.crossTabHeaderCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.crossTabHeaderCell6.ColumnIndex = 4;
            this.crossTabHeaderCell6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell6.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
            this.crossTabHeaderCell6.RowIndex = 1;
            this.crossTabHeaderCell6.Text = "TỶ LỆ";
            this.crossTabHeaderCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell4
            // 
            this.crossTabDataCell4.ColumnIndex = 4;
            this.crossTabDataCell4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabDataCell4.Name = "crossTabDataCell4";
            this.crossTabDataCell4.RowIndex = 2;
            this.crossTabDataCell4.TextFormatString = "{0:0.00%}";
            // 
            // crossTabHeaderCell8
            // 
            this.crossTabHeaderCell8.ColumnIndex = 0;
            this.crossTabHeaderCell8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
            this.crossTabHeaderCell8.RowIndex = 3;
            this.crossTabHeaderCell8.Text = "Cộng";
            this.crossTabHeaderCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.ColumnIndex = 1;
            this.crossTabTotalCell1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 3;
            this.crossTabTotalCell1.TextFormatString = "{0:#,##0.0}";
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.ColumnIndex = 2;
            this.crossTabTotalCell3.ForeColor = System.Drawing.Color.Black;
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 3;
            this.crossTabTotalCell3.TextFormatString = "{0:0.00%}";
            // 
            // crossTabTotalCell4
            // 
            this.crossTabTotalCell4.ColumnIndex = 3;
            this.crossTabTotalCell4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabTotalCell4.Name = "crossTabTotalCell4";
            this.crossTabTotalCell4.RowIndex = 3;
            this.crossTabTotalCell4.TextFormatString = "{0:#,##0.0}";
            // 
            // crossTabTotalCell5
            // 
            this.crossTabTotalCell5.ColumnIndex = 4;
            this.crossTabTotalCell5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossTabTotalCell5.Name = "crossTabTotalCell5";
            this.crossTabTotalCell5.RowIndex = 3;
            this.crossTabTotalCell5.TextFormatString = "{0:0.00%}";
            // 
            // sqlDataSource_THNX
            // 
            this.sqlDataSource_THNX.ConnectionName = "QLVT_PT_DevExpressPJ.Properties.Settings.QLVTConnectionString1";
            this.sqlDataSource_THNX.Name = "sqlDataSource_THNX";
            storedProcQuery1.Name = "SP_TONGHOPNHAPXUAT";
            queryParameter1.Name = "@THANGDAU";
            queryParameter1.Type = typeof(System.DateTime);
            queryParameter1.ValueInfo = "2017-01-01";
            queryParameter2.Name = "@THANGSAU";
            queryParameter2.Type = typeof(System.DateTime);
            queryParameter2.ValueInfo = "2017-12-31";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "SP_TONGHOPNHAPXUAT";
            this.sqlDataSource_THNX.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource_THNX.ResultSchemaSerializable = resources.GetString("sqlDataSource_THNX.ResultSchemaSerializable");
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // calFieldTyleNhap
            // 
            this.calFieldTyleNhap.DataMember = "SP_TONGHOPNHAPXUAT";
            this.calFieldTyleNhap.DataSource = this.sqlDataSource_THNX;
            this.calFieldTyleNhap.Expression = "Iif([NHAP]  !=  0 ,[NHAP] / Sum([NHAP]) ,[NHAP] /1)\n";
            this.calFieldTyleNhap.Name = "calFieldTyleNhap";
            // 
            // calFieldTyleXuat
            // 
            this.calFieldTyleXuat.DataMember = "SP_TONGHOPNHAPXUAT";
            this.calFieldTyleXuat.DataSource = this.sqlDataSource_THNX;
            this.calFieldTyleXuat.Expression = "Iif([XUAT]  !=  0 ,[XUAT] / Sum([XUAT]) ,[XUAT] /1)";
            this.calFieldTyleXuat.Name = "calFieldTyleXuat";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.ngayTitle,
            this.xrLabel1});
            this.GroupHeader1.HeightF = 151.9167F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLine1
            // 
            this.xrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(195.1888F, 109.5417F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(253.125F, 23F);
            // 
            // ngayTitle
            // 
            this.ngayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75.04171F);
            this.ngayTitle.Multiline = true;
            this.ngayTitle.Name = "ngayTitle";
            this.ngayTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ngayTitle.SizeF = new System.Drawing.SizeF(650F, 30.12498F);
            this.ngayTitle.StylePriority.UseFont = false;
            this.ngayTitle.StylePriority.UseTextAlignment = false;
            this.ngayTitle.Text = "TỪ dd/MM/yyyy ĐẾN dd/MM/yyyy";
            this.ngayTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.91668F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 52.12503F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BẢNG TỔNG HỢP NHẬT XUẤT\r\n";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TongHopNhapXuatRP
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calFieldTyleNhap,
            this.calFieldTyleXuat});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource_THNX});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 25, 100);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell14;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource_THNX;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.CalculatedField calFieldTyleNhap;
        private DevExpress.XtraReports.UI.CalculatedField calFieldTyleXuat;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        public DevExpress.XtraReports.UI.XRLabel ngayTitle;
    }
}
