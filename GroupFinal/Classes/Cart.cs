using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GroupFinal.Classes
{
    public class Cart 
    {
        List<CartItem> cartItems;

        Products myPizza = null;
        Products mySide = null;


        public Cart()
        {
           

        }


        public static List<CartItem> AddPizzaToCart(Products myPizza, List<CartItem> cartItems)
        {

            //if (myPizza != null)
            //{
            //    string myType = myPizza.GetType().ToString();

            //    if (myType == "GroupFinal.Pizza")
            //    {
            CartItem theCart = new CartItem();
            theCart.ProductID = myPizza.ProductID;
            theCart.ProductPrice = myPizza.ProductPrice;
            theCart.ProductType = myPizza.ProductType;
            theCart.ProductQty = myPizza.ProductQty;
            theCart.ProductCost = myPizza.ProductCost;
            theCart.ProductDetail = myPizza.ProductDetail;



            cartItems.Add(theCart);
            return cartItems;
        }
            public static List<CartItem> AddSidesToCart(Products mySide, List<CartItem> cartItems)
            {
                
                    CartItem theCart = new CartItem();
                    theCart.ProductID = mySide.ProductID;
                    theCart.ProductPrice = mySide.ProductPrice;
                    theCart.ProductType = mySide.ProductType;
                    theCart.ProductQty = mySide.ProductQty;
                    theCart.ProductCost = mySide.ProductCost;
                    theCart.ProductDetail = mySide.ProductDetail;


                    cartItems.Add(theCart);
                    return cartItems;
                }
        public static List<CartItem> DisplayCart(List<CartItem> cartItems)
        {
            return cartItems;
        }
    }

    





    }








