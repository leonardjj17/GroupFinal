using GroupFinal.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public class OrderDA
    {
        public static Order getOrderByID(int orderID)
        {

            SqlConnection connection = Connection.getConnection();

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
                    o.IsFavorite = (String)read["isFavorite"];
                    o.OrderType = (String)read["orderType"];
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

            SqlConnection connection = Connection.getConnection();

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
                    o.IsFavorite = (String)read["isFavorite"];
                    o.OrderType = (String)read["orderType"];

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

            SqlConnection connection = Connection.getConnection();

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
                    o.IsFavorite = (String)read["isFavorite"];
                    o.OrderType = (String)read["orderType"];

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

            SqlConnection connection = Connection.getConnection();

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
                    o.IsFavorite = (String)read["isFavorite"];
                    o.OrderType = (String)read["orderType"];

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

    }
}