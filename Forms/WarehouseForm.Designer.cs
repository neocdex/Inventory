namespace Inventory.Forms
{
    partial class WarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.txtWarehouseName = new DevExpress.XtraEditors.TextEdit();
            this.memoDescription = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.DisplayableProperties = "This;warehouse_id;name;description;location";
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
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
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtLocation);
            this.layoutControl1.Controls.Add(this.txtWarehouseName);
            this.layoutControl1.Controls.Add(this.memoDescription);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(350, 1, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(903, 337);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtLocation
            // 
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "location", true));
            this.txtLocation.Location = new System.Drawing.Point(69, 241);
            this.txtLocation.MenuManager = this.ribbon;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(598, 20);
            this.txtLocation.StyleController = this.layoutControl1;
            this.txtLocation.TabIndex = 5;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "name", true));
            this.txtWarehouseName.Location = new System.Drawing.Point(69, 12);
            this.txtWarehouseName.MenuManager = this.ribbon;
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(598, 20);
            this.txtWarehouseName.StyleController = this.layoutControl1;
            this.txtWarehouseName.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Por favor ingrese un valor";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.txtWarehouseName, conditionValidationRule1);
            // 
            // memoDescription
            // 
            this.memoDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MainBindingSource, "description", true));
            this.memoDescription.Location = new System.Drawing.Point(12, 52);
            this.memoDescription.MenuManager = this.ribbon;
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Size = new System.Drawing.Size(655, 185);
            this.memoDescription.StyleController = this.layoutControl1;
            this.memoDescription.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(903, 337);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLocation;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 229);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(659, 24);
            this.layoutControlItem2.Text = "Ubicado en";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtWarehouseName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(659, 24);
            this.layoutControlItem1.Text = "Almacén";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.memoDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(659, 205);
            this.layoutControlItem3.Text = "Descripción";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(659, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(224, 317);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 253);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(659, 64);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 511);
            this.Controls.Add(this.layoutControl1);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWarehouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtWarehouseName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.MemoEdit memoDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}