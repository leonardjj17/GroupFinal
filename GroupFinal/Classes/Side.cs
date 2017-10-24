using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Side : Products
    {
        private string sideType;
        private double sidePrice;

        public Side()
        {

        }
        public Side(string sideType, double sidePrice)
        {
            this.sideType = sideType;
            this.sidePrice = sidePrice;
        }

        public string SideType { get; set; }

        public double SidePrice { get; set; }
    }
}