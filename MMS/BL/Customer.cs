using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class Customer
    {
        public static void InsertCustomer(string F_name, string L_name, int age, string address, string tele, string gender,string Payment_method)
        {

            DataManager.ExecuteNonQuery("sp_addCustomer",
                    DataManager.CreateParameters("@firstName", SqlDbType.NVarChar, F_name),
                                 DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, L_name),
                    DataManager.CreateParameters("@age", SqlDbType.Int, age),
                    DataManager.CreateParameters("@adress", SqlDbType.NVarChar, address),
                    DataManager.CreateParameters("@tele", SqlDbType.NVarChar, tele),
                    DataManager.CreateParameters("@gender", SqlDbType.NVarChar, gender),
                        DataManager.CreateParameters("@paymentMethod", SqlDbType.NVarChar, Payment_method)
                          );

        }
        public static void UpdateCustomer(int id_Customer,string F_name, string L_name, int age, string address, string tele, string gender, string Payment_method)
        {

            DataManager.ExecuteNonQuery("sp_updateCustomer",
                DataManager.CreateParameters("@id_customer", SqlDbType.Int, id_Customer),
                    DataManager.CreateParameters("@firstName", SqlDbType.NVarChar, F_name),
                                 DataManager.CreateParameters("@lastName", SqlDbType.NVarChar, L_name),
                    DataManager.CreateParameters("@age", SqlDbType.Int, age),
                    DataManager.CreateParameters("@adress", SqlDbType.NVarChar, address),
                    DataManager.CreateParameters("@tele", SqlDbType.NVarChar, tele),
                    DataManager.CreateParameters("@gender", SqlDbType.NVarChar, gender),
                        DataManager.CreateParameters("@paymentMethod", SqlDbType.NVarChar, Payment_method)
                          );

        }


        public static void deleteCustomer(int id_Customer )
        {

            DataManager.ExecuteNonQuery("sp_DeleteCustomer",
                DataManager.CreateParameters("@id_customer", SqlDbType.Int, id_Customer)
                   
                          );

        }

        public static DataSet GetAllCustomer()
        {

            return DataManager.GetDataSet("sp_GetAllCustomer", "AllCustomer");



        }

    }
}
