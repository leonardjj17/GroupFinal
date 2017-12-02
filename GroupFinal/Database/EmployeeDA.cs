using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public class EmployeeDA

    {
        public static Boolean VerifyLogin(String login, String password)
        {
            if (login == null) return false;
            SqlConnection connection = Connection.GetConnection();
            if (connection != null)
            {
                connection.Open();
            }
            String query = "SELECT Password FROM Employee WHERE login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    string tempPass = (String)read["Password"];
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

        public static Employee GetEmployeeByLogin(String login)
        {
            if (login == null) return null;
            Employee e = new Employee();

            SqlConnection connection = Connection.GetConnection();
            if (connection != null)
            {
                connection.Open();
            }

            //String query = "SELECT * FROM Employee WHERE Role IN ('cook','bartender','delivery driver', 'store manager') AND Login = @login";
            String query = "SELECT * FROM Employee WHERE login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {

                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["employeeStatus"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];
                }
                else return null;

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

            SqlConnection connection = Connection.GetConnection();
     
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
                    e.EmployeeStatus = (String)read["employeeStatus"];
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
        public static List<Employee> GetAllEmployeesExceptManagerByStoreNumber(String storeNum)
        {
            List<Employee> allEmployees = new List<Employee>();

            SqlConnection connection = Connection.GetConnection();

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
                    e.EmployeeStatus = (String)read["employeeStatus"];
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

            SqlConnection connection = Connection.GetConnection();

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
                    e.EmployeeStatus = (String)read["employeeStatus"];
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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Employee where employeeID = @employeeID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    e.EmployeeID = (int)read["employeeID"];
                    e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["employeeStatus"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];
                    return e;
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
    

        public static List<Employee> GetDriversByStoreNumber(String storeNum)
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Employee WHERE role = 'delivery driver' AND storeNum = @storeNum";
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
                    e.EmployeeStatus = (String)read["employeeStatus"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    employees.Add(e);
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
            return employees;
        }
        public static List<Employee> GetDriversByStoreNumberWithDeliveryCount(String storeNum)
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Employee WHERE role = 'delivery driver' AND storeNum = @storeNum";
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
                    e.EmployeeStatus = (String)read["employeeStatus"];
                    e.EmployeeRole = (String)read["role"];
                    e.Login = (String)read["login"];
                    e.Password = (String)read["password"];

                    employees.Add(e);
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
            return employees;
        }

        public static void AddNewEmployee(Employee e)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "INSERT INTO Employee (storeNum, employeeFirst, employeeLast, employeeHireDate, employeeStatus, Role, Login, Password) VALUES (@storeNum, @employeeFirst, @employeeLast, @employeeHireDate, @employeeStatus, @Role, @Login, @Password)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", e.StoreNum);
            cmd.Parameters.AddWithValue("@employeeFirst", e.EmployeeFirst);
            cmd.Parameters.AddWithValue("@employeeLast", e.EmployeeLast);
            cmd.Parameters.AddWithValue("@employeeHireDate", e.EmployeeHireDate);
            cmd.Parameters.AddWithValue("@employeeStatus", e.EmployeeStatus);
            cmd.Parameters.AddWithValue("@Role", e.EmployeeRole);
            cmd.Parameters.AddWithValue("@Login", e.Login);
            cmd.Parameters.AddWithValue("@Password", e.Password);

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

        public static void UpdateEmployee(Employee e)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "Update Employee " +
                            "SET storeNum = @storeNum, employeeFirst = @employeeFirst, employeeLast = @employeeLast, employeeStatus = @employeeStatus, " +
                            "Role = @Role, Login = @Login, Password = @Password " +
                            "WHERE employeeID = @employeeID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", e.StoreNum);
            cmd.Parameters.AddWithValue("@employeeFirst", e.EmployeeFirst);
            cmd.Parameters.AddWithValue("@employeeLast", e.EmployeeLast);
           
            cmd.Parameters.AddWithValue("@employeeStatus", e.EmployeeStatus);
            cmd.Parameters.AddWithValue("@Role", e.EmployeeRole);
            cmd.Parameters.AddWithValue("@Login", e.Login);
            cmd.Parameters.AddWithValue("@Password", e.Password);
            cmd.Parameters.AddWithValue("@employeeID", e.EmployeeID);
            
  
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

        public static void RemoveEmployee(Employee e)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "DELETE FROM Employee WHERE employeeID=@employeeID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@employeeID", e.EmployeeID);

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
                e.EmployeeID = 0;
            }

        }
    }

}