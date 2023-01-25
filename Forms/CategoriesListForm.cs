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
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo.DB;

namespace Inventory.Forms
{
    public partial class CategoriesListForm : BaseList
    {
        
        private bool ErrorPresent;
        private bool RecordSaved;
        private string prefixCode;
        public CategoriesListForm()
        {
            InitializeComponent();
        }
       
        private void customizeGridControls()
        { 
            //gridCategories.EmbeddedNavigator.NavigatableControl.Get
        }
        
        private void barLargeBtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            gridCategories.RefreshDataSource();
        }

        private void gridViewCategories_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
            view.ClearColumnErrors();
            e.ErrorText = "";
            string code = Convert.ToString(view.GetRowCellValue(e.RowHandle, "code"));
            if (code == string.Empty)
            {
                e.ErrorText = "Código no puede ser vacío. ";
            }
            //else this.prefixCode = code;
            string name = Convert.ToString(view.GetRowCellValue(e.RowHandle, "name"));
            if (name == string.Empty)
            {
                e.ErrorText = "No se admite valor vacío para el nombre de la categoría. ";
            }
            if (e.ErrorText != string.Empty)
            {
                e.Valid = false;
            }            
        }

        private void gridViewCategories_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }
        protected override void OnSaveRecordClicked()
        {   
            gridViewCategories.CloseEditor();           
            if(gridViewCategories.UpdateCurrentRow() && prefixCode!=string.Empty){
                CreateSequence(prefixCode);
                base.OnSaveRecordClicked();                
            }                      
        }

        private void gridViewCategories_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)sender;
            //GridColumn column = view.FocusedColumn;
            //e.ErrorText = "";
            //if (column.FieldName == "code")
            //{
            //    //column code can't be empty
            //    string code = Convert.ToString(e.Value).Trim();
            //    if (code == string.Empty)
            //    {
            //        e.Valid = false;
            //        e.ErrorText = "Código no puede ser vacío";
            //    }
            //    else {
            //        this.prefixCode = code;
            //    }
            //}
            //else if (column.FieldName == "name")
            //{
            //    if (e.Value == null || Convert.ToString(e.Value) == string.Empty)
            //    {
            //        e.Valid = false;
            //        e.ErrorText = "No se admite valor vacío";
            //    }
            //}
            //else { e.Valid = true; ErrorPresent = false; }
        }

        private void gridViewCategories_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            ErrorPresent = true;
        }

        private void CreateSequence(string seqname) {
            try
            {
                String query = String.Format("select count(*) from sequence_data where name = '{0}'", seqname);
                object o = unitOfWork.ExecuteScalar(query);

                if (Convert.ToInt32(o) == 0)
                {
                    Sequence_data sequence = new Sequence_data(unitOfWork);
                    sequence.name = seqname;
                    sequence.increment = sequence.min_value = 1;
                    sequence.max_value = 9999999;
                    sequence.cur_value = 1;
                    sequence.Save();
                    //unitOfWork.CommitChanges();
                }
            }
            catch (Exception ex) { }     
        }
        private void gridViewCategories_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {            
            try
            {
               Category c = e.Row as Category;
               this.prefixCode = c.code;
            }
            catch (Exception ex) { }  
        }

        private void gridViewCategories_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            RecordSaved = false;
            ErrorPresent = false;
        }             
    }
}
