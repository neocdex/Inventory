namespace Inventory.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection16x16 = new DevExpress.Utils.ImageCollection();
            this.CategorybarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.WarehouseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.AddSupplierBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SupplierListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CompanyBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.UOMBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.BrandBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProductBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.StatusBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.AppSettingsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection32x32 = new DevExpress.Utils.ImageCollection();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ConfigRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imageCollection16x16;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.CategorybarButtonItem,
            this.WarehouseBarButtonItem,
            this.barSubItem2,
            this.SupplierListBarButtonItem,
            this.AddSupplierBarButtonItem,
            this.CompanyBarButtonItem,
            this.UOMBarButtonItem,
            this.BrandBarButtonItem,
            this.ProductBarButtonItem,
            this.StatusBarButtonItem,
            this.AppSettingsBarButtonItem});
            this.ribbon.LargeImages = this.imageCollection32x32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1004, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // imageCollection16x16
            // 
            this.imageCollection16x16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection16x16.ImageStream")));
            this.imageCollection16x16.Images.SetKeyName(0, "tool-box-16x16.png");
            this.imageCollection16x16.Images.SetKeyName(1, "equipment_16x16.png");
            this.imageCollection16x16.Images.SetKeyName(2, "chemical_sciencie_16x16.png");
            this.imageCollection16x16.Images.SetKeyName(3, "supplies-16x16.png");
            this.imageCollection16x16.Images.SetKeyName(4, "warehouse_16x16.png");
            this.imageCollection16x16.Images.SetKeyName(5, "suppliers_16x16.png");
            this.imageCollection16x16.Images.SetKeyName(6, "preferences-contact-list.png");
            // 
            // CategorybarButtonItem
            // 
            this.CategorybarButtonItem.Caption = "Categorías";
            this.CategorybarButtonItem.Id = 6;
            this.CategorybarButtonItem.LargeImageIndex = 4;
            this.CategorybarButtonItem.Name = "CategorybarButtonItem";
            this.CategorybarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CategorybarButtonItem_ItemClick);
            // 
            // WarehouseBarButtonItem
            // 
            this.WarehouseBarButtonItem.Caption = "Almacenes";
            this.WarehouseBarButtonItem.Id = 15;
            this.WarehouseBarButtonItem.LargeImageIndex = 6;
            this.WarehouseBarButtonItem.Name = "WarehouseBarButtonItem";
            this.WarehouseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.WarehouseBarButtonItem_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Proveedores";
            this.barSubItem2.Id = 17;
            this.barSubItem2.LargeImageIndex = 8;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AddSupplierBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.SupplierListBarButtonItem)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // AddSupplierBarButtonItem
            // 
            this.AddSupplierBarButtonItem.Caption = "Nuevo Proveedor...";
            this.AddSupplierBarButtonItem.Id = 19;
            this.AddSupplierBarButtonItem.ImageIndex = 5;
            this.AddSupplierBarButtonItem.Name = "AddSupplierBarButtonItem";
            this.AddSupplierBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddSupplierBarButtonItem_ItemClick);
            // 
            // SupplierListBarButtonItem
            // 
            this.SupplierListBarButtonItem.Caption = "Lista de Proveedores...";
            this.SupplierListBarButtonItem.Id = 18;
            this.SupplierListBarButtonItem.ImageIndex = 6;
            this.SupplierListBarButtonItem.Name = "SupplierListBarButtonItem";
            this.SupplierListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SupplierBarButtonItem_ItemClick);
            // 
            // CompanyBarButtonItem
            // 
            this.CompanyBarButtonItem.Caption = "Empresa";
            this.CompanyBarButtonItem.Id = 20;
            this.CompanyBarButtonItem.LargeImageIndex = 9;
            this.CompanyBarButtonItem.Name = "CompanyBarButtonItem";
            this.CompanyBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CompanyBarButtonItem_ItemClick);
            // 
            // UOMBarButtonItem
            // 
            this.UOMBarButtonItem.Caption = "Unidades de medidas";
            this.UOMBarButtonItem.Id = 21;
            this.UOMBarButtonItem.LargeImageIndex = 7;
            this.UOMBarButtonItem.Name = "UOMBarButtonItem";
            this.UOMBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UOMBarButtonItem_ItemClick);
            // 
            // BrandBarButtonItem
            // 
            this.BrandBarButtonItem.Caption = "Marcas";
            this.BrandBarButtonItem.Id = 22;
            this.BrandBarButtonItem.LargeImageIndex = 10;
            this.BrandBarButtonItem.Name = "BrandBarButtonItem";
            this.BrandBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BrandBarButtonItem_ItemClick);
            // 
            // ProductBarButtonItem
            // 
            this.ProductBarButtonItem.Caption = "Productos";
            this.ProductBarButtonItem.Id = 24;
            this.ProductBarButtonItem.LargeImageIndex = 5;
            this.ProductBarButtonItem.Name = "ProductBarButtonItem";
            this.ProductBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LoadItemList);
            // 
            // StatusBarButtonItem
            // 
            this.StatusBarButtonItem.Caption = "Estados";
            this.StatusBarButtonItem.Id = 25;
            this.StatusBarButtonItem.LargeImageIndex = 11;
            this.StatusBarButtonItem.Name = "StatusBarButtonItem";
            this.StatusBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StatusBarButtonItem_ItemClick);
            // 
            // AppSettingsBarButtonItem
            // 
            this.AppSettingsBarButtonItem.Caption = "AppSettings";
            this.AppSettingsBarButtonItem.Id = 26;
            this.AppSettingsBarButtonItem.Name = "AppSettingsBarButtonItem";
            this.AppSettingsBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.AppSettingsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AppSettingsBarButtonItem_ItemClick);
            // 
            // imageCollection32x32
            // 
            this.imageCollection32x32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32x32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32x32.ImageStream")));
            this.imageCollection32x32.Images.SetKeyName(0, "tool-box-32x32.png");
            this.imageCollection32x32.Images.SetKeyName(1, "03_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(2, "chemical_sciencie_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(3, "supplies-32x32.png");
            this.imageCollection32x32.Images.SetKeyName(4, "categories_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(5, "brand_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(6, "warehouse_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(7, "ruler_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(8, "suppliers_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(9, "briefcase_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(10, "brand-icon_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(11, "status_32x32.png");
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup,
            this.ConfigRibbonPageGroup});
            this.ribbonPage.MergeOrder = 1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Administración";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.ProductBarButtonItem);
            this.ribbonPageGroup.ItemLinks.Add(this.barSubItem2);
            this.ribbonPageGroup.ItemLinks.Add(this.CategorybarButtonItem);
            this.ribbonPageGroup.ItemLinks.Add(this.WarehouseBarButtonItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "Inventario";
            // 
            // ConfigRibbonPageGroup
            // 
            this.ConfigRibbonPageGroup.ItemLinks.Add(this.BrandBarButtonItem);
            this.ConfigRibbonPageGroup.ItemLinks.Add(this.UOMBarButtonItem);
            this.ConfigRibbonPageGroup.ItemLinks.Add(this.StatusBarButtonItem);
            this.ConfigRibbonPageGroup.ItemLinks.Add(this.CompanyBarButtonItem);
            this.ConfigRibbonPageGroup.ItemLinks.Add(this.AppSettingsBarButtonItem);
            this.ConfigRibbonPageGroup.Name = "ConfigRibbonPageGroup";
            this.ConfigRibbonPageGroup.Text = "Configuración";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 525);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1004, 31);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 556);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Inventario de Consultoría y Construcción S.A. (CYCSA)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection imageCollection32x32;
        private DevExpress.XtraBars.BarButtonItem CategorybarButtonItem;
        private DevExpress.Utils.ImageCollection imageCollection16x16;
        private DevExpress.XtraBars.BarButtonItem WarehouseBarButtonItem;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem AddSupplierBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem SupplierListBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem CompanyBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem UOMBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem BrandBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ConfigRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ProductBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem StatusBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem AppSettingsBarButtonItem;        
    }
}