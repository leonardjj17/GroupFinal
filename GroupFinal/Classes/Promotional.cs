using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Promotional : Products
    {
        private string promotionalSize;

        public Promotional()
        {

        }


        public Promotional(int productID, double productPrice, string productType, int productQty, string productDetail, string promotionalSize) : base(productID, productPrice, productType, productQty, productDetail)
        {
            this.promotionalSize = promotionalSize;
        }

        public string PromotionalSize { get; set; }

    }
}