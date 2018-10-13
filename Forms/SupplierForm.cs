using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.Metadata;
using Inventory.ORMDataModelCode;
using DevExpress.XtraEditors;
//using Inventory.Forms;

namespace Inventory.Forms
{
    public partial class SupplierForm : BaseDetail
    {              
        private bool editItem = false;
        

        public SupplierForm(bool editMode = false, Suppliers supplier = null)
        {
            InitializeComponent();
            PostInitializeComponent();
        }

        private void PostInitializeComponent()
        {
            AddressBindingSource.DataMember = "AddressesCollection";                    
        }

        
        public void limpiar_cajas(DevExpress.XtraEditors.PanelControl panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl.GetType() == typeof(TextEdit))
                    ctrl.Text = "";
            }
        }
        public bool validarPanelProveedor(DevExpress.XtraEditors.PanelControl panel)
        {
            foreach (Control ctrl in panel.Controls)
            //for (int i = 0; i < panel.Controls.Count ; i++)
            {
                if (ctrl.GetType() == typeof(TextEdit) && (ctrl.Name != "ctfax" && ctrl.Name != "ctemail" && ctrl.Name != "ctWebsite" && ctrl.Name != "ctnota") && ctrl.Text.Length == 0)
                {
                    dxErrorProvider1.SetError(ctrl, "Debe llenar el campo");
                    return false;
                }
            }
            return true;
        }

        public void bloquear_todo()
        {
            ctciudad.Enabled = false;
            //ctcompañia.Enabled = false;
            ctdepartamento.Enabled = false;
            ctemail.Enabled = false;
            //ctestatus.Enabled = false;
            ctfax.Enabled = false;
            ctline1.Enabled = false;
            //ctline2.Enabled = false;
            ctnombre_coonta.Enabled = false;
            ctnombre_prov.Enabled = false;
            ctnota.Enabled = false;
            //ctnumero.Enabled = false;
            ctpais.Enabled = false;
            //cttype.Enabled = false;
        }
        public void Desbloquear_todo()
        {
            ctciudad.Enabled = true;
            //ctcompañia.Enabled = true;
            ctdepartamento.Enabled = true;
            ctemail.Enabled = true;
            //ctestatus.Enabled = true;
            ctfax.Enabled = true;
            ctline1.Enabled = true;
            //ctline2.Enabled = true;
            ctnombre_coonta.Enabled = true;
            ctnombre_prov.Enabled = true;
            ctnota.Enabled = true;
            //ctnumero.Enabled = true;
            ctpais.Enabled = true;
            //cttype.Enabled = true;
        }
    


        private void ctnota_Enter(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
        }        

 
       

        private void eliminarTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editItem == false)
            {
                return;
            }
        }

        private void Solo_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Solo_Letras(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }                

        private void toolcancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSimpleButton_Click(object sender, EventArgs e)
        {
            ShowHideAddressGrid(DevExpress.XtraLayout.Utils.LayoutVisibility.Never);
            ShowHideAddressControls(DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime);
            AddressBindingSource.AddNew();
        }
        private void ShowHideAddressGrid(DevExpress.XtraLayout.Utils.LayoutVisibility visibility) {
            GridLayoutCI.Visibility = visibility;
        }
        private void ShowHideAddressControls(DevExpress.XtraLayout.Utils.LayoutVisibility visibility) {
            AddressLayoutCI.Visibility = visibility;
            CityLayoutCI.Visibility = visibility;
            StateLayoutCI.Visibility = visibility;
            CountryLayoutCI.Visibility = visibility;
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            ShowHideAddressControls(DevExpress.XtraLayout.Utils.LayoutVisibility.Never);
            ShowHideAddressGrid(DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime);
            AddressBindingSource.EndEdit();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            ShowHideAddressControls(DevExpress.XtraLayout.Utils.LayoutVisibility.Never);
            ShowHideAddressGrid(DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime);
            AddressBindingSource.CancelEdit();
        }

        private void AddressCardView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Suppliers s = MainBindingSource.Current as Suppliers;
            Addresses address = AddressBindingSource.Current as Addresses;

            if (s != null && address != null)
            {
                address.supplier_id = s;
                s.AddressesCollection.Add(address);
            }
        }
        public override void SetItem(XPBaseObject item)
        {
            int position = MainBindingSource.Find("supplier_id", ((Suppliers)item).supplier_id);
            if (position >= 0)
                MainBindingSource.Position = position;
        }       
    }
}

 

