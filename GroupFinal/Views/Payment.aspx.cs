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
                Label guest = new Label();
                Label lblFirstName = new Label();
                Label lblLastName = new Label();
                lblName.Enabled = false;

                TextBox txtFirstName = new TextBox();
                TextBox txtLastName = new TextBox();

                guest.Text = "Not signed in? No problem, just enter some quick info";
                lblFirstName.Text = "First Name: ";
                lblLastName.Text = "Last Name: ";


                pnlNewCustomer.Controls.Add(guest);
                pnlNewCustomer.Controls.Add(new LiteralControl("</br>"));

                pnlNewCustomer.Controls.Add(lblFirstName);
                pnlNewCustomer.Controls.Add(new LiteralControl("\t"));
                pnlNewCustomer.Controls.Add(txtFirstName);
                pnlNewCustomer.Controls.Add(new LiteralControl("</br>"));

                pnlNewCustomer.Controls.Add(lblLastName);
                pnlNewCustomer.Controls.Add(new LiteralControl("\t"));
                pnlNewCustomer.Controls.Add(txtLastName);
                pnlNewCustomer.Controls.Add(new LiteralControl("</br>"));


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