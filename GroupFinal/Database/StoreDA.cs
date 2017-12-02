using GroupFinal.Classes;
using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class StoreDA
    {
        public static List<Stores> GetAllStores()
        {
            List<Stores> allStores = new List<Stores>();

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Stores";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Stores st = new Stores();

                    st.StoreID = (String)read["storeNum"];
                    st.StoreAddress = (String)read["storeAddress"];
                    st.StoreCity = (String)read["storeCity"];
                    st.StoreState = (String)read["storeState"];
                    st.StoreZip = (String)read["storeZip"];
                    st.StoreManager = (String)read["storeManager"];
                    
                    allStores.Add(st);
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
            return allStores;
        }
    }
}