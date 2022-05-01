using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MMS.DAL.PL
{
    public partial class productsList : DevExpress.XtraEditors.XtraForm
    {
        public productsList()
        {
            InitializeComponent();
            GetAllItems();
        }
        public void GetAllItems()
        {

            gridControl1.DataSource = BL.products.GetAllProducts().Tables["items"];
             
 
        }
  


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}