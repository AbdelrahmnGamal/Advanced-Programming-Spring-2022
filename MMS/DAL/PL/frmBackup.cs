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
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MallManagement;Integrated Security=True");
        SqlCommand sqlcmd;
        public frmBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtfile.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string Pathe = txtfile.Text + "\\MallManagement" + DateTime.Now.ToShortDateString().Replace('/', '_') + DateTime.Now.ToShortTimeString().Replace(':', '_');

            string Query = "Backup Database [MallManagement] To Disk = '" + Pathe + ".bak'";

            con.Open();

            sqlcmd = new SqlCommand(Query, con);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("The backup is done successfully", "backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}