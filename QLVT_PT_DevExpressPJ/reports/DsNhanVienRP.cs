using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_PT_DevExpressPJ
{
    public partial class DsNhanVienRP : DevExpress.XtraReports.UI.XtraReport
    {
        public DsNhanVienRP()
        {
            InitializeComponent();
            this.sqlDataSource_DSNV.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource_DSNV.Fill();            
        }
    }
}
