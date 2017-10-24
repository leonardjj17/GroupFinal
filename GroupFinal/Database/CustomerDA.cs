using System;
using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class CustomerDA
    {
        public static Customer GetCustomerByLogin(String login)
        {
            Customer c = new Customer();

            SqlConnection connection = Connection.getConnection();
            if (connection != null)
            {
                connection.Open();
            }
            if (login == null) return null;

            String query = "SELECT * FROM Customer WHERE Role IN ('Customer') AND login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                c.CustomerID = (int)read["customerID"];
                c.PrimaryStore = (String)read["primaryStore"];
                c.CustomerFirst = (String)read["customerFirst"];
                c.CustomerLast = (String)read["customerLast"];
                c.CustomerAddress = (String)read["customerAddress"];
                c.CustomerCity = (String)read["customerCity"];
                c.CustomerState = (String)read["customerState"];
                c.CustomerZip = (String)read["customerZip"];
                c.CustomerRole = (String)read["role"];
                c.CustomerLogin = (String)read["login"];
                c.CustomerPassword = (String)read["password"];

            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return c;
        }



    }
}