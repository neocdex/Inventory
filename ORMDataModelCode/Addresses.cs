using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Addresses
    {
        public Addresses(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
