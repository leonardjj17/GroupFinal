using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class StoreDA
    {
    //    public static List<Store> GetAllStores()
    //    {
    //        List<Store> allStores = new List<Store>();

    //        SqlConnection connection = Connection.getConnection();

    //        String query = "SELECT * FROM Stores";
    //        SqlCommand cmd = new SqlCommand(query, connection);


    //        try
    //        {
    //            connection.Open();
    //            SqlDataReader read = cmd.ExecuteReader();

    //            while (read.Read())
    //            {
    //               //Store st = new Store();

    //                //e.EmployeeID = (int)read["employeeID"];
    //                //e.StoreNum = (String)read["storeNum"];
    //                //e.EmployeeFirst = (String)read["employeeFirst"];
    //                //e.EmployeeLast = (String)read["employeeLast"];
    //                //e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
    //                //e.EmployeeStatus = (String)read["empl"];
    //                //e.EmployeeRole = (String)read["role"];
    //                //e.Login = (String)read["login"];
    //                //e.password = (String)read["password"];

    //               // allStores.Add(st);
    //            }
    //        }
    //        catch (SqlException ex)
    //        {

    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //        finally
    //        {
    //            connection.Close();
    //        }
    //        return allStores;
    //    }
    }
}