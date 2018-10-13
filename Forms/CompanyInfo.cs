using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using Inventory.ORMDataModelCode;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace Inventory.Forms
{
    public partial class CompanyInfo : DevExpress.XtraEditors.XtraForm
    {        
        private Company company;
        //private bool isRowHeaderSelected = false;
        //UnitOfWork uow;
        public CompanyInfo()
        {
            InitializeComponent();
            PostInitializeComponet();
            BindingControls();
        }
        private void PostInitializeComponet() {
            //uow = new UnitOfWork();
            company = uow.FindObject<Company>(CriteriaOperator.Parse("company_id=1"));
            if (company == null)
                company = new Company(uow);   
        }
        private void BindingControls()
        {
            txtCompanyName.DataBindings.Add("EditValue",company, "companyName");
            memoEditAddress.DataBindings.Add("EditValue", company, "address");
            txtCity.DataBindings.Add("EditValue", company, "city");
            txtDepartment.DataBindings.Add("EditValue", company, "department");
            txtCountry.DataBindings.Add("EditValue", company, "country");
            pictureEditLogo.DataBindings.Add("EditValue", company, "logo");
            txtWebsite.DataBindings.Add("EditValue", company, "website");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try {
                //company.Save();
                uow.CommitChanges();
                MessageBox.Show("Información de la Empresa guardada", "Inventario CyCSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                uow.RollbackTransaction();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (uow.InTransaction)
                uow.RollbackTransaction();
            this.Close();
        }

        private void PhoneGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            Company_phonenumbers cp = PhoneBindingSource.Current as Company_phonenumbers;
            if (cp != null) {
                cp.company_id = company;
                company.Company_phonenumbers.Add(cp);
            }
        }

        private void PhoneGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn phoneNumber = view.Columns["phoneNumber"];
            GridColumn phoneCarrier = view.Columns["phonecarrier!"];
            string phonenumber = (string)view.GetRowCellValue(e.RowHandle, phoneNumber);
            Phonecarrier carrier = (Phonecarrier)view.GetRowCellValue(e.RowHandle, phoneCarrier);
                  
            if (phonenumber== null ) {                
                e.Valid = false;                
                view.SetColumnError(phoneNumber, "Ingrese un número de teléfono");                
            }
            if(carrier==null){
                e.Valid =false;                
                view.SetColumnError(phoneCarrier, "Seleccione una compañia telefónica");
            }
        }

        
    }
}