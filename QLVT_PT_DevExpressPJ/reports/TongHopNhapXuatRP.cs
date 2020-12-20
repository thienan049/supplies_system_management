using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ.reports
{
    public partial class TongHopNhapXuatRP : DevExpress.XtraReports.UI.XtraReport
    {
        public TongHopNhapXuatRP(DateTime ngayTruoc, DateTime ngaySau)
        {
            InitializeComponent();
            this.sqlDataSource_THNX.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_THNX.Queries[0].Parameters[0].Value = ngayTruoc;
            this.sqlDataSource_THNX.Queries[0].Parameters[1].Value = ngaySau;
            this.sqlDataSource_THNX.Fill();
        }

    }
}
