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
namespace Inventory.ORMDataModel {

	[Persistent(@"category")]
	public partial class Category : XPLiteObject {
		int fcategory_id;
		[Key(true)]
		public int category_id {
			get { return fcategory_id; }
			set { SetPropertyValue<int>("category_id", ref fcategory_id, value); }
		}
		string fname;
		[Size(45)]
		public string name {
			get { return fname; }
			set { SetPropertyValue<string>("name", ref fname, value); }
		}
		string fdescription;
		[Size(500)]
		public string description {
			get { return fdescription; }
			set { SetPropertyValue<string>("description", ref fdescription, value); }
		}
		[Association(@"ProductsReferencesCategory", typeof(Products))]
		public XPCollection<Products> ProductsCollection { get { return GetCollection<Products>("ProductsCollection"); } }
	}

}
