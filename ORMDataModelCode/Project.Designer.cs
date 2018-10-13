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

    [Persistent(@"project")]
    public partial class Project : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>("id", ref fid, value); }
        }
        string fname;
        [Size(255)]
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>("name", ref fname, value); }
        }
        string fdescription;
        [Size(255)]
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>("description", ref fdescription, value); }
        }
        string fmanager;
        [Size(60)]
        public string manager
        {
            get { return fmanager; }
            set { SetPropertyValue<string>("manager", ref fmanager, value); }
        }
        DateTime fstartdate;
        public DateTime startdate
        {
            get { return fstartdate; }
            set { SetPropertyValue<DateTime>("startdate", ref fstartdate, value); }
        }
        DateTime fenddate;
        public DateTime enddate
        {
            get { return fenddate; }
            set { SetPropertyValue<DateTime>("enddate", ref fenddate, value); }
        }
        [Association(@"WarehouseReferencesProject")]
        public XPCollection<Warehouse> Warehouses { get { return GetCollection<Warehouse>("Warehouses"); } }
    }

}
