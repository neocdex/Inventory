using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using Inventory.ORMDataModelCode;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using Inventory.Reports;

namespace Inventory.Forms
{
    public partial class ItemForm : BaseDetail
    {
        private bool saved;
        public ItemForm()
        {
            InitializeComponent();
            PostInitializeComponent();      
        }

        private void PostInitializeComponent()
        {
            lookupUOM.ItemIndex = 0;
            saved = false;
        }      
        
        protected override void OnSaveClicked()
        {
            if (dxValidationProvider.Validate())
            {
                //string productcode = GenerateProductCode();
                //if (productcode == string.Empty) return;
                Products p = this.MainBindingSource.Current as Products;                
                //save picture 
                using (MRUMemoryStream ms = new MRUMemoryStream())
                {
                    if (pictImage.Image != null)
                    {
                        pictImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        p.picture = ms.ToArray();
                    }
                }           
                base.OnSaveClicked();
                p.productcode = p.product_id.ToString();
                p.Save();
                unitOfWork.CommitChanges();
                saved = true;
            }
        }

        private string GenerateProductCode() {
            try
            {
                Category c = lookupCategory.EditValue as Category;
                string seqname = c.name;
                long nextvalue = 0;
                //DevExpress.Xpo.DB.SelectedData data= SprocHelper.Execnextval(unitOfWork, nextvalue, seqname);
                //DevExpress.Xpo.DB.SelectedData data = unitOfWork.ExecuteSproc("nextval", new OperandValue(seqname));
                //nextvalue = (long)data.ResultSet[1].Rows[0].Values[0];
                //Formato temporal...
                //return (String.Format("{0}-{1}-{2}", c.code, nextvalue.ToString("D5"),DateTime.Now.Year));
                return string.Empty;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }            
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
            foreach (Form child in this.MdiParent.MdiChildren) {
                if (saved && child.GetType() == typeof(InventoryTELForm))
                {
                    ((InventoryTELForm)child).added = true;
                    ((InventoryTELForm)child).OnReloadClicked();
                    break;
                }
            }            
        }

        private void chkDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscontinued.Checked)
            {
                DiscontinuedDateLCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
            }
            else
                DiscontinuedDateLCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        public override void SetItem(XPBaseObject item)
        {
            try
            {
                int position = MainBindingSource.Find("product_id", ((Products)item).product_id);
                if (position >= 0)
                    MainBindingSource.Position = position;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnPrintClicked()
        {
            try
            {
                ItemReport report = new ItemReport();
                Products p = this.MainBindingSource.Current as Products;
                report.MainBindingSource.DataSource = p;
                ReportViewerForm viewer = new ReportViewerForm();
                viewer.Report = report;
                viewer.MdiParent = this.MdiParent;
                viewer.Show();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WarehouseRepositoryItemLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            gridViewStored.FocusedColumn = gridViewStored.Columns[2];            
        }

        private void gridViewStored_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn colwarehouse = gridViewStored.Columns["warehouse_id!"];
            Warehouse warehouseName = (Warehouse)gridViewStored.GetRowCellValue(e.RowHandle, colwarehouse);

            if (warehouseName == null) {
                e.Valid = false;
                gridViewStored.SetColumnError(colwarehouse, "Por favor, seleccione un almacén");
            }            
        }

        private void gridViewStored_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewStored.FocusedColumn != colwarehouse)
                return;

            object convertedValue = null;
            try
            {
                convertedValue = Convert.ChangeType(e.Value, gridViewStored.FocusedColumn.ColumnType);
            }
            catch (Exception ex) {
                e.ErrorText = "Valor inválido";
                gridViewStored.SetColumnError(colwarehouse, "Valor inválido");
                e.Valid = false;
                return;
            }
            int foundHandle = gridViewStored.LocateByValue(0, gridViewStored.FocusedColumn, convertedValue);
            if (gridViewStored.IsValidRowHandle(foundHandle) && foundHandle != gridViewStored.FocusedRowHandle) {
                e.ErrorText = "Valor duplicado";
                gridViewStored.SetColumnError(colwarehouse, "Valor duplicado");
                e.Valid = false;
                return;
            }
            if (gridViewStored.IsNewItemRow(gridViewStored.FocusedRowHandle)) return;
            foundHandle = gridViewStored.LocateByValue(gridViewStored.FocusedRowHandle + 1, gridViewStored.FocusedColumn, convertedValue);
            if (gridViewStored.IsValidRowHandle(foundHandle)) {
                e.ErrorText = "Valor duplicado";
                gridViewStored.SetColumnError(colwarehouse, "Valor duplicado");
                e.Valid = false;
                return;
            }
        }       
    }
}
