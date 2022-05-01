using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MMS.BL
{
    class products
    {

        public static void addNewItem(string id_product,string name,int payment_price,int sale_price,int quantity,DateTime Expire,int dept_id)
        {
 
            DataManager.ExecuteNonQuery("sp_addItem",

           DataManager.CreateParameters("@product_id", System.Data.SqlDbType.NVarChar,id_product),
            DataManager.CreateParameters("@name", System.Data.SqlDbType.NVarChar,name),
                 DataManager.CreateParameters("@payment_price", System.Data.SqlDbType.Int,payment_price),
                 DataManager.CreateParameters("@sales_price", System.Data.SqlDbType.Int,sale_price),
                 DataManager.CreateParameters("@quantity", System.Data.SqlDbType.Int,quantity),
                 DataManager.CreateParameters("@expire_data", System.Data.SqlDbType.DateTime,Expire),
                 DataManager.CreateParameters("@dept_id", System.Data.SqlDbType.Int,dept_id)
                
               
                );
  
        }
        public static void UpdateItem(string id_product, string name, int payment_price, int sale_price, int quantity, DateTime Expire, int dept_id)
        {

            DataManager.ExecuteNonQuery("sp_updateItem",

           DataManager.CreateParameters("@product_id", System.Data.SqlDbType.NVarChar, id_product),
            DataManager.CreateParameters("@name", System.Data.SqlDbType.NVarChar, name),
                 DataManager.CreateParameters("@payment_price", System.Data.SqlDbType.Int, payment_price),
                 DataManager.CreateParameters("@sales_price", System.Data.SqlDbType.Int, sale_price),
                 DataManager.CreateParameters("@quantity", System.Data.SqlDbType.Int, quantity),
                 DataManager.CreateParameters("@expire_data", System.Data.SqlDbType.DateTime, Expire),
                 DataManager.CreateParameters("@dept_id", System.Data.SqlDbType.Int, dept_id)


                );

        }

        public static void DeleteItem(string Product_id)
        {


            DataManager.ExecuteNonQuery("sp_deleteItem",

                DataManager.CreateParameters("@product_id", System.Data.SqlDbType.NVarChar, Product_id));

        }


        public static  DataSet GetAllProducts()
        {

            return DataManager.GetDataSet("sp_getAllitems", "items");

        }

        public static DataSet GetSelectedItems(string id_product)
        {

            return DataManager.GetDataSet("sp_getSelectedProduct", "items",

                DataManager.CreateParameters("@id_product", SqlDbType.NVarChar, id_product)
                );

        }

        public static DataSet GetProductQte(int qte)
        {

 
            return DataManager.GetDataSet("sp_getProductQuantity", "Qte",


                DataManager.CreateParameters("@Quantity", SqlDbType.Int, qte)
                );


        }

    }
}
