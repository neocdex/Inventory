using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventory.Reports
{
    public partial class ItemByWarehouse : /*DevExpress.XtraReports.UI.XtraReport*/ BaseReport
    {
        public ItemByWarehouse()
        {
            InitializeComponent();
        }

        private void ItemByWarehouse_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
