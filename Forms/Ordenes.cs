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
using Inventory.ORMDataModelCode;


    public partial class Ordenes : Form
    {
        //string conn = DevExpress.Xpo.DB.MySqlConnectionProvider.GetConnectionString("localhost", "root", "", "inventory");
        Purchaseorders order;
        XPCollection order_detail;
        XPCollection visualizar_detail;
        ErrorProvider error;
           
       // List<Purchaseorderdetails> ordenes;
        public Ordenes()
        {
            error = new ErrorProvider();
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionHelper.ConnectionString, AutoCreateOption.DatabaseAndSchema);
           
            InitializeComponent();
        }

        private void btregistrar_Click(object sender, EventArgs e)
        {
          //  Suppliers sup;
            //sup = (Suppliers)searchLookUpEdit1View.GetFocusedRow();
          
         //VERIFICAR SI LA ORDEN TIENE PRODUCTOS
            if (gridView1.DataRowCount == 0)
            {
                error.SetError(griddetail, "Deve agregar productos a la orden");
                return;
            }

                order.purchaseOrderNumber = ctnumeroOrden.Text;
                order.purchaseOrderDescription = ctDescripOrden.Text;
                order.orderDate = DateTime.Parse(ctFechaOrden.Text.ToString());
                order.datePromised = DateTime.Parse(ctFechaPrometida.Text);
               order.shipDate=DateTime.Parse(ctFechaEnvio.Text);
               order.freightCharge = double.Parse(ctGastoEnvio.Text);
              // supplier_id=sup
               

            
            order.Save();

       
          session1.CommitTransaction();
          order = new Purchaseorders(session1);
       //   MessageBox.Show(order.purchaseOrder_id.ToString());
            MessageBox.Show("Orden guardada exitosamente");
            limpiarcajas();
            btregistrar.Enabled = false;
            bloqueartodo();
            btnuevo.Enabled = true;
            btregistrar.Enabled = false;
            btcancelar.Enabled = false;
            error.Clear();
            griddetail.DataSource = null;
        }
        public void bloqueartodo()
        {
            ctnumeroOrden.Enabled = false;
            ctFechaEnvio.Enabled = false;
            ctFechaOrden.Enabled = false;
            ctFechaPrometida.Enabled = false;
           // searchproveedor.Enabled = false;
            ctDescripOrden.Enabled = false;
            ctGastoEnvio.Enabled = false;

            searchProducto.Enabled = false;
            ctprecioUnitario.Enabled = false;
            ctcantidadOrdena.Enabled = false;
        }
        public void desbloqueartodo() 
        {
            ctnumeroOrden.Enabled = true;
            ctFechaEnvio.Enabled = true;
            ctFechaOrden.Enabled = true;
            ctFechaPrometida.Enabled = true;
            //searchproveedor.Enabled = true;
            ctDescripOrden.Enabled = true;
            ctGastoEnvio.Enabled = true;

            searchProducto.Enabled = true;
            ctprecioUnitario.Enabled = true;
            ctcantidadOrdena.Enabled = true;
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
                       
            order_detail = new XPCollection(session1, typeof(Purchaseorderdetails));
            
            visualizar_detail = new XPCollection(session1, typeof(Purchaseorderdetails));
            
            this.xpC_producto.DisplayableProperties = "name;description;serialnumber;discontinued;discontinued_date;weight";
           // order_detail.DisplayableProperties = "product_id.name;unitPrice;unitsOrdered;Subtotal;IVA;Total";
            visualizar_detail.DisplayableProperties = "unitPrice;unitsOrdered;Subtotal;IVA;Total";

            btregistrar.Enabled = false;
            btcancelar.Enabled = false;
        //    order_detail.Criteria= CriteriaOperator.Parse("purcharOrder_id=" +order.ToString() + "");
             
         //   MessageBox.Show(order.purchaseOrder_id.ToString());

            bloqueartodo();
           
           }
        public void limpiarcajas()
        {
            ctnumeroOrden.Text = "";
            ctFechaEnvio.Text = "";
            ctFechaOrden.Text = "";
            ctFechaPrometida.Text = "";
            //searchproveedor.Text = "";
            ctDescripOrden.Text = "";
            ctGastoEnvio.Text = "";
        }
        public void limpiarDetalle()
        {
            searchProducto.Text = "";
            ctprecioUnitario.Text = "";
            ctcantidadOrdena.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btagregarDetalle_Click(object sender, EventArgs e)
        {


           Purchaseorderdetails or = new Purchaseorderdetails(session1);
           Products produc;
            
            produc = (Products)searchProductoView.GetFocusedRow();
            if (produc == null || ctprecioUnitario.Text.Trim().Length==0 || ctcantidadOrdena.Text.Trim().Length==0)
            {
                error.SetError(btagregarDetalle, "Deve llenar todos lo campos");
                return;
                
            }
            or.unitPrice = double.Parse(ctprecioUnitario.Text);
            or.unitsOrdered = int.Parse(ctcantidadOrdena.Text);
            or.Subtotal = or.unitPrice * or.unitsOrdered;
            or.IVA = or.Subtotal * 0.15;
            or.Total = or.Subtotal + or.IVA;
            or.product_id = produc;
            or.purchaseOrder_id = order;
           // order_detail.Add(or);
            order.PurchaseorderdetailsCollection.Add(or);           
            griddetail.DataSource = order.PurchaseorderdetailsCollection;
            limpiarDetalle();
        //   dgdetalle.Rows.Add(produc.name,or.unitPrice.ToString(),or.unitsOrdered.ToString(),or.Subtotal.ToString(),or.IVA.ToString(),or.Total.ToString());



                 }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            griddetail.DataSource = null;
            error.Clear();
            bloqueartodo();
          
            limpiarcajas();
            limpiarDetalle();

            order = new Purchaseorders(session1);
            order_detail = new XPCollection(session1, typeof(Purchaseorderdetails));

            session1.RollbackTransaction();
            btnuevo.Enabled = true;
            btregistrar.Enabled = false;
            btcancelar.Enabled = false;
           
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Purchaseorders or= (Purchaseorders)gridView2.GetRow(e.FocusedRowHandle);
            visualizar_detail.Criteria = CriteriaOperator.Parse("purchaseOrder_id=" + or.purchaseOrder_id+ "");
            gridvisualizarDetalle.DataSource = visualizar_detail;
         
          
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            griddetail.DataSource = null;
            desbloqueartodo();
            order = new Purchaseorders(session1);
            order.PurchaseorderdetailsCollection.DisplayableProperties = "product_id.name;unitPrice;unitsOrdered;Subtotal;IVA;Total";

            if (session1.InTransaction == false)
            {
                session1.BeginTransaction();
            }
            btregistrar.Enabled = true;
            btnuevo.Enabled = false;
            btcancelar.Enabled = true;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(gridView2.FocusedRowHandle.ToString());
            Purchaseorders pur =(Purchaseorders) gridView2.GetRow(gridView2.FocusedRowHandle);
            session1.BeginTransaction();
            order = pur;
            griddetail.DataSource = order.PurchaseorderdetailsCollection ;
            ctnumeroOrden.Text = order.purchaseOrderNumber;
            ctFechaOrden.Text = order.orderDate.ToString();
            ctFechaEnvio.Text = order.shipDate.ToString();
            ctDescripOrden.Text = order.purchaseOrderDescription;
            ctFechaPrometida.Text = order.datePromised.ToString();
            ctGastoEnvio.Text = order.freightCharge.ToString();

            desbloqueartodo();
            btcancelar.Enabled = true;
            btregistrar.Enabled = true;
            btnuevo.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          // Purchaseorderdetails det =(Purchaseorderdetails) gridView1.GetRow(e.FocusedRowHandle);
          // searchProductoView.SetFocused
           
            
          ////  searchProductoView.SetFocusedValue(det.product_id);
          //  ctprecioUnitario.Text = det.unitPrice.ToString();
          //  ctcantidadOrdena.Text = det.unitsOrdered.ToString();
        
        }

        private void bteliminarDetalle_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            { return;
            }

            Purchaseorderdetails det =(Purchaseorderdetails) gridView1.GetRow(gridView1.FocusedRowHandle);
            if (det == null)
            { return; }
            order.PurchaseorderdetailsCollection[gridView1.FocusedRowHandle].Delete();
           // order.PurchaseorderdetailsCollection.Remove(det);
          //  MessageBox.Show(order.PurchaseorderdetailsCollection.Count.ToString());

        }

        private void searchProducto_Enter(object sender, EventArgs e)
        {
            error.Clear();
        }

    
      

     
    }