using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ.reports
{
    public partial class HoatDongNVRP : DevExpress.XtraReports.UI.XtraReport
    {
        public HoatDongNVRP(int maNV, DateTime thangTruoc, DateTime thangSau)
        {
            InitializeComponent();
            this.sqlDataSource_HDNV.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_HDNV.Queries[0].Parameters[0].Value = maNV;
            this.sqlDataSource_HDNV.Queries[0].Parameters[1].Value = thangTruoc;
            this.sqlDataSource_HDNV.Queries[0].Parameters[2].Value = thangSau;
            this.sqlDataSource_HDNV.Fill();
        }

    }
}
