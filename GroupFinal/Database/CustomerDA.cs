﻿using System;
using GroupFinal.DA;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class CustomerDA
    {
        public static Boolean VerifyLogin(String login, String password)
        {
            if (login == null) return false;
            SqlConnection connection = Connection.GetConnection();
            if (connection != null)
            {
                connection.Open();
            }
            String query = "SELECT Password FROM Customers WHERE login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    string tempPass = (String)read["password"];
                    if (BCrypt.Net.BCrypt.Verify(password, tempPass)) return true;
                }
                return false;

            }
            catch (SqlException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static Customer GetCustomerByLogin(String login)
        {
            Customer c = new Customer();

            SqlConnection connection = Connection.GetConnection();
            if (connection != null)
            {
                connection.Open();
            }
            if (login == null) return null;

            String query = "SELECT * FROM Customers WHERE login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    c.CustomerID = (int)read["customerID"];
                    c.PrimaryStore = (String)read["primaryStore"];
                    c.CustomerFirst = (String)read["customerFirst"];
                    c.CustomerLast = (String)read["customerLast"];
                    c.CustomerAddress = (String)read["cusstomerAddress"];
                    c.CustomerCity = (String)read["customerCity"];
                    c.CustomerState = (String)read["customerState"];
                    c.CustomerZip = (String)read["customerZip"];
                    c.CustomerPhone = (String)read["customerPhone"];
                    c.CustomerRole = (String)read["role"];
                    c.CustomerLogin = (String)read["login"];
                    c.CustomerPassword = (String)read["password"];
                }
            }
            catch (SqlException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Customers WHERE customerID = @customerID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerID", customerID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
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
        public static void AddCustomer(Customer c)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "INSERT INTO Customers (customerFirst, customerLast, customerPhone, cusstomerAddress, customerCity, customerState, customerZip, Login, Password, primaryStore) VALUES (@customerFirst, @customerLast, @customerPhone, @cusstomerAddress, @customerCity, @customerState, @customerZip, @Login, @Password, @primaryStore) ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerFirst", c.CustomerFirst);
            cmd.Parameters.AddWithValue("@customerLast", c.CustomerLast);
            cmd.Parameters.AddWithValue("@customerPhone", c.CustomerPhone);
            cmd.Parameters.AddWithValue("@cusstomerAddress", c.CustomerAddress);
            cmd.Parameters.AddWithValue("@customerCity", c.CustomerCity);
            cmd.Parameters.AddWithValue("@customerState", c.CustomerState);
            cmd.Parameters.AddWithValue("@customerZip", c.CustomerZip);
            cmd.Parameters.AddWithValue("@Login", c.CustomerLogin);
            cmd.Parameters.AddWithValue("@Password", c.CustomerPassword);
            cmd.Parameters.AddWithValue("@primaryStore", c.PrimaryStore);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        public static void UpdateCustomer(Customer c)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "Update Customers Set customerFirst = @customerFirst, customerLast = @customerLast, customerPhone = @customerPhone, cusstomerAddress = @cusstomerAddress, customerCity = @customerCity, customerState = @customerState, customerZip = @customerZip, Login = @login, Password = @password, primaryStore = @primaryStore where CustomerID = @customerID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerFirst", c.CustomerFirst);
            cmd.Parameters.AddWithValue("@customerLast", c.CustomerLast);
            cmd.Parameters.AddWithValue("@customerPhone", c.CustomerPhone);
            cmd.Parameters.AddWithValue("@cusstomerAddress", c.CustomerAddress);
            cmd.Parameters.AddWithValue("@customerCity", c.CustomerCity);
            cmd.Parameters.AddWithValue("@customerState", c.CustomerState);
            cmd.Parameters.AddWithValue("@customerZip", c.CustomerZip);
            cmd.Parameters.AddWithValue("@Login", c.CustomerLogin);
            cmd.Parameters.AddWithValue("@Password", c.CustomerPassword);
            cmd.Parameters.AddWithValue("@primaryStore", c.PrimaryStore);
            cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

        public static void RemoveCustomer(Customer c)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "DELETE FROM Customers WHERE CustomerID = @customerID";
            SqlCommand cmd = new SqlCommand(query, connection);
  
            cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
                c.CustomerID = 0;
            }
        }
    }
}