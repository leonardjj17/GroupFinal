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
            foreach(ListItem crust in rdoCrustList.Items)
            {
                if(crust.Selected)
                {
                    newPizza.PizzaCrust = crust.Text;
                    pizzaCost += 1.25;
                }
            }

            //check for selection in rdoSauceList
            foreach(ListItem sauce in rdoSauceList.Items)
            {
                if(sauce.Selected)
                {
                    newPizza.PizzaSauce = sauce.Text;
                    pizzaCost += 0.75;
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
            foreach(ListItem toppings in chkToppingsList.Items)
            {
                if(toppings.Selected)
                {
                    pizzaToppings += toppings.Text + " ";
                    pizzaCost += 0.50;
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