using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory.ORMDataModelCode;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace Inventory.Forms
{
    public partial class StatusListForm : BaseList
    {
        public StatusListForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            PrintBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            ribbonPageGroup2.Visible = false;
        }

        protected override void OnNewClicked()
        {
            this.MainBindingSource.AddNew();
        }
        protected override void OnDeleteClicked()
        {
            Status status = this.MainBindingSource.Current as Status;
            if (status.ProductsCollection.Count == 0)
                base.OnDeleteClicked();
            else {
                //ErrorMsgCantDeleteStatus
                MessageBox.Show("No se puede borrar estado porque hay items dependen de él", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StatusGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colstatus = view.Columns["status"];
            string status = (string)view.GetRowCellValue(e.RowHandle, colstatus);
            if (status == null)
            {
                e.Valid = false;
                //ErrorColumnStatus
                view.SetColumnError(colstatus, "Ingrese un nombre de estado");
            }           
        }
        protected override void OnSaveRecordClicked()
        {
            StatusGridView.CloseEditor();
            StatusGridView.UpdateCurrentRow();
            base.OnSaveRecordClicked();
        }
    }
}
