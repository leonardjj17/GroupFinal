using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Products
    {
        //declaring variables
        private int productID;
        private double productPrice;
        private string productType;
        private int productQuantity;
        private double productCost;
        private double productMenuPrice;
        private string productDetail;

        //empty constructor
        public Products()
        {

            productPrice = 0.0;
            productType = "";
            productQuantity = 0;
        }
        //constructor with all the variables
        public Products(int productID, double productPrice, string productType, int productQuantity, double productCost, double productMenuPrice, string productDetail)
        {
            this.productID = productID;
            this.productPrice = productPrice;
            this.productType = productType;
            this.productQuantity = productQuantity;
            this.productCost = productCost;
            this.productMenuPrice = productMenuPrice;
            this.productDetail = productDetail;
        }

        //get and sets for all variables
        public int ProductID { get; set; }

        public double ProductPrice { get; set; }

        public string ProductType { get; set; }

        public int ProductQuantity { get; set; }

        public double ProductCost { get; set; }

        public double ProductMenuPrice { get; set; }

        public string ProductDetail { get; set; }
    }
}