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
    public partial class frm_AddNewItem : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddNewItem()
        {
            InitializeComponent();
            fillDept();
            RefreshItemsGrid();

        }


        void clear()
        {

            txt_id.Text = txt_name.Text = txt_price.Text = txt_quantity.Text = txt_sell.Text = string.Empty;
            cmb_Dept.Text = "Choose a Depratment";



        }
        Boolean isSelected=false;
        public void RefreshItemsGrid()
        {
 
      //      gridView1.DataSource = BL.products.GetAllProducts().Tables["items"];

            gridControl1.DataSource = BL.products.GetAllProducts().Tables["items"];

           
               DataTable dt=   DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];

      // MessageBox.Show(dt.Rows.Count.ToString());
           

        }
        void fillDept()
        {

            //  fillDeptCombo
            cmb_Dept.DataSource = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];
            cmb_Dept.DisplayMember = "name";
            cmb_Dept.ValueMember = "dept_id";
        }

      

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            if (txt_name.Text=="" ||txt_price.Text==""||txt_quantity.Text==""||txt_sell.Text==""||txt_id.Text==""||cmb_Dept.Text=="")
            {
                            MessageBox.Show("please, Fill Info Completely first ","Operation Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return;
            }

            BL.products.addNewItem(txt_id.Text, txt_name.Text,Convert.ToInt32( txt_price.Text), Convert.ToInt32(txt_sell.Text),Convert.ToInt32( txt_quantity.Text), timeEdit1.Time,

                Convert.ToInt32(cmb_Dept.SelectedValue.ToString())

                );

            MessageBox.Show("Items is added Successfuly ","Operation Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clear();
            RefreshItemsGrid();

        }

        private void frm_AddNewItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mallManagementDataSet.Products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter.Fill(this.mallManagementDataSet.Products);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            //txt_name.Text = gridView1.GetFocusedDataRow()["name"].ToString();
            //txt_id.Text = gridView1.GetFocusedDataRow()["product_id"].ToString();
            //txt_price.Text = gridView1.GetFocusedDataRow()["payement_price"].ToString();
            //txt_sell.Text = gridView1.GetFocusedDataRow()["sale_price"].ToString();
            //txt_quantity.Text = gridView1.GetFocusedDataRow()["quantity"].ToString();
            //timeEdit1.Text = gridView1.GetFocusedDataRow()["expire_date"].ToString();
            //cmb_Dept.Text =  gridView1.GetFocusedDataRow()["Department Name"].ToString();




            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_sell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


    }
}