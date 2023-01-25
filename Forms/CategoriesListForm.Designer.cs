namespace Inventory.Forms
{
    partial class CategoriesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesListForm));
            this.gridCategories = new DevExpress.XtraGrid.GridControl();
            this.gridViewCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.xpMainCollection.DisplayableProperties = "This;category_id;name;description;code";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Category);
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
            this.ribbon.Margin = new System.Windows.Forms.Padding(3);
            this.ribbon.Size = new System.Drawing.Size(666, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // gridCategories
            // 
            this.gridCategories.DataSource = this.MainBindingSource;
            this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategories.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridCategories.Location = new System.Drawing.Point(0, 143);
            this.gridCategories.MainView = this.gridViewCategories;
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.Size = new System.Drawing.Size(666, 263);
            this.gridCategories.TabIndex = 4;
            this.gridCategories.UseEmbeddedNavigator = true;
            this.gridCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategories});
            // 
            // gridViewCategories
            // 
            this.gridViewCategories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcode,
            this.colname,
            this.coldescription});
            this.gridViewCategories.GridControl = this.gridCategories;
            this.gridViewCategories.Name = "gridViewCategories";
            this.gridViewCategories.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewCategories.OptionsFind.AlwaysVisible = true;
            this.gridViewCategories.OptionsFind.FindDelay = 1500;
            this.gridViewCategories.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewCategories.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewCategories.OptionsView.ShowGroupPanel = false;
            this.gridViewCategories.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewCategories_InvalidRowException);
            this.gridViewCategories.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewCategories_ValidateRow);
            this.gridViewCategories.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewCategories_RowUpdated);
            // 
            // colcode
            // 
            this.colcode.Caption = "Prefijo";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre de la categoría";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descripción";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 2;
            // 
            // CategoriesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 437);
            this.Controls.Add(this.gridCategories);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CategoriesListForm";
            this.Text = "Lista de Categorías";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.gridCategories, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategories;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;

    }
}