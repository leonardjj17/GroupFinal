//using GroupFinal.Classes;
//using GroupFinal.DA;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace GroupFinal.Database
//{
//    public class FinancialDA
//    {
//        public static List<Financial> GetAllBalances()
//        {
//            List<Financial> allBalances = new List<Financial>();

//            SqlConnection connection = Connection.getConnection();

//            String query = "SELECT * FROM Financial";
//            SqlCommand cmd = new SqlCommand(query, connection);
            

//            try
//            {
//                connection.Open();
//                SqlDataReader read = cmd.ExecuteReader();

//                while (read.Read())
//                {
//                    Financial f = new Financial();

//                    f.StoreNum = (String)read["storeNum"];
//                    f.StoreBalance = (double)read["storeBalance"];

                  
//                    allBalances.Add(f);
//                }
//            }
//            catch (SqlException ex)
//            {

//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }
//            return allBalances;
//        }

//        /*public static Financial GetTotalBalanceByStoreNum(string storeNum)
//        {

//            Financial storeBalance = new Financial();

//            SqlConnection connection = Connection.getConnection();

//            String query = "SELECT * FROM Financial WHERE storeNum = @storeNum";
//            SqlCommand cmd = new SqlCommand(query, connection);
//            cmd.Parameters.AddWithValue("@storeNum", storeNum);

//            try
//            {
//                connection.Open();
//                SqlDataReader read = cmd.ExecuteReader();

//                if (read.Read())
//                {
//                    storeBalance.StoreNum = (String)read["storeNum"];
//                    storeBalance.StoreBalance = Convert.ToDouble(read["storeBalance"]);
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine(ex.Message + " " + ex.StackTrace);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message + " " + ex.StackTrace);   
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return storeBalance;
//        }*/
//    }
//}