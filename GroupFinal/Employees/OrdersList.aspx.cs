﻿using GroupFinal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Employees
{
    public partial class OrdersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Employee)Session["employee"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string storeNum = (string)Session["storeNum"];

            OrderList orders = new OrderList(storeNum);
            foreach (Order order in orders.getOrders())
            {
                Label lblOrder = new Label();

                int orderID = order.OrderID;
                string customerName = order.CustomerFirst + " " + order.CustomerLast;
                double orderTotal = order.OrderTotal;
                string orderType = order.OrderType;
                string delete = null;
                if ((string)Session["role"] == "store manager") {
                    delete = "<td><form action='delete.aspx' method='post'><input type='hidden' id='id' value='"
                        + orderID + "'><input type='submit' value=Delete></form></td>";

                }
                lblOrder.Text = "<tr><td>" + orderID + "</td><td>" + customerName + "</td><td>"
                    + orderTotal + "</td><td>" + orderType + "</td>" + delete + "</tr>";
            }

        }
    }
}
 