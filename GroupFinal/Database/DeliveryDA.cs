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
            cmd.Parameters.AddWithValue("employeeID", @employeeID);


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

        public static Delivery GetDeliveryDriverByOrder(int orderID)
        {
            Delivery driver = new Delivery();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Delivery WHERE orderNum = @orderID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("orderID", @orderID);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {

                    driver.OrderNum = (int)read["orderNum"];
                    driver.EmployeeNum = (int)read["employeeNum"];
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
            return driver;
        }
        public static void AddDriverToOrder(Order order, Employee driver)
        {
            SqlConnection connection = Connection.getConnection();

            String query = "UPDATE Orders SET employeeNum = @employeeNum WHERE orderNum = @orderNum";
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
    }
}