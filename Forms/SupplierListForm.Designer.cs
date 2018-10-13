namespace Inventory.Forms
{
    partial class SupplierListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierListForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridViewAddresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colline1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeparment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSuppliers = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhoneNum = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisCellular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewSuppliers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsupplier_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsuppliername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontactname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfaxnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.PhoneCarrierRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpPhoneCarrierCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.NewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhoneNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneCarrierRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCarrierCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.xpMainCollection.DisplayableProperties = "This;supplier_id;suppliername;contactname;faxnumber;email;website;notes;active;Ad" +
    "dressesCollection;Suppliers_phonenumber";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Suppliers);
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
            this.ribbon.Size = new System.Drawing.Size(1098, 155);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // gridViewAddresses
            // 
            this.gridViewAddresses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colline1,
            this.colcity,
            this.coldeparment,
            this.colcountry});
            this.gridViewAddresses.GridControl = this.gridSuppliers;
            this.gridViewAddresses.Name = "gridViewAddresses";
            this.gridViewAddresses.OptionsView.ShowGroupPanel = false;
            this.gridViewAddresses.OptionsView.ShowViewCaption = true;
            this.gridViewAddresses.ViewCaption = "Direcciones";
            // 
            // colline1
            // 
            this.colline1.Caption = "Dirección";
            this.colline1.FieldName = "line1";
            this.colline1.Name = "colline1";
            this.colline1.Visible = true;
            this.colline1.VisibleIndex = 0;
            // 
            // colcity
            // 
            this.colcity.Caption = "Ciudad";
            this.colcity.FieldName = "city";
            this.colcity.Name = "colcity";
            this.colcity.Visible = true;
            this.colcity.VisibleIndex = 1;
            // 
            // coldeparment
            // 
            this.coldeparment.Caption = "Deparmento";
            this.coldeparment.FieldName = "deparment";
            this.coldeparment.Name = "coldeparment";
            this.coldeparment.Visible = true;
            this.coldeparment.VisibleIndex = 2;
            // 
            // colcountry
            // 
            this.colcountry.Caption = "País";
            this.colcountry.FieldName = "country";
            this.colcountry.Name = "colcountry";
            this.colcountry.Visible = true;
            this.colcountry.VisibleIndex = 3;
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.DataSource = this.MainBindingSource;
            this.gridSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewAddresses;
            gridLevelNode1.RelationName = "AddressesCollection";
            gridLevelNode2.LevelTemplate = this.gridViewPhoneNum;
            gridLevelNode2.RelationName = "Suppliers_phonenumber";
            this.gridSuppliers.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridSuppliers.Location = new System.Drawing.Point(0, 155);
            this.gridSuppliers.MainView = this.gridViewSuppliers;
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.PhoneCarrierRepositoryItemLookUpEdit});
            this.gridSuppliers.ShowOnlyPredefinedDetails = true;
            this.gridSuppliers.Size = new System.Drawing.Size(1098, 463);
            this.gridSuppliers.TabIndex = 0;
            this.gridSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhoneNum,
            this.gridViewSuppliers,
            this.gridViewAddresses});
            // 
            // gridViewPhoneNum
            // 
            this.gridViewPhoneNum.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colphoneNumber,
            this.colisCellular,
            this.colactive1});
            this.gridViewPhoneNum.GridControl = this.gridSuppliers;
            this.gridViewPhoneNum.Name = "gridViewPhoneNum";
            this.gridViewPhoneNum.OptionsView.ShowGroupPanel = false;
            this.gridViewPhoneNum.OptionsView.ShowViewCaption = true;
            this.gridViewPhoneNum.ViewCaption = "Teléfonos";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Compañía";
            this.gridColumn3.FieldName = "phonecarrier.company";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // colphoneNumber
            // 
            this.colphoneNumber.Caption = "No. de teléfono";
            this.colphoneNumber.FieldName = "phoneNumber";
            this.colphoneNumber.Name = "colphoneNumber";
            this.colphoneNumber.Visible = true;
            this.colphoneNumber.VisibleIndex = 1;
            // 
            // colisCellular
            // 
            this.colisCellular.Caption = "¿Es celular?";
            this.colisCellular.FieldName = "isCellular";
            this.colisCellular.Name = "colisCellular";
            this.colisCellular.Visible = true;
            this.colisCellular.VisibleIndex = 2;
            // 
            // colactive1
            // 
            this.colactive1.Caption = "Activo";
            this.colactive1.FieldName = "active";
            this.colactive1.Name = "colactive1";
            this.colactive1.Visible = true;
            this.colactive1.VisibleIndex = 3;
            // 
            // gridViewSuppliers
            // 
            this.gridViewSuppliers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsupplier_id,
            this.colsuppliername,
            this.colcontactname,
            this.colfaxnumber,
            this.colemail,
            this.colwebsite,
            this.colnotes,
            this.colactive});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[active] == False";
            this.gridViewSuppliers.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridViewSuppliers.GridControl = this.gridSuppliers;
            this.gridViewSuppliers.Name = "gridViewSuppliers";
            this.gridViewSuppliers.OptionsFind.AlwaysVisible = true;
            this.gridViewSuppliers.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewSuppliers.OptionsView.ShowGroupPanel = false;
            // 
            // colsupplier_id
            // 
            this.colsupplier_id.FieldName = "supplier_id";
            this.colsupplier_id.Name = "colsupplier_id";
            // 
            // colsuppliername
            // 
            this.colsuppliername.Caption = "Proveedor";
            this.colsuppliername.FieldName = "suppliername";
            this.colsuppliername.Name = "colsuppliername";
            this.colsuppliername.Visible = true;
            this.colsuppliername.VisibleIndex = 0;
            // 
            // colcontactname
            // 
            this.colcontactname.Caption = "Persona de contacto";
            this.colcontactname.FieldName = "contactname";
            this.colcontactname.Name = "colcontactname";
            this.colcontactname.Visible = true;
            this.colcontactname.VisibleIndex = 1;
            // 
            // colfaxnumber
            // 
            this.colfaxnumber.Caption = "Número de teléfono";
            this.colfaxnumber.FieldName = "faxnumber";
            this.colfaxnumber.Name = "colfaxnumber";
            this.colfaxnumber.Visible = true;
            this.colfaxnumber.VisibleIndex = 2;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 3;
            // 
            // colwebsite
            // 
            this.colwebsite.Caption = "Sitio web";
            this.colwebsite.FieldName = "website";
            this.colwebsite.Name = "colwebsite";
            this.colwebsite.Visible = true;
            this.colwebsite.VisibleIndex = 4;
            // 
            // colnotes
            // 
            this.colnotes.FieldName = "notes";
            this.colnotes.Name = "colnotes";
            // 
            // colactive
            // 
            this.colactive.Caption = "Activo";
            this.colactive.FieldName = "active";
            this.colactive.Name = "colactive";
            this.colactive.Visible = true;
            this.colactive.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // PhoneCarrierRepositoryItemLookUpEdit
            // 
            this.PhoneCarrierRepositoryItemLookUpEdit.AutoHeight = false;
            this.PhoneCarrierRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PhoneCarrierRepositoryItemLookUpEdit.DataSource = this.xpPhoneCarrierCollection;
            this.PhoneCarrierRepositoryItemLookUpEdit.DisplayMember = "company";
            this.PhoneCarrierRepositoryItemLookUpEdit.Name = "PhoneCarrierRepositoryItemLookUpEdit";
            // 
            // xpPhoneCarrierCollection
            // 
            this.xpPhoneCarrierCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpPhoneCarrierCollection.DisplayableProperties = "This;id;company";
            this.xpPhoneCarrierCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Phonecarrier);
            this.xpPhoneCarrierCollection.Session = this.unitOfWork;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.Text = "Tools";
            // 
            // NewBarButtonItem
            // 
            this.NewBarButtonItem.Caption = "Nuevo";
            this.NewBarButtonItem.Id = 5;
            this.NewBarButtonItem.Name = "NewBarButtonItem";
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 649);
            this.Controls.Add(this.gridSuppliers);
            this.Name = "SupplierListForm";
            this.Text = "Lista de proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.gridSuppliers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhoneNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneCarrierRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCarrierCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSuppliers;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplier_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsuppliername;
        private DevExpress.XtraGrid.Columns.GridColumn colcontactname;
        private DevExpress.XtraGrid.Columns.GridColumn colfaxnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colwebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colnotes;
        private DevExpress.XtraGrid.Columns.GridColumn colactive;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAddresses;
        private DevExpress.XtraGrid.Columns.GridColumn colline1;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn coldeparment;
        private DevExpress.XtraGrid.Columns.GridColumn colcountry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhoneNum;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colphoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PhoneCarrierRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colisCellular;
        private DevExpress.XtraGrid.Columns.GridColumn colactive1;
        private DevExpress.Xpo.XPCollection xpPhoneCarrierCollection;
        //private DevExpress.XtraBars.BarButtonItem NewBarButtonItem;         
    }
}