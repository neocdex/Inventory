namespace Inventory.Forms
{
    partial class BrandListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandListForm));
            this.gridBrand = new DevExpress.XtraGrid.GridControl();
            this.gridViewBrand = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBrand_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.DisplayableProperties = "This;Brand_id;name";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Brand);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = this.xpMainCollection;
            // 
            // imageCollection32x32
            // 
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
            this.ribbonPage1.MergeOrder = 0;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(700, 155);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // gridBrand
            // 
            this.gridBrand.DataSource = this.MainBindingSource;
            this.gridBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBrand.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridBrand.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridBrand_EmbeddedNavigator_ButtonClick);
            this.gridBrand.Location = new System.Drawing.Point(0, 155);
            this.gridBrand.MainView = this.gridViewBrand;
            this.gridBrand.Name = "gridBrand";
            this.gridBrand.Size = new System.Drawing.Size(700, 345);
            this.gridBrand.TabIndex = 6;
            this.gridBrand.UseEmbeddedNavigator = true;
            this.gridBrand.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBrand});
            // 
            // gridViewBrand
            // 
            this.gridViewBrand.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrand_id,
            this.colname});
            this.gridViewBrand.GridControl = this.gridBrand;
            this.gridViewBrand.Name = "gridViewBrand";
            this.gridViewBrand.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewBrand.OptionsFind.AlwaysVisible = true;
            this.gridViewBrand.OptionsFind.FindDelay = 1500;
            this.gridViewBrand.OptionsNavigation.UseOfficePageNavigation = false;
            this.gridViewBrand.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewBrand.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewBrand.OptionsView.ShowGroupPanel = false;
            // 
            // colBrand_id
            // 
            this.colBrand_id.FieldName = "Brand_id";
            this.colBrand_id.Name = "colBrand_id";
            // 
            // colname
            // 
            this.colname.Caption = "Marca";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // BrandListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 531);
            this.Controls.Add(this.gridBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BrandListForm";
            this.Text = "Lista de Marcas";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.gridBrand, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBrand;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;


    }
}