namespace Inventory.Forms
{
    partial class WarehouseTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseTransferForm));
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lookUpEditWarehouseSrc = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtStoreKeeper = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEditWarehouseDst = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEditInventory = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouseSrc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouseDst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInventory.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpMainCollection.DeleteObjectOnRemove = true;
            this.xpMainCollection.DisplayableProperties = "This;warehouse_id;name;StoredItems";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.AllowNew = false;
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
            this.ribbon.Size = new System.Drawing.Size(605, 143);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // lookUpEditWarehouseSrc
            // 
            this.lookUpEditWarehouseSrc.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.MainBindingSource, "name", true));
            this.lookUpEditWarehouseSrc.Location = new System.Drawing.Point(93, 36);
            this.lookUpEditWarehouseSrc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpEditWarehouseSrc.Name = "lookUpEditWarehouseSrc";
            this.lookUpEditWarehouseSrc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditWarehouseSrc.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditWarehouseSrc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditWarehouseSrc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditWarehouseSrc.Properties.DataSource = this.MainBindingSource;
            this.lookUpEditWarehouseSrc.Properties.DisplayMember = "name";
            this.lookUpEditWarehouseSrc.Properties.NullText = "";
            this.lookUpEditWarehouseSrc.Properties.ValueMember = "This";
            this.lookUpEditWarehouseSrc.Size = new System.Drawing.Size(500, 20);
            this.lookUpEditWarehouseSrc.StyleController = this.layoutControl1;
            this.lookUpEditWarehouseSrc.TabIndex = 7;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule2.Control = this.lookUpEditWarehouseDst;
            compareAgainstControlValidationRule2.ErrorText = "Los almacenes de origen y destino no pueden ser iguales";
            compareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider2.SetValidationRule(this.lookUpEditWarehouseSrc, compareAgainstControlValidationRule2);
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.lookUpEditWarehouseSrc, conditionValidationRule3);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtStoreKeeper);
            this.layoutControl1.Controls.Add(this.lookUpEditWarehouseDst);
            this.layoutControl1.Controls.Add(this.lookUpEditWarehouseSrc);
            this.layoutControl1.Controls.Add(this.dateEditInventory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(705, 303, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(605, 210);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtStoreKeeper
            // 
            this.txtStoreKeeper.Location = new System.Drawing.Point(93, 84);
            this.txtStoreKeeper.MenuManager = this.ribbon;
            this.txtStoreKeeper.Name = "txtStoreKeeper";
            this.txtStoreKeeper.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreKeeper.Properties.Appearance.Options.UseFont = true;
            this.txtStoreKeeper.Size = new System.Drawing.Size(500, 20);
            this.txtStoreKeeper.StyleController = this.layoutControl1;
            this.txtStoreKeeper.TabIndex = 14;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Por favor ingrese un valor";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider.SetValidationRule(this.txtStoreKeeper, conditionValidationRule1);
            // 
            // lookUpEditWarehouseDst
            // 
            this.lookUpEditWarehouseDst.Location = new System.Drawing.Point(93, 60);
            this.lookUpEditWarehouseDst.MenuManager = this.ribbon;
            this.lookUpEditWarehouseDst.Name = "lookUpEditWarehouseDst";
            this.lookUpEditWarehouseDst.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditWarehouseDst.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditWarehouseDst.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditWarehouseDst.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEditWarehouseDst.Properties.DisplayMember = "name";
            this.lookUpEditWarehouseDst.Properties.NullText = "";
            this.lookUpEditWarehouseDst.Properties.ValueMember = "This";
            this.lookUpEditWarehouseDst.Size = new System.Drawing.Size(500, 20);
            this.lookUpEditWarehouseDst.StyleController = this.layoutControl1;
            this.lookUpEditWarehouseDst.TabIndex = 13;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule1.Control = this.lookUpEditWarehouseSrc;
            compareAgainstControlValidationRule1.ErrorText = "Los almacenes de origen y destino no pueden ser iguales";
            compareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider2.SetValidationRule(this.lookUpEditWarehouseDst, compareAgainstControlValidationRule1);
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Por favor seleccione un valor";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.lookUpEditWarehouseDst, conditionValidationRule2);
            // 
            // dateEditInventory
            // 
            this.dateEditInventory.EditValue = new System.DateTime(2020, 2, 24, 17, 1, 29, 457);
            this.dateEditInventory.Location = new System.Drawing.Point(93, 12);
            this.dateEditInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditInventory.MenuManager = this.ribbon;
            this.dateEditInventory.Name = "dateEditInventory";
            this.dateEditInventory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInventory.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInventory.Properties.DisplayFormat.FormatString = "";
            this.dateEditInventory.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditInventory.Properties.EditFormat.FormatString = "";
            this.dateEditInventory.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditInventory.Properties.Mask.EditMask = "";
            this.dateEditInventory.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateEditInventory.Size = new System.Drawing.Size(207, 20);
            this.dateEditInventory.StyleController = this.layoutControl1;
            this.dateEditInventory.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(605, 210);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditWarehouseSrc;
            this.layoutControlItem2.CustomizationFormText = "Almacén origen";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem2.Text = "Almacén origen";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lookUpEditWarehouseDst;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem4.Text = "Almacén destino";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtStoreKeeper;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(585, 118);
            this.layoutControlItem5.Text = "Efectuado por";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEditInventory;
            this.layoutControlItem3.CustomizationFormText = "Ubicado en";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(292, 24);
            this.layoutControlItem3.Text = "Fecha";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(292, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(293, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // dxValidationProvider2
            // 
            this.dxValidationProvider2.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // WarehouseTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 384);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarehouseTransferForm";
            this.Text = "Traspaso de almacén";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouseSrc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreKeeper.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouseDst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInventory.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditWarehouseDst;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditWarehouseSrc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtStoreKeeper;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.DateEdit dateEditInventory;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider2;
    }
}