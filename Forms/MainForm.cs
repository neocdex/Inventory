using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Inventory.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {        
        public MainForm()
        {
            InitializeComponent();
            //PostInitializeComponent();
        }

        private void PostInitializeComponent() {
            //ProjectBarButtonItem.Visibility = BarItemVisibility.Never;
        }

        private void LoadItemList(object sender, ItemClickEventArgs e)
        {
            //Form childForm;
            foreach (Form childForm in MdiChildren) {
                if (childForm.GetType() == typeof(InventoryTELForm)) {
                    childForm.Activate();
                    SelectRibbonPage();
                    return;
                }
            }
            Form child = new InventoryTELForm();
            child.MdiParent = this;
            child.Visible = true;
            SelectRibbonPage();
            //BarButtonItem item = e.Item as BarButtonItem;
            //foreach (Form childForm in MdiChildren) {
            //    if (childForm.GetType() == typeof(InventoryTELForm) && childForm.Tag.Equals(item.Tag) )
            //    {
            //        childForm.Activate();
            //        return;
            //    }
            //}
            //Form InventoryForm =  new Form();
            //bool showForm = false;
            //switch (item.Tag.ToString()) { 
            //    case "tool":
            //        InventoryForm = new InventoryTELForm("Herramientas");
            //        InventoryForm.Tag = "tool";                    
            //        showForm = true;
            //        break;
            //    case "equipt":
            //        InventoryForm = new InventoryTELForm("Equipos");
            //        InventoryForm.Tag = "equipt";
            //        showForm = true;
            //        break;
            //    case "lab":
            //        InventoryForm = new InventoryTELForm("Laboratorio");
            //        InventoryForm.Tag = "lab";
            //        showForm = true;
            //        break;
            //    case "supplies":
            //        InventoryForm = new InventoryTELForm("Consumibles");
            //        InventoryForm.Tag = "supplies";
            //        showForm = true;
            //        break;
            //}
            //if (showForm)
            //{
            //    InventoryForm.MdiParent = this;
            //    InventoryForm.Visible = showForm;                
            //}
        }

        private void SupplierBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (!FindForm(typeof(SupplierListForm)))
            {
                BaseList f = new SupplierListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }

        private void SelectRibbonPage()
        {
            ribbon.SelectedPage = ribbon.MergedRibbon.Pages[0];
        }

        private void WarehouseBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (!FindForm(typeof(WarehouseListForm)))
            {
                BaseList f = new WarehouseListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }

        private void CategorybarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (!FindForm(typeof(CategoriesListForm)))
            {
                BaseList f = new CategoriesListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }

        private void AddSupplierBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaseDetail f = new SupplierForm();
            f.MdiParent = this;
            f.OnNewClicked();
            f.Show();
            SelectRibbonPage();
        }

        private void CompanyBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (!FindForm(typeof(CompanyInfo)))
            {
                Form f = new CompanyInfo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BrandBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {            
            if (!FindForm(typeof(BrandListForm)))
            {
                BaseList f = new BrandListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }

        private void UOMBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FindForm(typeof(UnitOfMeasureListForm)))
            {
                BaseList f = new UnitOfMeasureListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }

        }
        private bool FindForm(Type type) {
            foreach (Form childForm in this.MdiChildren) {
                if (type == childForm.GetType()) {
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void ProjectBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(!FindForm(typeof(FormProjectsList))){
                BaseList f = new FormProjectsList();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void StatusBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FindForm(typeof(StatusListForm))) {
                BaseList f = new StatusListForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }

        private void AppSettingsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!FindForm(typeof(AppSettingsForm))) {
                BaseList f = new AppSettingsForm();
                f.MdiParent = this;
                f.Show();
                SelectRibbonPage();
            }
        }
    }
}