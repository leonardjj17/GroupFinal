using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;
using GroupFinal.Database;

namespace GroupFinal.Views
{
    public partial class PizzaView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Products> allCrusts = ProductsDA.GetPizzaCrust();
            List<Products> allSauces = ProductsDA.GetPizzaSauce();
            List<Products> allToppings = ProductsDA.GetAllIngredients();
            

            foreach(Products crusts in allCrusts)
            {
                RadioButton newCrust = new RadioButton();
                newCrust.Text = " "+ crusts.ProductDetail;
                newCrust.GroupName = "grpCrusts";

                pnlCrusts.Controls.Add(newCrust);
                pnlCrusts.Controls.Add(new LiteralControl("<br />"));

            }

            foreach(Products sauces in allSauces)
            {
                CheckBox newSauce = new CheckBox();
                newSauce.Text = sauces.ProductDetail;

                pnlSauce.Controls.Add(newSauce);
                pnlSauce.Controls.Add(new LiteralControl("<br />"));
            }

            foreach(Products toppings in allToppings)
            {
                CheckBox newTopping = new CheckBox();
                newTopping.Text = toppings.ProductDetail;

                pnlToppings.Controls.Add(newTopping);
                pnlToppings.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Pizza newPizza = new Pizza();
            string pizzaToppings = "";
            string pizzaExtras = "";
            double pizzaCost = 0;

            //check for pizza size
            if(rdoSmall.Checked)
            {
                newPizza.PizzaSize = "Small";
                pizzaCost = 8.99;
            }
            else if(rdoMedium.Checked)
            {
                newPizza.PizzaSize = "Medium";
                pizzaCost = 11.99;
            }
            else if(rdoLarge.Checked)
            {
                newPizza.PizzaSize = "Large";
                pizzaCost = 14.99;
            }

            //check for crust type
 
            
            //check for selection in rdoSauceList

            
            
            //check for cheese type
            if(rdoNone.Checked)
            {
                newPizza.PizzaCheese = rdoNone.Text;
            }
            else if (rdoRegular.Checked)
            {
                newPizza.PizzaCheese = rdoRegular.Text;
            }

            //check for toppings


            //check for extras
            if (chkExtraCheese.Checked)
            {
                pizzaExtras = chkExtraCheese.Text + " ";
                pizzaCost += 1.50;
            }

            if(chkExtraSauce.Checked)
            {
                pizzaExtras += chkExtraSauce.Text;
                pizzaCost += 1.50;
            }

            newPizza.PizzaExtras = pizzaExtras;
            newPizza.PizzaPrice = Math.Round(pizzaCost, 2);



        }
    }
}