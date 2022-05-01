using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class Department
    {

        public static void add_Department(string txt_DeptName,int Deparment_manager)
        {

            DataManager.ExecuteNonQuery("sp_addDept",

                               DataManager.CreateParameters("dept_Name", SqlDbType.NVarChar, txt_DeptName),
                               DataManager.CreateParameters("@manager_id", SqlDbType.Int, Deparment_manager)


                               );

        }

        public static void update_Department(int id_dept,string Department_name,int Department_manager)
        {

            DataManager.ExecuteNonQuery("sp_UpdateDept",

                DataManager.CreateParameters("@Dept_id", SqlDbType.Int, id_dept),
                DataManager.CreateParameters("@dept_name", SqlDbType.NVarChar, Department_name),
                DataManager.CreateParameters("@manager_id", SqlDbType.Int, Department_manager));

        }

        public static void Delete_Deptarment(int id_Dept)
        {

            DataManager.ExecuteNonQuery("sp_deleteDept",
                DataManager.CreateParameters("@Dept_id", SqlDbType.Int, id_Dept));

        }



    }
}
