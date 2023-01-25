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
using DevExpress.Xpo.Helpers;

namespace Inventory.Forms
{
    public partial class ItemForm : BaseDetail
    {
        private bool saved;
        private bool newItem;
        private Products current;
        public ItemForm()
        {
            InitializeComponent();
            PostInitializeComponent();      
        }

        private void PostInitializeComponent()
        {
            lookupUOM.ItemIndex = 0;
            saved = false;
            newItem = false;       
        }
        public override void OnNewClicked()
        {
            current = this.MainBindingSource.Current as Products;
            base.OnNewClicked();
            newItem = true;
            gridViewStored.Columns.ColumnByFieldName("quantityInHand").OptionsColumn.AllowEdit = true;
            layoutCtrlItemBtnGenCode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        protected override void OnCancelClicked()
        {
            base.OnCancelClicked();
            SetItem(current);           
            gridViewStored.Columns.ColumnByFieldName("quantityInHand").OptionsColumn.AllowEdit = false;           
        }
        protected override void OnFirstClicked()
        {
            base.OnFirstClicked();
            current = this.MainBindingSource.Current as Products;
            UpdateQRCode(current);
        }
        protected override void OnLastClicked()
        {
            base.OnLastClicked();
            current = this.MainBindingSource.Current as Products;
            UpdateQRCode(current);
        }
        protected override void OnNextClicked()
        {
            base.OnNextClicked();
            current = this.MainBindingSource.Current as Products;
            UpdateQRCode(current);
        }
        protected override void OnPreviousClicked()
        {
            base.OnPreviousClicked();
            current = this.MainBindingSource.Current as Products;
            UpdateQRCode(current);
        }
        private void SetTotalStock(double totalStock) { 
            
        }
        protected override void OnSaveClicked()
        {
            if (dxValidationProvider.Validate())
            {                
                Products p = this.MainBindingSource.Current as Products;
                if (p != null && p.productcode == null && txtProductCode.Text.Trim()==string.Empty) { //generate productcode
                    string productcode = GenerateProductCode();
                    if (productcode == string.Empty)
                    {
                        MessageBox.Show("No se pudo generar código del item", "Guardar item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProductCode.Properties.ReadOnly = false;
                        txtProductCode.Focus();
                        return;
                    }
                    p.productcode = productcode;    
                }
                //update totalStock
                if (unitOfWork.IsNewObject(p)) { 
                    foreach(StoredItem st in p.StoredItems){
                        p.totalStock += st.quantityInHand;
                    }
                }
                //save picture 
                using (MRUMemoryStream ms = new MRUMemoryStream())
                {
                    if (pictImage.Image != null)
                    {
                        pictImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        p.picture = ms.ToArray();
                    }
                }
                p.Save();
                unitOfWork.CommitChanges();
                base.OnSaveClicked();                
                saved = true;                
            }
        }
        private void UpdateQRCode(Products p)
        {
            //Products p = this.MainBindingSource.Current as Products;
            if (p==null) return;
            String BarcodeText = String.Concat(p.name, "\n", p.model, "\n", p.serialnumber, "\n", (p.brand_id != null) ? p.brand_id.name : "");
            barCodeControl1.Text = BarcodeText;
        }

        private string GenerateProductCode() {
            try
            {
                Category c = lookupCategory.EditValue as Category;
                string seqname = c.code;
                long nextvalue = 0;
                DevExpress.Xpo.DB.SelectedData data = unitOfWork.ExecuteSproc("nextval", new OperandValue(seqname));
                nextvalue = (long)data.ResultSet[1].Rows[0].Values[0];
                return (String.Format("{0}-{1}", c.code, nextvalue.ToString("D7")));
                //return string.Empty;
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
                    ((InventoryTELForm)child).NewItemAdded = newItem;
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
                current = (Products)item;
                if (current == null) return;
                int position = MainBindingSource.Find("product_id", current.product_id);
                if (position >= 0)
                {
                    MainBindingSource.Position = position;
                    if (current.productcode != null)
                        layoutCtrlItemBtnGenCode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    UpdateQRCode(current);
                }
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

        private void gridStored_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {

                try
                {
                    GridControl grid = ((ControlNavigator)sender).NavigatableControl as GridControl;
                    BindingManagerBase bm = grid.BindingContext[grid.FocusedView.DataSource];
                    IXPSimpleObject xpo = bm.Current as IXPSimpleObject;
                    if (MessageBox.Show("¿Desea borrar el registro?", "Borrar almacén", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) 
                        return;
                    else if (xpo != null && ((StoredItem)xpo).quantityInHand <= 0)
                    {
                        xpo.Session.Delete(xpo);
                        unitOfWork.CommitChanges();
                        saved = true;
                       
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar registro porque hay existencias", "Borrar almacén", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al elminar registro", "Borrar almacén", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    e.Handled = true;
                }
            }
        }

        private void BtnGenerateCode_Click(object sender, EventArgs e)
        {
            Products p = this.MainBindingSource.Current as Products;
            if (p != null && p.productcode == null && txtProductCode.Text.Trim() == string.Empty)
            { //generate productcode
                string productcode = GenerateProductCode();
                if (productcode == string.Empty)
                {
                    MessageBox.Show("No se pudo generar código del item", "Guardar item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductCode.Properties.ReadOnly = false;
                    txtProductCode.Focus();
                    //return;
                }
                else
                {
                    p.productcode = productcode;
                    txtProductCode.Properties.ReadOnly = true;
                }
                layoutCtrlItemBtnGenCode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }       
    }
}
