using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public class Employees
    {
        public Employee GetEmployeeByLogin(String Login)
        {
            SqlConnection connection = Connection.getConnection();
            if (connection != null)
            {
                connection.Open();
            }
            if (Login == null) return null;
            String query = "SELECT * FROM Employees WHERE Role IN ('Employee', 'Manager') AND Login = @Login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("Login", Login);

        }
    }
}