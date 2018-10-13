using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModel
{

    public partial class Products
    {
        public Products(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
