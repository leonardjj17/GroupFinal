using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Alcohol : Products
    {
        public int alcoholID;
        public string alcoholType;
        public string alcoholDescription;
        public double alcoholPrice;

        public Alcohol()
        {

        }

        public Alcohol(int productID, double productPrice, string productType, int productQty, double productCost, string productDetail, int alcoholID, string alcoholType, string alcoholDescription,double alcoholPrice) : base(productID, productPrice, productType, productQty, productCost, productDetail)
        {
            this.alcoholID = alcoholID;
            this.alcoholType = alcoholType;
            this.alcoholDescription = alcoholDescription;
            this.alcoholPrice = alcoholPrice;
        }

        public int AlcoholID { get; set; }

        public string AlcoholType { get; set; }

        public string AlcoholDescription { get; set; }

        public double AlcoholPrice { get; set; }
    }
}