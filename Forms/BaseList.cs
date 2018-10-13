using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Inventory.Forms
{
    public partial class BaseList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseList()
        {
            InitializeComponent();
        }

        private void SaveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnSaveRecordClicked();
        }

        protected virtual void OnSaveRecordClicked()
        {
            try
            {
                MainBindingSource.EndEdit();
                unitOfWork.Save(MainBindingSource);
                unitOfWork.CommitChanges();
                MessageBox.Show("Transacción completada", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void CancelBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnCancelClicked();            
        }

        protected virtual void OnCancelClicked()
        {
            try
            {
                this.MainBindingSource.CancelEdit();
                unitOfWork.RollbackTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnReloadClicked();
        }

        public virtual void OnReloadClicked()
        {
            try
            {
                unitOfWork.DropIdentityMap();
                xpMainCollection.Reload();                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnEditClicked();
        }

        protected virtual void OnEditClicked()
        { }

        private void NewBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNewClicked();
        }

        protected virtual void OnNewClicked()
        { }

        private void PrintBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnPrintClicked();
        }

        protected virtual void OnPrintClicked()
        {        
        }

        protected virtual void OnDeleteClicked() {
            try
            {
                DevExpress.Xpo.XPBaseObject obj = this.MainBindingSource.Current as DevExpress.Xpo.XPBaseObject;
                if (obj != null)
                {
                    obj.Delete();
                    unitOfWork.CommitChanges();
                }                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnDeleteClicked();
        }        
    }
}