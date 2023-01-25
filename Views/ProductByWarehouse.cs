using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace Inventory.Views
{
    [Persistent(@"vproductsbywarehouse")]
    public class ProductByWarehouse : XPLiteObject
    {
        [Key, Persistent, Browsable(false)]
        public ProductByWarehouseKey Key;   
    
        public string productcode {
            get { return Key.productcode; }
        }
        [Persistent("name")]
        public string name;

        [Persistent("brandname")]
        public string brandname;

        [Persistent("serialnumber")]
        public string serialnumber;

        [Persistent("quantityInHand")]
        public int totalStock;

        [Persistent("status")]
        public string status;
        [Persistent("warehouse")]
        public string warehouse;

        [Persistent("purchasedate")]
        public DateTime purchasedate;
        
        public ProductByWarehouse(Session session) : base(session) { }
    }
    public struct ProductByWarehouseKey
    {
        [Persistent("wh_id"), Browsable(false)]
        public int wid;
        [Persistent("productcode"), Browsable(false)]
        public string productcode;
    }
    //public class ProductByWarehouse : XPLiteObject
    //{
    //    [Key, Persistent, Browsable(false)]
    //    public ProductByWarehouseKey Key;
    //    public string productcode {
    //        get { return Key.productcode; }
    //    }
    //    public string name {
    //        get { return Key.name; }
    //    }
    //    public string brandname {
    //        get { return Key.brandname; }
    //    }
    //    public string serialnumber {
    //        get { return Key.serialnumber; }
    //    }
    //    public int totalStock {
    //        get { return Key.quantity; }
    //    }
    //    public int whid {
    //        get { return Key.wh_id; }
    //    }      
    //    public string status {
    //        get { return Key.status; }
    //    }
    //    public string warehouse {
    //        get { return Key.warehouse; }
    //    }
    //    public DateTime purchasedate {
    //        get { return Key.purchasedate; }
    //    }
    //    public ProductByWarehouse(Session session) : base(session) { }
    //}
    //public struct ProductByWarehouseKey {
    //    [Persistent("productcode"), Browsable(false)]
    //    public string productcode;
    //    [Persistent("name"), Browsable(false)]
    //    public string name;
    //    [Persistent("brandname"), Browsable(false)]
    //    public string brandname;
    //    [Persistent("serialnumber"), Browsable(false)]
    //    public string serialnumber;
    //    [Persistent("quantityInHand"), Browsable(false)]
    //    public int quantity;       
    //    [Persistent("status"), Browsable(false)]
    //    public string status;
    //    [Persistent("wh_id"), Browsable(false)]
    //    public int wh_id;
    //    [Persistent("warehouse"), Browsable(false)]
    //    public string warehouse;
    //    [Persistent("purchasedate"), Browsable(false)]
    //    public DateTime purchasedate;
    //}    
}
