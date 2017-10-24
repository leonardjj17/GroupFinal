using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroupFinal.Database
{
    public class ProductsDA
    {
        public static List<Products> GetAllProducts()
        {
            List<Products> allProducts = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    //p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    //p.ProductDetail = (String)read["productDetail"];
                    //p.ProductPrice = (decimal)read["productPrice"];
                    //p.ProductCost = (decimal)read["productCost"];
                    //p.ProductQty = (int)read["productQty"];

                    allProducts.Add(p);
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
            return allProducts;
        }

        public static List<Products> GetAllIngredients()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    //e.EmployeeID = (int)read["employeeID"];
                    //e.StoreNum = (String)read["storeNum"];
                    //e.EmployeeFirst = (String)read["employeeFirst"];
                    //e.EmployeeLast = (String)read["employeeLast"];
                    //e.EmployeeHireDate = (DateTime)read["employeeHireDate"];
                    //e.EmployeeStatus = (String)read["empl"];
                    //e.EmployeeRole = (String)read["role"];
                    //e.Login = (String)read["login"];
                    //e.password = (String)read["password"];

                    allIngredients.Add(p);
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
            return allIngredients;
        }
    }
}