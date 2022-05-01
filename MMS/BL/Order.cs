using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class Order
    {  

        public static void Add_Order(int order_id,DateTime dt,int customer_id,string emp_name,string total)
        {

           DataManager.ExecuteNonQuery("sp_addOrder",
               
               DataManager.CreateParameters("@order_id", System.Data.SqlDbType.Int,order_id),
                              DataManager.CreateParameters("@time", System.Data.SqlDbType.DateTime,dt),
                                             DataManager.CreateParameters("@customer_id", System.Data.SqlDbType.Int,customer_id),
                                                                                          DataManager.CreateParameters("@total", System.Data.SqlDbType.Money, total),

                                                            DataManager.CreateParameters("@employee_name", System.Data.SqlDbType.NVarChar,emp_name));

               
        }
        public static  DataTable GetLastOrderID()
        {


    
            DataTable dt = new DataTable();
            dt = DataManager.SelectData("GetLastOrderId", null);

            return dt;

        }

         
        public static void Add_orderDetails(int order_id,string id_product,int quantity,string price,string  discount,string  amount,string totalAmount )
        {
            DataManager.ExecuteNonQuery("sp_addOrderDetails",
             DataManager.CreateParameters("@order_id", System.Data.SqlDbType.Int, order_id),
                      DataManager.CreateParameters("@product_id", System.Data.SqlDbType.NVarChar, id_product),
             DataManager.CreateParameters("@quantity", System.Data.SqlDbType.Int, quantity),
             DataManager.CreateParameters("@price", System.Data.SqlDbType.Money, price),
             DataManager.CreateParameters("@discount", System.Data.SqlDbType.Float, discount),
             DataManager.CreateParameters("@amount", System.Data.SqlDbType.Money, amount),
             DataManager.CreateParameters("@total_amount", System.Data.SqlDbType.Money, totalAmount)

            );


        }
        public static  DataTable VerifyQte(string  id_Product, int Qte)
        {

           

        return    DataManager.SelectData("sp_VrifyQte",

                DataManager.CreateParameters("@Id_Product", SqlDbType.NVarChar, id_Product),
                DataManager.CreateParameters("@Qte", SqlDbType.Int, Qte)
                );

 

          
        }

          public static DataTable SearchOrder(string key)

        {

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@key", key);

            return DataManager.SelectData("sp_searchOrder", param);
        }

        public static DataTable GetOrderSetails(int order_id)
          {

          

                  SqlParameter[] param = new SqlParameter[1];
                  param[0] = new SqlParameter("@id_order", order_id);

                  return DataManager.SelectData("GetOrderDetails", param);
               

          }


        public static DataSet GetOrderSum()
        {


            return DataManager.GetDataSet("sp_orderSum", "count");
        }

    }
}
