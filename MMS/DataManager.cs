using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Collections;


public class DataManager
{

    #region ConnectionString
    /// <summary>
    /// Connection String with DataBase that U specified 
    /// </summary>
  // static string ConnectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

   static string ConnectionString = @"Data Source=.\;Initial Catalog=MallManagement;Integrated Security=True";

   static SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\;Initial Catalog=MallManagement;Integrated Security=True");
    #endregion


    #region DisConnect_ModelWith_DataBase
    /// <summary>
    /// DisConnect Model With DataBase
    ///  Return The Specified Data From Original DB And Putting it In the DataSet In the Memory To DealWith  with it Not Original DataBase 
    ///  then, Save To Original  DataBase
    /// </summary>
    /// <param name="Stored_Name">Stored_Name : Enter The Name of the Stored Procedure</param>
    /// <param name="Tabel_Name">Table_Name :Enter The Table Name That stored in the Memory</param>
    /// <param name="parameters">Parameters : Enter The Parameters that used in Stored Procedure </param>
    /// <returns>Return the Data set that include the table in the Memory </returns>

    public static DataSet GetDataSet(string Stored_Name, string Tabel_Name, params SqlParameter[] parameters)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(Stored_Name, con);
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.Add(param);
        }
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds, Tabel_Name);

        return ds;
    }
    #endregion


    #region Connect_ModelWith_DataBase
    /// <summary>
    /// Connect_Model With DataBase 
    /// Return The DataReader That Have The tabels bu Using Query
    /// </summary>
    /// <param name="stored_Name">Stored_Name : Enter The Name of the Stored Procedure</param>
    /// <param name="connectionOut"> Return The Refrence of the Current Openning Connection To Close From </param>
    /// <param name="parameters">Parameters : Enter The Parameters that used in Stored Procedure</param>
    /// <returns> Return The DataReader to Deal With Data Retrived From  Your Query </returns>
    public static SqlDataReader GetDataReader(string stored_Name, out SqlConnection connectionOut, params SqlParameter[] parameters)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(stored_Name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.Add(param);
        }
        con.Open();
        SqlDataReader DReader = cmd.ExecuteReader();

        connectionOut = con;
        return DReader;
    }
    /// <summary>
    /// Connect_ModelWith DataBase 
    /// use it to Insert , update or Delete  without Return object from DataBase
    /// </summary>
    /// <param name="stored_Name">Stored_Name : Enter The Name of the Stored Procedure</param>
    /// <param name="parameters">Parameters : Enter The Parameters that used in Stored Procedure</param>
    /// <returns> </returns>
    public static int ExecuteNonQuery(string stored_Name, params SqlParameter[] parameters)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(stored_Name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.Add(param);
        }
        con.Open();
        int Effects = cmd.ExecuteNonQuery();
        con.Close();
        return Effects;

    }
    /// <summary>
    /// connect_Model with DataBase 
    /// Use This Function To doing insert, update ,delete and return from dataBase only one value 
    /// </summary>
    /// <param name="Stored_Name">Stored_Name : Enter The Name of the Stored Procedure</param>
    /// <param name="parameters">Parameters : Enter The Parameters that used in Stored Procedure</param>
    /// <returns></returns>
    public static object ExecuteScalar(string Stored_Name, params SqlParameter[] parameters)
    {
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd = new SqlCommand(Stored_Name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.Add(param);
        }
        con.Open();
        object scaler = cmd.ExecuteScalar();

        con.Close();
        return scaler;
    }
    /// <summary>
    /// connect_Model with DataBase 
    /// Use This Function To doing insert, update ,delete and return from dataBase but More Than one Value 
    /// </summary>
    /// <param name="stored_Name">Stored_Name : Enter The Name of the Stored Procedure</param>
    /// <param name="parameters">Parameters : Enter The Parameters that used in Stored Procedure</param>
    /// <returns></returns>
    public static Hashtable ExecuteNonQueryOutPut(string stored_Name, params SqlParameter[] parameters)
    {

        SqlConnection sqlcon = new SqlConnection(ConnectionString);
        SqlCommand sqlcmd = new SqlCommand(stored_Name, sqlcon);
        sqlcmd.CommandType = CommandType.StoredProcedure;

        foreach (SqlParameter param in parameters)
        {
            sqlcmd.Parameters.Add(param);
        }
        sqlcon.Open();

        int x = sqlcmd.ExecuteNonQuery();

        Hashtable ht = new Hashtable();
        foreach (SqlParameter param in parameters)
        {
            if (param.Direction == ParameterDirection.Output)
            {
                ht.Add(param.ParameterName, param.Value);
            }
        }
        sqlcon.Close();

        return ht;


    }
    #endregion

    public static DataTable SelectData(string Stored_Procedure, params SqlParameter[] Param)
    {
        SqlCommand SqlCmd = new SqlCommand();
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.CommandText = Stored_Procedure;
        SqlCmd.Connection = sqlConnection;
        if (Param != null)
        {
            for (int i = 0; i < Param.Length; i++)
            {

                SqlCmd.Parameters.Add(Param[i]);
            }

        }

        SqlDataAdapter da = new SqlDataAdapter(SqlCmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
    }


    #region Create Input_OutPut Parameters
    /// <summary>
    /// To do Input  Parameters 
    /// To create parameters Tha Accept type,Name,Value
    /// </summary>
    /// <param name="Parameters_Name">Parameters_Name: Enter The Name Of sqlParameters </param>
    /// <param name="Parameters_Type">Parameters_Type :Enter The Parameter sqlParameters </param>
    /// <param name="Parameters_Value">Parameters_Value :Enter The Object Value of sqlParameters</param>
    /// <returns></returns>

    public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, object Parameters_Value)
    {
        SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
        sqlParam.Value = Parameters_Value;
        return sqlParam;
    }

    /// <summary>
    /// To do OutPut  Parameters 
    ///  To create parameters Tha Accept type,Name,Direction 
    /// </summary>
    /// <param name="Parameters_Name">Parameters_Name: Enter The Name Of sqlParameters</param>
    /// <param name="Parameters_Type">Parameters_Type :Enter The Parameter sqlParameters</param>
    /// <param name="Parameters_Direction">Parameters_Direction: Determind The Type of Your Parameter Input Parameters ,OutPutParameters</param>
    /// <returns></returns>
    public static SqlParameter CreateParameters(string Parameters_Name, SqlDbType Parameters_Type, ParameterDirection Parameters_Direction)
    {
        SqlParameter sqlParam = new SqlParameter(Parameters_Name, Parameters_Type);
        sqlParam.Direction = Parameters_Direction;
        return sqlParam;
    }
    #endregion
}



