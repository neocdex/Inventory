using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo.DB;

namespace Inventory.Forms
{
    public partial class FormUser : Form
    {
        private int tries;
        public FormUser()
        {
            InitializeComponent();
            tries = 1;
            this.AcceptButton = OKSimpleButton;
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();
            string sql = "Select username, password, rol from user where username='" + username + "' and password='" + password + "' and rol='admin'"; 
            SelectedData data = unitOfWork.ExecuteQuery(sql);
            SelectStatementResult []row = data.ResultSet;
            if (data != null && row[0].Rows.Length > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else if (tries == 3) {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            else
            {
                tries++;
                MessageBox.Show("El nombre de usuario o la contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
