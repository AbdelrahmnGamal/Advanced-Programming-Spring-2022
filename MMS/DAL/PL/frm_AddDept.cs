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
    public partial class frm_AddDept : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddDept()
        {
            InitializeComponent();
            FillManager();

        }
        void FillManager()
        {
            cmbManager.DataSource = DataManager.GetDataSet("sp_getManager", "Manager_id").Tables["Manager_id"];
            cmbManager.DisplayMember = "Name";
            cmbManager.ValueMember = "employee_id";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_DeptName.Text = cmbManager.Text = "";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (txt_DeptName.Text == "" || cmbManager.Text == "")
            {
                MessageBox.Show("please Enter Data in correct way First", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //DataManager.ExecuteNonQuery("sp_addDept",

                //    DataManager.CreateParameters("dept_Name", SqlDbType.NVarChar, txt_DeptName.Text),
                //    DataManager.CreateParameters("@manager_id", SqlDbType.Int, Convert.ToInt32(cmb_DeptManager.Text))


                //    );

                BL.Department.add_Department(txt_DeptName.Text, Convert.ToInt32(cmbManager.SelectedValue.ToString()));


                MessageBox.Show("Deptartment is added sucessful", "Operation add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frm_AddDept_Load(object sender, EventArgs e)
        {
            cmbManager.Text = "Choose Department Manager ";

        }
    }
}