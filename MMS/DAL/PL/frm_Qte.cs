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
    public partial class frm_Qte : DevExpress.XtraEditors.XtraForm
    {
        public frm_Qte()
        {
            InitializeComponent();
        }

        private void btn_showRpt_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Report.rpt_ProductQte rpt_ProductQte = new Report.rpt_ProductQte();
            Report.RptViewer frm = new Report.RptViewer();
            rpt_ProductQte.SetDataSource(BL.products.GetProductQte(int.Parse(txtQte.Text)).Tables["Qte"]);
            frm.crystalReportViewer1.ReportSource = rpt_ProductQte;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}