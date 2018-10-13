using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.ORMDataModelCode;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;

namespace Inventory.Forms
{
    public partial class frmItemInOut : Form
    {
        Products item;
        private DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRuleW2;
        private DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compValidationRuleW1W2;
        private DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRuleRef;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider2;
        private string pleaseSelectValue;
        public frmItemInOut(Products product = null)
        {
            InitializeComponent();
            PostInitializeComponent();
            if (product != null)
            {

                uow = product.Session as UnitOfWork;
                xpCollectionReasons.Session = uow;
                xpCollectionSuppliers.Session = uow;
                //load data
                item = product;
                txtProductName.Text = item.name;        
            }
            else 
            {
                //MessageNoItemSelected, CaptionInventory
                MessageBox.Show("No hay ningún item seleccionado", "Entradas/Salidas de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }            
        }
        private void PostInitializeComponent() {
            //ErrorMsgSelectValue
            pleaseSelectValue = "Por favor seleccione un valor";
            spEditUnits.Properties.MaxValue = decimal.MaxValue;
            conditionValidationRuleW2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();            
            conditionValidationRuleW2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRuleW2.ErrorText = pleaseSelectValue;
            conditionValidationRuleW2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;

            compValidationRuleW1W2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule("W1notequalW2", lookupWarehouse, DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals);
            //ErrorMsgSameWarehouse
            compValidationRuleW1W2.ErrorText = "Los almacenes de origen y destino no puede ser iguales";
            compValidationRuleW1W2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;

            conditionValidationRuleRef = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            conditionValidationRuleRef.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            //ErrorMsgEmpty
            conditionValidationRuleRef.ErrorText = "Este valor no es válido";
            conditionValidationRuleRef.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;

            dxValidationProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            dxValidationProvider2.SetValidationRule(lookUpWarehouse2, conditionValidationRuleW2);
            dxValidationProvider2.SetValidationRule(lookUpWarehouse2, compValidationRuleW1W2);            
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {            
            if (!dxValidationProvider.Validate()) return;
            try
            {
                if (!uow.InTransaction) //Check this model of transaction
                    uow.BeginTransaction();

                Transactionreason treason = (Transactionreason)lookUpEditReason.EditValue;
                Warehouse warehouse = (Warehouse)lookupWarehouse.EditValue;
                double units = Convert.ToDouble(spEditUnits.EditValue);

                Inventorytransaction sourceIVT = new Inventorytransaction(uow);                
                StoredItem sourceStore = item.StoredItems.SingleOrDefault<StoredItem>(st => st.warehouse_id == warehouse);
                if (sourceStore == null)
                {
                    //MessageNoItemInWarehouse
                    MessageBox.Show("No existe item en bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                switch (treason.operation) {
                    case "-"://no puede salir más unidades de las existentes
                        //buscar unidades existentes en almacén seleccionado
                        if (sourceStore.quantityInHand >= units)
                        {
                            sourceIVT.units = units * -1;
                        }
                        else {
                            //MessageNoStock
                            MessageBox.Show("No hay suficientes unidades en existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case "="://no puede traspasarse más unidades de las existentes
                        if (sourceStore.quantityInHand >= units)
                        { //realizar traspaso

                            if (!dxValidationProvider2.Validate()) return;
                            Warehouse warehouse2 = (Warehouse)lookUpWarehouse2.EditValue;                           
                            
                            StoredItem destinationStore = item.StoredItems.SingleOrDefault<StoredItem>(st => st.warehouse_id == warehouse2);
                            if (destinationStore == null) //Si no existe el item en la bodega, embodegar
                            {
                                destinationStore = new StoredItem(uow);
                                destinationStore.product_id = item;
                                destinationStore.warehouse_id = warehouse2;
                                destinationStore.reorderQuantity = sourceStore.reorderQuantity; //igual que el origen
                                //destinationStore.quantityInHand += units;
                                item.StoredItems.Add(destinationStore);
                            }
                            //else {//si está en la bodega destino, crear una transaction
                                Inventorytransaction destinationIVT = new Inventorytransaction(uow);
                                destinationIVT.product_id = item;
                                destinationIVT.warehouse_id = warehouse2;
                                destinationIVT.description = "Traspaso desde la bodega "+warehouse.name;
                                destinationIVT.storeKeeper = txtStoreKeeper.Text;
                                destinationIVT.transactionReason = treason;
                                destinationIVT.date = dateInventory.DateTime;
                                destinationIVT.units = units;
                                item.Inventorytransactions.Add(destinationIVT);
                            //}                            
                            //realizar salida en origen
                            sourceIVT.units = units*-1;
                            sourceIVT.description = "Traspaso hacia bodega" + warehouse2.name;
                        }
                        else {
                            //MessageNoStock
                            MessageBox.Show("No hay suficientes unidades en existencia para el traspaso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    default:
                        sourceIVT.units = units;
                        break;
                }
                sourceIVT.product_id = item;
                sourceIVT.warehouse_id = warehouse;
                //sourceIVT.description = "";
                sourceIVT.storeKeeper = txtStoreKeeper.Text;
                sourceIVT.supplier_id = (Suppliers)lookUpEditSuppliers.EditValue;
                sourceIVT.transactionReason = treason;
                sourceIVT.date = dateInventory.DateTime;
                sourceIVT.referenceNumber = txtInvoiceNumber.Text.Trim();
                if (cBEInvoiceType.EditValue != null)
                    sourceIVT.creditInvoice = cBEInvoiceType.EditValue.Equals("Contado") ? false : true;
                item.Inventorytransactions.Add(sourceIVT);
                btnSaveProduct.Enabled = true;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uow.RollbackTransaction();
            }

        }

        private void frmItemInOut_Load(object sender, EventArgs e)
        {
            try
            {
                //display only warehouses on the item is stored in
                if (item.StoredItems != null && item.StoredItems.Count > 0)
                {
                    List<Warehouse> warehouses = new List<Warehouse>();
                    foreach (StoredItem st in item.StoredItems)
                    {
                        warehouses.Add(st.warehouse_id);
                    }
                    lookupWarehouse.Properties.DataSource = warehouses;
                    lookupWarehouse.Properties.DisplayMember = "name";
                    lookupWarehouse.Properties.ValueMember = "This";                    
                    lookupWarehouse.Properties.Columns.Add(new LookUpColumnInfo("name", 0));
                    //lookupWarehouse.Properties.Columns["name"].Caption = "Nombre";
                }
                //assign InventoryTransaction to dataGrid
                item.Inventorytransactions.DisplayableProperties = "warehouse_id.name;date;supplier_id.suppliername;description;storeKeeper;referenceNumber;creditInvoice;transactionReason;units";
                configGridTransactionProperties();
                loadWarehouses();
                //set default value to dateEdit controls
                dateInventory.DateTime = DateTime.Now;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadWarehouses()
        {
            XPCollection<Warehouse> w = new XPCollection<Warehouse>(uow);
            w.DisplayableProperties = "This;name";
            lookUpWarehouse2.Properties.DataSource = w;
            lookUpWarehouse2.Properties.DisplayMember = "name";
            lookUpWarehouse2.Properties.ValueMember = "This";
            lookUpWarehouse2.Properties.Columns.Add(new LookUpColumnInfo("name", 0));
        }

        private void configGridTransactionProperties()
        {
            gridInventoryTransaction.DataSource = item.Inventorytransactions;  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (uow.InTransaction)
            {
                uow.RollbackTransaction();
                item.Inventorytransactions.Reload();            
            }
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {                
                uow.CommitChanges();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                //ErrorMsgOcurred
                MessageBox.Show("Se ha producido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            this.Close();
        }

        private void frmItemInOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MDIParent parent = (MDIParent)this.MdiParent;
            //parent.EntradaSalidaMenuItem = true;
        }        
        
        private void ShowHideLayoutUnitsInput(string op, DevExpress.XtraLayout.Utils.LayoutVisibility visibility)
        {     
            //layoutUnitsReceived.Visibility = visibility;
            if (op.Contains("transf") || op.Contains("return"))
            {
                layoutInvoice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutInvoiceType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                layoutInvoice.Visibility = visibility;
                layoutInvoiceType.Visibility = visibility;
            }
        }

        private void lookUpEditReason_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.RemoveControlError(lookUpEditReason);
            String option = ((Transactionreason)lookUpEditReason.EditValue).name;
            if (option.Contains("Traspaso")) {
                lookUpWarehouse2.Enabled = true;
                layoutInvoice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutInvoiceType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                SupplierLayoutCtrlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else if (option.Contains("Compra")||option.Contains("compra"))
            {
                layoutInvoice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
                layoutInvoiceType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
                SupplierLayoutCtrlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
                emptySpaceItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
                if (lookUpWarehouse2.Enabled) lookUpWarehouse2.Enabled = false;
            }
            else {
                layoutInvoice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutInvoiceType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                SupplierLayoutCtrlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                emptySpaceItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lookUpWarehouse2.Enabled = false;
            }                
        }

        private void lookupWarehouse_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.RemoveControlError(lookupWarehouse);
        }
    }
}
