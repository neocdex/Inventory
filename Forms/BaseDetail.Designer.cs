namespace Inventory.Forms
{
    partial class BaseDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDetail));
            this.imageCollection32x32 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.FirstBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PreviousBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NextBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LastBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.PrintBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.xpMainCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.MainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection32x32
            // 
            this.imageCollection32x32.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection32x32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32x32.ImageStream")));
            this.imageCollection32x32.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 0);
            this.imageCollection32x32.Images.SetKeyName(0, "additem_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("save_32x32.png", "images/save/save_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/save_32x32.png"), 1);
            this.imageCollection32x32.Images.SetKeyName(1, "save_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("delete_32x32.png", "images/edit/delete_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/delete_32x32.png"), 2);
            this.imageCollection32x32.Images.SetKeyName(2, "delete_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("first_32x32.png", "images/arrows/first_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/first_32x32.png"), 3);
            this.imageCollection32x32.Images.SetKeyName(3, "first_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("prev_32x32.png", "images/arrows/prev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_32x32.png"), 4);
            this.imageCollection32x32.Images.SetKeyName(4, "prev_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("next_32x32.png", "images/arrows/next_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_32x32.png"), 5);
            this.imageCollection32x32.Images.SetKeyName(5, "next_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("last_32x32.png", "images/arrows/last_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/last_32x32.png"), 6);
            this.imageCollection32x32.Images.SetKeyName(6, "last_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 7);
            this.imageCollection32x32.Images.SetKeyName(7, "cancel_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("print_32x32.png", "images/print/print_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_32x32.png"), 8);
            this.imageCollection32x32.Images.SetKeyName(8, "print_32x32.png");
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 598);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1053, 31);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.SaveBarButtonItem,
            this.DeleteBarButtonItem,
            this.FirstBarButtonItem,
            this.PreviousBarButtonItem,
            this.NextBarButtonItem,
            this.LastBarButtonItem,
            this.CancelBarButtonItem,
            this.NewBarButtonItem,
            this.PrintBarButtonItem});
            this.ribbon.LargeImages = this.imageCollection32x32;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1053, 155);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // SaveBarButtonItem
            // 
            this.SaveBarButtonItem.Caption = "Guardar";
            this.SaveBarButtonItem.Id = 2;
            this.SaveBarButtonItem.LargeImageIndex = 1;
            this.SaveBarButtonItem.Name = "SaveBarButtonItem";
            this.SaveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBarButtonItem_ItemClick);
            // 
            // DeleteBarButtonItem
            // 
            this.DeleteBarButtonItem.Caption = "Eliminar";
            this.DeleteBarButtonItem.Id = 3;
            this.DeleteBarButtonItem.LargeImageIndex = 2;
            this.DeleteBarButtonItem.Name = "DeleteBarButtonItem";
            this.DeleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBarButtonItem_ItemClick);
            // 
            // FirstBarButtonItem
            // 
            this.FirstBarButtonItem.Caption = "Primero";
            this.FirstBarButtonItem.Id = 4;
            this.FirstBarButtonItem.LargeImageIndex = 3;
            this.FirstBarButtonItem.Name = "FirstBarButtonItem";
            this.FirstBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FirstBarButtonItem_ItemClick);
            // 
            // PreviousBarButtonItem
            // 
            this.PreviousBarButtonItem.Caption = "Anterior";
            this.PreviousBarButtonItem.Id = 5;
            this.PreviousBarButtonItem.LargeImageIndex = 4;
            this.PreviousBarButtonItem.Name = "PreviousBarButtonItem";
            this.PreviousBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PreviousBarButtonItem_ItemClick);
            // 
            // NextBarButtonItem
            // 
            this.NextBarButtonItem.Caption = "Siguiente";
            this.NextBarButtonItem.Id = 6;
            this.NextBarButtonItem.LargeImageIndex = 5;
            this.NextBarButtonItem.Name = "NextBarButtonItem";
            this.NextBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NextBarButtonItem_ItemClick);
            // 
            // LastBarButtonItem
            // 
            this.LastBarButtonItem.Caption = "Último";
            this.LastBarButtonItem.Id = 7;
            this.LastBarButtonItem.LargeImageIndex = 6;
            this.LastBarButtonItem.Name = "LastBarButtonItem";
            this.LastBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LastBarButtonItem_ItemClick);
            // 
            // CancelBarButtonItem
            // 
            this.CancelBarButtonItem.Caption = "Cancelar";
            this.CancelBarButtonItem.Id = 8;
            this.CancelBarButtonItem.LargeImageIndex = 7;
            this.CancelBarButtonItem.Name = "CancelBarButtonItem";
            this.CancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CancelBarButtonItem_ItemClick);
            // 
            // NewBarButtonItem
            // 
            this.NewBarButtonItem.Caption = "Nuevo";
            this.NewBarButtonItem.Id = 9;
            this.NewBarButtonItem.LargeImageIndex = 0;
            this.NewBarButtonItem.Name = "NewBarButtonItem";
            this.NewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBarButtonItem_ItemClick);
            // 
            // PrintBarButtonItem
            // 
            this.PrintBarButtonItem.Caption = "Imprimir";
            this.PrintBarButtonItem.Id = 10;
            this.PrintBarButtonItem.LargeImageIndex = 8;
            this.PrintBarButtonItem.Name = "PrintBarButtonItem";
            this.PrintBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PrintBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NewBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.CancelBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.PrintBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.FirstBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.PreviousBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.NextBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.LastBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Navegación";
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
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // BaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 629);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "BaseDetail";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "BaseDetail";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        protected DevExpress.Xpo.UnitOfWork unitOfWork;
        protected DevExpress.Xpo.XPCollection xpMainCollection;
        protected System.Windows.Forms.BindingSource MainBindingSource;
        protected DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.Utils.ImageCollection imageCollection32x32;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        protected DevExpress.XtraBars.BarButtonItem SaveBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem DeleteBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem FirstBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem PreviousBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem NextBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem LastBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem CancelBarButtonItem;
        protected DevExpress.XtraBars.BarButtonItem NewBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem PrintBarButtonItem;
    }
}