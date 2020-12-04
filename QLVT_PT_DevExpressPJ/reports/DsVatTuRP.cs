using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ.reports
{
    public partial class DsVatTuRP : DevExpress.XtraReports.UI.XtraReport
    {
        public DsVatTuRP()
        {
            InitializeComponent();
            this.sqlDataSource_VT.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_VT.Fill();
        }

    }
}
