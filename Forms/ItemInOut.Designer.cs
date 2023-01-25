namespace Inventory.Forms
{
    partial class frmItemInOut
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemInOut));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gridcoloperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolinput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lookupWarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpWarehouse2 = new DevExpress.XtraEditors.LookUpEdit();
            this.cBEInvoiceType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtInvoiceNumber = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditReason = new DevExpress.XtraEditors.LookUpEdit();
            this.xpCollectionReasons = new DevExpress.Xpo.XPCollection(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditSuppliers = new DevExpress.XtraEditors.LookUpEdit();
            this.xpCollectionSuppliers = new DevExpress.Xpo.XPCollection(this.components);
            this.gridInventoryTransaction = new DevExpress.XtraGrid.GridControl();
            this.gridViewInvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcolwarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcoldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcoldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolstorekeeper = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolinvoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolinvoicetype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcolreason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtStoreKeeper = new DevExpress.XtraEditors.TextEdit();
            this.spEditUnits = new DevExpress.XtraEditors.SpinEdit();
            this.dateInventory = new DevExpress.XtraEditors.DateEdit();
            this.btnAddInventory = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutUnitsReceived = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SupplierLayoutCtrlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemW2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutInvoice = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutInvoiceType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lookupWarehouse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWarehouse2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionReasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEditUnits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventory.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUnitsReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierLayoutCtrlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutInvoiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcoloperation
            // 
            this.gridcoloperation.Caption = "operation";
            this.gridcoloperation.FieldName = "transactionReason.operation";
            this.gridcoloperation.Name = "gridcoloperation";
            // 
            // gridcolinput
            // 
            this.gridcolinput.Caption = "Unidades";
            this.gridcolinput.FieldName = "units";
            this.gridcolinput.Name = "gridcolinput";
            this.gridcolinput.Visible = true;
            this.gridcolinput.VisibleIndex = 7;
            this.gridcolinput.Width = 102;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(520, 68);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(54, 13);
            this.labelControl19.TabIndex = 89;
            this.labelControl19.Text = "Descripción";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(959, 68);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(56, 13);
            this.labelControl17.TabIndex = 83;
            this.labelControl17.Text = "Retornadas";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(908, 68);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(33, 13);
            this.labelControl16.TabIndex = 79;
            this.labelControl16.Text = "Salidas";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(857, 68);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(43, 13);
            this.labelControl15.TabIndex = 77;
            this.labelControl15.Text = "Entradas";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(806, 68);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(53, 13);
            this.labelControl14.TabIndex = 76;
            this.labelControl14.Text = "Ordenadas";
            // 
            // lookupWarehouse
            // 
            this.lookupWarehouse.Location = new System.Drawing.Point(88, 102);
            this.lookupWarehouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookupWarehouse.Name = "lookupWarehouse";
            this.lookupWarehouse.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupWarehouse.Properties.NullText = "";
            this.lookupWarehouse.Properties.NullValuePrompt = "Seleccione";
            this.lookupWarehouse.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookupWarehouse.Properties.ShowHeader = false;
            this.lookupWarehouse.Size = new System.Drawing.Size(316, 20);
            this.lookupWarehouse.StyleController = this.layoutControl1;
            this.lookupWarehouse.TabIndex = 78;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.lookupWarehouse, conditionValidationRule3);
            this.lookupWarehouse.EditValueChanged += new System.EventHandler(this.lookupWarehouse_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpWarehouse2);
            this.layoutControl1.Controls.Add(this.cBEInvoiceType);
            this.layoutControl1.Controls.Add(this.txtInvoiceNumber);
            this.layoutControl1.Controls.Add(this.lookUpEditReason);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSaveProduct);
            this.layoutControl1.Controls.Add(this.txtProductName);
            this.layoutControl1.Controls.Add(this.lookUpEditSuppliers);
            this.layoutControl1.Controls.Add(this.gridInventoryTransaction);
            this.layoutControl1.Controls.Add(this.txtStoreKeeper);
            this.layoutControl1.Controls.Add(this.spEditUnits);
            this.layoutControl1.Controls.Add(this.lookupWarehouse);
            this.layoutControl1.Controls.Add(this.dateInventory);
            this.layoutControl1.Controls.Add(this.btnAddInventory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(258, 98, 250, 354);
            this.layoutControl1.Root = this.layoutControlGroup;
            this.layoutControl1.Size = new System.Drawing.Size(1018, 515);
            this.layoutControl1.TabIndex = 102;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpWarehouse2
            // 
            this.lookUpWarehouse2.Location = new System.Drawing.Point(418, 102);
            this.lookUpWarehouse2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpWarehouse2.Name = "lookUpWarehouse2";
            this.lookUpWarehouse2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpWarehouse2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpWarehouse2.Properties.DisplayMember = "name";
            this.lookUpWarehouse2.Properties.NullText = "";
            this.lookUpWarehouse2.Properties.NullValuePrompt = "Seleccione";
            this.lookUpWarehouse2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpWarehouse2.Properties.ShowHeader = false;
            this.lookUpWarehouse2.Properties.ValueMember = "This";
            this.lookUpWarehouse2.Size = new System.Drawing.Size(366, 20);
            this.lookUpWarehouse2.StyleController = this.layoutControl1;
            this.lookUpWarehouse2.TabIndex = 105;
            // 
            // cBEInvoiceType
            // 
            this.cBEInvoiceType.Location = new System.Drawing.Point(699, 126);
            this.cBEInvoiceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBEInvoiceType.Name = "cBEInvoiceType";
            this.cBEInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBEInvoiceType.Properties.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.cBEInvoiceType.Size = new System.Drawing.Size(97, 20);
            this.cBEInvoiceType.StyleController = this.layoutControl1;
            this.cBEInvoiceType.TabIndex = 104;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(484, 126);
            this.txtInvoiceNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(135, 20);
            this.txtInvoiceNumber.StyleController = this.layoutControl1;
            this.txtInvoiceNumber.TabIndex = 103;
            // 
            // lookUpEditReason
            // 
            this.lookUpEditReason.Location = new System.Drawing.Point(88, 78);
            this.lookUpEditReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditReason.Name = "lookUpEditReason";
            this.lookUpEditReason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditReason.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("operation", "operation", 64, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditReason.Properties.DataSource = this.xpCollectionReasons;
            this.lookUpEditReason.Properties.DisplayMember = "name";
            this.lookUpEditReason.Properties.NullText = "";
            this.lookUpEditReason.Properties.NullValuePrompt = "Seleccione";
            this.lookUpEditReason.Properties.ShowHeader = false;
            this.lookUpEditReason.Properties.ValueMember = "This";
            this.lookUpEditReason.Size = new System.Drawing.Size(316, 20);
            this.lookUpEditReason.StyleController = this.layoutControl1;
            this.lookUpEditReason.TabIndex = 102;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.lookUpEditReason, conditionValidationRule1);
            this.lookUpEditReason.EditValueChanged += new System.EventHandler(this.lookUpEditReason_EditValueChanged);
            // 
            // xpCollectionReasons
            // 
            this.xpCollectionReasons.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCollectionReasons.DisplayableProperties = "This;id;name;operation";
            this.xpCollectionReasons.ObjectType = typeof(Inventory.ORMDataModelCode.Transactionreason);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(873, 465);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Image = global::Inventory.Properties.Resources.save_32x32;
            this.btnSaveProduct.Location = new System.Drawing.Point(762, 465);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(107, 38);
            this.btnSaveProduct.StyleController = this.layoutControl1;
            this.btnSaveProduct.TabIndex = 93;
            this.btnSaveProduct.Text = "Guardar";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.EditValue = "Texto de prueba";
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(12, 12);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductName.Properties.AutoHeight = false;
            this.txtProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtProductName.Size = new System.Drawing.Size(994, 36);
            this.txtProductName.StyleController = this.layoutControl1;
            this.txtProductName.TabIndex = 95;
            // 
            // lookUpEditSuppliers
            // 
            this.lookUpEditSuppliers.Location = new System.Drawing.Point(88, 126);
            this.lookUpEditSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpEditSuppliers.Name = "lookUpEditSuppliers";
            this.lookUpEditSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSuppliers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier_id", "supplier_id", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("suppliername", "suppliername", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("contactname", "contactname", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("faxnumber", "faxnumber", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditSuppliers.Properties.DataSource = this.xpCollectionSuppliers;
            this.lookUpEditSuppliers.Properties.DisplayMember = "suppliername";
            this.lookUpEditSuppliers.Properties.NullText = "";
            this.lookUpEditSuppliers.Properties.NullValuePrompt = "Seleccione";
            this.lookUpEditSuppliers.Properties.ShowFooter = false;
            this.lookUpEditSuppliers.Properties.ShowHeader = false;
            this.lookUpEditSuppliers.Properties.ValueMember = "This";
            this.lookUpEditSuppliers.Size = new System.Drawing.Size(316, 20);
            this.lookUpEditSuppliers.StyleController = this.layoutControl1;
            this.lookUpEditSuppliers.TabIndex = 100;
            // 
            // xpCollectionSuppliers
            // 
            this.xpCollectionSuppliers.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCollectionSuppliers.CriteriaString = "[active] = True";
            this.xpCollectionSuppliers.DisplayableProperties = "This;supplier_id;suppliername;contactname;faxnumber;email;active";
            this.xpCollectionSuppliers.ObjectType = typeof(Inventory.ORMDataModelCode.Suppliers);
            // 
            // gridInventoryTransaction
            // 
            this.gridInventoryTransaction.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridInventoryTransaction.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gridInventoryTransaction.Location = new System.Drawing.Point(12, 201);
            this.gridInventoryTransaction.MainView = this.gridViewInvTransaction;
            this.gridInventoryTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridInventoryTransaction.Name = "gridInventoryTransaction";
            this.gridInventoryTransaction.Size = new System.Drawing.Size(994, 260);
            this.gridInventoryTransaction.TabIndex = 74;
            this.gridInventoryTransaction.UseEmbeddedNavigator = true;
            this.gridInventoryTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvTransaction});
            // 
            // gridViewInvTransaction
            // 
            this.gridViewInvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridcolwarehouse,
            this.gridcoldate,
            this.gridcolsupplier,
            this.gridcoldescription,
            this.gridcolstorekeeper,
            this.gridcolinvoice,
            this.gridcolinvoicetype,
            this.gridcolreason,
            this.gridcoloperation,
            this.gridcolinput});
            gridFormatRule1.Column = this.gridcoloperation;
            gridFormatRule1.ColumnApplyTo = this.gridcolinput;
            gridFormatRule1.Name = "Format0";
            formatConditionIconSet1.CategoryName = "Directional";
            formatConditionIconSetIcon1.PredefinedName = "Triangles3_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Triangles3_3.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Triangles3_2.png";
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "Triangles3";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gridViewInvTransaction.FormatRules.Add(gridFormatRule1);
            this.gridViewInvTransaction.GridControl = this.gridInventoryTransaction;
            this.gridViewInvTransaction.GroupCount = 1;
            this.gridViewInvTransaction.Name = "gridViewInvTransaction";
            this.gridViewInvTransaction.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInvTransaction.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewInvTransaction.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewInvTransaction.OptionsBehavior.Editable = false;
            this.gridViewInvTransaction.OptionsCustomization.AllowGroup = false;
            this.gridViewInvTransaction.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewInvTransaction.OptionsFind.AllowFindPanel = false;
            this.gridViewInvTransaction.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewInvTransaction.OptionsView.ShowGroupPanel = false;
            this.gridViewInvTransaction.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridcolwarehouse, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridcoldate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridcolwarehouse
            // 
            this.gridcolwarehouse.Caption = "Almacen";
            this.gridcolwarehouse.FieldName = "warehouse_id.name";
            this.gridcolwarehouse.Name = "gridcolwarehouse";
            this.gridcolwarehouse.Visible = true;
            this.gridcolwarehouse.VisibleIndex = 0;
            // 
            // gridcoldate
            // 
            this.gridcoldate.Caption = "Fecha";
            this.gridcoldate.DisplayFormat.FormatString = "d";
            this.gridcoldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridcoldate.FieldName = "date";
            this.gridcoldate.Name = "gridcoldate";
            this.gridcoldate.Visible = true;
            this.gridcoldate.VisibleIndex = 0;
            this.gridcoldate.Width = 169;
            // 
            // gridcolsupplier
            // 
            this.gridcolsupplier.Caption = "Proveedor";
            this.gridcolsupplier.FieldName = "supplier_id.suppliername";
            this.gridcolsupplier.Name = "gridcolsupplier";
            this.gridcolsupplier.Visible = true;
            this.gridcolsupplier.VisibleIndex = 1;
            this.gridcolsupplier.Width = 237;
            // 
            // gridcoldescription
            // 
            this.gridcoldescription.Caption = "Descripción";
            this.gridcoldescription.FieldName = "description";
            this.gridcoldescription.Name = "gridcoldescription";
            this.gridcoldescription.Visible = true;
            this.gridcoldescription.VisibleIndex = 2;
            // 
            // gridcolstorekeeper
            // 
            this.gridcolstorekeeper.Caption = "Efectuado por";
            this.gridcolstorekeeper.FieldName = "storeKeeper";
            this.gridcolstorekeeper.Name = "gridcolstorekeeper";
            this.gridcolstorekeeper.Visible = true;
            this.gridcolstorekeeper.VisibleIndex = 3;
            this.gridcolstorekeeper.Width = 272;
            // 
            // gridcolinvoice
            // 
            this.gridcolinvoice.Caption = "Refencia";
            this.gridcolinvoice.FieldName = "referenceNumber";
            this.gridcolinvoice.Name = "gridcolinvoice";
            this.gridcolinvoice.Visible = true;
            this.gridcolinvoice.VisibleIndex = 4;
            this.gridcolinvoice.Width = 244;
            // 
            // gridcolinvoicetype
            // 
            this.gridcolinvoicetype.Caption = "De crédito";
            this.gridcolinvoicetype.FieldName = "creditInvoice";
            this.gridcolinvoicetype.Name = "gridcolinvoicetype";
            this.gridcolinvoicetype.Visible = true;
            this.gridcolinvoicetype.VisibleIndex = 5;
            this.gridcolinvoicetype.Width = 70;
            // 
            // gridcolreason
            // 
            this.gridcolreason.Caption = "Razón";
            this.gridcolreason.FieldName = "transactionReason.name";
            this.gridcolreason.Name = "gridcolreason";
            this.gridcolreason.Visible = true;
            this.gridcolreason.VisibleIndex = 6;
            this.gridcolreason.Width = 94;
            // 
            // txtStoreKeeper
            // 
            this.txtStoreKeeper.Location = new System.Drawing.Point(88, 150);
            this.txtStoreKeeper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStoreKeeper.Name = "txtStoreKeeper";
            this.txtStoreKeeper.Size = new System.Drawing.Size(316, 20);
            this.txtStoreKeeper.StyleController = this.layoutControl1;
            this.txtStoreKeeper.TabIndex = 101;
            // 
            // spEditUnits
            // 
            this.spEditUnits.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spEditUnits.Location = new System.Drawing.Point(88, 174);
            this.spEditUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spEditUnits.Name = "spEditUnits";
            this.spEditUnits.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spEditUnits.Properties.Appearance.Options.UseFont = true;
            this.spEditUnits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spEditUnits.Properties.EditFormat.FormatString = "n";
            this.spEditUnits.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spEditUnits.Properties.Mask.EditMask = "n";
            this.spEditUnits.Size = new System.Drawing.Size(168, 18);
            this.spEditUnits.StyleController = this.layoutControl1;
            this.spEditUnits.TabIndex = 97;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "Este no es un valor válido";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dxValidationProvider.SetValidationRule(this.spEditUnits, conditionValidationRule2);
            // 
            // dateInventory
            // 
            this.dateInventory.EditValue = null;
            this.dateInventory.Location = new System.Drawing.Point(88, 52);
            this.dateInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateInventory.Name = "dateInventory";
            this.dateInventory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInventory.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInventory.Properties.Mask.EditMask = "g";
            this.dateInventory.Size = new System.Drawing.Size(316, 20);
            this.dateInventory.StyleController = this.layoutControl1;
            this.dateInventory.TabIndex = 80;
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Image = global::Inventory.Properties.Resources.add_16x16;
            this.btnAddInventory.Location = new System.Drawing.Point(260, 174);
            this.btnAddInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(140, 23);
            this.btnAddInventory.StyleController = this.layoutControl1;
            this.btnAddInventory.TabIndex = 86;
            this.btnAddInventory.Text = "Agregar";
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.CustomizationFormText = "Root";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.emptySpaceItem1,
            this.layoutUnitsReceived,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.emptySpaceItem4,
            this.layoutControlItem11,
            this.layoutControlItem10,
            this.SupplierLayoutCtrlItem,
            this.layoutControlItem14,
            this.layoutControlItemW2,
            this.emptySpaceItem6,
            this.emptySpaceItem8,
            this.layoutInvoice,
            this.layoutInvoiceType,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem5});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Size = new System.Drawing.Size(1018, 515);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtProductName;
            this.layoutControlItem9.CustomizationFormText = "Producto:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(998, 40);
            this.layoutControlItem9.Text = "Producto:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridInventoryTransaction;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(998, 264);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnSaveProduct;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem12";
            this.layoutControlItem12.Location = new System.Drawing.Point(750, 453);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(111, 42);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnCancel;
            this.layoutControlItem13.CustomizationFormText = "layoutControlItem13";
            this.layoutControlItem13.Location = new System.Drawing.Point(861, 453);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(137, 42);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 453);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(750, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutUnitsReceived
            // 
            this.layoutUnitsReceived.Control = this.spEditUnits;
            this.layoutUnitsReceived.CustomizationFormText = "Und. recibidas";
            this.layoutUnitsReceived.Location = new System.Drawing.Point(0, 162);
            this.layoutUnitsReceived.MaxSize = new System.Drawing.Size(248, 27);
            this.layoutUnitsReceived.MinSize = new System.Drawing.Size(248, 27);
            this.layoutUnitsReceived.Name = "layoutUnitsReceived";
            this.layoutUnitsReceived.Size = new System.Drawing.Size(248, 27);
            this.layoutUnitsReceived.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutUnitsReceived.Text = "Unidades";
            this.layoutUnitsReceived.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnAddInventory;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(248, 162);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(144, 27);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(144, 27);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(144, 27);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtStoreKeeper;
            this.layoutControlItem2.CustomizationFormText = "Efectuado por:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem2.Text = "Efectuado por";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(392, 162);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(396, 27);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.dateInventory;
            this.layoutControlItem11.CustomizationFormText = "Fecha:";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(396, 26);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(396, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(396, 26);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "Fecha";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.lookupWarehouse;
            this.layoutControlItem10.CustomizationFormText = "Almacen:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem10.Text = "Almacen";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(73, 13);
            // 
            // SupplierLayoutCtrlItem
            // 
            this.SupplierLayoutCtrlItem.Control = this.lookUpEditSuppliers;
            this.SupplierLayoutCtrlItem.CustomizationFormText = "Proveedor:";
            this.SupplierLayoutCtrlItem.Location = new System.Drawing.Point(0, 114);
            this.SupplierLayoutCtrlItem.Name = "SupplierLayoutCtrlItem";
            this.SupplierLayoutCtrlItem.Size = new System.Drawing.Size(396, 24);
            this.SupplierLayoutCtrlItem.Text = "Proveedor";
            this.SupplierLayoutCtrlItem.TextSize = new System.Drawing.Size(73, 13);
            this.SupplierLayoutCtrlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.lookUpEditReason;
            this.layoutControlItem14.CustomizationFormText = "Razón:";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem14.Text = "Razón:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItemW2
            // 
            this.layoutControlItemW2.Control = this.lookUpWarehouse2;
            this.layoutControlItemW2.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItemW2.Location = new System.Drawing.Point(406, 90);
            this.layoutControlItemW2.Name = "layoutControlItemW2";
            this.layoutControlItemW2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItemW2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemW2.TextVisible = false;
            this.layoutControlItemW2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(396, 40);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(392, 50);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(396, 90);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutInvoice
            // 
            this.layoutInvoice.Control = this.txtInvoiceNumber;
            this.layoutInvoice.CustomizationFormText = "Factura No.";
            this.layoutInvoice.Location = new System.Drawing.Point(396, 114);
            this.layoutInvoice.Name = "layoutInvoice";
            this.layoutInvoice.Size = new System.Drawing.Size(215, 24);
            this.layoutInvoice.Text = "Factura No.";
            this.layoutInvoice.TextSize = new System.Drawing.Size(73, 13);
            this.layoutInvoice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutInvoiceType
            // 
            this.layoutInvoiceType.Control = this.cBEInvoiceType;
            this.layoutInvoiceType.CustomizationFormText = "Tipo de factura";
            this.layoutInvoiceType.Location = new System.Drawing.Point(611, 114);
            this.layoutInvoiceType.Name = "layoutInvoiceType";
            this.layoutInvoiceType.Size = new System.Drawing.Size(177, 24);
            this.layoutInvoiceType.Text = "Tipo de factura";
            this.layoutInvoiceType.TextSize = new System.Drawing.Size(73, 13);
            this.layoutInvoiceType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(788, 40);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(210, 149);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(776, 90);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(12, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(396, 138);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(392, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmItemInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 515);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmItemInOut";
            this.Text = "Entrada - Salida";
            this.Load += new System.EventHandler(this.frmItemInOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookupWarehouse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWarehouse2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBEInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionReasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spEditUnits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventory.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutUnitsReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierLayoutCtrlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutInvoiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.SimpleButton btnAddInventory;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit lookupWarehouse;
        private DevExpress.XtraGrid.GridControl gridInventoryTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvTransaction;
        private DevExpress.XtraEditors.DateEdit dateInventory;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveProduct;
        private DevExpress.XtraEditors.SpinEdit spEditUnits;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSuppliers;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.TextEdit txtStoreKeeper;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem SupplierLayoutCtrlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutUnitsReceived;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;        
        private DevExpress.Xpo.XPCollection xpCollectionSuppliers;
        private DevExpress.XtraEditors.ComboBoxEdit cBEInvoiceType;
        private DevExpress.XtraEditors.TextEdit txtInvoiceNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditReason;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutInvoice;
        private DevExpress.XtraLayout.LayoutControlItem layoutInvoiceType;
        private DevExpress.Xpo.XPCollection xpCollectionReasons;
        private DevExpress.Xpo.UnitOfWork uow;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolwarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoldate;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolsupplier;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolstorekeeper;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolinvoice;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolinvoicetype;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolreason;
        private DevExpress.XtraGrid.Columns.GridColumn gridcolinput;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.LookUpEdit lookUpWarehouse2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemW2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoldescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridcoloperation;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}