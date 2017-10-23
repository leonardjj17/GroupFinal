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

            String query = "SELECT * FROM Employees WHERE Role IN ('Employee', 'Manager') AND login = @login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                //e.EmployeeID = (int)read["employeeID"];
                //e.StoreNum = (String)read["storeNum"];
                e.EmployeeFirst = (String)read["employeeFirst"];
                e.EmployeeLast = (String)read["employeeLast"];
                e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                e.EmployeeStatus = (String)read["empl"];
                e.EmployeeRole = (String)read["role"];
                //e.Login = (String)read["login"];
                //e.password = (String)read["password"];

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

        public static List<Employee> GetAllEmployee()
        {
            List<Employee> allEmployees = new List<Employee>();

            SqlConnection connection = Connection.getConnection();
     
            String query = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(query, connection);
       

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Employee e = new Employee();

                    //e.EmployeeID = (int)read["employeeID"];
                    //e.StoreNum = (String)read["storeNum"];
                    e.EmployeeFirst = (String)read["employeeFirst"];
                    e.EmployeeLast = (String)read["employeeLast"];
                    e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    e.EmployeeStatus = (String)read["empl"];
                    e.EmployeeRole = (String)read["role"];
                    //e.Login = (String)read["login"];
                    //e.password = (String)read["password"];

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
    }
}