namespace Inventory.Forms
{
    partial class UnitOfMeasureListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitOfMeasureListForm));
            this.gridUOM = new DevExpress.XtraGrid.GridControl();
            this.gridViewUOM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colabbreviation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUOM)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.DisplayableProperties = "This;uom_id;abbreviation;description";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Unitofmeasure);
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
            this.ribbon.Size = new System.Drawing.Size(830, 155);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // gridUOM
            // 
            this.gridUOM.DataSource = this.MainBindingSource;
            this.gridUOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUOM.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridUOM.Location = new System.Drawing.Point(0, 155);
            this.gridUOM.MainView = this.gridViewUOM;
            this.gridUOM.Name = "gridUOM";
            this.gridUOM.Size = new System.Drawing.Size(830, 411);
            this.gridUOM.TabIndex = 6;
            this.gridUOM.UseEmbeddedNavigator = true;
            this.gridUOM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUOM});
            // 
            // gridViewUOM
            // 
            this.gridViewUOM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colabbreviation,
            this.coldescription});
            this.gridViewUOM.GridControl = this.gridUOM;
            this.gridViewUOM.Name = "gridViewUOM";
            this.gridViewUOM.NewItemRowText = "Testing purpose";
            this.gridViewUOM.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewUOM.OptionsFind.AlwaysVisible = true;
            this.gridViewUOM.OptionsFind.FindDelay = 1500;
            this.gridViewUOM.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewUOM.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewUOM.OptionsView.ShowGroupPanel = false;
            // 
            // colabbreviation
            // 
            this.colabbreviation.Caption = "Abreviatura";
            this.colabbreviation.FieldName = "abbreviation";
            this.colabbreviation.Name = "colabbreviation";
            this.colabbreviation.Visible = true;
            this.colabbreviation.VisibleIndex = 0;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descripción";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            // 
            // UnitOfMeasureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 597);
            this.Controls.Add(this.gridUOM);
            this.Name = "UnitOfMeasureListForm";
            this.Text = "Lista de Unidades de Medida";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.gridUOM, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUOM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUOM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colabbreviation;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
    }
}