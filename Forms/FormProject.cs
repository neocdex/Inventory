using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace Inventory.Forms
{
    public partial class FormProject : BaseDetail
    {
        public FormProject()
        {
            InitializeComponent();
        }

        private void WarehouseGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn colname = WarehouseGridView.Columns["name"];
            string name = (string)WarehouseGridView.GetRowCellValue(e.RowHandle, colname);

            if (name == null || name.Trim() == string.Empty) {
                e.Valid = false;
                WarehouseGridView.SetColumnError(colname, "Ingrese un nombre válido");
            }
        }
    }
}
