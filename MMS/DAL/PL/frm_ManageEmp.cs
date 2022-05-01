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
    public partial class frm_ManageEmp : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        int id_emp;//get id of selection name
        string gender; //get gender depend on or off case 
        bool manager=false; //get if manager or no depend on Yes or No



        void ClearDate()
        {

    cmbDept.Text=   cmbManager.Text=     txt_Adress.Text = txt_FirstName.Text = txt_LastName.Text = txt_Passwrod.Text = txt_Telephone.Text = txt_UserName.Text = txtsalary.Text = string.Empty;
            se_Age.Text = string.Empty;


            cmbEmp.Text = "Choose the Employee ! ";
        }
        void fillEmpNames()
        {
            //fillNameCombo
            cmbEmp.DataSource = DataManager.GetDataSet("sp_getAllEmpName", "EmpNames").Tables["EmpNames"];
            cmbEmp.DisplayMember = "first_name";
            cmbEmp.ValueMember = "employee_id";
            cmbEmp.Text = "Choose Employee Name";
        }
        void fillDept()
        {

          //  fillDeptCombo
              cmbDept.DataSource = DataManager.GetDataSet("sp_getAllDept", "Dept").Tables["Dept"];
              cmbDept.DisplayMember = "name";
              cmbDept.ValueMember = "dept_id";
        }

        public frm_ManageEmp()
        {
            InitializeComponent();
           // flag = true;
            cmbEmp.Text = "Choose Employee Name";
          
        }

        private void frm_ManageEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.dataSet2.Employee);
            //// TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.dataSet1.Employee);
             fillEmpNames();
            fillDept();

            //
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.employeeTableAdapter1.FillBy(this.dataSet2.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                 id_emp = Convert.ToInt32(cmbEmp.SelectedValue.ToString());

                DataRow[] Emp = DataManager.GetDataSet("sp_GetAllEmp", "Names").Tables["Names"].Select("employee_id=" + id_emp); 

                if (Emp.Length > 0)
                {
                    txt_FirstName.Text = Emp[0]["first_name"].ToString();
                    txt_LastName.Text = Emp[0]["last_name"].ToString();
                    se_Age.Text = Emp[0]["age"].ToString();
                    txt_Adress.Text = Emp[0]["adress"].ToString();
                    txt_Telephone.Text = Emp[0]["tele"].ToString();
                    txtsalary.Text = Emp[0]["salary"].ToString();

        string Gender=    Emp[0]["gender"].ToString();

                    if (Gender=="Male")
                    {
                   
                    ts_Gender.IsOn=false;
                    }
                    else
                    {
                         ts_Gender.IsOn=true;
                

                    }
                    if ((bool)Emp[0]["manager"])
                    {
                        cmbManager.Text = "Yes";
                     }
                    else
                    {
                        cmbManager.Text = "No";
                    }

              //      MessageBox.Show(Emp[0]["name"].ToString());
                    cmbDept.Text = Emp[0]["name"].ToString();
                    txt_UserName.Text = Emp[0]["userName"].ToString();
                    txt_Passwrod.Text = Emp[0]["pw"].ToString();

                }
            }






        } 

        private void frm_ManageEmp_Shown(object sender, EventArgs e)
        {
            flag = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (ts_Gender.IsOn)
	{
		 gender=ts_Gender.Properties.OnText;
	}
            else
	{
                		 gender=ts_Gender.Properties.OffText;

	}
   if (cmbManager.Text=="Yes")
	{
		 manager=true;
	}
 

            /*
             @id_emp int,
	 @firstName nvarchar(50),
	 @lastName nvarchar(50),
	 @age int,
	 @adress nvarchar(50),
	 @tele nvarchar(50),
	 @gender  nvarchar(50),
	 @manager bit ,
	 @dept_id int,
	 @userName nvarchar(50),
	 @pw nvarchar(50)
            */
    //        DataManager.ExecuteNonQuery("sp_updateEmp",
                
    //            DataManager.CreateParameters("@id_emp", SqlDbType.Int,  id_emp),
    //            DataManager.CreateParameters("@firstName", SqlDbType.NVarChar,    txt_FirstName.Text),
    //DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, txt_LastName.Text ),
    //DataManager.CreateParameters("@age", SqlDbType.Int,  Convert.ToInt32(se_Age.Text)),
    //DataManager.CreateParameters("@adress", SqlDbType.NVarChar, txt_Adress.Text  ),
    //DataManager.CreateParameters("@tele", SqlDbType.NVarChar,    txt_Telephone.Text),
    //DataManager.CreateParameters("@gender", SqlDbType.NVarChar,    gender),
    //DataManager.CreateParameters("@manager", SqlDbType.Bit,    manager),
    //    DataManager.CreateParameters("@dept_id", SqlDbType.Int, Convert.ToInt32(cmbDept.SelectedValue.ToString())),
    //  DataManager.CreateParameters("@userName", SqlDbType.NVarChar,    txt_UserName.Text),
    //    DataManager.CreateParameters("@pw", SqlDbType.NVarChar,    txt_Passwrod.Text)

                
                
    //            );

   if (Convert.ToInt32(se_Age.Text) < 20)
   {
       MessageBox.Show("please age must be larger than 20 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
       return;
   }

   if (Convert.ToDouble(txtsalary.Text) <1200.0000 )
   {
              MessageBox.Show("please age must be larger than Or Equal 1200 ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
       return;

   }
   BL.Employee.update_Employee(id_emp, txt_FirstName.Text, txt_LastName.Text, Convert.ToInt32(se_Age.Text), txt_Adress.Text, txt_Telephone.Text, gender, manager, Convert.ToInt32(cmbDept.SelectedValue.ToString()), txt_UserName.Text, txt_Passwrod.Text,Convert.ToDouble(txtsalary.Text));

            MessageBox.Show("Employee Information is updated","successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearDate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure That You Want To Delete this Employee ?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== System.Windows.Forms.DialogResult.Yes)
            {
                //DataManager.ExecuteNonQuery("sp_deleteEmp",


                //    DataManager.CreateParameters("@id_emp", SqlDbType.Int,id_emp)
                //    );

                BL.Employee.DeleteEmp(id_emp);
                MessageBox.Show("Employee"+cmbEmp.Text +"is deleted","done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fillEmpNames();
                ClearDate();
            }
            else
            {
                MessageBox.Show("Deleting operation is canceled ","Cancle deleting", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

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

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}