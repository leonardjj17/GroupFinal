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

        List<Products> allDrinks;

        protected void getDrinks()
        {
            List<Products> drinks = ProductsDA.GetAllDrinks();
            List<Products> alcohol = ProductsDA.GetAllAlcohol();
            allDrinks = new List<Products>(drinks.Count + alcohol.Count);
            allDrinks.AddRange(drinks);
            allDrinks.AddRange(alcohol);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            getDrinks();
            foreach (Products drink in allDrinks)
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
            getDrinks();
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
                    foreach (Products product in allDrinks)
                    {
                        if (product.ProductDetail == (((RadioButton)rdoDrink).Text))
                        {
                            Drink drink = new Drink(size, product.ProductDetail, Math.Round(product.ProductMenuPrice * pricemultiplier,2));

                            //put it into the cart......

                            Response.Redirect("CartView.aspx");
                        }
                    }
                }
            }
        }
    }
}