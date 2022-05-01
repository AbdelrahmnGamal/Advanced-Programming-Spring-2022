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
    public partial class frm_Reports : DevExpress.XtraEditors.XtraForm
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            Report.rptAllEmployee rptAllEmployee = new Report.rptAllEmployee();
            Report.RptViewer frm = new Report.RptViewer();

       //     int id_order = Convert.ToInt32(gridView1.GetFocusedDataRow()["order_id"].ToString());
            rptAllEmployee.SetDataSource(BL.Employee.GetAllEmployee().Tables["Emp"]);
            frm.crystalReportViewer1.ReportSource = rptAllEmployee;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MMS.PL.frm_ManageProducts frm_manageProduct = new MMS.PL.frm_ManageProducts();
            frm_manageProduct.btn_update.Enabled = frm_manageProduct.btn_delete.Enabled = false;
            frm_manageProduct.btn_printSelected.Enabled = frm_manageProduct.btn_PrintAll.Enabled = true;
            frm_manageProduct.ShowDialog();
            this.Cursor = Cursors.Default;


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MMS.PL.frm_OrderManagement frm_orderManagerment = new MMS.PL.frm_OrderManagement();
            frm_orderManagerment.ShowDialog();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Report.rptEmpSalary rptEmpSalary = new Report.rptEmpSalary();
            Report.RptViewer frm = new Report.RptViewer();
            rptEmpSalary.SetDataSource(BL.Employee.GetCountSalary().Tables["count"]);
            frm.crystalReportViewer1.ReportSource = rptEmpSalary;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
         //   count
            this.Cursor = Cursors.WaitCursor;
            Report.rptOrderSum rptOrderSum = new Report.rptOrderSum();
            Report.RptViewer frm = new Report.RptViewer();
            rptOrderSum.SetDataSource(BL.Order.GetOrderSum().Tables["count"]);
            frm.crystalReportViewer1.ReportSource = rptOrderSum;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_Qte frm_qte = new frm_Qte();
            frm_qte.ShowDialog();
        }

        private void frm_Reports_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}