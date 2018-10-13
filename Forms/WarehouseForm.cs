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
            //Validar antes de guardar
        }
        protected override void OnSaveClicked()
        {
            if(dxValidationProvider.Validate())
                base.OnSaveClicked();
        }
    }
}
