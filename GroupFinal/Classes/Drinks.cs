using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Drinks
    {
        //variables
        private string drinkSize;
        private string drinkType;
        private double drinkPrice;
        //constructors
        public Drinks()
        {

        }
        public Drinks(string drinkSize, string drinkType, double drinkPrice)
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