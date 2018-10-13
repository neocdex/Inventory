using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Xpo;


namespace Inventory.Forms
{
    public partial class BaseDetail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BaseDetail()
        {
            InitializeComponent();
        }

        private void NewRecordBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNewRecordClicked();
        }

        protected virtual void OnNewRecordClicked()
        {
            this.MainBindingSource.AddNew();
        }

        private void SaveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnSaveClicked();
        }

        protected virtual void OnSaveClicked()
        {
            try
            {
                this.MainBindingSource.EndEdit();
                unitOfWork.CommitChanges();
                MessageBox.Show("¡Item guardado!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (DevExpress.Xpo.DB.Exceptions.ConstraintViolationException e)
            {
               MessageBox.Show("Clave duplicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                unitOfWork.RollbackTransaction();
            }
        }

        private void DeleteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            XPLiteObject o = this.MainBindingSource.Current as XPLiteObject;
            if (o != null) {
                o.Delete();
            }
        }

        private void FirstBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnFirstClicked();
        }

        protected virtual void OnFirstClicked()
        {
            if (MainBindingSource.Current != null)
                MainBindingSource.MoveFirst();
        }

        private void PreviousBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnPreviousClicked();
        }

        protected virtual void OnPreviousClicked()
        {
            if (this.MainBindingSource.Current != null && this.MainBindingSource.Position - 1 >= 0)
                MainBindingSource.MovePrevious();
        }

        private void NextBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNextClicked();
        }

        protected virtual void OnNextClicked()
        {
            if (this.MainBindingSource.Current != null && this.MainBindingSource.Position + 1 <= this.MainBindingSource.Count)
                MainBindingSource.MoveNext();
        }

        private void LastBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnLastClicked();
        }

        protected virtual void OnLastClicked()
        {
            if (this.MainBindingSource.Current != null)
                this.MainBindingSource.MoveLast();
        }

        private void CancelBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnCancelClicked();
        }

        protected virtual void OnCancelClicked()
        {
            MainBindingSource.CancelEdit();
            unitOfWork.RollbackTransaction();
        }

        public virtual void SetItem(XPBaseObject item) { }

        public virtual void OnNewClicked() {
            MainBindingSource.AddNew();
        }

        private void NewBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnNewClicked();
        }

        private void PrintBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnPrintClicked();
        }

        protected virtual void OnPrintClicked()
        {
            
        }
    }
}