using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TonerTakip
{
    public partial class rptDeneme : DevExpress.XtraReports.UI.XtraReport
    {
        
        public rptDeneme()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();   
            source.DataSource = source;
            //xrTable1.DataBindings.Add("");
        }

    }
}
