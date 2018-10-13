namespace Inventory.Forms
{
    partial class InventoryTELForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTELForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.StoredCardView = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colwarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colshelf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InventoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolwarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscontinued_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpCategoryCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridcolbrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrandRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpBrandCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.colunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UOMRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpUOMCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridcolstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpCollectionStatus = new DevExpress.Xpo.XPCollection(this.components);
            this.coltmante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalstock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WarehouseRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpWarehouseCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.InOutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.AllItemReport = new DevExpress.XtraBars.BarButtonItem();
            this.ItemsByWarehouseReport = new DevExpress.XtraBars.BarButtonItem();
            this.TransactionsReport = new DevExpress.XtraBars.BarButtonItem();
            this.ItemsByWarehouseReport2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoredCardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBrandCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUOMCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpWarehouseCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.DisplayableProperties = resources.GetString("xpMainCollection.DisplayableProperties");
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Products);
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
            this.imageCollection32x32.Images.SetKeyName(7, "shipping_handle_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.MergeOrder = 0;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.InOutBarButtonItem);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.InOutBarButtonItem,
            this.AllItemReport,
            this.ItemsByWarehouseReport,
            this.TransactionsReport,
            this.ItemsByWarehouseReport2});
            this.ribbon.Margin = new System.Windows.Forms.Padding(3);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Size = new System.Drawing.Size(1015, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.AllItemReport);
            this.ribbonPageGroup2.ItemLinks.Add(this.ItemsByWarehouseReport);
            this.ribbonPageGroup2.ItemLinks.Add(this.TransactionsReport);
            this.ribbonPageGroup2.ItemLinks.Add(this.ItemsByWarehouseReport2);
            // 
            // StoredCardView
            // 
            this.StoredCardView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colwarehouse,
            this.colshelf,
            this.colrow,
            this.colposition,
            this.colstock,
            this.gridColumn4});
            this.StoredCardView.FocusedCardTopFieldIndex = 0;
            this.StoredCardView.GridControl = this.InventoryGridControl;
            this.StoredCardView.Name = "StoredCardView";
            this.StoredCardView.OptionsFind.AllowFindPanel = false;
            this.StoredCardView.OptionsView.ShowQuickCustomizeButton = false;
            this.StoredCardView.ViewCaption = "Almacenes";
            // 
            // colwarehouse
            // 
            this.colwarehouse.Caption = "Almacén";
            this.colwarehouse.FieldName = "warehouse_id.name";
            this.colwarehouse.Name = "colwarehouse";
            this.colwarehouse.OptionsColumn.ReadOnly = true;
            this.colwarehouse.Visible = true;
            this.colwarehouse.VisibleIndex = 0;
            // 
            // colshelf
            // 
            this.colshelf.Caption = "Estante";
            this.colshelf.FieldName = "shelf";
            this.colshelf.Name = "colshelf";
            this.colshelf.OptionsColumn.ReadOnly = true;
            this.colshelf.Visible = true;
            this.colshelf.VisibleIndex = 1;
            // 
            // colrow
            // 
            this.colrow.Caption = "Fila";
            this.colrow.FieldName = "row";
            this.colrow.Name = "colrow";
            this.colrow.OptionsColumn.ReadOnly = true;
            this.colrow.Visible = true;
            this.colrow.VisibleIndex = 2;
            // 
            // colposition
            // 
            this.colposition.Caption = "Posición";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.ReadOnly = true;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 3;
            // 
            // colstock
            // 
            this.colstock.Caption = "Existencias";
            this.colstock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colstock.FieldName = "quantityInHand";
            this.colstock.Name = "colstock";
            this.colstock.OptionsColumn.ReadOnly = true;
            this.colstock.Visible = true;
            this.colstock.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cant. mínima";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "reorderQuantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // InventoryGridControl
            // 
            this.InventoryGridControl.DataSource = this.MainBindingSource;
            this.InventoryGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.InventoryGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.InventoryGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.InventoryGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.InventoryGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.InventoryGridControl.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            gridLevelNode1.LevelTemplate = this.StoredCardView;
            gridLevelNode1.RelationName = "StoredItems";
            this.InventoryGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.InventoryGridControl.Location = new System.Drawing.Point(12, 12);
            this.InventoryGridControl.MainView = this.gridViewInventory;
            this.InventoryGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryGridControl.Name = "InventoryGridControl";
            this.InventoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.StatusRepositoryItemLookUpEdit,
            this.CategoryRepositoryItemLookUpEdit,
            this.BrandRepositoryItemLookUpEdit,
            this.UOMRepositoryItemLookUpEdit,
            this.WarehouseRepositoryItemLookUpEdit});
            this.InventoryGridControl.ShowOnlyPredefinedDetails = true;
            this.InventoryGridControl.Size = new System.Drawing.Size(991, 363);
            this.InventoryGridControl.TabIndex = 4;
            this.InventoryGridControl.UseEmbeddedNavigator = true;
            this.InventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInventory,
            this.StoredCardView});
            // 
            // gridViewInventory
            // 
            this.gridViewInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproduct_id,
            this.colname,
            this.coldescription,
            this.gridcolwarehouse,
            this.coldiscontinued,
            this.coldiscontinued_date,
            this.gridcolcategory,
            this.gridcolbrand,
            this.colunit,
            this.gridcolstatus,
            this.coltmante,
            this.coltotalstock});
            this.gridViewInventory.GridControl = this.InventoryGridControl;
            this.gridViewInventory.Name = "gridViewInventory";
            this.gridViewInventory.OptionsFind.AlwaysVisible = true;
            this.gridViewInventory.OptionsView.ShowGroupPanel = false;
            this.gridViewInventory.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewInventory_RowStyle);
            this.gridViewInventory.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewInventory_CustomUnboundColumnData);
            // 
            // colproduct_id
            // 
            this.colproduct_id.Caption = "ID";
            this.colproduct_id.FieldName = "productcode";
            this.colproduct_id.Name = "colproduct_id";
            this.colproduct_id.OptionsColumn.ReadOnly = true;
            this.colproduct_id.Visible = true;
            this.colproduct_id.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Item";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
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
            // gridcolwarehouse
            // 
            this.gridcolwarehouse.Caption = "Almacenes";
            this.gridcolwarehouse.FieldName = "gridcolwarehouse";
            this.gridcolwarehouse.Name = "gridcolwarehouse";
            this.gridcolwarehouse.OptionsColumn.ReadOnly = true;
            this.gridcolwarehouse.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridcolwarehouse.Visible = true;
            this.gridcolwarehouse.VisibleIndex = 3;
            // 
            // coldiscontinued
            // 
            this.coldiscontinued.Caption = "Descontinuado";
            this.coldiscontinued.FieldName = "discontinued";
            this.coldiscontinued.Name = "coldiscontinued";
            this.coldiscontinued.Visible = true;
            this.coldiscontinued.VisibleIndex = 4;
            // 
            // coldiscontinued_date
            // 
            this.coldiscontinued_date.Caption = "Fecha descontinuad";
            this.coldiscontinued_date.FieldName = "discontinued_date";
            this.coldiscontinued_date.Name = "coldiscontinued_date";
            this.coldiscontinued_date.Visible = true;
            this.coldiscontinued_date.VisibleIndex = 5;
            // 
            // gridcolcategory
            // 
            this.gridcolcategory.Caption = "Categoría";
            this.gridcolcategory.ColumnEdit = this.CategoryRepositoryItemLookUpEdit;
            this.gridcolcategory.FieldName = "category_id!";
            this.gridcolcategory.Name = "gridcolcategory";
            this.gridcolcategory.Visible = true;
            this.gridcolcategory.VisibleIndex = 6;
            // 
            // CategoryRepositoryItemLookUpEdit
            // 
            this.CategoryRepositoryItemLookUpEdit.AutoHeight = false;
            this.CategoryRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("category_id", "category_id", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CategoryRepositoryItemLookUpEdit.DataSource = this.xpCategoryCollection;
            this.CategoryRepositoryItemLookUpEdit.DisplayMember = "name";
            this.CategoryRepositoryItemLookUpEdit.Name = "CategoryRepositoryItemLookUpEdit";
            this.CategoryRepositoryItemLookUpEdit.NullText = "";
            this.CategoryRepositoryItemLookUpEdit.ShowHeader = false;
            this.CategoryRepositoryItemLookUpEdit.ValueMember = "This";
            this.CategoryRepositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.CategoryRepositoryItemLookUpEdit_EditValueChanged);
            // 
            // xpCategoryCollection
            // 
            this.xpCategoryCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCategoryCollection.DisplayableProperties = "This;code;name;description";
            this.xpCategoryCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Category);
            this.xpCategoryCollection.Session = this.unitOfWork;
            // 
            // gridcolbrand
            // 
            this.gridcolbrand.Caption = "Marca";
            this.gridcolbrand.ColumnEdit = this.BrandRepositoryItemLookUpEdit;
            this.gridcolbrand.FieldName = "brand_id!";
            this.gridcolbrand.Name = "gridcolbrand";
            this.gridcolbrand.Visible = true;
            this.gridcolbrand.VisibleIndex = 7;
            // 
            // BrandRepositoryItemLookUpEdit
            // 
            this.BrandRepositoryItemLookUpEdit.AutoHeight = false;
            this.BrandRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BrandRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_id", "Brand_id", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Marca", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.BrandRepositoryItemLookUpEdit.DataSource = this.xpBrandCollection;
            this.BrandRepositoryItemLookUpEdit.DisplayMember = "name";
            this.BrandRepositoryItemLookUpEdit.Name = "BrandRepositoryItemLookUpEdit";
            this.BrandRepositoryItemLookUpEdit.NullText = "";
            this.BrandRepositoryItemLookUpEdit.ShowHeader = false;
            this.BrandRepositoryItemLookUpEdit.ValueMember = "This";
            this.BrandRepositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.BrandRepositoryItemLookUpEdit_EditValueChanged);
            // 
            // xpBrandCollection
            // 
            this.xpBrandCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpBrandCollection.DisplayableProperties = "This;Brand_id;name";
            this.xpBrandCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Brand);
            this.xpBrandCollection.Session = this.unitOfWork;
            // 
            // colunit
            // 
            this.colunit.Caption = "Unidad";
            this.colunit.ColumnEdit = this.UOMRepositoryItemLookUpEdit;
            this.colunit.FieldName = "uom_id!";
            this.colunit.Name = "colunit";
            this.colunit.Visible = true;
            this.colunit.VisibleIndex = 8;
            // 
            // UOMRepositoryItemLookUpEdit
            // 
            this.UOMRepositoryItemLookUpEdit.AutoHeight = false;
            this.UOMRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UOMRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uom_id", "uom_id", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("abbreviation", "abbreviation", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UOMRepositoryItemLookUpEdit.DataSource = this.xpUOMCollection;
            this.UOMRepositoryItemLookUpEdit.DisplayMember = "abbreviation";
            this.UOMRepositoryItemLookUpEdit.Name = "UOMRepositoryItemLookUpEdit";
            this.UOMRepositoryItemLookUpEdit.NullText = "";
            this.UOMRepositoryItemLookUpEdit.ShowHeader = false;
            this.UOMRepositoryItemLookUpEdit.ValueMember = "This";
            this.UOMRepositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.UOMRepositoryItemLookUpEdit_EditValueChanged);
            // 
            // xpUOMCollection
            // 
            this.xpUOMCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpUOMCollection.DisplayableProperties = "This;uom_id;abbreviation;description";
            this.xpUOMCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Unitofmeasure);
            this.xpUOMCollection.Session = this.unitOfWork;
            // 
            // gridcolstatus
            // 
            this.gridcolstatus.Caption = "Estado";
            this.gridcolstatus.ColumnEdit = this.StatusRepositoryItemLookUpEdit;
            this.gridcolstatus.FieldName = "Status_idStatus!";
            this.gridcolstatus.Name = "gridcolstatus";
            this.gridcolstatus.Visible = true;
            this.gridcolstatus.VisibleIndex = 9;
            // 
            // StatusRepositoryItemLookUpEdit
            // 
            this.StatusRepositoryItemLookUpEdit.AutoHeight = false;
            this.StatusRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idStatus", "id Status", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("status", "status", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.StatusRepositoryItemLookUpEdit.DataSource = this.xpCollectionStatus;
            this.StatusRepositoryItemLookUpEdit.DisplayMember = "status";
            this.StatusRepositoryItemLookUpEdit.Name = "StatusRepositoryItemLookUpEdit";
            this.StatusRepositoryItemLookUpEdit.NullText = "";
            this.StatusRepositoryItemLookUpEdit.ShowHeader = false;
            this.StatusRepositoryItemLookUpEdit.ValueMember = "This";
            this.StatusRepositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.StatusRepositoryItemLookUpEdit_EditValueChanged);
            // 
            // xpCollectionStatus
            // 
            this.xpCollectionStatus.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCollectionStatus.DisplayableProperties = "This;idStatus;status";
            this.xpCollectionStatus.ObjectType = typeof(Inventory.ORMDataModelCode.Status);
            this.xpCollectionStatus.Session = this.unitOfWork;
            // 
            // coltmante
            // 
            this.coltmante.Caption = "T/Mante";
            this.coltmante.FieldName = "tmante";
            this.coltmante.Name = "coltmante";
            this.coltmante.Visible = true;
            this.coltmante.VisibleIndex = 10;
            // 
            // coltotalstock
            // 
            this.coltotalstock.Caption = "Total en existencias";
            this.coltotalstock.FieldName = "totalStock";
            this.coltotalstock.Name = "coltotalstock";
            this.coltotalstock.OptionsColumn.AllowEdit = false;
            this.coltotalstock.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "coltotalstock", "{0:c2}")});
            this.coltotalstock.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.coltotalstock.Visible = true;
            this.coltotalstock.VisibleIndex = 11;
            // 
            // WarehouseRepositoryItemLookUpEdit
            // 
            this.WarehouseRepositoryItemLookUpEdit.AutoHeight = false;
            this.WarehouseRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WarehouseRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("warehouse_id", "", 103, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Almacén", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.WarehouseRepositoryItemLookUpEdit.DataSource = this.xpWarehouseCollection;
            this.WarehouseRepositoryItemLookUpEdit.DisplayMember = "name";
            this.WarehouseRepositoryItemLookUpEdit.Name = "WarehouseRepositoryItemLookUpEdit";
            this.WarehouseRepositoryItemLookUpEdit.ValueMember = "This";
            // 
            // xpWarehouseCollection
            // 
            this.xpWarehouseCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpWarehouseCollection.DisplayableProperties = "This;warehouse_id;name;description;location";
            this.xpWarehouseCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
            this.xpWarehouseCollection.Session = this.unitOfWork;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.InventoryGridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 143);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(1015, 387);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1015, 387);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.InventoryGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(995, 367);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // InOutBarButtonItem
            // 
            this.InOutBarButtonItem.Caption = "Entrada/Salida";
            this.InOutBarButtonItem.Id = 7;
            this.InOutBarButtonItem.LargeImageIndex = 7;
            this.InOutBarButtonItem.Name = "InOutBarButtonItem";
            this.InOutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InOutBarButtonItem_ItemClick);
            // 
            // AllItemReport
            // 
            this.AllItemReport.Caption = "Todos los items";
            this.AllItemReport.Id = 8;
            this.AllItemReport.LargeImageIndex = 8;
            this.AllItemReport.Name = "AllItemReport";
            this.AllItemReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AllItemReport_ItemClick);
            // 
            // ItemsByWarehouseReport
            // 
            this.ItemsByWarehouseReport.Caption = "Items por Almacén";
            this.ItemsByWarehouseReport.Id = 10;
            this.ItemsByWarehouseReport.LargeImageIndex = 12;
            this.ItemsByWarehouseReport.Name = "ItemsByWarehouseReport";
            this.ItemsByWarehouseReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemsByWarehouseReport_ItemClick);
            // 
            // TransactionsReport
            // 
            this.TransactionsReport.Caption = "Movimientos";
            this.TransactionsReport.Id = 11;
            this.TransactionsReport.LargeImageIndex = 9;
            this.TransactionsReport.Name = "TransactionsReport";
            this.TransactionsReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TransactionsReport_ItemClick);
            // 
            // ItemsByWarehouseReport2
            // 
            this.ItemsByWarehouseReport2.Caption = "Por Almacén";
            this.ItemsByWarehouseReport2.Id = 12;
            this.ItemsByWarehouseReport2.LargeImageIndex = 11;
            this.ItemsByWarehouseReport2.Name = "ItemsByWarehouseReport2";
            this.ItemsByWarehouseReport2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ItemsByWarehouseReport2_ItemClick);
            // 
            // InventoryTELForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 561);
            this.Controls.Add(this.layoutControl);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "InventoryTELForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.layoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoredCardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBrandCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UOMRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUOMCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpWarehouseCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollectionStatus;
        private DevExpress.Xpo.XPCollection xpBrandCollection;
        private DevExpress.Xpo.XPCollection xpCategoryCollection;
        private DevExpress.Xpo.XPCollection xpUOMCollection;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraGrid.GridControl InventoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInventory;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit StatusRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CategoryRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit BrandRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UOMRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Views.Card.CardView StoredCardView;
        private DevExpress.XtraGrid.Columns.GridColumn colshelf;
        private DevExpress.XtraGrid.Columns.GridColumn colrow;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colstock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colwarehouse;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit WarehouseRepositoryItemLookUpEdit;
        private DevExpress.Xpo.XPCollection xpWarehouseCollection;
        private DevExpress.XtraBars.BarButtonItem InOutBarButtonItem;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscontinued;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscontinued_date;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolcategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolbrand;
        private DevExpress.XtraGrid.Columns.GridColumn colunit;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolstatus;
        private DevExpress.XtraGrid.Columns.GridColumn coltmante;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalstock;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolwarehouse;
        private DevExpress.XtraBars.BarButtonItem AllItemReport;
        private DevExpress.XtraBars.BarButtonItem ItemsByWarehouseReport;
        private DevExpress.XtraBars.BarButtonItem TransactionsReport;
        private DevExpress.XtraBars.BarButtonItem ItemsByWarehouseReport2;        
    }
}