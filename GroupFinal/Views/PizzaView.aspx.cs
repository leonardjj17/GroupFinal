using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;
using GroupFinal.Database;
using System.Collections.ObjectModel;

namespace GroupFinal.Views
{
    public partial class PizzaView : System.Web.UI.Page
    {

        
        Products newPizza = null;
        List<Products> allCrusts = ProductsDA.GetPizzaCrust();
        List<Products> allSauces = ProductsDA.GetPizzaSauce();
        List<Products> allToppings = ProductsDA.GetAllToppings();
        List<CartItem> cartItems;

        protected void Page_Load(object sender, EventArgs e)
        {
            //cartItems = new List<CartItem>();
            foreach (Products crusts in allCrusts)
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
            List<CartItem> cartItems = (List<CartItem>)Session["items"];

            string pizzaSize = "";
            string pizzaCheese = "";
            string pizzaSauce = "";
            string pizzaCrust = "";
            string pizzaToppings = "";
            string pizzaExtras = "";
            double pizzaCost = 0;

            //check for pizza size
            if(rdoSmall.Checked)
            {
                pizzaSize = "Small";
                pizzaCost = 8.99;
            }
            else if(rdoMedium.Checked)
            {
                pizzaSize = "Medium";
                pizzaCost = 11.99;
            }
            else if(rdoLarge.Checked)
            {
                pizzaSize = "Large";
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
                        pizzaCrust = ((RadioButton)crustType).Text;
                    }
                }
            }

            //String currentCrust = newPizza.PizzaCrust;

            foreach(Products crust in allCrusts)
            {
                String crustSelection = crust.ProductDetail;
                if(pizzaCrust == crustSelection)
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
                        pizzaSauce = ((RadioButton)sauceType).Text;
                    }
                }
            }

            foreach(Products sauce in allSauces)
            {
                if(pizzaSauce == sauce.ProductDetail)
                {
                    pizzaCost += sauce.ProductPrice;
                }
            }
            
            
            //check for cheese type
            if(rdoNone.Checked)
            {
                pizzaCheese = rdoNone.Text;
            }
            else if (rdoRegular.Checked)
            {
                pizzaCheese = rdoRegular.Text;
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

            //newPizza.PizzaExtras = pizzaExtras;
            //newPizza.PizzaPrice = Math.Round(pizzaCost, 2);
            //newPizza.ProductPrice = Math.Round(pizzaCost, 2);
            //newPizza.ProductType = "Pizza";
            //newPizza.ProductDetail = "New Pizza object";



            //string pizza = newPizza.PizzaToppings;


            newPizza = new Pizza(1, pizzaCost, "Pizza", 1, pizzaCost, "Pizza with: " + pizzaToppings, pizzaToppings, pizzaCheese, pizzaSauce, pizzaCrust, pizzaExtras, pizzaSize, pizzaCost);


            cartItems = Cart.AddItemToCart(newPizza, cartItems);


            Session["items"] = cartItems;

            Response.Redirect("CartView.aspx");
        }
    }
}