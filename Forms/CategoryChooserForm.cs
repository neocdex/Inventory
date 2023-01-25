using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class CategoryChooserForm : Form
    {
        //private object w;
        public object Warehouse{
            get { return WarehouseLookUpEdit.EditValue; }        
        }
        public object Category {
            get { return CategoryLookUpEdit.EditValue; }
        }

        public string OrderBy {
            get {
                string svalue = string.Empty;
                if (OrderByCBE.SelectedIndex == 0) 
                    svalue = "product_id";
                else svalue = "product";
                return svalue;
            }
        }
        public string SortOrder {
            get {                
                return (Convert.ToString(SortOrdercCBE.EditValue));
            }
        }
        public CategoryChooserForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            int guid=0;
            List<ORMDataModelCode.Warehouse> warehouses = new List<ORMDataModelCode.Warehouse>();
            ORMDataModelCode.Warehouse all = new ORMDataModelCode.Warehouse(unitOfWork);
            all.warehouse_id = guid;
            all.description = "Todas";
            all.name = "Todas";
            warehouses.Add(all);
            foreach (ORMDataModelCode.Warehouse w in xpWarehouseCollection)
            {
                warehouses.Add(w);
                guid = w.warehouse_id;
            }
            WarehouseLookUpEdit.Properties.DisplayMember = "name";
            WarehouseLookUpEdit.Properties.ValueMember = "This";
            WarehouseLookUpEdit.Properties.DataSource = warehouses;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //w = WarehouseLookUpEdit.EditValue;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        public void hideCategoryLayout() {
            layoutCtrlCategory.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
    }
}
