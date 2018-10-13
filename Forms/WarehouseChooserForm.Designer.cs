namespace Inventory.Forms
{
    partial class WarehouseChooserForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.OrderByCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CategoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.OKButton = new DevExpress.XtraEditors.SimpleButton();
            this.WarehouseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.xpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.SortOrdercCBE = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutCtrlCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpCategoryCollection = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderByCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortOrdercCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.OrderByCBE);
            this.layoutControl1.Controls.Add(this.CategoryLookUpEdit);
            this.layoutControl1.Controls.Add(this.CancelBtn);
            this.layoutControl1.Controls.Add(this.OKButton);
            this.layoutControl1.Controls.Add(this.WarehouseLookUpEdit);
            this.layoutControl1.Controls.Add(this.SortOrdercCBE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(548, 219, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(356, 170);
            this.layoutControl1.TabIndex = 0;
            // 
            // OrderByCBE
            // 
            this.OrderByCBE.EditValue = "Código producto";
            this.OrderByCBE.Location = new System.Drawing.Point(78, 73);
            this.OrderByCBE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByCBE.Name = "OrderByCBE";
            this.OrderByCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrderByCBE.Properties.Items.AddRange(new object[] {
            "Código producto",
            "Nombre producto"});
            this.OrderByCBE.Size = new System.Drawing.Size(266, 20);
            this.OrderByCBE.StyleController = this.layoutControl1;
            this.OrderByCBE.TabIndex = 8;
            // 
            // CategoryLookUpEdit
            // 
            this.CategoryLookUpEdit.Location = new System.Drawing.Point(78, 49);
            this.CategoryLookUpEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CategoryLookUpEdit.Name = "CategoryLookUpEdit";
            this.CategoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre")});
            this.CategoryLookUpEdit.Properties.DisplayMember = "name";
            this.CategoryLookUpEdit.Properties.NullValuePrompt = "Seleccione";
            this.CategoryLookUpEdit.Properties.ValueMember = "This";
            this.CategoryLookUpEdit.Size = new System.Drawing.Size(266, 20);
            this.CategoryLookUpEdit.StyleController = this.layoutControl1;
            this.CategoryLookUpEdit.TabIndex = 7;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(179, 136);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(165, 22);
            this.CancelBtn.StyleController = this.layoutControl1;
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 136);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(163, 22);
            this.OKButton.StyleController = this.layoutControl1;
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "Aceptar";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // WarehouseLookUpEdit
            // 
            this.WarehouseLookUpEdit.Location = new System.Drawing.Point(78, 25);
            this.WarehouseLookUpEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.WarehouseLookUpEdit.Name = "WarehouseLookUpEdit";
            this.WarehouseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WarehouseLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Nombre", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.WarehouseLookUpEdit.Properties.DataSource = this.xpCollection;
            this.WarehouseLookUpEdit.Properties.DisplayMember = "name";
            this.WarehouseLookUpEdit.Properties.NullValuePrompt = "Seleccione";
            this.WarehouseLookUpEdit.Properties.ValueMember = "This";
            this.WarehouseLookUpEdit.Size = new System.Drawing.Size(266, 20);
            this.WarehouseLookUpEdit.StyleController = this.layoutControl1;
            this.WarehouseLookUpEdit.TabIndex = 4;
            // 
            // xpCollection
            // 
            this.xpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCollection.DisplayableProperties = "This;warehouse_id;name;description;location";
            this.xpCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Warehouse);
            this.xpCollection.Session = this.unitOfWork;
            // 
            // unitOfWork
            // 
            this.unitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWork.TrackPropertiesModifications = false;
            // 
            // SortOrdercCBE
            // 
            this.SortOrdercCBE.EditValue = 'A';
            this.SortOrdercCBE.Location = new System.Drawing.Point(78, 97);
            this.SortOrdercCBE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SortOrdercCBE.Name = "SortOrdercCBE";
            this.SortOrdercCBE.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('A', "Ascendente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('D', "Descendente")});
            this.SortOrdercCBE.Size = new System.Drawing.Size(266, 25);
            this.SortOrdercCBE.StyleController = this.layoutControl1;
            this.SortOrdercCBE.TabIndex = 9;
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
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.layoutCtrlCategory,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(356, 170);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.WarehouseLookUpEdit;
            this.layoutControlItem1.CustomizationFormText = "Almacenes";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 13);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem1.Text = "Almacén:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.OKButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CancelBtn;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(167, 124);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(169, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(336, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(336, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutCtrlCategory
            // 
            this.layoutCtrlCategory.Control = this.CategoryLookUpEdit;
            this.layoutCtrlCategory.CustomizationFormText = "Categorías";
            this.layoutCtrlCategory.Location = new System.Drawing.Point(0, 37);
            this.layoutCtrlCategory.Name = "layoutCtrlCategory";
            this.layoutCtrlCategory.Size = new System.Drawing.Size(336, 24);
            this.layoutCtrlCategory.Text = "Categoría:";
            this.layoutCtrlCategory.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.OrderByCBE;
            this.layoutControlItem5.CustomizationFormText = "Ordenar por:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem5.Text = "Ordenar por:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.SortOrdercCBE;
            this.layoutControlItem6.CustomizationFormText = "Orden:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(336, 29);
            this.layoutControlItem6.Text = "Orden:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 13);
            // 
            // xpCategoryCollection
            // 
            this.xpCategoryCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCategoryCollection.DisplayableProperties = "This;category_id;name;description;code";
            this.xpCategoryCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Category);
            this.xpCategoryCollection.Session = this.unitOfWork;
            // 
            // WarehouseChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 170);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "WarehouseChooserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de almacenés";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderByCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortOrdercCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategoryCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpCollection;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
        private DevExpress.XtraEditors.SimpleButton OKButton;
        private DevExpress.XtraEditors.LookUpEdit WarehouseLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.LookUpEdit CategoryLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutCtrlCategory;
        private DevExpress.Xpo.XPCollection xpCategoryCollection;
        private DevExpress.XtraEditors.ComboBoxEdit OrderByCBE;
        private DevExpress.XtraEditors.RadioGroup SortOrdercCBE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}