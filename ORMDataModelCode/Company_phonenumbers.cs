using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Inventory.ORMDataModelCode
{

    public partial class Company_phonenumbers
    {
        public Company_phonenumbers(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}