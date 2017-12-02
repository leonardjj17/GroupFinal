﻿using GroupFinal.Classes;
using GroupFinal.DA;

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

        protected void ContinueOrderBtn_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Menu.aspx");

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

       
        protected void SubmitOrderBtn_Click(object sender, EventArgs e)
        {
            Cart cart = (Cart)Session["theCart"];

            if(Session["customer"] != null)
            {
                Customer theCustomer = (Customer)Session["customer"];

                myOrder.CustomerFirst = theCustomer.CustomerFirst;
                myOrder.CustomerLast = theCustomer.CustomerLast;
                myOrder.OrderTotal = cart.Total;
                myOrder.StoreNum = theCustomer.PrimaryStore;
                myOrder.OrderDate = DateTime.Now;

                
                OrderDA.SaveOrder(myOrder);
                myOrder.convertThenSave(cart);
                

            }
            

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

    }
}