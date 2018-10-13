namespace Inventory.Forms
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridStored = new DevExpress.XtraGrid.GridControl();
            this.gridViewStored = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstored_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WarehouseRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpWarehouseCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.colshelf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreorderQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEditDiscontinued = new DevExpress.XtraEditors.DateEdit();
            this.chkDiscontinued = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.xpStatusCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.txtTMant = new DevExpress.XtraEditors.TextEdit();
            this.txtFEnergia = new DevExpress.XtraEditors.TextEdit();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.pictImage = new DevExpress.XtraEditors.PictureEdit();
            this.txtSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtBarCode = new DevExpress.XtraEditors.TextEdit();
            this.lookupCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.xpCategoryCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.lookupBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.xpBrandCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.lookupUOM = new DevExpress.XtraEditors.LookUpEdit();
            this.xpUOMCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DiscontinuedDateLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpWarehouseCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDiscontinued.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDiscontinued.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiscontinued.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpStatusCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFEnergia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBrandCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupUOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUOMCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscontinuedDateLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.xpMainCollection.DisplayableProperties = resources.GetString("xpMainCollection.DisplayableProperties");
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Products);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = this.xpMainCollection;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // imageCollection32x32
            // 
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
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Margin = new System.Windows.Forms.Padding(3);
            this.ribbon.Size = new System.Drawing.Size(1015, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridStored);
            this.layoutControl1.Controls.Add(this.dateEditDiscontinued);
            this.layoutControl1.Controls.Add(this.chkDiscontinued);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.lookUpEditStatus);
            this.layoutControl1.Controls.Add(this.txtTMant);
            this.layoutControl1.Controls.Add(this.txtFEnergia);
            this.layoutControl1.Controls.Add(this.memoDescription);
            this.layoutControl1.Controls.Add(this.txtProductCode);
            this.layoutControl1.Controls.Add(this.pictImage);
            this.layoutControl1.Controls.Add(this.txtSerialNumber);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtBarCode);
            this.layoutControl1.Controls.Add(this.lookupCategory);
            this.layoutControl1.Controls.Add(this.lookupBrand);
            this.layoutControl1.Controls.Add(this.txtModel);
            this.layoutControl1.Controls.Add(this.lookupUOM);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(691, 509, 412, 378);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1015, 387);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridStored
            // 
            this.gridStored.DataMember = "StoredItems";
            this.gridStored.DataSource = this.MainBindingSource;
            this.gridStored.Location = new System.Drawing.Point(12, 240);
            this.gridStored.MainView = this.gridViewStored;
            this.gridStored.Margin = new System.Windows.Forms.Padding(4);
            this.gridStored.Name = "gridStored";
            this.gridStored.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.WarehouseRepositoryItemLookUpEdit});
            this.gridStored.Size = new System.Drawing.Size(991, 135);
            this.gridStored.TabIndex = 15;
            this.gridStored.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStored});
            // 
            // gridViewStored
            // 
            this.gridViewStored.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstored_id,
            this.colwarehouse,
            this.colshelf,
            this.colrow,
            this.colposition,
            this.colreorderQuantity,
            this.gridColumn1});
            this.gridViewStored.GridControl = this.gridStored;
            this.gridViewStored.Name = "gridViewStored";
            this.gridViewStored.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewStored.OptionsFind.AllowFindPanel = false;
            this.gridViewStored.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewStored.OptionsView.ShowGroupPanel = false;
            this.gridViewStored.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewStored_ValidateRow);
            this.gridViewStored.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewStored_ValidatingEditor);
            // 
            // colstored_id
            // 
            this.colstored_id.FieldName = "stored_id";
            this.colstored_id.Name = "colstored_id";
            // 
            // colwarehouse
            // 
            this.colwarehouse.Caption = "Almacén";
            this.colwarehouse.ColumnEdit = this.WarehouseRepositoryItemLookUpEdit;
            this.colwarehouse.FieldName = "warehouse_id!";
            this.colwarehouse.Name = "colwarehouse";
            this.colwarehouse.Visible = true;
            this.colwarehouse.VisibleIndex = 0;
            // 
            // WarehouseRepositoryItemLookUpEdit
            // 
            this.WarehouseRepositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.WarehouseRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WarehouseRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("warehouse_id", "id", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Descripción", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("location", 72, "Ubicación")});
            this.WarehouseRepositoryItemLookUpEdit.DataSource = this.xpWarehouseCollection;
            this.WarehouseRepositoryItemLookUpEdit.DisplayMember = "name";
            this.WarehouseRepositoryItemLookUpEdit.Name = "WarehouseRepositoryItemLookUpEdit";
            this.WarehouseRepositoryItemLookUpEdit.NullText = "";
            this.WarehouseRepositoryItemLookUpEdit.NullValuePrompt = "Seleccione";
            this.WarehouseRepositoryItemLookUpEdit.ValueMember = "This";
            this.WarehouseRepositoryItemLookUpEdit.EditValueChanged += new System.EventHandler(this.WarehouseRepositoryItemLookUpEdit_EditValueChanged);
            // 
            // xpWarehouseCollection
            // 
            this.xpWarehouseCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpWarehouseCollection.DisplayableProperties = "This;warehouse_id;name;description;location";
            this.xpWarehouseCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
            this.xpWarehouseCollection.Session = this.unitOfWork;
            // 
            // colshelf
            // 
            this.colshelf.Caption = "Estante";
            this.colshelf.FieldName = "shelf";
            this.colshelf.Name = "colshelf";
            this.colshelf.Visible = true;
            this.colshelf.VisibleIndex = 1;
            // 
            // colrow
            // 
            this.colrow.Caption = "Fila";
            this.colrow.FieldName = "row";
            this.colrow.Name = "colrow";
            this.colrow.Visible = true;
            this.colrow.VisibleIndex = 2;
            // 
            // colposition
            // 
            this.colposition.Caption = "Posición";
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 3;
            // 
            // colreorderQuantity
            // 
            this.colreorderQuantity.Caption = "Cantidad mínima";
            this.colreorderQuantity.FieldName = "reorderQuantity";
            this.colreorderQuantity.Name = "colreorderQuantity";
            this.colreorderQuantity.Visible = true;
            this.colreorderQuantity.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "product_id!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // dateEditDiscontinued
            // 
            this.dateEditDiscontinued.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "discontinued_date", true));
            this.dateEditDiscontinued.EditValue = new System.DateTime(2014, 5, 14, 12, 32, 24, 371);
            this.dateEditDiscontinued.Location = new System.Drawing.Point(601, 107);
            this.dateEditDiscontinued.Margin = new System.Windows.Forms.Padding(4);
            this.dateEditDiscontinued.Name = "dateEditDiscontinued";
            this.dateEditDiscontinued.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDiscontinued.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDiscontinued.Size = new System.Drawing.Size(232, 20);
            this.dateEditDiscontinued.StyleController = this.layoutControl1;
            this.dateEditDiscontinued.TabIndex = 13;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "discontinued", true));
            this.chkDiscontinued.Location = new System.Drawing.Point(492, 84);
            this.chkDiscontinued.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Properties.Caption = "Descontinuado:";
            this.chkDiscontinued.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkDiscontinued.Size = new System.Drawing.Size(118, 19);
            this.chkDiscontinued.StyleController = this.layoutControl1;
            this.chkDiscontinued.TabIndex = 12;
            this.chkDiscontinued.CheckedChanged += new System.EventHandler(this.chkDiscontinued_CheckedChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "weight", true));
            this.textEdit1.Location = new System.Drawing.Point(121, 200);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.Mask.EditMask = "n2";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Size = new System.Drawing.Size(98, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 7;
            // 
            // lookUpEditStatus
            // 
            this.lookUpEditStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "Status_idStatus!", true));
            this.lookUpEditStatus.Location = new System.Drawing.Point(601, 60);
            this.lookUpEditStatus.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditStatus.Name = "lookUpEditStatus";
            this.lookUpEditStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idStatus", "id Status", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("status", "status", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditStatus.Properties.DataSource = this.xpStatusCollection;
            this.lookUpEditStatus.Properties.DisplayMember = "status";
            this.lookUpEditStatus.Properties.NullText = "";
            this.lookUpEditStatus.Properties.NullValuePrompt = "Seleccione";
            this.lookUpEditStatus.Properties.ValueMember = "This";
            this.lookUpEditStatus.Size = new System.Drawing.Size(232, 20);
            this.lookUpEditStatus.StyleController = this.layoutControl1;
            this.lookUpEditStatus.TabIndex = 11;
            // 
            // xpStatusCollection
            // 
            this.xpStatusCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpStatusCollection.DisplayableProperties = "This;idStatus;status";
            this.xpStatusCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Status);
            this.xpStatusCollection.Session = this.unitOfWork;
            // 
            // txtTMant
            // 
            this.txtTMant.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "tmante", true));
            this.txtTMant.Location = new System.Drawing.Point(601, 36);
            this.txtTMant.Margin = new System.Windows.Forms.Padding(4);
            this.txtTMant.Name = "txtTMant";
            this.txtTMant.Size = new System.Drawing.Size(232, 20);
            this.txtTMant.StyleController = this.layoutControl1;
            this.txtTMant.TabIndex = 10;
            // 
            // txtFEnergia
            // 
            this.txtFEnergia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "fenergia", true));
            this.txtFEnergia.Location = new System.Drawing.Point(601, 12);
            this.txtFEnergia.Margin = new System.Windows.Forms.Padding(4);
            this.txtFEnergia.Name = "txtFEnergia";
            this.txtFEnergia.Size = new System.Drawing.Size(232, 20);
            this.txtFEnergia.StyleController = this.layoutControl1;
            this.txtFEnergia.TabIndex = 9;
            // 
            // memoDescription
            // 
            this.memoDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "description", true));
            this.memoDescription.Location = new System.Drawing.Point(121, 108);
            this.memoDescription.Margin = new System.Windows.Forms.Padding(4);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Size = new System.Drawing.Size(310, 16);
            this.memoDescription.StyleController = this.layoutControl1;
            this.memoDescription.TabIndex = 3;
            // 
            // txtProductCode
            // 
            this.txtProductCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "productcode", true));
            this.txtProductCode.Location = new System.Drawing.Point(121, 12);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(158, 20);
            this.txtProductCode.StyleController = this.layoutControl1;
            this.txtProductCode.TabIndex = 19;
            // 
            // pictImage
            // 
            this.pictImage.Location = new System.Drawing.Point(837, 28);
            this.pictImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictImage.Name = "pictImage";
            this.pictImage.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pictImage.Size = new System.Drawing.Size(166, 192);
            this.pictImage.StyleController = this.layoutControl1;
            this.pictImage.TabIndex = 14;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "serie", true));
            this.txtSerialNumber.Location = new System.Drawing.Point(121, 84);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(310, 20);
            this.txtSerialNumber.StyleController = this.layoutControl1;
            this.txtSerialNumber.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(121, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Este valor no es válido";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // txtBarCode
            // 
            this.txtBarCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "barcode_digits", true));
            this.txtBarCode.Location = new System.Drawing.Point(121, 60);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(310, 20);
            this.txtBarCode.StyleController = this.layoutControl1;
            this.txtBarCode.TabIndex = 1;
            // 
            // lookupCategory
            // 
            this.lookupCategory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "category_id!", true));
            this.lookupCategory.Location = new System.Drawing.Point(121, 128);
            this.lookupCategory.Margin = new System.Windows.Forms.Padding(4);
            this.lookupCategory.Name = "lookupCategory";
            this.lookupCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("category_id", "category_id", 89, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupCategory.Properties.DataSource = this.xpCategoryCollection;
            this.lookupCategory.Properties.DisplayMember = "name";
            this.lookupCategory.Properties.NullText = "";
            this.lookupCategory.Properties.NullValuePrompt = "Seleccione";
            this.lookupCategory.Properties.PopupSizeable = false;
            this.lookupCategory.Properties.ShowHeader = false;
            this.lookupCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupCategory.Properties.ValueMember = "This";
            this.lookupCategory.Size = new System.Drawing.Size(310, 20);
            this.lookupCategory.StyleController = this.layoutControl1;
            this.lookupCategory.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.lookupCategory, conditionValidationRule2);
            // 
            // xpCategoryCollection
            // 
            this.xpCategoryCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCategoryCollection.DisplayableProperties = "This;category_id;code;name";
            this.xpCategoryCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Category);
            this.xpCategoryCollection.Session = this.unitOfWork;
            // 
            // lookupBrand
            // 
            this.lookupBrand.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "brand_id!", true));
            this.lookupBrand.Location = new System.Drawing.Point(121, 152);
            this.lookupBrand.Margin = new System.Windows.Forms.Padding(4);
            this.lookupBrand.Name = "lookupBrand";
            this.lookupBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Brand_id", "Brand_id", 73, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Marca", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupBrand.Properties.DataSource = this.xpBrandCollection;
            this.lookupBrand.Properties.DisplayMember = "name";
            this.lookupBrand.Properties.NullText = "";
            this.lookupBrand.Properties.NullValuePrompt = "Seleccione";
            this.lookupBrand.Properties.PopupSizeable = false;
            this.lookupBrand.Properties.ShowHeader = false;
            this.lookupBrand.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupBrand.Properties.ValueMember = "This";
            this.lookupBrand.Size = new System.Drawing.Size(310, 20);
            this.lookupBrand.StyleController = this.layoutControl1;
            this.lookupBrand.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider.SetValidationRule(this.lookupBrand, conditionValidationRule3);
            // 
            // xpBrandCollection
            // 
            this.xpBrandCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpBrandCollection.DisplayableProperties = "This;Brand_id;name";
            this.xpBrandCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Brand);
            this.xpBrandCollection.Session = this.unitOfWork;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "model", true));
            this.txtModel.Location = new System.Drawing.Point(121, 176);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(310, 20);
            this.txtModel.StyleController = this.layoutControl1;
            this.txtModel.TabIndex = 6;
            // 
            // lookupUOM
            // 
            this.lookupUOM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "uom_id!", true));
            this.lookupUOM.EditValue = "Seleccione";
            this.lookupUOM.Location = new System.Drawing.Point(332, 200);
            this.lookupUOM.Margin = new System.Windows.Forms.Padding(4);
            this.lookupUOM.Name = "lookupUOM";
            this.lookupUOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupUOM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("uom_id", "uom_id", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("abbreviation", "abrev.", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookupUOM.Properties.DataSource = this.xpUOMCollection;
            this.lookupUOM.Properties.DisplayMember = "abbreviation";
            this.lookupUOM.Properties.NullValuePrompt = "Seleccione";
            this.lookupUOM.Properties.PopupSizeable = false;
            this.lookupUOM.Properties.ShowHeader = false;
            this.lookupUOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupUOM.Properties.ValueMember = "This";
            this.lookupUOM.Size = new System.Drawing.Size(99, 20);
            this.lookupUOM.StyleController = this.layoutControl1;
            this.lookupUOM.TabIndex = 8;
            // 
            // xpUOMCollection
            // 
            this.xpUOMCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpUOMCollection.DisplayableProperties = "This;uom_id;abbreviation;description";
            this.xpUOMCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Unitofmeasure);
            this.xpUOMCollection.Session = this.unitOfWork;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem16,
            this.layoutControlItem10,
            this.layoutControlItem18,
            this.emptySpaceItem5,
            this.layoutControlItem11,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem17,
            this.layoutControlItem8,
            this.DiscontinuedDateLCI,
            this.emptySpaceItem4,
            this.emptySpaceItem1,
            this.layoutControlItem20});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1015, 387);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtProductCode;
            this.layoutControlItem1.CustomizationFormText = "ID Producto:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(271, 24);
            this.layoutControlItem1.Text = "Código:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.CustomizationFormText = "Nombre del producto:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem2.Text = "Nombre del producto:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtBarCode;
            this.layoutControlItem3.CustomizationFormText = "Código de barra:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem3.Text = "Código de barra:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSerialNumber;
            this.layoutControlItem4.CustomizationFormText = "Número de serie:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem4.Text = "Número de serie:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtFEnergia;
            this.layoutControlItem9.CustomizationFormText = "F/Energía:";
            this.layoutControlItem9.Location = new System.Drawing.Point(480, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem9.Text = "F/Energía:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.memoDescription;
            this.layoutControlItem12.CustomizationFormText = "Descripción";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(423, 20);
            this.layoutControlItem12.Text = "Descripción";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.lookUpEditStatus;
            this.layoutControlItem16.CustomizationFormText = "Estado:";
            this.layoutControlItem16.Location = new System.Drawing.Point(480, 48);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem16.Text = "Estado:";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.pictImage;
            this.layoutControlItem10.CustomizationFormText = "Imagen";
            this.layoutControlItem10.Location = new System.Drawing.Point(825, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(170, 212);
            this.layoutControlItem10.Text = "Imagen";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.chkDiscontinued;
            this.layoutControlItem18.CustomizationFormText = "layoutControlItem18";
            this.layoutControlItem18.Location = new System.Drawing.Point(480, 72);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(122, 23);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem18.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(271, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(152, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtTMant;
            this.layoutControlItem11.CustomizationFormText = "T/Mant.:";
            this.layoutControlItem11.Location = new System.Drawing.Point(480, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem11.Text = "T/Mant.:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(106, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(423, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(57, 212);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookupCategory;
            this.layoutControlItem5.CustomizationFormText = "Categoría:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem5.Text = "Categoría:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lookupBrand;
            this.layoutControlItem6.CustomizationFormText = "Marca:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem6.Text = "Marca:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtModel;
            this.layoutControlItem7.CustomizationFormText = "Modelo:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem7.Text = "Modelo:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.textEdit1;
            this.layoutControlItem17.CustomizationFormText = "Peso:";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(211, 24);
            this.layoutControlItem17.Text = "Peso:";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lookupUOM;
            this.layoutControlItem8.CustomizationFormText = "Unidad de medida:";
            this.layoutControlItem8.Location = new System.Drawing.Point(211, 188);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(212, 24);
            this.layoutControlItem8.Text = "Unidad de medida:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(106, 13);
            // 
            // DiscontinuedDateLCI
            // 
            this.DiscontinuedDateLCI.Control = this.dateEditDiscontinued;
            this.DiscontinuedDateLCI.CustomizationFormText = "Fecha descontinuado:";
            this.DiscontinuedDateLCI.Location = new System.Drawing.Point(480, 95);
            this.DiscontinuedDateLCI.Name = "DiscontinuedDateLCI";
            this.DiscontinuedDateLCI.Size = new System.Drawing.Size(345, 24);
            this.DiscontinuedDateLCI.Text = "Fecha descontinuado:";
            this.DiscontinuedDateLCI.TextSize = new System.Drawing.Size(106, 13);
            this.DiscontinuedDateLCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(480, 119);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(345, 93);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(602, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(223, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.gridStored;
            this.layoutControlItem20.CustomizationFormText = "Almacenado en";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(995, 155);
            this.layoutControlItem20.Text = "Almacenado en";
            this.layoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem20.TextSize = new System.Drawing.Size(106, 13);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 561);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MaximizeBox = false;
            this.Name = "ItemForm";
            this.Text = "TEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpWarehouseCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDiscontinued.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDiscontinued.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiscontinued.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpStatusCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFEnergia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBrandCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupUOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUOMCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscontinuedDateLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStored;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStored;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.PictureEdit pictImage;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LookUpEdit lookupBrand;
        private DevExpress.XtraEditors.LookUpEdit lookupCategory;
        private DevExpress.XtraEditors.LookUpEdit lookupUOM;
        private DevExpress.XtraEditors.TextEdit txtSerialNumber;
        private DevExpress.XtraEditors.TextEdit txtBarCode;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.TextEdit txtTMant;
        private DevExpress.XtraEditors.TextEdit txtFEnergia;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.CheckEdit chkDiscontinued;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraEditors.DateEdit dateEditDiscontinued;
        private DevExpress.XtraLayout.LayoutControlItem DiscontinuedDateLCI;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.Xpo.XPCollection xpCategoryCollection;
        private DevExpress.Xpo.XPCollection xpBrandCollection;
        private DevExpress.Xpo.XPCollection xpUOMCollection;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colstored_id;
        private DevExpress.XtraGrid.Columns.GridColumn colwarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colshelf;
        private DevExpress.XtraGrid.Columns.GridColumn colrow;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colreorderQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.Xpo.XPCollection xpWarehouseCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit WarehouseRepositoryItemLookUpEdit;
        private DevExpress.Xpo.XPCollection xpStatusCollection;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}