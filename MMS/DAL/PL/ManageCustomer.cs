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
    public partial class ManageCustomer : DevExpress.XtraEditors.XtraForm
    {
        public ManageCustomer()
        {
            InitializeComponent();
            RefreshCustomer();

        }
        void RefreshCustomer()
        {
            gridControl1.DataSource = BL.Customer.GetAllCustomer().Tables["AllCustomer"];

        }
        Boolean isSelected = false;
        string id_customer;
        string gender;

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            isSelected = true;
            id_customer = gridView1.GetFocusedDataRow()["customer_id"].ToString();
            txt_FirstName.Text = gridView1.GetFocusedDataRow()["first_name"].ToString();
            txt_LastName.Text = gridView1.GetFocusedDataRow()["last_name"].ToString();
            se_Age.Text = gridView1.GetFocusedDataRow()["age"].ToString();
            txt_Telephone.Text = gridView1.GetFocusedDataRow()["tele"].ToString();
            ts_Gender.Text = gridView1.GetFocusedDataRow()["gender"].ToString();
            txt_Adress.Text = gridView1.GetFocusedDataRow()["address"].ToString();
            cmb_pay.Text = gridView1.GetFocusedDataRow()["Pay_method"].ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
                 if (ts_Gender.IsOn)
	{
		 gender=ts_Gender.Properties.OnText;
	}
            else
	{
                		 gender=ts_Gender.Properties.OffText;

	}
                 //if (Convert.ToInt32(se_Age.Text) < 20)
                 //{
                 //    MessageBox.Show("please age must be larger than 20 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 //    return;
                 //}
            if (isSelected)
            {


                BL.Customer.UpdateCustomer(Convert.ToInt32(id_customer), txt_FirstName.Text, txt_LastName.Text, Convert.ToInt32(se_Age.Text), txt_Adress.Text, txt_Telephone.Text, gender, cmb_pay.Text);

                MessageBox.Show("Selected Customer is updated Successsfuly","done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                RefreshCustomer();
            }
            else
            {
                MessageBox.Show("please select any Customer first to update him :)", "done", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            //if (Convert.ToInt32(se_Age.Text)<20)
            //{
            //    MessageBox.Show("please age must be larger than 20 ","Fail",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            //    return;
            //}


            if (isSelected)
            {
                if (MessageBox.Show("Are You sure from this Deleting Operation ?", "Sure ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {

                    BL.Customer.deleteCustomer(Convert.ToInt32(id_customer));
                    MessageBox.Show("Deleting the selected Customer is done  :)", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCustomer();
                }
                else
                {
                    MessageBox.Show("Deleting is canceled :)", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("please select any Customer first to Delete him :)", "done", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
       


        }

        private void txt_Adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}