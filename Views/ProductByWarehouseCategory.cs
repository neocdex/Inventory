using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.ComponentModel;

namespace Inventory.Views
{
    [Persistent(@"vproductsbywarehousecategory")]
    public class ProductByWarehouseCategory : XPLiteObject 
    {
        [Key, Persistent, Browsable(false)]
        public ProductByWarehouseCatKey Key;
        public int product_id {
            get { return Key.product_id; }
        }
        [Persistent("category")]
        public string category;
        [Persistent("productcode")]
        public string productcode;
        [Persistent("product")]
        public string product;
        [Persistent("serialnumber")]
        public string serialnumber;
        [Persistent("abbr")]
        public string abbr;
        [Persistent("quantityInHand")]
        public double quantityInHand;
        [Persistent("warehouse")]
        public string warehouse;        
        public ProductByWarehouseCategory(Session session) : base(session) { }
    }
    public struct ProductByWarehouseCatKey
    {
        [Persistent("wid"), Browsable(false)]
        public int wid;
        [Persistent("product_id"), Browsable(false)]
        public int product_id;
    }
}
