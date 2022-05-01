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
    public partial class frm_ManageProducts : DevExpress.XtraEditors.XtraForm
    {
        public frm_ManageProducts()
        {
            InitializeComponent();
            fillDept();
            RefreshItemsGrid();

        }

        bool isSelected = false;
        public void RefreshItemsGrid()
        {

            //      gridView1.DataSource = BL.products.GetAllProducts().Tables["items"];

            gridControl1.DataSource = BL.products.GetAllProducts().Tables["items"];


            DataTable dt = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];

            // MessageBox.Show(dt.Rows.Count.ToString());


        }
        void fillDept()
        {

            //  fillDeptCombo
            cmb_Dept.DataSource = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];
            cmb_Dept.DisplayMember = "name";
            cmb_Dept.ValueMember = "dept_id";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            isSelected = true;
            txt_name.Text = gridView1.GetFocusedDataRow()["name"].ToString();
            txt_id.Text = gridView1.GetFocusedDataRow()["product_id"].ToString();
            txt_price.Text = gridView1.GetFocusedDataRow()["payement_price"].ToString();
            txt_sell.Text = gridView1.GetFocusedDataRow()["sale_price"].ToString();
            txt_quantity.Text = gridView1.GetFocusedDataRow()["quantity"].ToString();
            timeEdit1.Text = gridView1.GetFocusedDataRow()["expire_date"].ToString();
            cmb_Dept.Text = gridView1.GetFocusedDataRow()["Department Name"].ToString();

            if (Program.Emp_name!="AbdElRahman Gamal")
            {
                btn_update.Enabled = btn_delete.Enabled = true;  
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            

            if (isSelected)
            {
                BL.products.UpdateItem(txt_id.Text, txt_name.Text, Convert.ToInt32(txt_price.Text), Convert.ToInt32(txt_sell.Text), Convert.ToInt32(txt_quantity.Text), timeEdit1.Time,

         Convert.ToInt32(cmb_Dept.SelectedValue.ToString())

         );

                MessageBox.Show("Item "+txt_name.Text+"  is updated Successfuly","Successful operations",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                RefreshItemsGrid();

                btn_delete.Enabled = btn_update.Enabled = false;
            
            }
            else
            {
                MessageBox.Show("please Select item First To update ;) ","Miss Data",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }




        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure from deleting this items ?","sure ?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
            {

                BL.products.DeleteItem(txt_id.Text);
                MessageBox.Show("Item is Deleted Successfulty","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RefreshItemsGrid();

            }
            else
            {
                MessageBox.Show("Deleting Operation  is Canceled Successfulty, ","Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        private void btn_printSelected_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
                Report.rptProduct rpt_product = new Report.rptProduct();
            Report.RptViewer frm = new Report.RptViewer();

            string id_product = txt_id.Text;
            rpt_product.SetDataSource(BL.products.GetSelectedItems(id_product).Tables["items"]);
            frm.crystalReportViewer1.ReportSource = rpt_product;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void btn_PrintAll_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Report.rptAllProducts rpt_order = new Report.rptAllProducts();
            Report.RptViewer frm = new Report.RptViewer();

           
            rpt_order.SetDataSource(BL.products.GetAllProducts());
            frm.crystalReportViewer1.ReportSource = rpt_order;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void frm_ManageProducts_Load(object sender, EventArgs e)
        {
            if (Program.Emp_name=="AbdElRahman Gamal")
            {

                btn_printSelected.Enabled = true;
                btn_PrintAll.Enabled = true;
            }

            btn_delete.Enabled = btn_update.Enabled = false;




        }

        private void frm_ManageProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        }
       
    }
 