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
    public partial class frm_AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
            cmb_pay.Text = "Choose PaymentMethod";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Adress.Text == "" || txt_FirstName.Text == "" || txt_LastName.Text == "" ||  

                 txt_Telephone.Text == ""    || cmb_pay.Text==""

              )
            {

                MessageBox.Show("please Ensert All Information First then Add The Cutomer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

          
            //if (Convert.ToInt32(se_Age.Text) < 20)
            //{
            //    MessageBox.Show("please age must be larger than 20 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            //if all condition true will add

             string gender;//get male or female

            if (ts_Gender.IsOn)
            {
                gender = ts_Gender.Properties.OnText; //male
            }
            else
            {
                gender = ts_Gender.Properties.OffText;//female
            }

            BL.Customer.InsertCustomer(txt_FirstName.Text, txt_LastName.Text, Convert.ToInt32(se_Age.Text), txt_Adress.Text, txt_Telephone.Text, gender, cmb_pay.Text);

            MessageBox.Show("New Cutomer is added Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

         


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Adress.Text = txt_FirstName.Text = txt_LastName.Text =
                se_Age.Text = 
                txt_Telephone.Text = "";
                cmb_pay.Text = "Choose PaymentMethod";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}