using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Brand
    {
        public Brand(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
