using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace MMS.DAL.PL
{
   
    public partial class frm_Restore : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        SqlCommand sqlcmd;
        public frm_Restore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtfile.Text = opn.FileName;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Query = "ALTER DATABASE [MallManagement] set offline with rollback immediate;Restore Database [MallManagement] from disk='" + txtfile.Text + "'";
            con.Open();

            sqlcmd = new SqlCommand(Query, con);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Restore is done Successfuly :)) ", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

 

       
    }
}