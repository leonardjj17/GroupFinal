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
        List<Products> allCrusts = ProductsDA.GetPizzaCrust();
        List<Products> allSauces = ProductsDA.GetPizzaSauce();
        List<Products> allToppings = ProductsDA.GetAllIngredients();

        protected void Page_Load(object sender, EventArgs e)
        {

            

            foreach(Products crusts in allCrusts)
            {
                RadioButton newCrust = new RadioButton();
                newCrust.Text = crusts.ProductDetail;
                newCrust.GroupName = "grpCrusts";

                pnlCrusts.Controls.Add(newCrust);
                pnlCrusts.Controls.Add(new LiteralControl("<br />"));

            }

            foreach(Products sauces in allSauces)
            {
                RadioButton newSauce = new RadioButton();
                newSauce.Text = sauces.ProductDetail;
                newSauce.GroupName = "grpSauce";
                
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

            //found logic on stack overflow checks or Controls within the Panel
            foreach(Control crustType in pnlCrusts.Controls)
            {
                //Searches for the type of the control, checks for RadioButton
                if(crustType.GetType().Name == "RadioButton")
                {
                    //casts the crust type control to radio button, checks if it's selected
                    if(((RadioButton)crustType).Checked)
                    {
                        //sets the pizza crust type
                        newPizza.PizzaCrust = ((RadioButton)crustType).Text;
                    }
                }
            }

            String currentCrust = newPizza.PizzaCrust;

            foreach(Products crust in allCrusts)
            {
                String crustSelection = crust.ProductDetail;
                if(currentCrust == crustSelection)
                {
                    pizzaCost += Convert.ToDouble(crust.ProductPrice);
                }
            }
            
            //check for selection in rdoSauceList
            foreach(Control sauceType in pnlSauce.Controls)
            {
                if(sauceType.GetType().Name == "RadioButton")
                {
                    if(((RadioButton)sauceType).Checked)
                    {
                        newPizza.PizzaSauce = ((RadioButton)sauceType).Text;
                    }
                }
            }

            foreach(Products sauce in allSauces)
            {
                if(newPizza.PizzaSauce == sauce.ProductDetail)
                {
                    pizzaCost += sauce.ProductPrice;
                }
            }
            
            
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
            foreach(Control topping in pnlToppings.Controls)
            {
                if(topping.GetType().Name == "CheckBox")
                {
                    if(((CheckBox)topping).Checked)
                    {
                        string currentTopping = ((CheckBox)topping).Text;
                        pizzaToppings += currentTopping + " ";
                        foreach(Products top in allToppings)
                        {
                            if(top.ProductDetail == currentTopping)
                            {
                                pizzaCost += top.ProductPrice;
                            }
                        }
                    }
                }
            }

            newPizza.PizzaToppings = pizzaToppings;

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