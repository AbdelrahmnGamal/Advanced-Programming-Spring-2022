using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class Login
    {

      public static DataTable login(string name,string pw)
        {

            return DataManager.SelectData("sp_EmpLogin",
                
                DataManager.CreateParameters("@user_name", SqlDbType.NVarChar, name),
                DataManager.CreateParameters("@pw", SqlDbType.NVarChar, pw)

                );


        }
               




    }
}
