using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using Inventory.ORMDataModelCode;

namespace Inventory.Forms
{
    public partial class CategoryForm : Form
    {
        Session session;
        private Category category;        
        public CategoryForm(Session s)
        {
            InitializeComponent();
            session = s;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (validateForm())
            {
                try
                {
                    session.BeginTransaction();
                    if (!EditMode)
                        category = new Category(session);
                    
                    category.name = txtCategoryName.Text;
                    category.description = txtCategoryDescription.Text;
                    category.Save();
                    //}
                    session.CommitTransaction();
                    this.Close();
                }catch(Exception ex){
                    //Error                    
                    session.RollbackTransaction();
                    MessageBox.Show("Se ha producido un error al guardar el registro", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool validateForm()
        {
            bool isOk = true;
            //txtCategoryName.Select();
            //txtCategoryName.IsModified = true;
            //if (txtCategoryName.DoValidate()) isOk = true;
            //txtCategoryDescription.Select();
            //txtCategoryDescription.IsModified = true;
            //if (txtCategoryDescription.DoValidate()) isOk = true;
            return isOk;
        }
        public Category Category {
            set { category = value; }
        }
        public bool EditMode { set; get; }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (EditMode && category!=null) 
            {
                txtCategoryName.Text = category.name;
                txtCategoryDescription.Text = category.description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = string.IsNullOrEmpty(txtCategoryName.Text);
        }        
    }
}
