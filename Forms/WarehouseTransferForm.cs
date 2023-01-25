using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.ORMDataModelCode;

namespace Inventory.Forms
{
    public partial class WarehouseTransferForm : BaseDetail
    {
        public WarehouseTransferForm()
        {
            InitializeComponent();
            LoadWarehouses();
        }        
        protected override void OnCancelClicked()
        {
            if (unitOfWork.InTransaction)
            {
                unitOfWork.RollbackTransaction();
                //item.Inventorytransactions.Reload();
            }
            this.Close();
        }
        private void LoadWarehouses() {
            List<Warehouse> wList = new List<Warehouse>();
            foreach (Warehouse w in xpMainCollection) {
                wList.Add(w);
            }
            lookUpEditWarehouseDst.Properties.DataSource = wList;
        }
        protected override void OnSaveClicked() {           

            if (!(dxValidationProvider.Validate() && dxValidationProvider2.Validate()))
                return;            
            try {
                if(!unitOfWork.InTransaction)
                    unitOfWork.BeginTransaction();
                Transactionreason treason = (Transactionreason)new DevExpress.Xpo.XPCollection(unitOfWork, typeof(Transactionreason), new DevExpress.Data.Filtering.BinaryOperator("name", "Traspaso", DevExpress.Data.Filtering.BinaryOperatorType.Equal))[0];
                Warehouse warehouseSrc = (Warehouse)lookUpEditWarehouseSrc.EditValue;
                Warehouse warehouseDst = (Warehouse)lookUpEditWarehouseDst.EditValue;
                foreach(StoredItem sti in warehouseSrc.StoredItems){
                    Products p = sti.product_id;                    
                    StoredItem dstStore = p.StoredItems.SingleOrDefault<StoredItem>(st => st.warehouse_id == warehouseDst);
                    if (dstStore==null) {
                        dstStore = new StoredItem(unitOfWork);
                        dstStore.product_id = p;
                        dstStore.warehouse_id = warehouseDst;
                        dstStore.reorderQuantity = sti.reorderQuantity;
                        p.StoredItems.Add(dstStore);
                    }
                    Inventorytransaction dstIVT = new Inventorytransaction(unitOfWork);
                    dstIVT.product_id = p;
                    dstIVT.warehouse_id = warehouseDst;
                    dstIVT.description = "Traspaso desde la bodega: " + warehouseSrc.name;
                    dstIVT.storeKeeper = txtStoreKeeper.Text;
                    dstIVT.transactionReason = treason;
                    dstIVT.date = dateEditInventory.DateTime;
                    dstIVT.units = sti.quantityInHand;
                    p.Inventorytransactions.Add(dstIVT);
                    //realizar salida en origen
                    Inventorytransaction srcIVT = new Inventorytransaction(unitOfWork);
                    srcIVT.product_id = p;
                    srcIVT.warehouse_id = warehouseSrc;
                    srcIVT.units = sti.quantityInHand * -1;
                    srcIVT.date = dateEditInventory.DateTime;
                    srcIVT.storeKeeper = txtStoreKeeper.Text;
                    srcIVT.transactionReason = treason;
                    srcIVT.description = "Traspaso hacia bodega: " + warehouseDst.name;
                    p.Inventorytransactions.Add(srcIVT);
                    //p.StoredItems.Remove(sti);                    
                    p.Save();
                    //eliminar items de almacén 
                    //unitOfWork.Delete(sti);
                }
                
                //unitOfWork.CommitChanges();
                unitOfWork.Delete(warehouseSrc.StoredItems);
                unitOfWork.Save(warehouseSrc.StoredItems);
                unitOfWork.CommitTransaction();
                MessageBox.Show("Se han pasado todos los items desde el almacén " + warehouseSrc.name + " hacia el almacén " + warehouseDst.name, "Traspaso entre almacenes", MessageBoxButtons.OK);                
                //preguntar si desea borrar almacén
                DialogResult result = MessageBox.Show("El almacén " + warehouseSrc.name + " está vacío ¿Desea borrarlo?", "Borrar almacén", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    unitOfWork.Delete(warehouseSrc);
                    unitOfWork.CommitChanges();
                    lookUpEditWarehouseSrc.Properties.DataSource = null;
                    lookUpEditWarehouseSrc.Properties.DataSource = this.MainBindingSource;
                    LoadWarehouses();
                } 
            }
            catch (Exception ex) {
                MessageBox.Show("Se ha producido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(unitOfWork.InTransaction)
                    unitOfWork.RollbackTransaction();
            }
            finally { }
        }
    }
}
