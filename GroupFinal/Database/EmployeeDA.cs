using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public class EmployeeDA

    {
    

        public static Employee GetEmployeeByLogin(String login)
        {
            Employee e = new Employee();

            SqlConnection connection = Connection.getConnection();
            if (connection != null)
            {
                connection.Open();
            }
            if (login == null) return null;

            String query = "SELECT * FROM Employee WHERE Role IN ('cook','bartender','delivery driver', 'store manager') AND login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                e.EmployeeID = (int)read["employeeID"];
                e.StoreNum = (String)read["storeNum"];
                e.EmployeeFirst = (String)read["employeeFirst"];
                e.EmployeeLast = (String)read["employeeLast"];
                e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                e.EmployeeStatus = (String)read["Role"];
                e.EmployeeRole = (String)read["role"];
                e.Login = (String)read["login"];
                e.Password = (String)read["password"];
                

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
            return e;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();

            SqlConnection connection = Connection.getConnection();
     
            String query = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(query, connection);
       

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Employee e = new Employee();

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["empl"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    allEmployees.Add(e);
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
            return allEmployees;
        }
        public static List<Employee> GetAllEmployeeExceptManagerByStoreNumber(int storeNum)
        {
            List<Employee> allEmployees = new List<Employee>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Employee where role NOT LIKE ('store manager') AND storeNum = @storeNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Employee e = new Employee();

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["empl"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    allEmployees.Add(e);
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
            return allEmployees;
        }

        public static List<Employee> GetAllEmployeesExceptManager()
        {
            List<Employee> allEmployees = new List<Employee>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Employee where role NOT LIKE ('store manager')";
            SqlCommand cmd = new SqlCommand(query, connection);
            

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Employee e = new Employee();

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["empl"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    allEmployees.Add(e);
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
            return allEmployees;
        }

        public static List<Employee> GetAllManagers()
        {
            List<Employee> allManagers = new List<Employee>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Employee where role LIKE ('store manager')";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Employee e = new Employee();

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["employeeStatus"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    allManagers.Add(e);
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
            return allManagers;
        }

        public static Employee GetEmployeeByID(int employeeID)
        {
            Employee e = new Employee();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Employee where employeeID = @employeeID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

               

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["empl"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

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
            return e;
        }
    }


}