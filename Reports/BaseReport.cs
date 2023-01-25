using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventory.Reports
{
    public partial class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BaseReport()
        {
            //DevExpress.Data.Helpers.IsDesignModeHelper.BypassDesignModeAlterationDetection = true;
            InitializeComponent();
        }

    }
}
