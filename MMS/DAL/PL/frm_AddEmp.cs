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
    public partial class frm_AddEmp : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddEmp()
        {
            InitializeComponent();
          
        }

        void FillDept()
        {
            cmbDept.DataSource = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];
            cmbDept.DisplayMember = "name";
            cmbDept.ValueMember = "dept_id";
            cmbDept.Text = "Choose Department";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_Adress.Text==""&&txt_FirstName.Text==""&&txt_LastName.Text==""&&txt_Passwrod.Text==""

                && txt_UserName.Text == "" && txt_Telephone.Text == "" && cmbDept.Text == "Choose Department" && cmbManager.Text == ""
                
                )
            {

                MessageBox.Show("please Ensert All Information First then Add The Employee","Failed",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            if (Convert.ToInt32(txtsalary.Text) < 1200)
            {
                MessageBox.Show("please age must be larger than Or Equal 1200 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;

            }

            if (Convert.ToInt32(se_Age.Text) < 20)
            {
                MessageBox.Show("please age must be larger than 20 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //if all condition true will add
 
            bool manager;//get true or false
            string gender;//get male or female

                if (ts_Gender.IsOn)
	{
		 gender=ts_Gender.Properties.OnText; //male
	}
else
	{
                    gender=ts_Gender.Properties.OffText;//female
	}

                if (cmbManager.Text=="Yes")
                {
                    manager = true;  //manager
                }
                else
                {
                    manager = false; //not manager
                }

         
                 //DataManager.ExecuteNonQuery("sp_addEmp",
                 //   DataManager.CreateParameters("@firstName", SqlDbType.NVarChar, txt_FirstName.Text),
                 //                DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, txt_LastName.Text),
                 //   DataManager.CreateParameters("@age", SqlDbType.Int, Convert.ToInt32(se_Age.Text)),
                 //   DataManager.CreateParameters("@adress", SqlDbType.NVarChar, txt_Adress.Text),
                 //   DataManager.CreateParameters("@tele", SqlDbType.NVarChar, txt_Telephone.Text),
                 //   DataManager.CreateParameters("@gender", SqlDbType.NVarChar, gender),
                 //   DataManager.CreateParameters("@manager", SqlDbType.Bit, manager),
                 //     DataManager.CreateParameters("@dept_id", SqlDbType.Int, Convert.ToInt32(cmbDept.SelectedValue.ToString())),
                 //       DataManager.CreateParameters("@userName", SqlDbType.NVarChar, txt_UserName.Text),
                 //         DataManager.CreateParameters("@pw", SqlDbType.NVarChar, txt_Passwrod.Text)

                 //   );

                BL.Employee.InsertEmployee(txt_FirstName.Text, txt_LastName.Text, Convert.ToInt32(se_Age.Text), txt_Adress.Text, txt_Telephone.Text, gender, manager, Convert.ToInt32(cmbDept.SelectedValue.ToString()), txt_UserName.Text, txt_Passwrod.Text,int.Parse(txtsalary.Text));

                MessageBox.Show("New Employee is added Successfuly","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
        }

        private void frm_AddEmp_Load(object sender, EventArgs e)
        {
            FillDept();
        }

        private void txt_Passwrod_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
          txt_Adress.Text=txt_FirstName.Text=txt_LastName.Text=txt_Passwrod.Text=

                  txt_UserName.Text =   txt_Telephone.Text = cmbManager.Text ="";
              cmbDept.Text = "Choose Department";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            PL.frm_AddDept frm_Dept = new frm_AddDept();
            frm_Dept.ShowDialog();
            FillDept();
          


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