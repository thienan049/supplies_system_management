using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ.reports
{
    public partial class NhapXuatTheoThangRP : DevExpress.XtraReports.UI.XtraReport
    {
        public NhapXuatTheoThangRP(string loaiPhieu, DateTime thangTruoc, DateTime thangSau)
        {
            InitializeComponent();
            this.sqlDataSource_CTNXThang.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_CTNXThang.Queries[0].Parameters[0].Value = loaiPhieu;
            this.sqlDataSource_CTNXThang.Queries[0].Parameters[1].Value = thangTruoc;
            this.sqlDataSource_CTNXThang.Queries[0].Parameters[2].Value = thangSau;
            this.sqlDataSource_CTNXThang.Fill();
        }
    }
}
