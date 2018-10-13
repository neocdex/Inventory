using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModel
{

    public partial class Purchaseorderdetails
    {
        public Purchaseorderdetails(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
