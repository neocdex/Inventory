using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Stored
    {
        public Stored(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
