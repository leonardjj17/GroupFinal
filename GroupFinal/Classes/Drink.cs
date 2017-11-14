using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Drink : Products
    {
        //variables
        private string drinkSize;
        private string drinkType;
        private double drinkPrice;
        //constructors
        public Drink()
        {

        }
        public Drink(string drinkSize, string drinkType, double drinkPrice, int productID, double productPrice, string productType, int productQty, double productCost, string productDetail) : base(productID, productPrice, productType, productQty, productCost, productDetail)
          
        {
            this.drinkSize = drinkSize;
            this.drinkType = drinkType;
            this.drinkPrice = drinkPrice;
        }
        //gets and sets for all variables
        public string DrinkSize { get; set; }

        public string DrinkType { get; set; }

        public double DrinkPrice { get; set; }
    }
}