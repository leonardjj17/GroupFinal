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
        const double MEDIUM_PRICE_MULTIPLIER = 1.5;
        const double LARGE_PRICE_MULTIPLIER = 2;

        List<Products> drinks;
        
        protected void Page_Load(object sender, EventArgs e)
        {
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

                pnlDrink.Controls.Add(newDrink);
                pnlDrink.Controls.Add(new LiteralControl("<br />"));
            }
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            drinks = ProductsDA.GetAllDrinks();
            double pricemultiplier = 1;
            string size = "small";
            if (rdoMedium.Checked)
            {
                pricemultiplier = MEDIUM_PRICE_MULTIPLIER;
                size = "medium";
            }
            else if (rdoLarge.Checked)
            {
                pricemultiplier = LARGE_PRICE_MULTIPLIER;
                size = "large";
            }
            
            foreach (Control rdoDrink in pnlDrink.Controls)
            {
                if ((rdoDrink.GetType().Name == "RadioButton") && (((CheckBox)rdoDrink).Checked))
                {
                    foreach (Products product in drinks)
                    {
                        if (product.ProductDetail == (((RadioButton)rdoDrink).Text))
                        {
                            Drink drink = new Drink(size, product.ProductDetail, Math.Round(product.ProductPrice * pricemultiplier,2));

                            //put it into the cart......

                            Response.Redirect("CartView.aspx");
                        }
                    }
                }
            }
        }
    }
}