using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Database;

namespace GroupFinal.Views
{
    public partial class Inventory : System.Web.UI.Page 
    {
        List<Products> allProducts = ProductsDA.GetAllIngredients();
        protected void Page_Load(object sender, EventArgs e)
        {


            foreach(Products ingredient in allProducts)
            {   
                lstIngredients.Items.Add(Convert.ToString(ingredient.ProductDetail));
            }
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            int index = 0;

            index = lstIngredients.SelectedIndex;

            Products selectedProduct = allProducts[index];

            lblIngredientName.Text = selectedProduct.ProductDetail;
            lblItemCost.Text = selectedProduct.ProductPrice.ToString("c2");
            lblMenuPrice.Text = selectedProduct.ProductPrice.ToString("c2");
            lblQuantity.Text = Convert.ToString(selectedProduct.ProductQty);
        }
    }
}