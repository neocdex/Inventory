namespace Inventory.Forms
{
    partial class BaseList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseList));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ReloadBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection32x32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpMainCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.MainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveBarButtonItem,
            this.CancelBarButtonItem,
            this.ReloadBarButtonItem,
            this.EditBarButtonItem,
            this.NewBarButtonItem,
            this.PrintBarButtonItem,
            this.DeleteBarButtonItem});
            this.ribbon.LargeImages = this.imageCollection32x32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(872, 155);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // SaveBarButtonItem
            // 
            this.SaveBarButtonItem.Caption = "Guardar";
            this.SaveBarButtonItem.Id = 1;
            this.SaveBarButtonItem.LargeImageIndex = 2;
            this.SaveBarButtonItem.Name = "SaveBarButtonItem";
            this.SaveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBarButtonItem_ItemClick);
            // 
            // CancelBarButtonItem
            // 
            this.CancelBarButtonItem.Caption = "Cancelar";
            this.CancelBarButtonItem.Id = 2;
            this.CancelBarButtonItem.LargeImageIndex = 3;
            this.CancelBarButtonItem.Name = "CancelBarButtonItem";
            this.CancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CancelBarButtonItem_ItemClick);
            // 
            // ReloadBarButtonItem
            // 
            this.ReloadBarButtonItem.Caption = "Recargar";
            this.ReloadBarButtonItem.Id = 3;
            this.ReloadBarButtonItem.LargeImageIndex = 5;
            this.ReloadBarButtonItem.Name = "ReloadBarButtonItem";
            this.ReloadBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReloadBarButtonItem_ItemClick);
            // 
            // EditBarButtonItem
            // 
            this.EditBarButtonItem.Caption = "Editar";
            this.EditBarButtonItem.Id = 4;
            this.EditBarButtonItem.LargeImageIndex = 1;
            this.EditBarButtonItem.Name = "EditBarButtonItem";
            this.EditBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditBarButtonItem_ItemClick);
            // 
            // NewBarButtonItem
            // 
            this.NewBarButtonItem.Caption = "Nuevo";
            this.NewBarButtonItem.Id = 5;
            this.NewBarButtonItem.LargeImageIndex = 0;
            this.NewBarButtonItem.Name = "NewBarButtonItem";
            this.NewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBarButtonItem_ItemClick);
            // 
            // PrintBarButtonItem
            // 
            this.PrintBarButtonItem.AllowAllUp = true;
            this.PrintBarButtonItem.Caption = "Imprimir";
            this.PrintBarButtonItem.Id = 6;
            this.PrintBarButtonItem.LargeImageIndex = 6;
            this.PrintBarButtonItem.Name = "PrintBarButtonItem";
            this.PrintBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.PrintBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBarButtonItem_ItemClick);
            // 
            // DeleteBarButtonItem
            // 
            this.DeleteBarButtonItem.Caption = "Eliminar";
            this.DeleteBarButtonItem.Id = 7;
            this.DeleteBarButtonItem.LargeImageIndex = 4;
            this.DeleteBarButtonItem.Name = "DeleteBarButtonItem";
            this.DeleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBarButtonItem_ItemClick);
            // 
            // imageCollection32x32
            // 
            this.imageCollection32x32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32x32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32x32.ImageStream")));
            this.imageCollection32x32.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 0);
            this.imageCollection32x32.Images.SetKeyName(0, "additem_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("edit_32x32.png", "images/edit/edit_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/edit_32x32.png"), 1);
            this.imageCollection32x32.Images.SetKeyName(1, "edit_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("save_32x32.png", "images/save/save_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/save_32x32.png"), 2);
            this.imageCollection32x32.Images.SetKeyName(2, "save_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 3);
            this.imageCollection32x32.Images.SetKeyName(3, "cancel_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("delete_32x32.png", "images/edit/delete_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png"), 4);
            this.imageCollection32x32.Images.SetKeyName(4, "delete_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_32x32.png"), 5);
            this.imageCollection32x32.Images.SetKeyName(5, "refresh_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("print_32x32.png", "images/print/print_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_32x32.png"), 6);
            this.imageCollection32x32.Images.SetKeyName(6, "print_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NewBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.CancelBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ReloadBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.PrintBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Reportes";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 401);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(872, 31);
            // 
            // unitOfWork
            // 
            this.unitOfWork.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
            this.unitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork.TrackPropertiesModifications = false;
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.Session = this.unitOfWork;
            // 
            // BaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 432);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "BaseList";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "BaseList";            
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        protected DevExpress.Xpo.UnitOfWork unitOfWork;
        protected DevExpress.Xpo.XPCollection xpMainCollection;
        protected System.Windows.Forms.BindingSource MainBindingSource;
        protected DevExpress.Utils.ImageCollection imageCollection32x32;
        protected DevExpress.XtraBars.BarButtonItem ReloadBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem SaveBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem CancelBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditBarButtonItem;
        protected DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        protected DevExpress.XtraBars.BarButtonItem NewBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem PrintBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem DeleteBarButtonItem;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}