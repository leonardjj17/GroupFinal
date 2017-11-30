using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<CartItem> cartItems;
        Customer currentCustomer;
        Order currentOrder;
        double total = 0;
        string customerName = "";
        DateTime deliveryTime = new DateTime();
        DateTime date = DateTime.Now;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<CartItem> cartItems = (List<CartItem>)Session["items"];
            currentCustomer = (Customer)Session["customer"];
            currentOrder = (Order)Session["Order"];

            if(currentCustomer != null)
            {
                customerName = currentCustomer.CustomerFirst + " " + currentCustomer.CustomerLast;
                lblCustomerName.Text = customerName;
            }

            else
            {
                customerName = "Guest";
                lblCustomerName.Text = customerName;
            }

            deliveryTime = date.AddMinutes(Convert.ToDouble(currentOrder.OrderEstimation));

            lblOrderType.Text = currentOrder.OrderType;
            lblOrderEstimation.Text = Convert.ToString(deliveryTime);

            lblDate.Text = Convert.ToString(date);

            foreach(CartItem item in cartItems)
            {
                total += item.ProductPrice;
            }

            lblTotal.Text = total.ToString("c2");
            
        }
    }
}