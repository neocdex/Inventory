using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.ComponentModel;

namespace Inventory.Views
{
    [Persistent(@"vProductsByWarehouseCategory")]
    public class ProductByWarehouseCategory : XPLiteObject 
    {
        [Key, Persistent, Browsable(false)]
        public ProductByWarehouseCategoryKey Key;
        public string category{
            get { return Key.category; }   
        }       
        public int product_id{
            get { return Key.product_id; }
        }
        public string productcode {
            get { return Key.productcode; }
        }
        public string product { get { return Key.product; } }
        public string abbr {
            get { return Key.abbr; }
        }        
        public double qtyInHand {
            get { return Key.quantityInHand; }
        }        
        public string warehouse {
            get { return Key.warehouse; }
        }        
        public ProductByWarehouseCategory(Session session) : base(session) { }
    }

    public struct ProductByWarehouseCategoryKey {
        [Persistent("category"), Browsable(false)]
        public string category;
        [Persistent("product_id"), Browsable(false)]
        public int product_id;
        [Persistent("productcode"), Browsable(false)]
        public string productcode;
        [Persistent("product"), Browsable(false)]
        public string product;
        [Persistent("abbr"), Browsable(false)]
        public string abbr;
        [Persistent("quantityInHand"), Browsable(false)]
        public double quantityInHand;
        [Persistent("warehouse"), Browsable(false)]
        public string warehouse;
    }
}
