﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    [Serializable]
    public class Products
    {
        //instantiating the variables
        private int productID;
        private double productPrice;
        private string productType;
        private int productQty;
        private string productDetail;


        //get and sets for all variables
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public string ProductType { get; set; }
        public int ProductQty { get; set; }
        public string ProductDetail { get; set; }


        //empty constructor
        public Products()
        {
            ProductID = 0;
            ProductPrice = 0.0;
            ProductType = "";
            ProductQty = 0;
        }
        //constructor with all the variables
        public Products(int productID, double productPrice, string productType, int productQty, string productDetail)
        {
            this.ProductID = productID;
            this.ProductPrice = productPrice;
            this.ProductType = productType;
            this.ProductQty = productQty;
            this.ProductDetail = productDetail;
        }

    }
}