using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.Metadata;
using Inventory.ORMDataModel;
//using Inventory.Forms;


    public partial class Form1 : Form
    {
        //string conn = @"Server=localhost;Database=inventory; Uid=root;Pwd= ;";
      string conn = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("localhost", "root", "", "inventory");
      bool editar = false;
      bool seleccionado = false;
      bool nuevo = false;
        

      Suppliers proveedor;
      Addresses direccion;
      //XPCollection Numero_telefono;
      XPCollection proveedor_telefono;
     
      
        public Form1()
        {
          
           //session1 = new Session();
            //session1.ConnectionString = conn;
 
            InitializeComponent();
        }
        public void limpiar_cajas(DevExpress.XtraEditors.PanelControl panel)
        {

            for (int i = 0; i < panel.Controls.Count; i++)
            {
                //  MessageBox.Show("Elemento"+i.ToString()+" "+panel.Controls[i].Name);                
                panel.Controls[i].Text = "";

            }
 
        }
        public bool validarPanelProveedor(DevExpress.XtraEditors.PanelControl panel)
        {
            
            //System.Collections.IEnumerator controles= panel.Controls.GetEnumerator();
           // MessageBox.Show( controles.Current.ToString());
            
            for (int i = 0; i < panel.Controls.Count ; i++)
            {
              //  MessageBox.Show("Elemento"+i.ToString()+" "+panel.Controls[i].Name);                
                if (panel.Controls[i].Text.Length == 0)
                {
                    dxErrorProvider1.SetError(panel.Controls[i], "Debe llenar el campo");
                    return false;
                }
 
            }
            return true;

 
        }

        public void bloquear_todo()
        {
            ctciudad.Enabled = false;
            ctcompañia.Enabled = false;
            ctdepartamento.Enabled = false;
            ctemail.Enabled = false;
            ctestatus.Enabled = false;
            ctfax.Enabled = false;
            ctline1.Enabled = false;
            ctline2.Enabled = false;
            ctnombre_coonta.Enabled = false;
            ctnombre_prov.Enabled = false;
            ctnota.Enabled = false;
            ctnumero.Enabled = false;
            ctpais.Enabled = false;
            cttype.Enabled = false;
        }
        public void Desbloquear_todo()
        {
            ctciudad.Enabled = true;
            ctcompañia.Enabled = true;
            ctdepartamento.Enabled = true;
            ctemail.Enabled = true;
            ctestatus.Enabled = true;
            ctfax.Enabled = true;
            ctline1.Enabled = true;
            ctline2.Enabled = true;
            ctnombre_coonta.Enabled = true;
            ctnombre_prov.Enabled = true;
            ctnota.Enabled = true;
            ctnumero.Enabled = true;
            ctpais.Enabled = true;
            cttype.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bloquear_todo();
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionHelper.ConnectionString, AutoCreateOption.DatabaseAndSchema);
            
            //try
            //{  
           // sup_phone = new Suppliers_phonenumber(session1);
            
            
            direccion = new Addresses(session1);
           // Numero_telefono = new XPCollection(session1, typeof(Phonenumbers));
            proveedor_telefono = new XPCollection(session1, typeof(Phonenumbers));


              toolnuevo.Enabled = true;
               tooleliminar.Enabled = true;
               tooleditar.Enabled = true;
               toolGuardar.Enabled = false;
               toolcancelar.Enabled = false;
               btagregarTelefono.Enabled = false;
          

        }

        private void btguardar_Click(object sender, EventArgs e)
        { }

        private void ctnota_Enter(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
        }

        
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           // MessageBox.Show("hola");

        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            //MessageBox.Show("hola1");
        }

        private void btagregarTelefono_Click(object sender, EventArgs e)
        {

            if (validarPanelProveedor(panelTelefono) == false )
                return;

            
         //   dgtelefono.Rows.Add(ctnumero.Text, cttype.Text, ctcompañia.Text, ctestatus.Text);



            Suppliers_phonenumber sub_phone = new Suppliers_phonenumber(session1);
            sub_phone.supplier_id = proveedor;
            sub_phone.phoneNumbers_id=new Phonenumbers(session1);
            sub_phone.phoneNumbers_id.company = ctcompañia.Text;
            sub_phone.phoneNumbers_id.phoneNumber = ctnumero.Text;
            sub_phone.phoneNumbers_id.type =Convert.ToSByte( cttype.Text);
            sub_phone.phoneNumbers_id.status =Convert.ToSByte( ctestatus.Text);
            
            proveedor.Suppliers_phonenumber.Add(sub_phone);
            gridtelefono.DataSource = proveedor.Suppliers_phonenumber;

            ctnumero.Text = "";
            cttype.Text = "";
            ctcompañia.Text = "";
            ctestatus.Text = "";

        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            limpiar_cajas(panelAddress);
            limpiar_cajas(panelproveedor);
            limpiar_cajas(panelTelefono);
          //  dgtelefono.Rows.Clear();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
        

        private void toolGuardar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("intentando editar");
            if (validarPanelProveedor(panelproveedor) == false)
            {
                //MessageBox.Show("Deve llenar todos los datos");
                return;
            }
            if (validarPanelProveedor(panelAddress) == false)
            {
                //MessageBox.Show("Deve llenar todos los campos de direccion");
                return;
            }

        //    Session sesion = new Session();
            // using (Session sesion = new Session())
            //   {
         //   MessageBox.Show("intentando editar1");

            //EDITAR  UN REGISTRO
            if (editar == true)
            {
                 proveedor.suppliername = ctnombre_prov.Text;
                 proveedor.contactname = ctnombre_coonta.Text;
                 proveedor.faxnumber = ctfax.Text;
                 proveedor.email = ctemail.Text;
                 proveedor.notes = ctnota.Text;
                 proveedor.Save();//Actualizamos el proveedor


                direccion.line1 = ctline1.Text;
                direccion.line2 = ctline2.Text;
                direccion.city = ctciudad.Text;
                direccion.deparment = ctdepartamento.Text;
                direccion.country = ctpais.Text;
                direccion.Save();        





                 MessageBox.Show("Proveedor Actualizado Correctameente");
               

                 editar = false;

                 toolnuevo.Enabled = true;
                 tooleliminar.Enabled =true;
                 toolGuardar.Enabled = false;
                 tooleditar.Enabled = true;
                 toolcancelar.Enabled = false;
                 bloquear_todo();
                 btagregarTelefono.Enabled = false;

                 return;
              
            }

            session1.BeginTransaction();

            

                proveedor.suppliername = ctnombre_prov.Text;
                proveedor.contactname = ctnombre_coonta.Text;
                proveedor.faxnumber = ctfax.Text;
                proveedor.email = ctemail.Text;
                proveedor.notes = ctnota.Text;
            
          //  supp.Save();
            //MessageBox.Show("guardando pro");

            Addresses add = new Addresses(session1)
            {

                line1 = ctline1.Text,
                line2 = ctline2.Text,
                city = ctciudad.Text,
                deparment = ctdepartamento.Text,
                country = ctpais.Text,
                
            };
            proveedor.AddressesCollection.Add(add);
           
            try
            {
                proveedor.Save();
                session1.CommitTransaction();
                CollectionProveedor.Reload();//CARGAR LOS DATOS DE GRIDCONTROL PROVEEDORES

                MessageBox.Show("Proveedor Registrado", "Guardando proveedor");

                //LIMPIAR TODAS LAS CAJAS DE TEXTO
                limpiar_cajas(panelAddress);
                limpiar_cajas(panelproveedor);
                limpiar_cajas(panelTelefono);
                btagregarTelefono.Enabled = false;
                toolcancelar.Enabled = false;
                bloquear_todo();

                editar = false;

                toolnuevo.Enabled = true;
                tooleliminar.Enabled = true;
                toolGuardar.Enabled = false;
                tooleditar.Enabled = true;
                nuevo = false;

            }
            catch
            {
                MessageBox.Show("Error al registrar proveedor");
                session1.RollbackTransaction();

            }
            //}
            // MessageBox.Show(supp.supplier_id.ToString());
           
           
    
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            btagregarTelefono.Enabled = true;
            gridtelefono.DataSource = null;
            nuevo = true;
            toolcancelar.Enabled = true;
            Desbloquear_todo();
            proveedor = new Suppliers(session1);
            
            limpiar_cajas(panelAddress);
            limpiar_cajas(panelproveedor);
            limpiar_cajas(panelTelefono);
            editar = false;
            toolnuevo.Enabled = false;
            tooleliminar.Enabled = false;
            toolGuardar.Enabled = true;
            tooleditar.Enabled = false;
           // dgtelefono.Rows.Clear();

            proveedor.Suppliers_phonenumber.DisplayableProperties = "phoneNumbers_id.phoneNumber;phoneNumbers_id.type;phoneNumbers_id.company;phoneNumbers_id.status;";
         
        }

        public void Cargar_de_grid(int row)
        {
            Suppliers sup = new Suppliers(session1);
            sup = (Suppliers)gridView1.GetRow(row);
            ctnombre_prov.Text = sup.suppliername;
            ctnombre_coonta.Text = sup.contactname;
            ctfax.Text = sup.faxnumber;
            ctemail.Text = sup.email;
            ctnota.Text = sup.notes;

            proveedor = sup;// Guardamos una copia del objeeto en la variable global proveedor para su posiblee edicion


            Addresses add = new Addresses(session1);
            if (sup.AddressesCollection.Count > 0)
            {
                add = sup.AddressesCollection[0];
            } ctline1.Text = add.line1;
            ctline2.Text = add.line2;
            ctciudad.Text = add.city;
            ctdepartamento.Text = add.deparment;
            ctpais.Text = add.country;

            direccion = add;// Guardamos una copia del objeeto en la variable global direccion para su posiblee edicion

            proveedor.Suppliers_phonenumber.DisplayableProperties = "phoneNumbers_id.phoneNumber;phoneNumbers_id.type;phoneNumbers_id.company;phoneNumbers_id.status;";
            gridtelefono.DataSource = proveedor.Suppliers_phonenumber;
            seleccionado = true;

 
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (editar == true || nuevo==true)
            {
                return;
            }
            Cargar_de_grid(e.FocusedRowHandle);
             
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado == true)
            {
                
            proveedor.Delete();
            seleccionado = false;
            gridtelefono.DataSource = null;
            gridView1.FocusedRowHandle = 0;
 
            } 
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            btagregarTelefono.Enabled = true;
            toolcancelar.Enabled = true;
            Desbloquear_todo();
            editar = true;
            toolnuevo.Enabled = false;
            tooleliminar.Enabled = false;
            toolGuardar.Enabled = true;
            tooleditar.Enabled = false;
        }

        private void toolcancelar_Click(object sender, EventArgs e)
        {
            btagregarTelefono.Enabled = false;
            nuevo = false;
            editar = false;
            bloquear_todo();
            Cargar_de_grid(0);
            tooleditar.Enabled = true;
            tooleliminar.Enabled = true;
            toolGuardar.Enabled = false;
            toolnuevo.Enabled = true;
        }

        private void eliminarTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                return;
            }
            proveedor.Suppliers_phonenumber[gridView2.FocusedRowHandle].Delete();
            
        }

        private void Solo_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Solo_Letras(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

       
     

        

       
    }


 

