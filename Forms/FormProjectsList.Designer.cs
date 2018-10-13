namespace Inventory.Forms
{
    partial class FormProjectsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectsList));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.WarehouseGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectGridControl = new DevExpress.XtraGrid.GridControl();
            this.ProjectGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstartdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenddate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xpMainCollection
            // 
            this.xpMainCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Project);
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = this.xpMainCollection;
            // 
            // imageCollection32x32
            // 
            this.imageCollection32x32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection32x32.ImageStream")));
            this.imageCollection32x32.InsertGalleryImage("save_32x32.png", "images/save/save_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/save/save_32x32.png"), 0);
            this.imageCollection32x32.Images.SetKeyName(0, "save_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("cancel_32x32.png", "images/actions/cancel_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png"), 1);
            this.imageCollection32x32.Images.SetKeyName(1, "cancel_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("refresh_32x32.png", "images/actions/refresh_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/refresh_32x32.png"), 2);
            this.imageCollection32x32.Images.SetKeyName(2, "refresh_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("edit_32x32.png", "images/edit/edit_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/edit_32x32.png"), 3);
            this.imageCollection32x32.Images.SetKeyName(3, "edit_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("additem_32x32.png", "images/actions/additem_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_32x32.png"), 4);
            this.imageCollection32x32.Images.SetKeyName(4, "additem_32x32.png");
            this.imageCollection32x32.InsertGalleryImage("print_32x32.png", "images/print/print_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/print/print_32x32.png"), 5);
            this.imageCollection32x32.Images.SetKeyName(5, "print_32x32.png");
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Size = new System.Drawing.Size(846, 155);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname1,
            this.coldescription1,
            this.collocation});
            this.WarehouseGridView.GridControl = this.ProjectGridControl;
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colname1
            // 
            this.colname1.Caption = "Almacén";
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 1;
            this.colname1.Width = 253;
            // 
            // coldescription1
            // 
            this.coldescription1.Caption = "Descripción";
            this.coldescription1.FieldName = "description";
            this.coldescription1.Name = "coldescription1";
            this.coldescription1.Visible = true;
            this.coldescription1.VisibleIndex = 2;
            this.coldescription1.Width = 253;
            // 
            // collocation
            // 
            this.collocation.Caption = "Ubicado en";
            this.collocation.FieldName = "location";
            this.collocation.Name = "collocation";
            this.collocation.Visible = true;
            this.collocation.VisibleIndex = 3;
            this.collocation.Width = 258;
            // 
            // ProjectGridControl
            // 
            this.ProjectGridControl.DataSource = this.MainBindingSource;
            this.ProjectGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.WarehouseGridView;
            gridLevelNode1.RelationName = "Warehouses";
            this.ProjectGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.ProjectGridControl.Location = new System.Drawing.Point(0, 155);
            this.ProjectGridControl.MainView = this.ProjectGridView;
            this.ProjectGridControl.MenuManager = this.ribbon;
            this.ProjectGridControl.Name = "ProjectGridControl";
            this.ProjectGridControl.ShowOnlyPredefinedDetails = true;
            this.ProjectGridControl.Size = new System.Drawing.Size(846, 375);
            this.ProjectGridControl.TabIndex = 2;
            this.ProjectGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProjectGridView,
            this.WarehouseGridView});
            // 
            // ProjectGridView
            // 
            this.ProjectGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.coldescription,
            this.colmanager,
            this.colstartdate,
            this.colenddate});
            this.ProjectGridView.GridControl = this.ProjectGridControl;
            this.ProjectGridView.Name = "ProjectGridView";
            this.ProjectGridView.OptionsFind.AlwaysVisible = true;
            this.ProjectGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colname
            // 
            this.colname.Caption = "Nombre del proyecto";
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
            // colmanager
            // 
            this.colmanager.Caption = "Director";
            this.colmanager.FieldName = "manager";
            this.colmanager.Name = "colmanager";
            this.colmanager.Visible = true;
            this.colmanager.VisibleIndex = 2;
            // 
            // colstartdate
            // 
            this.colstartdate.Caption = "Fecha de inicio";
            this.colstartdate.FieldName = "startdate";
            this.colstartdate.Name = "colstartdate";
            this.colstartdate.Visible = true;
            this.colstartdate.VisibleIndex = 3;
            // 
            // colenddate
            // 
            this.colenddate.Caption = "Fecha de finalización";
            this.colenddate.FieldName = "enddate";
            this.colenddate.Name = "colenddate";
            this.colenddate.Visible = true;
            this.colenddate.VisibleIndex = 4;
            // 
            // FormProjectsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 561);
            this.Controls.Add(this.ProjectGridControl);
            this.Name = "FormProjectsList";
            this.Text = "Proyectos";
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.ProjectGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpMainCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection32x32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ProjectGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProjectGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colmanager;
        private DevExpress.XtraGrid.Columns.GridColumn colstartdate;
        private DevExpress.XtraGrid.Columns.GridColumn colenddate;
        private DevExpress.XtraGrid.Views.Grid.GridView WarehouseGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription1;
        private DevExpress.XtraGrid.Columns.GridColumn collocation;
    }
}