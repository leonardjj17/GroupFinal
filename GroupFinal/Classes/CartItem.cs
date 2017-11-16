using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class CartItem : Products
    {
        List<CartItem> cartItems = new List<CartItem>();

        public CartItem()
        {

        }

        public CartItem(int Id, int Qty, string Description, double Price, int productID, double productPrice, string productType, int productQty, double productCost, string productDetail) : base(productID, productPrice, productType, productQty, productCost, productDetail)
        {
            this.Id = Id;
            this.Qty = Qty;
            this.Description = Description;
            this.Price = Price;

        }

        public int Id { get; set; }

       // public string CartId { get; set; }

        //public DateTime DateCreated { get; set; }

        public int Qty { get; set; }

       // public int ProductId { get; set; }

        //public virtual Products Products { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

     
    }
}