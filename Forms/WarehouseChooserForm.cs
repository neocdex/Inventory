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
    public partial class WarehouseChooserForm : Form
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
        public WarehouseChooserForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            int guid=0;
            List<ORMDataModelCode.Category> categories = new List<ORMDataModelCode.Category>();
            ORMDataModelCode.Category all = new ORMDataModelCode.Category(unitOfWork);
            all.category_id = guid;
            all.description = "Todas";
            all.name = "Todas";
            categories.Add(all);
            foreach (ORMDataModelCode.Category c in xpCategoryCollection) {
                categories.Add(c);
                guid = c.category_id;
            }
            CategoryLookUpEdit.Properties.DisplayMember = "name";
            CategoryLookUpEdit.Properties.ValueMember = "This";
            CategoryLookUpEdit.Properties.DataSource = categories;
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
