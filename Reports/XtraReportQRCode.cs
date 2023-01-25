using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Inventory.ORMDataModelCode;
using DevExpress.Xpo;
using System.Collections.Generic;

namespace Inventory.Reports
{
    public partial class XtraReportQRCode : DevExpress.XtraReports.UI.XtraReport
    {        
        public XtraReportQRCode()
        {
            InitializeComponent();           
                
        }

        private void GenerateQRCode()
        {
            Products p = (Products)GetCurrentRow() ;
            String QRCodeText = String.Concat(p.name, "\n", p.model, "\n", p.serialnumber, "\n", (p.brand_id != null)?p.brand_id.name:"");
            xrQRCode.Text = QRCodeText;            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            GenerateQRCode();
        }
        public void SetDataSource(List<Products> collection) {
            this.DataSource = collection;
        }
    }
}
