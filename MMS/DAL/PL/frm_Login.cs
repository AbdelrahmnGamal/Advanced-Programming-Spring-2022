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
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = BL.Login.login(textEdit1.Text, textEdit2.Text);
            if (dt.Rows.Count> 0)
            {
                frm_Main frm_main = (frm_Main)Application.OpenForms["frm_Main"];

                MessageBox.Show("   login Successful   \n\n   Welcome  " + dt.Rows[0]["first_name"].ToString() +"  " + dt.Rows[0]["last_name"].ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_main.Alloperation.Enabled = true;
                Program.Emp_name = dt.Rows[0]["first_name"].ToString() + " " + dt.Rows[0]["last_name"].ToString();


                Program.isLogin = true;
                this.Close();

              }
            else
            {
                MessageBox.Show("Login Failed...........Enter Info again ","Fail",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Program.isLogin = false;
            }

        
          

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}