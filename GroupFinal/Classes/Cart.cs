using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GroupFinal.Classes
{
    public class Cart : Page
    {
        List<CartItem> cartItems;

        Products myPizza = null;


        public Cart()
        {
            if(cartItems == null)
            {
                cartItems = new List<CartItem>();
            }

            if (Session["pizza"] == null)
            {
                myPizza = new Pizza();
            }
            else
            {
                myPizza = (Pizza)Session["pizza"];

                if (!IsPostBack)
                {
                    AddItemsToCart(myPizza);
                }
            }


        }




        public List<CartItem> AddItemsToCart(Products myPizza)
        {
            if (myPizza != null)
            {
                CartItem theCart = new CartItem();
                theCart.ProductID = myPizza.ProductID;
                theCart.ProductPrice = myPizza.ProductPrice;
                theCart.ProductType = myPizza.ProductType;
                theCart.ProductQty = myPizza.ProductQty;
                theCart.ProductCost = myPizza.ProductCost;
                theCart.ProductDetail = myPizza.ProductDetail;

                //theCart.Description = myPizza.ProductDetail;
                //theCart.Qty = myPizza.ProductID;
                //theCart.Price = myPizza.ProductPrice;
                //theCart.ProductID = myPizza.ProductID;
                //theCart.ProductPrice = myPizza.ProductPrice;
                //theCart.ProductDetail = myPizza.ProductDetail;
                //theCart.ProductCost = myPizza.ProductPrice;

                cartItems.Add(theCart);
                return cartItems;
            }

            return cartItems;
        }

        //stuff



    }



}




