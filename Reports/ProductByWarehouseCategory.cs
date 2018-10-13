using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventory.Reports
{
    public partial class ProductByWarehouseCategory : DevExpress.XtraReports.UI.XtraReport
    {
        private string fOrderBy = string.Empty;
        private XRColumnSortOrder fSortOrder;
        public string OrderBy {
            set { fOrderBy = value; }
        }

        public string SortOrder {
            set {
                if (value.Equals("A")) fSortOrder = XRColumnSortOrder.Ascending;
                else fSortOrder = XRColumnSortOrder.Descending;
            }
        }
        
        public ProductByWarehouseCategory()
        {
            InitializeComponent();
        }

        private void ProductByWarehouseCategory_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Detail.SortFields.Add(new GroupField(fOrderBy, fSortOrder));
        }

    }
}
