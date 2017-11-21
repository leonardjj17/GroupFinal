using GroupFinal.Classes;
using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class DeliveryDA
    {
        public static List<Delivery> GetAllDeliveries()
        {
            List<Delivery> allDeliveries = new List<Delivery>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Delivery";
            SqlCommand cmd = new SqlCommand(query, connection);
            
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Delivery d = new Delivery();

                    d.OrderNum = (int)read["orderNum"];
                    d.EmployeeNum = (int)read["employeeNum"];

                    allDeliveries.Add(d);
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
            return allDeliveries;
        }

        public static List<Delivery> GetAllOrdersByEmployee(int employeeID)
        {
            List<Delivery> allDeliveries = new List<Delivery>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Delivery WHERE employeeNum = @employeeID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Delivery d = new Delivery();

                    d.OrderNum = (int)read["orderNum"];
                    d.EmployeeNum = (int)read["employeeNum"];

                    allDeliveries.Add(d);
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
            return allDeliveries;
        }

        public static Delivery GetDeliveryByOrderID(int orderID)
        {
            List<Delivery> allDeliveries = new List<Delivery>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Delivery WHERE orderNum = @orderNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderNum", orderID);
            
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    Delivery d = new Delivery();

                    d.OrderNum = (int)read["orderNum"];
                    d.EmployeeNum = (int)read["employeeNum"];

                    return d;
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

        public static int GetDeliveryDriverByOrder(int orderID)
        {
            int driver;

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Delivery WHERE orderNum = @orderID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderID", orderID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {

                    return (int)read["employeeNum"];
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
            return -1;
        }
        public static void AddDriverToOrder(Order order, Employee driver)
        {
            SqlConnection connection = Connection.getConnection();

            String query = "INSERT INTO Delivery (orderNum, employeeNum) VALUES (@orderNum, @employeeNum)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderNum", order.OrderID);
            cmd.Parameters.AddWithValue("@employeeNum", driver.EmployeeID);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                
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
        }

        public static void UpdateDriverForOrder (Order order, Employee driver)
        {
            SqlConnection connection = Connection.getConnection();

            String query = "UPDATE Delivery SET employeeNum = @employeeNum WHERE orderNum = @orderNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@orderNum", order.OrderID);
            cmd.Parameters.AddWithValue("@employeeNum", driver.EmployeeID);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

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
        }
        
        public static Dictionary<String, int> getDeliveryCountForAllDriversAtStore(string storeNum)
        {
            Dictionary<String, int> deliveryCount = new Dictionary<string, int>();
            SqlConnection connection = Connection.getConnection();

            String query = "SELECT CONCAT(e.employeeFirst, ', ', e.employeeLast) as name, count(*) as count " +
                "FROM Delivery AS d " +
                "JOIN Employee AS e ON d.employeenum = e.employeeID " +
                "JOIN Orders AS o ON d.orderNum = o.orderID " +
                "WHERE o.iscompleted NOT IN ('Y', 'y') " +
                "AND o.storeNum = @storeNum " +
                "GROUP BY CONCAT(e.employeeFirst, ', ', e.employeeLast)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    string name = (string)read["name"];
                    int count = (int)read["count"];
                    deliveryCount.Add(name, count);
                    
                }

            }
            catch (Exception e)
            {

            }


            return deliveryCount;
        }
    }
}