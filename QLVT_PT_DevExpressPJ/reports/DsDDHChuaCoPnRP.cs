using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ.reports
{
    public partial class DsDDHChuaCoPnRP : DevExpress.XtraReports.UI.XtraReport
    {
        public DsDDHChuaCoPnRP()
        {
            InitializeComponent();
            this.sqlDataSource_DSDDHChPN.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_DSDDHChPN.Fill();
        }

    }
}
