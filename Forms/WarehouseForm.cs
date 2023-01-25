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
    public partial class WarehouseForm : BaseDetail
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }
        protected override void OnSaveClicked()
        {
            if (dxValidationProvider.Validate())
                base.OnSaveClicked();
        }
        public override void SetItem(DevExpress.Xpo.XPBaseObject item)
        {
            try
            {
                int position = MainBindingSource.Find("warehouse_id", ((Inventory.ORMDataModelCode.Warehouse)item).warehouse_id);
                if (position >= 0)
                    MainBindingSource.Position = position;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
