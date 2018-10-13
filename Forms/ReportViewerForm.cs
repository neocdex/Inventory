using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Inventory.Forms
{
    public partial class ReportViewerForm : Form
    {
        private XtraReport report;
        public ReportViewerForm()
        {
            InitializeComponent();
        }
        public XtraReport Report {
            set {
                this.report = value;
                documentViewer.DocumentSource = report;
                if (report != null)
                {
                    report.CreateDocument();                    
                }
            }
        }
    }
}
