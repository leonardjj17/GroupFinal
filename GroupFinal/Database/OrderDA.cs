﻿using GroupFinal.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public class OrderDA
    {
        public static Order GetOrderByID(int orderID)
        {

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Orders WHERE orderID = @orderID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderID", orderID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();
                Order o = new Order();
                if (read.Read())
                {

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];
                    
                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    return o;
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
            return null;
        }
        public static List<Order> GetAllOrders()
        {
            List<Order> allOrders = new List<Order>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Order o = new Order();

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];
                    
                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    allOrders.Add(o);
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
            return allOrders;
        }

        public static List<Order> GetAllOrdersByStoreNum(string storeNum)
        {
            List<Order> allStoreOrders = new List<Order>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Orders WHERE storeNum = @storeNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Order o = new Order();

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];

                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    allStoreOrders.Add(o);
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
            return allStoreOrders;
        }

        public static List<Order> GetAllOrdersByCustomer(string customerFirst, string customerLast)
        {
            List<Order> allCustomerOrders = new List<Order>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Orders WHERE customerFirst = @customerFirst AND customerLast = @customerLast";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerFirst", customerFirst);
            cmd.Parameters.AddWithValue("@customerLast", customerLast);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Order o = new Order();

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];
                    
                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    allCustomerOrders.Add(o);
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
            return allCustomerOrders;
        }

        public static Order GetCustomersLatestOrder(string customerFirst, string customerLast)
        {

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT TOP 1 * FROM Orders WHERE customerFirst = @customerFirst AND customerLast = @customerLast ORDER BY orderDate desc";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerFirst", customerFirst);
            cmd.Parameters.AddWithValue("@customerLast", customerLast);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Order o = new Order();

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];

                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    return o;
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
            return null;
        }

        public static List<Order> GetAllIncompleteOrdersByStoreNum(string storeNum)
        {
            List<Order> orders = new List<Order>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Orders WHERE isCompleted NOT IN ('Y', 'y') AND storeNum = @storeNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Order o = new Order();

                    o.OrderID = (int)read["orderID"];
                    o.CustomerFirst = (String)read["customerFirst"];
                    o.CustomerLast = (String)read["customerLast"];
                    o.OrderTotal = Convert.ToDouble(read["orderTotal"]);
                    o.StoreNum = (String)read["storeNum"];
                    
                    o.OrderType = (String)read["orderType"];
                    o.IsCompleted = (String)read["isCompleted"];
                    orders.Add(o);
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
            return orders;
        }
        public static void SetOrderComplete(Order order)
        {
            SqlConnection connection = Connection.GetConnection();
            String query = "UPDATE Orders SET isCompleted = 'Y' WHERE orderID = @orderID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderID", order.OrderID);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }
        }
        public static void SaveOrder(Order o)
        {
           
            SqlConnection connection = Connection.GetConnection();

            String query = "Insert into Orders(customerFirst, customerLast, orderTotal, storeNum, orderType, orderDate) values (@customerFirst, @customerLast, @orderTotal, @storeNum, @orderType, @orderDate)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@customerFirst", o.CustomerFirst);
            cmd.Parameters.AddWithValue("@customerLast", o.CustomerLast);
            cmd.Parameters.AddWithValue("@orderTotal", o.OrderTotal);
            cmd.Parameters.AddWithValue("@storeNum", o.StoreNum);
            
            cmd.Parameters.AddWithValue("@orderType", o.OrderType);
            cmd.Parameters.AddWithValue("@orderDate", o.OrderDate);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void SaveOrderLineItems(int orderNum, int productNum, string productDetail)
        {

            SqlConnection connection = Connection.GetConnection();

            String query = "Insert into OrderLI values (@orderNum, @productNum, @productDetail)";
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.AddWithValue("@orderNum", orderNum);
            cmd.Parameters.AddWithValue("@productNum", productNum);
            cmd.Parameters.AddWithValue("@productDetail", productDetail);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void RemoveOrder(Order o)
        {

            SqlConnection connection = Connection.GetConnection();

            String query = "DELETE FROM Orders WHERE orderID = @orderID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderID", o.OrderID);
           


            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
                o.OrderID = 0;
            }
        }

    }
}