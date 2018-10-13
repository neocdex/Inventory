using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Secuence_data
    {
        public Secuence_data(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
