using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    [Serializable]
    public class CartItem : Products
    {
       
        private int id;
        private int qty;
        private string description;
        private double price;
        private double subtotal;

        public CartItem()
        {

        }

        public CartItem(int Id, int Qty, string Description, double Price, int productID, double productPrice, string productType, int productQty, /*double productCost,*/ string productDetail) : base(productID, productPrice, productType, productQty, /*productCost,*/ productDetail)
        {
            id = Id;
            qty = Qty;
            description = Description;
            price = Price;

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
     
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Subtotal
        {
            get { return qty * price; }

        }
    }
}