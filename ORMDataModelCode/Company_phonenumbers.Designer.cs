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
using System.Collections.Generic;
using System.ComponentModel;
namespace Inventory.ORMDataModelCode
{

    [Persistent(@"company_phonenumbers")]
    public partial class Company_phonenumbers : XPLiteObject
    {
        int fidCompany_PhoneNumbers;
        [Key(true)]
        public int idCompany_PhoneNumbers
        {
            get { return fidCompany_PhoneNumbers; }
            set { SetPropertyValue<int>("idCompany_PhoneNumbers", ref fidCompany_PhoneNumbers, value); }
        }
        Company fcompany_id;
        [Association(@"Company_phonenumbersReferencesCompany")]
        public Company company_id
        {
            get { return fcompany_id; }
            set { SetPropertyValue<Company>("company_id", ref fcompany_id, value); }
        }
        Phonecarrier fphonecarrier;
        [Association(@"Company_phonenumbersReferencesPhonecarrier")]
        public Phonecarrier phonecarrier
        {
            get { return fphonecarrier; }
            set { SetPropertyValue<Phonecarrier>("phonecarrier", ref fphonecarrier, value); }
        }
        string fphoneNumber;
        [Size(15)]
        public string phoneNumber
        {
            get { return fphoneNumber; }
            set { SetPropertyValue<string>("phoneNumber", ref fphoneNumber, value); }
        }
        bool fisCellular;
        public bool isCellular
        {
            get { return fisCellular; }
            set { SetPropertyValue<bool>("isCellular", ref fisCellular, value); }
        }
        bool factive;
        public bool active
        {
            get { return factive; }
            set { SetPropertyValue<bool>("active", ref factive, value); }
        }
    }

}
