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
      string conn = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("localhost", "tester", "developer", "inventory");
    
      
        public Form1()
        {
           
           //session1 = new Session();
            //session1.ConnectionString = conn;
 
            InitializeComponent();
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


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema);
            }
            catch (Exception ex) { 
            
            }

         

           /*
           
            Session s = new Session();
            var cat = new category(s);
            cat.category_id = 5;
            cat.name = "cat2";
            cat.description = "cat222222";
           // MessageBox.Show(cat.Session.ConnectionString.ToString());
           cat.Save();
           MessageBox.Show("guardado");
            
            */

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (validarPanelProveedor(panelproveedor)==false )
            {
                //MessageBox.Show("Deve llenar todos los datos");
                return;
            }
            if (validarPanelProveedor(panelAddress) == false)
            {
                //MessageBox.Show("Deve llenar todos los campos de direccion");
                return;
            }
           Session sesion=new Session();
           // using (Session sesion = new Session())
         //   {
                sesion.BeginTransaction();
            
                Suppliers supp = new Suppliers(sesion)
                {

                    suppliername = ctnombre_prov.Text,
                    contactname = ctnombre_coonta.Text,
                    faxnumber = ctfax.Text,
                    email = ctemail.Text,
                    notes = ctnota.Text
                };
                supp.Save();
          
                Addresses add = new Addresses(sesion)
                {

                    line1 = ctline1.Text,
                    line2 = ctline2.Text,
                    city = ctciudad.Text,
                    deparment = ctdepartamento.Text,
                    country = ctpais.Text,
                    supplier_id = supp
                };
                add.Save();
          
                try
                {


                    sesion.CommitTransaction();
                    CollectionProveedor.Reload();
                    MessageBox.Show("Proveedor Registrado", "Guardando proveedor");

                }
                catch
                {
                    sesion.RollbackTransaction();
                    MessageBox.Show("Error al registrar proveedor");
                }
            //}
           // MessageBox.Show(supp.supplier_id.ToString());
           
           
    
        }

        private void ctnota_Enter(object sender, EventArgs e)
        {
            dxErrorProvider1.ClearErrors();
        }
    }


 

