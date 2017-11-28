using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    [Serializable]
    public class Products
    {
        //get and sets for all variables
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public string ProductType { get; set; }
        public int ProductQty { get; set; }
        public double ProductCost { get; set; }
        public string ProductDetail { get; set; }


        //empty constructor
        public Products()
        {
            ProductPrice = 0.0;
            ProductType = "";
            ProductQty = 0;
        }
        //constructor with all the variables
        public Products(int productID, double productPrice, string productType, int productQty, double productCost, string productDetail)
        {
            this.ProductID = productID;
            this.ProductPrice = productPrice;
            this.ProductType = productType;
            this.ProductQty = productQty;
            this.ProductCost = productCost;
            this.ProductDetail = productDetail;
        }

    }
}