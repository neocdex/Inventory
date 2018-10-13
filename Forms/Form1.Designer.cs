
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.btguardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctnombre_prov = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctnombre_coonta = new DevExpress.XtraEditors.TextEdit();
            this.ctfax = new DevExpress.XtraEditors.TextEdit();
            this.ctemail = new DevExpress.XtraEditors.TextEdit();
            this.ctnota = new DevExpress.XtraEditors.TextEdit();
            this.ctline1 = new DevExpress.XtraEditors.TextEdit();
            this.ctline2 = new DevExpress.XtraEditors.TextEdit();
            this.ctciudad = new DevExpress.XtraEditors.TextEdit();
            this.ctdepartamento = new DevExpress.XtraEditors.TextEdit();
            this.ctpais = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.panelproveedor = new DevExpress.XtraEditors.PanelControl();
            this.panelAddress = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.CollectionProveedor = new DevExpress.Xpo.XPCollection(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsupplier_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsuppliername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontactname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfaxnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnotes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnombre_prov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnombre_coonta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctfax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctline1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctline2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctciudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelproveedor)).BeginInit();
            this.panelproveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAddress)).BeginInit();
            this.panelAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectionProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // session1
            // 
            this.session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly;
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(728, 530);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 1;
            this.btguardar.Text = "Registrar";
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(602, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nombre del proveedor";
            // 
            // ctnombre_prov
            // 
            this.ctnombre_prov.Location = new System.Drawing.Point(5, 15);
            this.ctnombre_prov.Name = "ctnombre_prov";
            this.ctnombre_prov.Size = new System.Drawing.Size(227, 20);
            this.ctnombre_prov.TabIndex = 1;
            this.ctnombre_prov.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(602, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nombre del contacto";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(602, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fax";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(601, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Email";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(602, 230);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Nota";
            // 
            // ctnombre_coonta
            // 
            this.ctnombre_coonta.Location = new System.Drawing.Point(5, 50);
            this.ctnombre_coonta.Name = "ctnombre_coonta";
            this.ctnombre_coonta.Size = new System.Drawing.Size(227, 20);
            this.ctnombre_coonta.TabIndex = 2;
            this.ctnombre_coonta.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctfax
            // 
            this.ctfax.Location = new System.Drawing.Point(5, 85);
            this.ctfax.Name = "ctfax";
            this.ctfax.Size = new System.Drawing.Size(227, 20);
            this.ctfax.TabIndex = 3;
            this.ctfax.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctemail
            // 
            this.ctemail.Location = new System.Drawing.Point(5, 126);
            this.ctemail.Name = "ctemail";
            this.ctemail.Size = new System.Drawing.Size(227, 20);
            this.ctemail.TabIndex = 4;
            this.ctemail.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctnota
            // 
            this.ctnota.Location = new System.Drawing.Point(5, 161);
            this.ctnota.Name = "ctnota";
            this.ctnota.Size = new System.Drawing.Size(227, 20);
            this.ctnota.TabIndex = 5;
            this.ctnota.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctline1
            // 
            this.ctline1.EditValue = "";
            this.ctline1.Location = new System.Drawing.Point(17, 16);
            this.ctline1.Name = "ctline1";
            this.ctline1.Size = new System.Drawing.Size(227, 20);
            this.ctline1.TabIndex = 6;
            this.ctline1.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctline2
            // 
            this.ctline2.Location = new System.Drawing.Point(17, 55);
            this.ctline2.Name = "ctline2";
            this.ctline2.Size = new System.Drawing.Size(227, 20);
            this.ctline2.TabIndex = 7;
            this.ctline2.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctciudad
            // 
            this.ctciudad.Location = new System.Drawing.Point(17, 86);
            this.ctciudad.Name = "ctciudad";
            this.ctciudad.Size = new System.Drawing.Size(227, 20);
            this.ctciudad.TabIndex = 8;
            this.ctciudad.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctdepartamento
            // 
            this.ctdepartamento.Location = new System.Drawing.Point(17, 127);
            this.ctdepartamento.Name = "ctdepartamento";
            this.ctdepartamento.Size = new System.Drawing.Size(227, 20);
            this.ctdepartamento.TabIndex = 9;
            this.ctdepartamento.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // ctpais
            // 
            this.ctpais.Location = new System.Drawing.Point(17, 162);
            this.ctpais.Name = "ctpais";
            this.ctpais.Size = new System.Drawing.Size(227, 20);
            this.ctpais.TabIndex = 10;
            this.ctpais.Enter += new System.EventHandler(this.ctnota_Enter);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(602, 303);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Line 1";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(602, 338);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Line 2";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(602, 373);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Ciudad";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(601, 414);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(69, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Departamento";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(602, 449);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(19, 13);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Pais";
            // 
            // panelproveedor
            // 
            this.panelproveedor.Controls.Add(this.ctnota);
            this.panelproveedor.Controls.Add(this.ctnombre_prov);
            this.panelproveedor.Controls.Add(this.ctnombre_coonta);
            this.panelproveedor.Controls.Add(this.ctfax);
            this.panelproveedor.Controls.Add(this.ctemail);
            this.panelproveedor.Location = new System.Drawing.Point(728, 62);
            this.panelproveedor.Name = "panelproveedor";
            this.panelproveedor.Size = new System.Drawing.Size(285, 192);
            this.panelproveedor.TabIndex = 4;
            // 
            // panelAddress
            // 
            this.panelAddress.Controls.Add(this.ctline1);
            this.panelAddress.Controls.Add(this.ctline2);
            this.panelAddress.Controls.Add(this.ctpais);
            this.panelAddress.Controls.Add(this.ctciudad);
            this.panelAddress.Controls.Add(this.ctdepartamento);
            this.panelAddress.Location = new System.Drawing.Point(729, 284);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(279, 193);
            this.panelAddress.TabIndex = 5;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // CollectionProveedor
            // 
            this.CollectionProveedor.ObjectType = typeof(Inventory.ORMDataModel.Suppliers);
            this.CollectionProveedor.Session = this.session1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.CollectionProveedor;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(556, 523);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsupplier_id,
            this.colsuppliername,
            this.colcontactname,
            this.colfaxnumber,
            this.colemail,
            this.colnotes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colsupplier_id
            // 
            this.colsupplier_id.FieldName = "supplier_id";
            this.colsupplier_id.Name = "colsupplier_id";
            this.colsupplier_id.Visible = true;
            this.colsupplier_id.VisibleIndex = 0;
            // 
            // colsuppliername
            // 
            this.colsuppliername.FieldName = "suppliername";
            this.colsuppliername.Name = "colsuppliername";
            this.colsuppliername.Visible = true;
            this.colsuppliername.VisibleIndex = 1;
            // 
            // colcontactname
            // 
            this.colcontactname.FieldName = "contactname";
            this.colcontactname.Name = "colcontactname";
            this.colcontactname.Visible = true;
            this.colcontactname.VisibleIndex = 2;
            // 
            // colfaxnumber
            // 
            this.colfaxnumber.FieldName = "faxnumber";
            this.colfaxnumber.Name = "colfaxnumber";
            this.colfaxnumber.Visible = true;
            this.colfaxnumber.VisibleIndex = 3;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            // 
            // colnotes
            // 
            this.colnotes.FieldName = "notes";
            this.colnotes.Name = "colnotes";
            this.colnotes.Visible = true;
            this.colnotes.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 582);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.panelproveedor);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btguardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnombre_prov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnombre_coonta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctfax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctnota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctline1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctline2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctciudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctdepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctpais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelproveedor)).EndInit();
            this.panelproveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAddress)).EndInit();
            this.panelAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollectionProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Xpo.XPCollection CollectionProveedor;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraEditors.SimpleButton btguardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctnombre_prov;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit ctnombre_coonta;
        private DevExpress.XtraEditors.TextEdit ctfax;
        private DevExpress.XtraEditors.TextEdit ctemail;
        private DevExpress.XtraEditors.TextEdit ctnota;
        private DevExpress.XtraEditors.TextEdit ctline1;
        private DevExpress.XtraEditors.TextEdit ctline2;
        private DevExpress.XtraEditors.TextEdit ctciudad;
        private DevExpress.XtraEditors.TextEdit ctdepartamento;
        private DevExpress.XtraEditors.TextEdit ctpais;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PanelControl panelproveedor;
        private DevExpress.XtraEditors.PanelControl panelAddress;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colsupplier_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsuppliername;
        private DevExpress.XtraGrid.Columns.GridColumn colcontactname;
        private DevExpress.XtraGrid.Columns.GridColumn colfaxnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colnotes;

    }


