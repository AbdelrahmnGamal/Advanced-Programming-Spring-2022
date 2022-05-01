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
    public partial class frm_ManageDept : DevExpress.XtraEditors.XtraForm
    {
        public frm_ManageDept()
        {
            InitializeComponent();
            FillManager();
            fillDept();

            cmb_Departments.SelectedItem = "Choose Department Name";
            cmbManager.SelectedItem = "Choose Department Manager ";

        }
        void fillDept()
        {

            //  fillDeptCombo
            cmb_Departments.DataSource = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];
            cmb_Departments.DisplayMember = "name";
            cmb_Departments.ValueMember = "dept_id";
        }
        void FillManager()
        {
            cmbManager.DataSource = DataManager.GetDataSet("sp_getManager", "Manager_id").Tables["Manager_id"];
            cmbManager.DisplayMember = "Name";
            cmbManager.ValueMember = "employee_id";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txt_DepartmentName.Text!="" && cmbManager.Text!="")
            {
                BL.Department.update_Department(Convert.ToInt32(cmb_Departments.SelectedValue.ToString()), txt_DepartmentName.Text, Convert.ToInt32(cmbManager.SelectedValue.ToString()));
                MessageBox.Show("Deptarment is updated ","pass",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("please Enter Info Completely","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure From Delete "+cmb_Departments.Text,"Warnning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
	{
		         DataManager.ExecuteNonQuery("sp_deleteDept", DataManager.CreateParameters("@Dept_id", SqlDbType.Int,Convert.ToInt32(cmb_Departments.SelectedValue.ToString())));
            MessageBox.Show("Department  "+" "+cmbManager.Text,"Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
	}
            else
	{
                            MessageBox.Show("Operation  is Canceled ","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);

	}


    

        }

        private void frm_ManageDept_Load(object sender, EventArgs e)
        {
            cmb_Departments.Text = "Choose the DepartMent !";
            cmbManager.Text = "Choose the Manager !";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Departments.Text = "Choose the DepartMent !";
            cmbManager.Text = "Choose the Manager !";
            txt_DepartmentName.Text = string.Empty;
        }

    }
}