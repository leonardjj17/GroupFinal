using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Promotional : Products
    {
        private string promotionalType;
        private string promotionalSize;
        private double promotionalPrice;

        public Promotional()
        {

        }

        public Promotional(string promotionalType, string promotionalSize, double promotionalPrice)
        {
            this.promotionalType = promotionalType;
            this.promotionalSize = promotionalSize;
            this.promotionalPrice = promotionalPrice;
        }
    }
}