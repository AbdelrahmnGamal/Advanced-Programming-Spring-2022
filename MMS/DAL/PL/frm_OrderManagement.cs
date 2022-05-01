using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MMS.PL
{
    public partial class frm_OrderManagement : DevExpress.XtraEditors.XtraForm
    {
        public frm_OrderManagement()
        {
            InitializeComponent();
            gridControl1.DataSource = BL.Order.SearchOrder("");
        }

        Boolean isSelected = false;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                MessageBox.Show("please select an order first ","Missing",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Report.RptOrder rpt_order = new Report.RptOrder();
            Report.RptViewer frm = new Report.RptViewer();

            int id_order=Convert.ToInt32   (gridView1.GetFocusedDataRow()["order_id"].ToString());
            rpt_order.SetDataSource(BL.Order.GetOrderSetails(id_order));
            frm.crystalReportViewer1.ReportSource = rpt_order;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void txtkey_TextChanged(object sender, EventArgs e)
        {
            if (txtkey.Text!=string.Empty)
            {
                gridControl1.DataSource = BL.Order.SearchOrder(txtkey.Text);
            }
            else
            {
                gridControl1.DataSource = BL.Order.SearchOrder("");

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            isSelected = true;
        }

        private void frm_OrderManagement_Load(object sender, EventArgs e)
        {
            
        }

       
     
      

       
    }
}