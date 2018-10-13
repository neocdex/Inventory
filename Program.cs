using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventory.Forms;
using Inventory.ORMDataModelCode;
using DevExpress.XtraBars.Ribbon;


namespace InventoryLaquisa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Establish connection to database
            try
            {
                //ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
                Inventory.Utils.Setup.Settings();

                RibbonForm form = new MainForm();

                Application.Run(form);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Inventario - CyCSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
