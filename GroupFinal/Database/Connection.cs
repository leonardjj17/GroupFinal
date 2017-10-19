using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.DA
{
    public static class Connection
    {
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}