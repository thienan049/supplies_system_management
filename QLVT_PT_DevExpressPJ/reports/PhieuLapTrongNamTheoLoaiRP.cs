using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ
{
    public partial class PhieuLapTrongNamTheoLoaiRP : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuLapTrongNamTheoLoaiRP(string loaiPhieu, int nam)
        {
            InitializeComponent();
            this.sqlDataSource_PhieuLap.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_PhieuLap.Queries[0].Parameters[0].Value = loaiPhieu;
            this.sqlDataSource_PhieuLap.Queries[0].Parameters[1].Value = nam;
            this.sqlDataSource_PhieuLap.Fill();
        }

    }
}
