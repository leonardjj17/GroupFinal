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
        public static List<Order> getOrdersByStoreNum(String storeNum)
        {
            List<Order> orders = new List<Order>();

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
                    Order order = new Order();

                    order.OrderID = (int)read["OrderID"];
                    order.CustomerFirst = (string)read["customerFirst"];
                    order.CustomerLast = (string)read["customerLast"];
                    order.OrderTotal = (double)read["orderTotal"];
                    order.StoreNum = (string)read["storeNum"];
                    order.IsFavorite = (string)read["isFavorite"];
                    order.OrderType = (string)read["orderType"];


                    orders.Add(order);
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


        public static void addOrder(Order order)
        {

        }
        public static void removeOrder(Order order)
        {

        }
       
    }
}