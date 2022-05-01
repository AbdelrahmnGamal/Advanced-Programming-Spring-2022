using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.CrystalReports;

namespace MMS.PL
{
    public partial class frm_Order : DevExpress.XtraEditors.XtraForm
    {
        public frm_Order()
        {
            InitializeComponent();

         
            CreateDataTable();
            ResizeTabel();
            fillCustomer();
        }

        void fillCustomer()
        {
            cmb_customer.DataSource = DataManager.GetDataSet("sp_getAllCutomer", "Cust").Tables["Cust"];

            cmb_customer.DisplayMember = "name";
            cmb_customer.ValueMember = "customer_id";
            cmb_customer.Text = "Choose an Customer !";
        }


        public int Order_id;
        Boolean isSelected = false;
        public void GetInitialPrice()
        {
            if (txtQty.Text != string.Empty && txtPrice.Text != string.Empty)
            {

                txtAmount.Text = (Convert.ToInt32(txtQty.Text) * Convert.ToDouble(txtPrice.Text)).ToString();

            }

        }
        public double GetAllPrice()
        {
            double Total = Convert.ToDouble(txtAmount.Text);
            try
            {

                double discount;
                double amount = Convert.ToDouble(txtAmount.Text);

                if (txtDiscount.Text == string.Empty)
                {
                    discount = 0;
                }
                else
                {
                    discount = Convert.ToDouble(txtDiscount.Text);
                }
                Total = amount - (amount * discount / 100);


            }

            catch
            {

            }
            return Total;
        }
        void Clear()
        {
            txtQty.Text = txtIDproduct.Text = txtNameProduct.Text = txtPrice.Text = txtDiscount.Text = txtAmount.Text = txtTotalAmount.Text ="";

        }
        void CreateDataTable()
        {


            dt.Columns.Add("Product_id");
            dt.Columns.Add("Product_Name ");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("QuantityPrice ");
            dt.Columns.Add("Discount ");
            dt.Columns.Add("TotalAmount");



             dgvProducts.DataSource = dt;
            dgvProducts.Columns[6].Visible = true;

        }
        void ResizeTabel()
        {
            this.dgvProducts.RowHeadersWidth = 100;
            this.dgvProducts.Columns[0].Width = 81;
            this.dgvProducts.Columns[1].Width = 203;
            this.dgvProducts.Columns[2].Width = 85;
            this.dgvProducts.Columns[3].Width = 96;
            this.dgvProducts.Columns[4].Width = 83;
            this.dgvProducts.Columns[5].Width = 108;
            this.dgvProducts.Columns[5].Width = 76;
        }
        DataTable dt = new DataTable();

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DAL.PL.productsList prd_list = new DAL.PL.productsList();
            prd_list.ShowDialog();
            prd_list.StartPosition = FormStartPosition.CenterParent;
                  txtNameProduct.Text  = prd_list.gridView1.GetFocusedDataRow()["name"].ToString();
                   txtIDproduct.Text = prd_list.gridView1.GetFocusedDataRow()["product_id"].ToString();
                   txtPrice .Text = prd_list.gridView1.GetFocusedDataRow()["sale_price"].ToString();
                   txtQty.Focus();



 
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)
            {
                txtQty.Focus();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty)
            {
                txtDiscount.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {
                txtAmount.Text = "";
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text == string.Empty)
            {
                txtAmount.Text = "";
            }
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            if (txtDiscount.Text == string.Empty)
            {

                txtTotalAmount.Text = txtAmount.Text;
                txtSumTotals.Text =

          (from DataGridViewRow row in dgvProducts.Rows
           where row.Cells[6].FormattedValue.ToString() != string.Empty
           select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {



            if (txtOrderID.Text == "" || txtSalesMan.Text == "" || cmb_customer.Text == "Choose an Customer !")
            {
                MessageBox.Show("please Enter The Info Order ", "missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isSelected)
            {
                MessageBox.Show("please Choose items first !","Missing data",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
            {
                BL.Order.Add_orderDetails(

            Convert.ToInt32(txtOrderID.Text),
               dgvProducts.Rows[i].Cells[0].Value.ToString(),
 
                  Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value),
                  dgvProducts.Rows[i].Cells[2].Value.ToString(),
                  dgvProducts.Rows[i].Cells[5].Value.ToString(),
                   dgvProducts.Rows[i].Cells[4].Value.ToString(),
                   dgvProducts.Rows[i].Cells[6].Value.ToString()
                   );
            }
            BL.Order.Add_Order(int.Parse(txtOrderID.Text), dtOrder.Value, int.Parse(cmb_customer.SelectedValue.ToString()), Program.Emp_name,txtSumTotals.Text);

            MessageBox.Show("Order is saved successfully ", "Order Saves", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            btn_Save.Enabled  =false;
            btnClear.Enabled = true;
            btnPrint.Enabled = true;

        }

        private void frm_Order_TextChanged(object sender, EventArgs e)
        {
            GetInitialPrice();

        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQty.Text != string.Empty && txtPrice.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                txtTotalAmount.Text = GetAllPrice().ToString();
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty && txtQty.Text != string.Empty)
            {

                if (BL.Order.VerifyQte(txtIDproduct.Text, Convert.ToInt32(txtQty.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("Quantity that You choosed not existing in Stock !","missing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {

                    if (dgvProducts.Rows[i].Cells[0].Value.ToString() == txtIDproduct.Text)
                    {
                        Clear();
                        MessageBox.Show("stop ! , this Product is selected later ! ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }

                }

                isSelected = true;
                DataRow Row = dt.NewRow();
                Row[0] = txtIDproduct.Text;
                Row[1] = txtNameProduct.Text;
                Row[2] = txtPrice.Text;
                Row[3] = txtQty.Text;
                Row[4] = txtAmount.Text;
                if (txtDiscount.Text == string.Empty)
                {
                    Row[5] = "0";
                }
                else
                {
                    Row[5] = txtDiscount.Text;
                }

                Row[6] = txtTotalAmount.Text;
                dt.Rows.Add(Row);
                dgvProducts.DataSource = dt;


                txtSumTotals.Text =

                         (from DataGridViewRow row in dgvProducts.Rows
                          where row.Cells[6].FormattedValue.ToString() != string.Empty
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                Clear();
                btnBrowse.Focus();

            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            GetInitialPrice();

        }

        private void frm_Order_Load(object sender, EventArgs e)
        {
            txtSalesMan.Text = Program.Emp_name;
            cmb_customer.Text = "Choose a Customer !";
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

            try
            {
                txtOrderID.Text = BL.Order.GetLastOrderID().Rows[0][0].ToString();
                btn_Save.Enabled = true;
                btnClear.Enabled = false;
                //txtTotalAmount.Text = txtAmount.Text = txtPrice.Text = txtDiscount.Text = txtQty.Text = txtIDproduct.Text =txtNameProduct.Text= string.Empty;
                Order_id = int.Parse(txtOrderID.Text);
                Clear();
                dt.Clear();
                cmb_customer.Text = "choose a customer !";

            }
            catch (Exception)
            {
                
             }
         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
                txtSumTotals.Text =

                      (from DataGridViewRow row in dgvProducts.Rows
                       where row.Cells[6].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            try
            {
                txtSumTotals.Text =

          (from DataGridViewRow row in dgvProducts.Rows
           where row.Cells[6].FormattedValue.ToString() != string.Empty
           select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
            catch (Exception)
            {
                
              
            }

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            GetInitialPrice();
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Report.RptOrder rpt_order = new Report.RptOrder();
            Report.RptViewer frm  = new Report.RptViewer();
            rpt_order.SetDataSource(BL.Order.GetOrderSetails(Order_id));
            frm.crystalReportViewer1.ReportSource = rpt_order;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.PL.frm_AddCustomer frm_customer = new DAL.PL.frm_AddCustomer();
            frm_customer.ShowDialog();
            fillCustomer();
        }
    }
}