namespace Inventory.Forms
{
    partial class CompanyInfo
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.PhoneGridControl = new DevExpress.XtraGrid.GridControl();
            this.PhoneBindingSource = new System.Windows.Forms.BindingSource();
            this.xpPhoneCollection = new DevExpress.Xpo.XPCollection();
            this.uow = new DevExpress.Xpo.UnitOfWork();
            this.PhoneGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colphoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumberRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.phoneCarrier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneCarrierRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpPhoneCarrierCollection = new DevExpress.Xpo.XPCollection();
            this.colisCellular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtWebsite = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtCountry = new DevExpress.XtraEditors.TextEdit();
            this.txtDepartment = new DevExpress.XtraEditors.TextEdit();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditLogo = new DevExpress.XtraEditors.PictureEdit();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneCarrierRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCarrierCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.PhoneGridControl);
            this.layoutControl.Controls.Add(this.txtWebsite);
            this.layoutControl.Controls.Add(this.BtnCancel);
            this.layoutControl.Controls.Add(this.BtnSave);
            this.layoutControl.Controls.Add(this.memoEditAddress);
            this.layoutControl.Controls.Add(this.txtCountry);
            this.layoutControl.Controls.Add(this.txtDepartment);
            this.layoutControl.Controls.Add(this.txtCity);
            this.layoutControl.Controls.Add(this.pictureEditLogo);
            this.layoutControl.Controls.Add(this.txtCompanyName);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(850, 483, 435, 350);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(917, 517);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // PhoneGridControl
            // 
            this.PhoneGridControl.DataSource = this.PhoneBindingSource;
            this.PhoneGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneGridControl.Location = new System.Drawing.Point(132, 302);
            this.PhoneGridControl.MainView = this.PhoneGridView;
            this.PhoneGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneGridControl.Name = "PhoneGridControl";
            this.PhoneGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.PhoneCarrierRepositoryItemLookUpEdit,
            this.PhoneNumberRepositoryItemTextEdit});
            this.PhoneGridControl.Size = new System.Drawing.Size(768, 124);
            this.PhoneGridControl.TabIndex = 14;
            this.PhoneGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PhoneGridView});
            // 
            // PhoneBindingSource
            // 
            this.PhoneBindingSource.DataSource = this.xpPhoneCollection;
            // 
            // xpPhoneCollection
            // 
            this.xpPhoneCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
            this.xpPhoneCollection.DisplayableProperties = "This;idCompany_PhoneNumbers;company_id!;company_id;phonecarrier!;phonecarrier;pho" +
    "neNumber;isCellular;active";
            this.xpPhoneCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Company_phonenumbers);
            this.xpPhoneCollection.Session = this.uow;
            // 
            // uow
            // 
            this.uow.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.uow.TrackPropertiesModifications = false;
            // 
            // PhoneGridView
            // 
            this.PhoneGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colphoneNumber,
            this.phoneCarrier,
            this.colisCellular});
            this.PhoneGridView.GridControl = this.PhoneGridControl;
            this.PhoneGridView.Name = "PhoneGridView";
            this.PhoneGridView.OptionsDetail.EnableMasterViewMode = false;
            this.PhoneGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.PhoneGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.PhoneGridView.OptionsView.ShowGroupPanel = false;
            this.PhoneGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.PhoneGridView_InitNewRow);
            this.PhoneGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.PhoneGridView_ValidateRow);
            // 
            // colphoneNumber
            // 
            this.colphoneNumber.Caption = "No. de teléfono";
            this.colphoneNumber.ColumnEdit = this.PhoneNumberRepositoryItemTextEdit;
            this.colphoneNumber.FieldName = "phoneNumber";
            this.colphoneNumber.Name = "colphoneNumber";
            this.colphoneNumber.Visible = true;
            this.colphoneNumber.VisibleIndex = 0;
            // 
            // PhoneNumberRepositoryItemTextEdit
            // 
            this.PhoneNumberRepositoryItemTextEdit.AutoHeight = false;
            this.PhoneNumberRepositoryItemTextEdit.Mask.EditMask = "(\\(\\d\\d\\d\\))?\\d{1,3}-\\d\\d-\\d\\d\\d";
            this.PhoneNumberRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.PhoneNumberRepositoryItemTextEdit.Mask.UseMaskAsDisplayFormat = true;
            this.PhoneNumberRepositoryItemTextEdit.Name = "PhoneNumberRepositoryItemTextEdit";
            // 
            // phoneCarrier
            // 
            this.phoneCarrier.Caption = "Compañía";
            this.phoneCarrier.ColumnEdit = this.PhoneCarrierRepositoryItemLookUpEdit;
            this.phoneCarrier.FieldName = "phonecarrier!";
            this.phoneCarrier.Name = "phoneCarrier";
            this.phoneCarrier.Visible = true;
            this.phoneCarrier.VisibleIndex = 1;
            // 
            // PhoneCarrierRepositoryItemLookUpEdit
            // 
            this.PhoneCarrierRepositoryItemLookUpEdit.AutoHeight = false;
            this.PhoneCarrierRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PhoneCarrierRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 33, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("company", "company", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.PhoneCarrierRepositoryItemLookUpEdit.DataSource = this.xpPhoneCarrierCollection;
            this.PhoneCarrierRepositoryItemLookUpEdit.DisplayMember = "company";
            this.PhoneCarrierRepositoryItemLookUpEdit.Name = "PhoneCarrierRepositoryItemLookUpEdit";
            this.PhoneCarrierRepositoryItemLookUpEdit.NullText = "";
            this.PhoneCarrierRepositoryItemLookUpEdit.NullValuePrompt = "Seleccione";
            this.PhoneCarrierRepositoryItemLookUpEdit.ShowHeader = false;
            this.PhoneCarrierRepositoryItemLookUpEdit.ValueMember = "This";
            // 
            // xpPhoneCarrierCollection
            // 
            this.xpPhoneCarrierCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpPhoneCarrierCollection.DisplayableProperties = "This;id;company";
            this.xpPhoneCarrierCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Phonecarrier);
            this.xpPhoneCarrierCollection.Session = this.uow;
            // 
            // colisCellular
            // 
            this.colisCellular.Caption = "¿Es celular?";
            this.colisCellular.FieldName = "isCellular";
            this.colisCellular.Name = "colisCellular";
            this.colisCellular.Visible = true;
            this.colisCellular.VisibleIndex = 2;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(246, 260);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(654, 20);
            this.txtWebsite.StyleController = this.layoutControl;
            this.txtWebsite.TabIndex = 13;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(606, 585);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(137, 39);
            this.BtnCancel.StyleController = this.layoutControl;
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(481, 585);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 39);
            this.BtnSave.StyleController = this.layoutControl;
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Aceptar";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // memoEditAddress
            // 
            this.memoEditAddress.Location = new System.Drawing.Point(132, 66);
            this.memoEditAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEditAddress.Name = "memoEditAddress";
            this.memoEditAddress.Size = new System.Drawing.Size(768, 112);
            this.memoEditAddress.StyleController = this.layoutControl;
            this.memoEditAddress.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(246, 234);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(429, 20);
            this.txtCountry.StyleController = this.layoutControl;
            this.txtCountry.TabIndex = 9;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(246, 208);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(429, 20);
            this.txtDepartment.StyleController = this.layoutControl;
            this.txtDepartment.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(246, 182);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(429, 20);
            this.txtCity.StyleController = this.layoutControl;
            this.txtCity.TabIndex = 7;
            // 
            // pictureEditLogo
            // 
            this.pictureEditLogo.Location = new System.Drawing.Point(-112, 28);
            this.pictureEditLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEditLogo.Name = "pictureEditLogo";
            this.pictureEditLogo.Size = new System.Drawing.Size(230, 270);
            this.pictureEditLogo.StyleController = this.layoutControl;
            this.pictureEditLogo.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(246, 12);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyName.Size = new System.Drawing.Size(654, 28);
            this.txtCompanyName.StyleController = this.layoutControl;
            this.txtCompanyName.TabIndex = 4;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.CustomizationFormText = "layoutControlGroup";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.layoutControlItem9,
            this.emptySpaceItem1,
            this.emptySpaceItem6,
            this.layoutControlItem10,
            this.emptySpaceItem5,
            this.emptySpaceItem7,
            this.emptySpaceItem3});
            this.layoutControlGroup.Location = new System.Drawing.Point(-124, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(1070, 636);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCompanyName;
            this.layoutControlItem1.CustomizationFormText = "Nombre de la empresa";
            this.layoutControlItem1.Location = new System.Drawing.Point(244, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(772, 38);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(772, 38);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(806, 38);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Nombre de la empresa:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.memoEditAddress;
            this.layoutControlItem3.CustomizationFormText = "Dirección";
            this.layoutControlItem3.Location = new System.Drawing.Point(244, 38);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(772, 132);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(772, 132);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(806, 132);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Dirección:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureEditLogo;
            this.layoutControlItem2.CustomizationFormText = "Logo";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(234, 290);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(234, 290);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(234, 290);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Logo";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtDepartment;
            this.layoutControlItem5.CustomizationFormText = "Departamento";
            this.layoutControlItem5.Location = new System.Drawing.Point(244, 196);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(547, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Departamento:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCity;
            this.layoutControlItem4.CustomizationFormText = "Ciudad";
            this.layoutControlItem4.Location = new System.Drawing.Point(244, 170);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(547, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Ciudad:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtCountry;
            this.layoutControlItem6.CustomizationFormText = "País";
            this.layoutControlItem6.Location = new System.Drawing.Point(244, 222);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(547, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(547, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "País:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnSave;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(593, 573);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(125, 43);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(125, 43);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(125, 43);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.BtnCancel;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(718, 573);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(141, 43);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(141, 43);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(141, 43);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 573);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(593, 43);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(593, 43);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(593, 43);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(234, 0);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(10, 563);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 563);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 573);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtWebsite;
            this.layoutControlItem9.CustomizationFormText = "Sitio web:";
            this.layoutControlItem9.Location = new System.Drawing.Point(244, 248);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(772, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(772, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(806, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "Sitio web:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(859, 573);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(191, 27);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(191, 27);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(191, 43);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(791, 170);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(259, 78);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.PhoneGridControl;
            this.layoutControlItem10.CustomizationFormText = "Teléfonos";
            this.layoutControlItem10.Location = new System.Drawing.Point(244, 274);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(772, 144);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(772, 144);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(806, 144);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "Teléfonos";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(111, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 290);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(234, 273);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(234, 273);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(234, 283);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(244, 418);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(772, 145);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(772, 145);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(806, 145);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(244, 563);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(806, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyInfo";
            this.Text = "Información de la empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneCarrierRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPhoneCarrierCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit txtCountry;
        private DevExpress.XtraEditors.TextEdit txtDepartment;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.PictureEdit pictureEditLogo;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.MemoEdit memoEditAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.TextEdit txtWebsite;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraGrid.GridControl PhoneGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PhoneGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.Xpo.UnitOfWork uow;
        private DevExpress.Xpo.XPCollection xpPhoneCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colphoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn phoneCarrier;
        private DevExpress.XtraGrid.Columns.GridColumn colisCellular;
        private DevExpress.Xpo.XPCollection xpPhoneCarrierCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PhoneCarrierRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource PhoneBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit PhoneNumberRepositoryItemTextEdit;

    }
}