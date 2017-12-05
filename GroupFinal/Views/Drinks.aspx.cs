using GroupFinal.Classes;
using GroupFinal.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Views
{
    public partial class Drinks : System.Web.UI.Page
    {
        Products drink = null;
        List<CartItem> cartItems;
        const double MEDIUM_PRICE_MULTIPLIER = 1.5;
        const double LARGE_PRICE_MULTIPLIER = 2;

        List<Products> drinks;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            cartItems = new List<CartItem>();
            drinks = ProductsDA.GetAllDrinks();
            double basePrice = drinks.First().ProductPrice;
            rdoSmall.Text = rdoSmall.Text + " (" + Math.Round(basePrice,2).ToString("C") + ")";
            rdoMedium.Text = rdoMedium.Text + " (" + Math.Round(basePrice * MEDIUM_PRICE_MULTIPLIER, 2).ToString("C") + ")";
            rdoLarge.Text = rdoLarge.Text + " (" + Math.Round(basePrice * LARGE_PRICE_MULTIPLIER, 2).ToString("C") + ")";
            foreach (Products drink in drinks)
            {
                RadioButton newDrink = new RadioButton();
                newDrink.Text = drink.ProductDetail;
                newDrink.GroupName = "grpDrinks";
                if (count < 1) newDrink.Checked = true;
                pnlDrink.Controls.Add(newDrink);
                pnlDrink.Controls.Add(new LiteralControl("<br />"));
                count++;
            }
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<CartItem> cartItems = (List<CartItem>)Session["items"];
            drinks = ProductsDA.GetAllDrinks();
            double pricemultiplier = 1;
            string size = null;
            if (rdoSmall.Checked)
            {
                size = "small";
            }
            else if (rdoMedium.Checked)
            {
                pricemultiplier = MEDIUM_PRICE_MULTIPLIER;
                size = "medium";
            }
            else if (rdoLarge.Checked)
            {
                pricemultiplier = LARGE_PRICE_MULTIPLIER;
                size = "large";
            }
            else
            {
                Response.Redirect("Drinks.aspx");
            }
            
            foreach (Control rdoDrink in pnlDrink.Controls)
            {
                if ((rdoDrink.GetType().Name == "RadioButton") && (((CheckBox)rdoDrink).Checked))
                {
                    foreach (Products product in drinks)
                    {
                        if (product.ProductDetail == (((RadioButton)rdoDrink).Text))
                        {
                            drink = new Drink(size, product.ProductDetail, Math.Round(product.ProductPrice * pricemultiplier,2), 1, Math.Round(product.ProductPrice * pricemultiplier, 2), product.ProductType, 1, product.ProductDetail);

                            cartItems = Cart.AddItemToCart(drink, cartItems);


                            Session["items"] = cartItems;

                            Response.Redirect("CartView.aspx");
                        }
                    }
                }
            }
            Response.Redirect("Drinks.aspx");
        }
    }
}