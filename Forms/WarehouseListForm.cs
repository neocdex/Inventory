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
using DevExpress.XtraGrid.Columns;
using Inventory.Reports;
using Inventory.Utils;

namespace Inventory.Forms
{
    public partial class WarehouseListForm : BaseList
    {        
        public WarehouseListForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent() {
            PrintBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
        }

        private void gridViewWarehouse_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gridViewWarehouse.IsNewItemRow(e.RowHandle)) {
                GridColumn column = gridViewWarehouse.Columns["name"];
                object val = gridViewWarehouse.GetRowCellValue(e.RowHandle, column);
                if (val == null || val.ToString() == string.Empty) {
                    e.Valid = false;
                    //ErrorMsgEmpty
                    //gridViewWarehouse.SetColumnError(column, "Valor no puede ser vacío");
                    gridViewWarehouse.SetColumnError(column, Setup.GetMessage("ErrorMsgEmpty"));
                }
            }
        }
        protected override void OnNewClicked()
        {
            try {
                WarehouseForm f = new WarehouseForm();
                //f.MdiParent = this.MdiParent;
                f.OnNewClicked();
                f.ShowDialog();
                //f.Show(this);                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Setup.GetMessage("CaptionError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xpInstantFeedbackSource_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = unitOfWork;
        }

        private void xpInstantFeedbackSource_DismissSession(object sender, ResolveSessionEventArgs e)
        {
            IDisposable session = e.Session as IDisposable;
            if (session != null)
                session.Dispose();
        }

        protected override void OnPrintClicked()
        {
            try
            {
                ItemByWarehouse report = new ItemByWarehouse();
                //report.MainBindingSource.DataSource = xpMainCollection;
                ReportViewerForm f = new ReportViewerForm();
                f.Report = report;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Setup.GetMessage("CaptionError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnDeleteClicked()
        {
            Warehouse current = this.MainBindingSource.Current as Warehouse;
            bool delete = true;
            foreach (StoredItem st in current.StoredItems) {
                if (st.quantityInHand > 0) {
                    //MessageWarehouseNotEmpty
                    //MessageBox.Show("El almacén aún contiene items con existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Setup.GetMessage("MessageWarehouseNotEmpty"), Setup.GetMessage("CaptionError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    delete = false;
                    break;
                }
            }
            if (delete)
            {
                Form f = new FormUser();
                DialogResult result = f.ShowDialog(this);
                if (result == System.Windows.Forms.DialogResult.OK)
                    base.OnDeleteClicked();
            }
        }

        private void ItemsByWarehouseReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Warehouse w = MainBindingSource.Current as Warehouse;
            if (w == null) {
                //MessageWarehouseNoSelected
                //MessageBox.Show("No hay ningún almacén seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Setup.GetMessage("MessageWarehouseNoSelected"), Setup.GetMessage("CaptionError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ItemByWarehouse report = new ItemByWarehouse();
            report.MainBindingSource.DataSource = w;
            ReportViewerForm f = new ReportViewerForm();
            f.MdiParent = this.MdiParent;
            f.Report = report;
            f.Show();
        }
    }
}
