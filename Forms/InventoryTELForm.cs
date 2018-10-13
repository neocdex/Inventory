using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.ORMDataModelCode;
using DevExpress.Data.Filtering;
using Inventory.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

namespace Inventory.Forms
{
    public partial class InventoryTELForm : BaseList
    {
        public bool added;
        public InventoryTELForm(String criteria=null)
        {            
            InitializeComponent();
            PostInitializeComponent();
        }
        private void PostInitializeComponent() {
            PrintBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }             

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            gridViewInventory.BestFitColumns();            
        }       

        private void gridViewInventory_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0) { 
                //get childs                 
                Products item = gridViewInventory.GetRow(e.RowHandle) as Products;
                foreach (StoredItem st in item.StoredItems)
                {
                    if (st.quantityInHand <= st.reorderQuantity)
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        e.Appearance.ForeColor = Color.White;
                        e.HighPriority = true;
                        break;
                    }
                }                
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ItemByBrandXtraReport report = new ItemByBrandXtraReport();                
                report.bindingSource.DataSource = xpMainCollection;
                ReportViewerForm f = new ReportViewerForm();
                f.Report = report;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnEditClicked()
        {
            Products p = MainBindingSource.Current as Products;
            //Products p = gridViewInventory.GetFocusedRow() as Products;
            if (p != null)
            {
                BaseDetail f = new ItemForm();
                f.MdiParent = this.MdiParent;
                f.SetItem(p);
                f.Visible = true;
            }
        }
        protected override void OnPrintClicked()
        {
            try
            {
                //ItemsInStockXtraReport report = new ItemsInStockXtraReport();                
                //report.bindingSource.DataSource = xpMainCollection;
                MovInvItemXtraReport report = new MovInvItemXtraReport();
                //report.MainBindingSource.DataSource = xpMainCollection;
                report.MainBindingSource.DataSource = this.MainBindingSource.Current as Products;
                ReportViewerForm f = new ReportViewerForm();
                f.Report = report;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InOutBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Products p = this.MainBindingSource.Current as Products;
                //Products p = gridViewInventory.GetFocusedRow() as Products;
                Form f = new frmItemInOut(p);
                //f.MdiParent = this.MdiParent;
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    
                    OnReloadClicked();
                }                
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnNewClicked()
        {
            try
            {
                ItemForm f = new ItemForm();
                f.MdiParent = this.MdiParent;
                f.OnNewClicked();
                added = false;
                f.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnDeleteClicked()
        {
            Form f = new FormUser();
            DialogResult result = f.ShowDialog(this) ;
            if (result== System.Windows.Forms.DialogResult.OK) {
                base.OnDeleteClicked();    
            }            
        }
        public override void OnReloadClicked()
        {
            if (added)
            {   xpMainCollection.Reload();                
                added = false;
                return;
            }
            object o = this.MainBindingSource.Current;
            if (o != null)
            {                
                unitOfWork.Reload(o);
                ((Products)o).StoredItems.Reload();
                foreach (StoredItem s in ((Products)o).StoredItems) {
                    s.Reload();
                }
                StoredCardView.RefreshData();
            }
        }        

        private void StatusRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //ChangeFocusedColumn();
        }
        private void ChangeFocusedColumn() {
            int currentColumn = gridViewInventory.FocusedColumn.VisibleIndex;
            if (currentColumn == gridViewInventory.Columns.Count - 1) currentColumn--;
            else currentColumn++;
            gridViewInventory.FocusedColumn = gridViewInventory.Columns[currentColumn];
        }

        private void UOMRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //ChangeFocusedColumn();
        }

        private void BrandRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //ChangeFocusedColumn();
        }

        private void CategoryRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //ChangeFocusedColumn();
        }

        private void gridViewInventory_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                //GridView view = sender as GridView;
                switch (e.Column.FieldName)
                {
                    case "gridcolwarehouse":
                        e.Value = GetWarehousesName(e.ListSourceRowIndex);
                        break;
                }
            }            
        }

        private string GetWarehousesName(int listSourceRowIndex) {
            List<string> w = new List<string>();            
            Products item = this.MainBindingSource[listSourceRowIndex] as Products;
            if (item != null && item.StoredItems !=null)
            {
                foreach (StoredItem s in item.StoredItems)
                {
                    w.Add(s.warehouse_id.name);
                }
            }
            return string.Join(", ", w.ToArray());
        }

        private double GetTotalUnitsInStock(GridView view, int listSourceRowIndex) {
            double total = 0;
            Products item = view.GetRow(listSourceRowIndex) as Products;
            foreach (StoredItem s in item.StoredItems) {
                total += s.quantityInHand;
            }
            return total;
        }

        private void AllItemReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemReport report = new ItemReport();            
            ReportViewerForm f = new ReportViewerForm();
            f.Report = report;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void ItemsByWarehouseReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WarehouseChooserForm wf = new WarehouseChooserForm();
            DialogResult result = wf.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //ItemByWarehouse report = new ItemByWarehouse();
                ProductByWarehouseCategory report = new ProductByWarehouseCategory();
                
                Warehouse w = (Warehouse)wf.Warehouse;
                Category c = (Category)wf.Category;
                string filterString = string.Empty;
                if (w != null)                
                {                    
                    report.pWarehouse.Value = w.name;
                    filterString = "[warehouse] = ?pWarehouse";
                }
                if(c != null && c.name!="Todas"){
                    report.pCategory.Value = c.name;
                    if(filterString.Length>0)
                        filterString += " And [category] = ?pCategory";
                    else
                        filterString = "[category] = ?pCategory";
                }
                report.FilterString = filterString;
                report.OrderBy = wf.OrderBy;
                report.SortOrder = wf.SortOrder;
                report.RequestParameters = false;                
                ReportViewerForm f = new ReportViewerForm();
                f.Report = report;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void TransactionsReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Products p = MainBindingSource.Current as Products;
            if (p == null) {
                MessageBox.Show("Seleccione un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MovInvItemXtraReport report = new MovInvItemXtraReport();
            ReportViewerForm f = new ReportViewerForm();
            report.MainBindingSource.DataSource = p;
            f.Report = report;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        protected override void OnSaveRecordClicked()
        {
            gridViewInventory.CloseEditor();
            gridViewInventory.UpdateCurrentRow();
            base.OnSaveRecordClicked();
        }

        private void ItemsByWarehouseReport2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WarehouseChooserForm warehouseForm = new WarehouseChooserForm();
            warehouseForm.hideCategoryLayout();
            DialogResult result = warehouseForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK) {

                ProductByWarehouse report = new ProductByWarehouse();
                Warehouse w = (Warehouse)warehouseForm.Warehouse;
                String filterString = String.Empty;
                if (w != null) {
                    report.pWarehouse.Value = w.name;
                    filterString = "[warehouse] = ?pWarehouse";
                }
                report.FilterString = filterString;
                report.OrderBy = warehouseForm.OrderBy;
                report.SortOrder = warehouseForm.SortOrder;
                report.RequestParameters = false;      
                
                ReportViewerForm f = new ReportViewerForm();
                f.Report = report;
                f.MdiParent = this.MdiParent;
                f.Show();
            }            
        }        
    }
}
