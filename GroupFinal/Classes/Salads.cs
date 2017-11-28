using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Salads : Products
    {
        private string saladType;
        private string saladDressing;
        private double saladPrice;


        //constructors
        public Salads()
        {

        }
        public Salads(string saladType, string saladDressing, double saladPrice, int productID, double productPrice, string productType, int productQty, string productDetail) : base(productID, productPrice, productType, productQty, productDetail)
            
        {
            this.saladType = saladType;
            this.saladDressing = saladDressing;
            this.saladPrice = saladPrice;
        }

        public string SaladType { get; set; }

        public string SaladDressing { get; set; }

        public string SaladPrice { get; set; }

    }
}