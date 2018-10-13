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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Ribbon;

namespace Inventory.Forms
{
    public partial class MDIParent : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int childFormNumber = 0;
        private Form activeChild;
        private Form ToolsInventoryForm;
        private Form EquipmentInventoryForm;
        private Form LabInventoryForm;
        private Form SuppliesInventoryForm;
        public Products Product{ set; get; }
        public bool supplierToolMenuItem {
            set {
                supplierToolStripMenuItem.Enabled = value;
            }
        }
        public bool SuppliersListToolMenuItem {
            set {
                SuppliersListToolStripMenuItem.Enabled = value;
            }
        }
        public bool NewWarehouseToolMenuItem
        {
            set {
                NewWarehouseToolStripMenuItem.Enabled = value;
            }
        }         
        
        public bool EntradaSalidaMenuItem {
            set {
               //entradaSalidaToolStripMenuItem.Enabled = value;
            }
        }
        public bool EditarArticuloMenuItem {
            set {
                //editarArtículoToolStripMenuItem.Enabled = value;
            }
        }
        //public void UpdateInventoryGrid() 
        //{
        //    if (main != null)
        //    {
        //        ((InventoryForm)main).UpdateGridviewStored();                
        //    }
        //}
        public MDIParent()
        {
            InitializeComponent();            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
      
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nuevoArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new ItemForm();
            Item.MdiParent = this;
            Item.Show();            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new WarehouseListForm();
            Item.MdiParent = this;
            Item.Show();
            NewWarehouseToolStripMenuItem.Enabled = false;   
        }

        private void nuevaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new CategoriesListForm();              
            Item.MdiParent = this;
            Item.Show();
            //NewCategoryToolStripMenuItem.Enabled = false;
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new UnitOfMeasureListForm();            
            //Item.ShowDialog();
            Item.MdiParent = this;
            Item.Show();
            //UOMsToolStripMenuItem.Enabled = false;
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new BrandListForm();
            Item.MdiParent = this;
            Item.Show();
            //BrandsToolStripMenuItem.Enabled = false;
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {            
            //toolStripStatusLabel.Text = "Cargando Inventario...";
            //main = new InventoryForm();
            //main.MdiParent = this;
            //main.Show();

        }
        public void ShowMessageInStatusBar(string Message){
            toolStripStatusLabel.Text = Message;
        }        

        private void EditProduct(object sender, EventArgs e)
        {
            if (Product != null)
            {                
                Form productForm = new ItemForm(/*true,Product*/);    
                productForm.ShowDialog();
                //productForm.MdiParent = this;
                //productForm.Show();
            }
            else {
                MessageBox.Show("Seleccione el producto/artículo a editar.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void editarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Product != null)
            {
                Form productForm = new ItemForm(/*true, Product*/);
                //productForm.ShowDialog();
                productForm.MdiParent = this;
                productForm.Show();
                //editarArtículoToolStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione el producto/artículo a editar.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new SupplierListForm();
            //Item.ShowDialog();
            Item.MdiParent = this;
            Item.Show();
            SuppliersListToolStripMenuItem.Enabled = false;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Item = new SupplierForm();
            //Item.ShowDialog();
            Item.MdiParent = this;            
            Item.Show();
            supplierToolStripMenuItem.Enabled = false;
        }

        private void entradaSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Product != null)
            {
                Form Item = new frmItemInOut(Product);
                //productForm.ShowDialog();
                Item.MdiParent = this;
                Item.Show();
                EntradaSalidaMenuItem = false;
            }
            else
            {
                MessageBox.Show("Seleccione el producto a inventariar.", "Inventario de Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private void navBarItemTool_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (ToolsInventoryForm == null)
            {
                ToolsInventoryForm = new InventoryTELForm("Herramientas");
                ToolsInventoryForm.MdiParent = this;
                ToolsInventoryForm.FormClosed += delegate { ToolsInventoryForm = null; };
                ToolsInventoryForm.Show();
            }
            else {
                ToolsInventoryForm.Activate();
            }
            
        }

        private void navBarItemEquipment_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (EquipmentInventoryForm == null)
            {
                EquipmentInventoryForm = new InventoryTELForm("Equipos");
                EquipmentInventoryForm.MdiParent = this;
                EquipmentInventoryForm.FormClosed += delegate { EquipmentInventoryForm = null; };
                EquipmentInventoryForm.Show();
            }
            else {
                EquipmentInventoryForm.Activate();
            }
            
        }

        private void navBarItemLab_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (LabInventoryForm == null)
            {
                LabInventoryForm = new InventoryTELForm("Laboratorio");
                LabInventoryForm.MdiParent = this;
                LabInventoryForm.FormClosed += delegate { LabInventoryForm = null; };
                LabInventoryForm.Show();
            }
            else {
                LabInventoryForm.Activate();
            }
            
        }

        private void navBarItemSupplies_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (SuppliesInventoryForm == null)
            {
                SuppliesInventoryForm = new InventoryTELForm("Consumibles");
                //SuppliesInventoryForm = new InventoryForm();
                SuppliesInventoryForm.MdiParent = this;
                SuppliesInventoryForm.FormClosed += delegate { SuppliesInventoryForm = null; };
                SuppliesInventoryForm.Show();
            }
            else {
                SuppliesInventoryForm.Activate();
            }            
        }

