using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Unitofmeasure
    {
        public Unitofmeasure(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
