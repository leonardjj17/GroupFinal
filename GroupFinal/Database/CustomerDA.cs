using System;
using GroupFinal.DA;
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

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> allCustomers = new List<Customer>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Customer c = new Customer();

                    c.CustomerID = (int)read["customerID"];
                    c.CustomerFirst = (String)read["customerFirst"];
                    c.CustomerLast = (String)read["customerLast"];
                    c.CustomerPhone = (String)read["customerPhone"];
                    c.CustomerAddress = (String)read["cusstomerAddress"];
                    c.CustomerCity = (String)read["customerCity"];
                    c.CustomerState = (String)read["customerState"];
                    c.CustomerZip = (String)read["customerZip"];
                    c.CustomerRole = (String)read["Role"];
                    c.CustomerLogin = (String)read["Login"];
                    c.CustomerPassword = (String)read["Password"];
                    c.PrimaryStore = (String)read["primaryStore"];

                    allCustomers.Add(c);
                }
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
            return allCustomers;
        }

        public static List<Customer> GetAllCustomersByPrimaryStore(string storeNum)
        {
            List<Customer> allCustomers = new List<Customer>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Customers WHERE primaryStore = @storeNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Customer c = new Customer();

                    c.CustomerID = (int)read["customerID"];
                    c.CustomerFirst = (String)read["customerFirst"];
                    c.CustomerLast = (String)read["customerLast"];
                    c.CustomerPhone = (String)read["customerPhone"];
                    c.CustomerAddress = (String)read["cusstomerAddress"];
                    c.CustomerCity = (String)read["customerCity"];
                    c.CustomerState = (String)read["customerState"];
                    c.CustomerZip = (String)read["customerZip"];
                    c.CustomerRole = (String)read["Role"];
                    c.CustomerLogin = (String)read["Login"];
                    c.CustomerPassword = (String)read["Password"];
                    c.PrimaryStore = (String)read["primaryStore"];

                    allCustomers.Add(c);
                }
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
            return allCustomers;
        }

        public static Customer GetCustomerByID(int customerID)
        {
            Customer aCustomer = new Customer();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Customers WHERE customerID = @customerID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerID", customerID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

               
                    aCustomer.CustomerID = (int)read["customerID"];
                    aCustomer.CustomerFirst = (String)read["customerFirst"];
                    aCustomer.CustomerLast = (String)read["customerLast"];
                    aCustomer.CustomerPhone = (String)read["customerPhone"];
                    aCustomer.CustomerAddress = (String)read["cusstomerAddress"];
                    aCustomer.CustomerCity = (String)read["customerCity"];
                    aCustomer.CustomerState = (String)read["customerState"];
                    aCustomer.CustomerZip = (String)read["customerZip"];
                    aCustomer.CustomerRole = (String)read["Role"];
                    aCustomer.CustomerLogin = (String)read["Login"];
                    aCustomer.CustomerPassword = (String)read["Password"];
                    aCustomer.PrimaryStore = (String)read["primaryStore"];

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
            return aCustomer;
        }
    }
}