﻿using GroupFinal.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Views
{
    public partial class CartView : System.Web.UI.Page
    {
        Order myOrder = new Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["theCart"] != null)

            {
                Cart theCart = (Cart)Session["theCart"];
                
            }


            
        }

        protected void continueOrderBtn_Click(object sender, EventArgs e)
        {
            //Session["theCart"] = theCart;
            Response.Redirect("Menu.aspx");

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

       
        protected void submitOrderBtn_Click(object sender, EventArgs e)
        {
            Cart cart = (Cart)Session["theCart"];

            if(Session["customer"] != null)
            {
                Customer theCustomer = (Customer)Session["customer"];

                myOrder.CustomerFirst = theCustomer.CustomerFirst;
                myOrder.CustomerLast = theCustomer.CustomerLast;
                myOrder.OrderTotal = cart.Total;
                myOrder.StoreNum = theCustomer.PrimaryStore;
                

            }
            

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        //private void FillData()
        //{
        //    gvShoppingCart.DataSource = theCart.Items;
        //    gvShoppingCart.DataBind();
        //    if (cart.Items.Count == 0)
        //    {
        //        lblTotal.Visible = false;
        //    }
        //    else
        //    {
        //        lblTotal.Text = string.Format("{ 0,19:C}", cart.Total);
        //    }
        //}

        //public List<CartItem> GetShoppingCartItems()
        // {
        //     ShoppingCartActions actions = new ShoppingCartActions();
        //     return actions.GetCartItems();
        // }
    }
}