using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Pizza : Products
    {
        //declaring variables
        private string pizzaToppings, pizzaCheese, pizzaSauce, pizzaCrust, pizzaExtras, pizzaSize;
        private double pizzaPrice;

        //empty constructor
        public Pizza()
        {
            pizzaToppings = "";
            pizzaCheese = "";
            pizzaSauce = "";
            pizzaCrust = "";
            pizzaExtras = "";
            pizzaSize = "";
            pizzaPrice = 0;
        }

        //constructor with all the variables
        public Pizza(string pizzaToppings, string pizzaCheese, string pizzaSauce, string pizzaCrust, string pizzaExtras, string pizzaSize, double pizzaPrice) :base()
        {
            this.pizzaToppings = pizzaToppings;
            this.pizzaCheese = pizzaCheese;
            this.pizzaSauce = pizzaSauce;
            this.pizzaCrust = pizzaCrust;
            this.pizzaExtras = pizzaExtras;
            this.pizzaSize = pizzaSize;
            this.pizzaPrice = pizzaPrice;
        }

        //get and sets for all the variables, these may need to be changed/just the basic ones for right now


        public string PizzaToppings { get; set; }

        public string PizzaCheese { get; set; }

        public string PizzaSauce { get; set; }

        public string PizzaCrust { get; set; }

        public string PizzaExtras { get; set; }

        public string PizzaSize { get; set; }

        public double PizzaPrice { get; set; }
    }
}