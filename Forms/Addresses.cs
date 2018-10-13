using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModel
{

    public partial class Addresses
    {
        public Addresses() { }
        public Addresses(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
