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
    public partial class FormWarehouseTransfer : Form
    {
        public FormWarehouseTransfer()
        {
            InitializeComponent();
        }

        private void TransferSimpleButton_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider.Validate()) return;
            if (WarehouseDstLookUpEdit.EditValue == WarehouseSrcLookUpEdit.EditValue) {
                MessageBox.Show("El almacén destino no puede ser el mismo que el almacén origen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Warehouse wsrc = (Warehouse)WarehouseSrcLookUpEdit.EditValue;
            Warehouse wdst = (Warehouse)WarehouseDstLookUpEdit.EditValue;

            foreach (StoredItem st in wsrc.StoredItems) {
                Inventorytransaction ivt = new Inventorytransaction(unitOfWork);
                //Comprobar si cada item está en el almacén destino
                //Stored itemInStock = 
            }
        }
    }
}
