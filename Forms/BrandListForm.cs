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

namespace Inventory.Forms
{
    public partial class BrandListForm : BaseList
    {
        
        public BrandListForm()
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            ribbonPageGroup2.Visible = false;
        }

        private void gridBrand_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove) {
                if (MessageBox.Show("¿Desea eliminar el registro actual?", "Confirmar eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    OnDeleteClicked();
                    e.Handled = true;
                }
            }
        }
        protected override void OnNewClicked()
        {
            gridViewBrand.CloseEditor();
            gridViewBrand.UpdateCurrentRow();
            base.OnNewClicked();
        }
    }
}
