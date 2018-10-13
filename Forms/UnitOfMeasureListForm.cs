using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using Inventory.ORMDataModelCode;

namespace Inventory.Forms
{
    public partial class UnitOfMeasureListForm : BaseList
    {        
        public UnitOfMeasureListForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            ribbonPageGroup2.Visible = false;
        }
    }
}