        private void navBarItemWarehouse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType() == typeof(WarehouseListForm))
                {
                    childForm.Activate();
                    return;
                }

            }
            Form Item = new WarehouseListForm();
            Item.MdiParent = this;
            Item.Show();            
        }

        private void AddItemTSMI_Click(object sender, EventArgs e)
        {
            //activeChild = this.ActiveMdiChild;
            //Form addForm = null;
            //if (activeChild != null)
            //{
                
            //    switch (activeChild.Text)
            //    {
            //        case "Inventario de Equipos":
            //        case "Inventario de Herramientas":
            //        case "Inventario de Laboratorio":
            //            foreach (Form childForm in MdiChildren)
            //            {
            //                if (childForm.GetType() == typeof(ItemTELForm))
            //                {
            //                    childForm.Activate();
            //                    return;
            //                }
            //            }
            //            addForm = new ItemTELForm();
            //            addForm.MdiParent = this;
            //            addForm.Show();
            //            break;
            //        case "Inventario de Consumibles":
            //            foreach (Form childForm in MdiChildren)
            //            {
            //                if (childForm.GetType() == typeof(ItemSuppliesForm))
            //                {
            //                    childForm.Activate();
            //                    return;
            //                }
            //            }
            //            addForm = new ItemSuppliesForm();
            //            addForm.MdiParent = this;
            //            addForm.Show();
            //            break;
            //    }
            //}
            //else {
            //    addForm = new ItemTELForm();
            //    addForm.MdiParent = this;
            //    addForm.Show();
            //}

            RibbonForm form = new ItemForm();
            form.MdiParent = this;
            form.Show();
        }

        private void editItemTSMI_Click(object sender, EventArgs e)
        {
            if (Product == null) 
            {
                MessageBox.Show("Seleccione el producto a inventariar.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                Form editForm = null;
                switch (activeChild.Text)
                {
                    case "Inventario de Equipos":
                    case "Inventario de Herramientas":
                    case "Inventario de Laboratorio":
                    case "Inventario de Consumibles":
                        foreach (Form childForm in MdiChildren)
                        {
                            if (childForm.GetType() == typeof(ItemForm))
                            {
                                childForm.Activate();
                                return;
                            }
                        }
                        editForm = new ItemForm(/*true, Product*/);
                        editForm.MdiParent = this;
                        editForm.Show();
                        break;                        
                }
            }
        }

        private void InputOutputTSMI_Click(object sender, EventArgs e)
        {
            if (Product != null)
            {
                Form Item = new frmItemInOut(Product);                
                Item.MdiParent = this;
                Item.Show();
                EntradaSalidaMenuItem = false;
            }
            else
            {
                MessageBox.Show("Seleccione el producto a inventariar.", "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void navBarItemCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //childForm=null;
            foreach (Form childForm in MdiChildren)
            {
                if(childForm.GetType()==typeof(CategoriesListForm)){
                    childForm.Activate();
                    return;
                }
            }
            Form categoryForm = new CategoriesListForm();
            categoryForm.MdiParent = this;
            categoryForm.Show();
        }

        private void navBarItemBrand_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            { 
                if(childForm.GetType() == typeof(BrandListForm))
                {
                    childForm.Activate();
                    return;
                }
            }
            Form brandForm = new BrandListForm();
            brandForm.MdiParent = this;
            brandForm.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType() == typeof(UnitOfMeasureListForm))
                {
                    childForm.Activate();
                    return;
                }
            }
            Form uomForm = new UnitOfMeasureListForm();
            uomForm.MdiParent = this;
            uomForm.Show();
        }

        private void infoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            { 
                if(childForm.GetType()==typeof(CompanyInfo))
                {
                    childForm.Activate();
                    return;
                }
            }
            Form infoForm = new CompanyInfo();
            infoForm.MdiParent = this;
            infoForm.Show();
        }

        private void OpenOrdersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form orderForm = new PurchaseOrderForm();
            orderForm.MdiParent = this;
            orderForm.Show();
        }

                                
    }
}
