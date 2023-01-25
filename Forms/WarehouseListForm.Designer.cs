namespace Inventory.Forms
{
    partial class WarehouseListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseListForm));
            this.gridWarehouse = new DevExpress.XtraGrid.GridControl();
            this.gridViewWarehouse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemsByWarehouseReport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnWarehouseTransfer = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.xpMainCollection.DisplayableProperties = "This;warehouse_id;name;description;location;project_id!;project_id!Key;project_id" +
    "";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.AllowNew = true;
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
            this.imageCollection32x32.Images.SetKeyName(7, "graph_stock_v2_32x32.png");
            this.imageCollection32x32.Images.SetKeyName(8, "handle4_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.MergeOrder = 0;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnWarehouseTransfer);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ItemsByWarehouseReport,
            this.barBtnWarehouseTransfer});
            this.ribbon.MaxItemId = 10;
            this.ribbon.Size = new System.Drawing.Size(606, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ItemsByWarehouseReport);
            // 
            // gridWarehouse
            // 
            this.gridWarehouse.DataSource = this.MainBindingSource;
            this.gridWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWarehouse.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridWarehouse.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridWarehouse.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridWarehouse.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridWarehouse.Location = new System.Drawing.Point(0, 143);
            this.gridWarehouse.MainView = this.gridViewWarehouse;
            this.gridWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridWarehouse.Name = "gridWarehouse";
            this.gridWarehouse.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit});
            this.gridWarehouse.Size = new System.Drawing.Size(606, 255);
            this.gridWarehouse.TabIndex = 5;
            this.gridWarehouse.UseEmbeddedNavigator = true;
            this.gridWarehouse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWarehouse});
            // 
            // gridViewWarehouse
            // 
            this.gridViewWarehouse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldescription,
            this.collocation});
            this.gridViewWarehouse.GridControl = this.gridWarehouse;
            this.gridViewWarehouse.Name = "gridViewWarehouse";
            this.gridViewWarehouse.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewWarehouse.OptionsFind.AlwaysVisible = true;
            this.gridViewWarehouse.OptionsFind.FindDelay = 1500;
            this.gridViewWarehouse.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewWarehouse.OptionsView.ShowGroupPanel = false;
            this.gridViewWarehouse.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Panel;
            this.gridViewWarehouse.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewWarehouse_ValidateRow);
            // 
            // colname
            // 
            this.colname.Caption = "Nombre del almacén";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descripción";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            // 
            // collocation
            // 
            this.collocation.Caption = "Ubicado en";
            this.collocation.FieldName = "location";
            this.collocation.Name = "collocation";
            this.collocation.Visible = true;
            this.collocation.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit
            // 
            this.repositoryItemGridLookUpEdit.AutoHeight = false;
            this.repositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit.DisplayMember = "name";
            this.repositoryItemGridLookUpEdit.Name = "repositoryItemGridLookUpEdit";
            this.repositoryItemGridLookUpEdit.NullText = "";
            this.repositoryItemGridLookUpEdit.ShowFooter = false;
            this.repositoryItemGridLookUpEdit.ValueMember = "This";
            this.repositoryItemGridLookUpEdit.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsDetail.EnableMasterViewMode = false;
            this.repositoryItemGridLookUpEdit1View.OptionsFind.AllowFindPanel = false;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemsByWarehouseReport
            // 
            this.ItemsByWarehouseReport.Caption = "Items por Almacén";
            this.ItemsByWarehouseReport.Id = 8;
            this.ItemsByWarehouseReport.LargeImageIndex = 7;
            this.ItemsByWarehouseReport.Name = "ItemsByWarehouseReport";
            this.ItemsByWarehouseReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemsByWarehouseReport_ItemClick);
            // 
            // barBtnWarehouseTransfer
            // 
            this.barBtnWarehouseTransfer.Caption = "Trapasar";
            this.barBtnWarehouseTransfer.Id = 9;
            this.barBtnWarehouseTransfer.LargeImageIndex = 8;
            this.barBtnWarehouseTransfer.Name = "barBtnWarehouseTransfer";
            this.barBtnWarehouseTransfer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnWarehouseTransfer_ItemClick);
            // 
            // WarehouseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 429);
            this.Controls.Add(this.gridWarehouse);
            this.Name = "WarehouseListForm";
            this.Text = "Lista de Almacenes";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.gridWarehouse, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridWarehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn collocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem ItemsByWarehouseReport;
        private DevExpress.XtraBars.BarButtonItem barBtnWarehouseTransfer;
    }
}