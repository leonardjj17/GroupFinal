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

            SqlConnection connection = Connection.GetConnection();

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

        public static int GetLatestProductID()
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "Select TOP 1 productID From Products";

            SqlCommand cmd = new SqlCommand(query, connection);
            int productID = 0;
            try
            {
                connection.Open();
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    productID = (int)read["productID"];

                    
                }
                return productID;

            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productID;
        }

        public static List<Products> GetAllIngredients()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

       

        public static List<Products> GetAllSalads()
        {
            List<Products> allIngredients = new List<Products>();

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

            SqlConnection connection = Connection.GetConnection();

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

        public static Products GetProductByID(int id)
        {

            SqlConnection connection = Connection.GetConnection();

            String query = "SELECT * FROM Products WHERE productID = @productID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@productID", id);
            
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
                    p.ProductQty = (int)read["productQty"];

                    return p;
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
            return null;
        }

        public static void AddNewProduct(Products p)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "INSERT INTO Products (productType, productDetail, productQty, productMenuPrice) " +
                            "VALUES (@productType,@productDetail,@productQty,@productMenuPrice)";
              
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@productType", p.ProductType);
            cmd.Parameters.AddWithValue("@productDetail", p.ProductDetail);
            cmd.Parameters.AddWithValue("@productQty", p.ProductQty);
            cmd.Parameters.AddWithValue("@productMenuPrice", p.ProductPrice);
        
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

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
        }

        public static void UpdateProduct(Products p)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "UPDATE Products SET productType = @productType, " +
                "productDetail = @productDetail, productQty = @productQty, " +
                "productCost = @productCost, productMenuPrice = @productMenuPrice " +
                "WHERE productID = @productID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@productType", p.ProductType);
            cmd.Parameters.AddWithValue("@productDetail", p.ProductDetail);
            cmd.Parameters.AddWithValue("@productQty", p.ProductQty);
            cmd.Parameters.AddWithValue("@productMenuPrice", p.ProductPrice);
            cmd.Parameters.AddWithValue("@productID", p.ProductID);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

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
        }

        public static void RemoveProduct(Products p)
        {
            SqlConnection connection = Connection.GetConnection();

            String query = "DELETE FROM Products WHERE productID = @productID";

            SqlCommand cmd = new SqlCommand(query, connection);
      
            cmd.Parameters.AddWithValue("@productID", p.ProductID);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

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
                p.ProductID = 0;
            }
        }

        public static List<Products> GetPizzaCrust()
        {
            List<Products> allCrusts = new List<Products>();

            SqlConnection connection = Connection.GetConnection();

            String query = "Select * from Products Where productType = 'crust'";

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

            SqlConnection connection = Connection.GetConnection();

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
    }
}