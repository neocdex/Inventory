using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Localization;

namespace Inventory.Utils
{
    public class SpGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Buscar";
            if (id == GridStringId.FindControlClearButton)
                return "Limpiar";
            if (id == GridStringId.ColumnViewExceptionMessage)
                return "¿Desea corregir el valor?";
            //if(id == GridStringId.
            return base.GetLocalizedString(id);
        }
    }
}
