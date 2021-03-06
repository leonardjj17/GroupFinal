﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GroupFinal.Classes
{
    [Serializable]
    public class Cart
    {
        private List<CartItem> cartItems;
        private DateTime dateCreated;
        private DateTime lastUpdate;
        Products product = null;



        public Cart()
        {

            if (this.cartItems == null)
            {
                this.cartItems = new List<CartItem>();
                this.dateCreated = DateTime.Now;
            }

        }

        public List<CartItem> CartItems
        {
            get { return cartItems; }
            set { cartItems = value; }
        }

        public static List<CartItem> AddItemToCart(Products product, List<CartItem> cartItems)
        {

            if (cartItems == null)
            {
                cartItems = new List<CartItem>();
            }

            CartItem theCart = new CartItem();
            theCart.ProductID = product.ProductID;
            theCart.ProductPrice = product.ProductPrice;
            theCart.ProductType = product.ProductType;
            theCart.ProductQty = product.ProductQty;
            
            theCart.ProductDetail = product.ProductDetail;

            cartItems.Add(theCart);

            return cartItems;

      

        }
          

        public void Insert(int Id, int Qty, string Description, double Price)
        {
            int ItemIndex = ItemIndexOfID(Id);
            if (ItemIndex == -1)
            {
                CartItem NewItem = new CartItem();
                NewItem.Id = Id;
                NewItem.Qty = Qty;
                NewItem.Description = Description;
                NewItem.Price = Price;
              
                cartItems.Add(NewItem);
            }
            else
            {
                cartItems[ItemIndex].Qty += 1;
            }
            lastUpdate = DateTime.Now;
        }

        public void Update(int RowID, int Id,
                         int Qty, string Description, double Price)
        {
            CartItem Item = cartItems[RowID];
            Item.Id = Id;
            Item.Qty = Qty;
            Item.Description = Description;
            Item.Price = Price;
            lastUpdate = DateTime.Now;
        }

        public void DeleteItem(int rowID)
        {
            cartItems.RemoveAt(rowID);
            lastUpdate = DateTime.Now;
        }

        private int ItemIndexOfID(int Id)
        {
            int index = 0;
            foreach (CartItem item in cartItems)
            {
                if (item.Id == Id)
                {
                    return index;
                }
                index += 1;
            }
            return -1;
        }

        public double Total
        {
            get
            {
                double t = 0;
                if (cartItems == null)
                {
                    return 0;
                }
                foreach (CartItem Item in cartItems)
                {
                    t += Item.Subtotal;
                }
                return t;
            }
        }

       

    }
}
    

    





    








