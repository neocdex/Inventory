using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class FormProjectsList : BaseList
    {
        public FormProjectsList()
        {
            InitializeComponent();
        }
        //public override void OnNewClicked()
        //{
        //    BaseDetail f = new FormProject();
        //    f.OnNewClicked();
        //    f.MdiParent = this.MdiParent;
        //    f.Show();
        //}

        protected override void OnNewClicked()
        {
            BaseDetail f = new FormProject();
            f.OnNewClicked();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
