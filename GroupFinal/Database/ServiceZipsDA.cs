using GroupFinal.Classes;
using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class ServiceZipsDA
    {
        public static List<ServiceZips> GetAllServiceZips()
        {
            List<ServiceZips> allServiceZips = new List<ServiceZips>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM ServiceZips";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ServiceZips zip = new ServiceZips();

                    zip.StoreNum = (int)read["storeNum"];
                    zip.ServiceZip = (String)read["serviceZip"];

                    allServiceZips.Add(zip);
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
            return allServiceZips;
        }

        public static List<ServiceZips> GetAllServiceZipsByStoreNum(int storeNum)
        {
            List<ServiceZips> allServiceZips = new List<ServiceZips>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM ServiceZips WHERE storeNum = @storeNum";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@storeNum", storeNum);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    ServiceZips zip = new ServiceZips();

                    zip.StoreNum = (int)read["storeNum"];
                    zip.ServiceZip = (String)read["serviceZip"];

                    allServiceZips.Add(zip);
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
            return allServiceZips;
        }
    }


}