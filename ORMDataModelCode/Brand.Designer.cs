//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Inventory.ORMDataModelCode
{

    [Persistent(@"brand")]
    public partial class Brand : XPLiteObject
    {
        int fBrand_id;
        [Key(true)]
        public int Brand_id
        {
            get { return fBrand_id; }
            set { SetPropertyValue<int>("Brand_id", ref fBrand_id, value); }
        }
        string fname;
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>("name", ref fname, value); }
        }
        [Association(@"ProductsReferencesBrand")]
        public XPCollection<Products> ProductsCollection { get { return GetCollection<Products>("ProductsCollection"); } }
    }

}
