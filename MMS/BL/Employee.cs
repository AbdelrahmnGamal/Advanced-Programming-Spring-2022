using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class Employee
    {

        public static void InsertEmployee(string F_name,string L_name, int age,string address,string tele,string gender,bool manager,int dept_id,string user_name,string pw,int salary)
        {

            DataManager.ExecuteNonQuery("sp_addEmp",
                    DataManager.CreateParameters("@firstName", SqlDbType.NVarChar, F_name),
                                 DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, L_name),
                    DataManager.CreateParameters("@age", SqlDbType.Int, age),
                    DataManager.CreateParameters("@adress", SqlDbType.NVarChar, address),
                    DataManager.CreateParameters("@tele", SqlDbType.NVarChar, tele),
                    DataManager.CreateParameters("@gender", SqlDbType.NVarChar, gender),
                    DataManager.CreateParameters("@manager", SqlDbType.Bit, manager),
                      DataManager.CreateParameters("@dept_id", SqlDbType.Int, dept_id),
                               DataManager.CreateParameters("@salary", SqlDbType.Money, salary),

                        DataManager.CreateParameters("@userName", SqlDbType.NVarChar, user_name),
                          DataManager.CreateParameters("@pw", SqlDbType.NVarChar, pw));

        }


         

        public static  void update_Employee (int id_emp,string F_name,string L_name, int age,string address,string tele,string gender,bool manager,int dept_id,string user_name,string pw,double  salary)
        {
            DataManager.ExecuteNonQuery("sp_updateEmp",

                DataManager.CreateParameters("@id_emp", SqlDbType.Int, id_emp),
                DataManager.CreateParameters("@firstName", SqlDbType.NVarChar, F_name),
    DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, L_name),
    DataManager.CreateParameters("@age", SqlDbType.Int, age),
    DataManager.CreateParameters("@adress", SqlDbType.NVarChar, address),
    DataManager.CreateParameters("@tele", SqlDbType.NVarChar, tele),
    DataManager.CreateParameters("@gender", SqlDbType.NVarChar, gender),
    DataManager.CreateParameters("@manager", SqlDbType.Bit, manager),
        DataManager.CreateParameters("@dept_id", SqlDbType.Int, dept_id),
         DataManager.CreateParameters("@salary", SqlDbType.Money, salary),
      DataManager.CreateParameters("@userName", SqlDbType.NVarChar, user_name),
        DataManager.CreateParameters("@pw", SqlDbType.NVarChar, pw));

        }

        public static void DeleteEmp(int id_emp)
        {
            DataManager.ExecuteNonQuery("sp_deleteEmp",


             DataManager.CreateParameters("@id_emp", SqlDbType.Int, id_emp)
             );
        }

        public static DataSet GetAllEmployee()
        {

      return      DataManager.GetDataSet("sp_GetAllEmployee", "Emp");
     
                
            
        }

        public static DataSet GetCountSalary()
        {

            return DataManager.GetDataSet("sp_GetEmpSumsalary", "count");


        }
    }
}
