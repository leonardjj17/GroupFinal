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

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

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

            String query = "SELECT * FROM Products WHERE productType = 'ingredients'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductQty = (int)read["productQty"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);


                    allIngredients.Add(p);
                }
            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " +ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return allIngredients;
        }
        public static List<Products> GetAllToppings()
        {
            List<Products> allToppings = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'toppings'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductQty = (int)read["productQty"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);


                    allToppings.Add(p);
                }
            }
            catch (SqlException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
            return allToppings;
        }

        public static List<Products> GetAllSides()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'side'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

                    allIngredients.Add(p);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
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

        public static List<Products> GetPizzaCrust()
        {
            List<Products> allCrusts = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "Select * from Products Where productType = 'crust'";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while(read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

                    allCrusts.Add(p);
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
            return allCrusts;
        }

        public static List<Products> GetPizzaSauce()
        {
            List<Products> allSauce = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "Select * from Products Where productType = 'sauce'";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

                    allSauce.Add(p);
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
            return allSauce;
        }

        public static List<Products> GetAllSalads()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'salads'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

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

        public static List<Products> GetAllDressings()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'dressings'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();
                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

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

        public static List<Products> GetAllDrinks()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'drinks'";
            SqlCommand cmd = new SqlCommand(query, connection);
            
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

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

        public static List<Products> GetAllAlcohol()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.getConnection();

            String query = "SELECT * FROM Products WHERE productType = 'alcohol'";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)read["productID"];
                    p.ProductType = (String)read["productType"];
                    p.ProductDetail = (String)read["productDetail"];
                    p.ProductPrice = Convert.ToDouble(read["productMenuPrice"]);
                    p.ProductCost = Convert.ToDouble(read["productCost"]);
                    p.ProductQty = (int)read["productQty"];

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