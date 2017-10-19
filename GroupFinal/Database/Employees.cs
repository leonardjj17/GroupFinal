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
            if (Login == null) return null;
            String query = "SELECT * FROM Employees WHERE Role in ('Employee', 'Manager') AND Login = @Login";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("Login", Login);

        }
    }
}