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

    [Persistent(@"company")]
    public partial class Company : XPLiteObject
    {
        int fcompany_id;
        [Key(true)]
        public int company_id
        {
            get { return fcompany_id; }
            set { SetPropertyValue<int>("company_id", ref fcompany_id, value); }
        }
        string fcompanyName;
        [Size(150)]
        public string companyName
        {
            get { return fcompanyName; }
            set { SetPropertyValue<string>("companyName", ref fcompanyName, value); }
        }
        string fwebsite;
        [Size(150)]
        public string website
        {
            get { return fwebsite; }
            set { SetPropertyValue<string>("website", ref fwebsite, value); }
        }
        string faddress;
        [Size(300)]
        public string address
        {
            get { return faddress; }
            set { SetPropertyValue<string>("address", ref faddress, value); }
        }
        string fcity;
        [Size(50)]
        public string city
        {
            get { return fcity; }
            set { SetPropertyValue<string>("city", ref fcity, value); }
        }
        string fdepartment;
        [Size(50)]
        public string department
        {
            get { return fdepartment; }
            set { SetPropertyValue<string>("department", ref fdepartment, value); }
        }
        string fcountry;
        [Size(25)]
        public string country
        {
            get { return fcountry; }
            set { SetPropertyValue<string>("country", ref fcountry, value); }
        }
        byte[] flogo;
        [Size(SizeAttribute.Unlimited)]
        public byte[] logo
        {
            get { return flogo; }
            set { SetPropertyValue<byte[]>("logo", ref flogo, value); }
        }
        [Association(@"Company_phonenumbersReferencesCompany")]
        public XPCollection<Company_phonenumbers> Company_phonenumbers { get { return GetCollection<Company_phonenumbers>("Company_phonenumbers"); } }
    }

}