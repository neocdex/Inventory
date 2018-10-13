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
        
        private bool ErrorAdd;
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
            GridColumn categoryName = gridViewCategories.Columns["name"];
            GridColumn categoryCode = gridViewCategories.Columns["code"];
            //gridViewCategories.ClearColumnErrors();
            //if(gridViewCategories.GetRowCellValue(e.RowHandle, categoryName) == null||
            //    gridViewCategories.GetRowCellDisplayText(e.RowHandle, categoryName) == string.Empty)
            //{
                
            //}
            //else{
                
            //}
        }

        private void gridViewCategories_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;            
        }
        protected override void OnSaveRecordClicked()
        {
            
            //revisar código porque da exepción si aún no se ha terminado de editar grid
            
            gridViewCategories.CloseEditor();
            if (!ErrorAdd)
            {
                gridViewCategories.UpdateCurrentRow();                
                base.OnSaveRecordClicked();
                try
                {
                    //obtener última categoría guardada, si no hay habido error
                    Category c = xpMainCollection[xpMainCollection.Count - 1] as Category;

                    Secuence_data secuence = new Secuence_data(unitOfWork);
                    secuence.name = c.name;
                    secuence.increment = secuence.min_value = 1;
                    secuence.max_value = 9999999;
                    secuence.cur_value = 1;
                    secuence.Save();
                    unitOfWork.CommitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridViewCategories_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewCategories.FocusedColumn.FieldName == "code")
            {
                //comprobar que no hay código duplicado
                string code = Convert.ToString(e.Value);
                if (code == string.Empty) {
                    e.Valid = false;
                    e.ErrorText = "Código no puede ser vacío";
                    return;
                }
                string sql = String.Format("Select category_id, code from Category where code = {0}", code);
                SelectedData resultset = unitOfWork.ExecuteQuery(sql);

                if (resultset != null && resultset.ResultSet[0].Rows.Length > 0)
                { //valor duplicado
                    e.Valid = false;
                    e.ErrorText = "Código duplicado";
                }
            }
            else if (gridViewCategories.FocusedColumn.FieldName == "name")
            {
                if (e.Value == null || Convert.ToString(e.Value) == string.Empty)
                {
                    e.Valid = false;
                    e.ErrorText = "No se admite valor vacío";
                }
            }
            else { e.Valid = true; ErrorAdd = false; }
        }

        private void gridViewCategories_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            ErrorAdd = true;
        }      
    }
}
