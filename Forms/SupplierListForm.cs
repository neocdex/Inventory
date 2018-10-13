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
using DevExpress.XtraGrid;

namespace Inventory.Forms
{
    public partial class SupplierListForm : BaseList
    {        
        public SupplierListForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent() {
            DeleteBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ribbonPageGroup2.Visible = false;
        }
        
        private void barLargeBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Item = new SupplierForm();
            Item.MdiParent = this.MdiParent;
            Item.Show();            
        }             

        private void barLargeBtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //If no row is selected, return
                if (gridViewSuppliers == null || gridViewSuppliers.SelectedRowsCount == 0)
                    return;
                for (int i = 0; i < gridViewSuppliers.SelectedRowsCount; i++)
                {
                    Suppliers s = gridViewSuppliers.GetRow(gridViewSuppliers.GetSelectedRows()[i]) as Suppliers;
                    //supplier.active = false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLargeBtnActive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //If no row is selected, return
                if (gridViewSuppliers == null || gridViewSuppliers.SelectedRowsCount == 0)
                    return;
                for (int i = 0; i < gridViewSuppliers.SelectedRowsCount; i++)
                {
                    Suppliers s = gridViewSuppliers.GetRow(gridViewSuppliers.GetSelectedRows()[i]) as Suppliers;
                    //supplier.active = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnEditClicked()
        {
            Suppliers s = MainBindingSource.Current as Suppliers;
            if (s != null) {
                BaseDetail f = new SupplierForm();
                f.MdiParent = this.MdiParent;
                f.SetItem(s);
                f.Visible = true;
            }
        }
      
        protected override void OnNewClicked()
        {
            BaseDetail f = new SupplierForm();
            f.MdiParent = this.MdiParent;
            f.OnNewClicked();
            f.Visible = true;
        }
    }
}
