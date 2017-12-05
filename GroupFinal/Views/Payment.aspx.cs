using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;
using GroupFinal.DA;
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
            if (Session["Order"] == null || Session["items"] == null)
                Response.Redirect("~");

            
            
                string currentTime = Convert.ToString(date.Hour + ": " + date.Minute);

                List<CartItem> cartItems = (List<CartItem>)Session["items"];
                currentCustomer = (Customer)Session["customer"];
                currentOrder = (Order)Session["Order"];

                if (currentCustomer != null)
                {
                    customerName = currentCustomer.CustomerFirst + " " + currentCustomer.CustomerLast;
                    lblCustomerName.Text = customerName;
                }

                else
                {
                    pnlNewCustomer.Visible = true;                
                }
                if (currentCustomer != null)
                {
                    deliveryTime = date.AddMinutes(Convert.ToDouble(currentOrder.OrderEstimation));
                }
                else
                {
                    deliveryTime = date;
                }

                string deliveryEstimated = Convert.ToString(deliveryTime.Hour + ": " + deliveryTime.Minute);

                lblOrderType.Text = currentOrder.OrderType;
                lblOrderEstimation.Text = deliveryEstimated + ". That's about " + currentOrder.OrderEstimation + " minutes from now";

                //lblDate.Text = Convert.ToString(currentTime);

                foreach (CartItem item in cartItems)
                {
                    total += item.ProductPrice;
                }

                lblTotal.Text = total.ToString("c2");
            
        }

        protected void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            List<CartItem> cartItems = (List<CartItem>)Session["items"];
            if(currentCustomer != null)
            {
                currentOrder.CustomerFirst = currentCustomer.CustomerFirst;
                currentOrder.CustomerLast = currentCustomer.CustomerLast;
                currentOrder.OrderDate = DateTime.Now;
                currentOrder.OrderTotal = total;
                OrderDA.SaveOrder(currentOrder);
                currentOrder = OrderDA.GetCustomersLatestOrder(currentCustomer.CustomerFirst, currentCustomer.CustomerLast);
                foreach(CartItem item in cartItems)
                {
                    int productID = item.ProductID;
                    int orderID = currentOrder.OrderID;
                    string productDetail = item.Description;

                    OrderDA.SaveOrderLineItems(orderID, productID, productDetail);
                }
                Session["Receipt"] = currentOrder;
            }
            else
            {
                currentOrder.CustomerFirst = txtFirstName.Text;
                currentOrder.CustomerLast = txtLastName.Text;
                currentOrder.OrderDate = DateTime.Now;
                currentOrder.OrderTotal = total;
                OrderDA.SaveOrder(currentOrder);
                currentOrder = OrderDA.GetCustomersLatestOrder(currentOrder.CustomerFirst, currentOrder.CustomerLast);
                foreach(CartItem item in cartItems)
                {
                    int productID = item.ProductID;
                    int orderID = currentOrder.OrderID;
                    string productDetail = item.ProductDetail;

                    OrderDA.SaveOrderLineItems(orderID, productID, productDetail);
                }
                Session["Receipt"] = currentOrder;
            }
            Response.Redirect("OrderReciept.aspx");
        }
    }
}