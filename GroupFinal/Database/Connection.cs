﻿using System;
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
                string connectionString = @"Data Source = quentindb.db.2823567.59f.hostedresource.net; Initial Catalog = QuentinDB; User ID = OsheaDB2644; Password = s#blaRNey!01";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}