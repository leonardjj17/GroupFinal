using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Classes;
using System.Net.Mail;

namespace GroupFinal.Views
{
    public partial class OrderReciept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["customer"] == null)
            {
                Response.Redirect("~");
            }

            Customer theCustomer = (Customer)Session["Customer"];
            List<Order> customerOrders = OrderDA.GetAllOrdersByCustomer(theCustomer.CustomerFirst, theCustomer.CustomerLast);

            foreach(Order o in customerOrders)
            {
                lblFirst.Text = o.CustomerFirst;
                lblLast.Text = o.CustomerLast;
                lblOrderTotal.Text = o.OrderTotal.ToString("c2");
                lblStoreNumber.Text = Convert.ToString(o.StoreNum);
                
                lblOrderType.Text = o.OrderType;
            }
            
            //Needs the customers email passed to the "to" variable to work.
            /*
            SmtpClient client = new SmtpClient();

            MailAddress from = new MailAddress("noreply@shenaniganspizza.com", "O'Shea Shenanigan's Pizza", System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress();
            MailMessage message = new MailMessage(from, to);
            message.Body = "Thank you for signing up for your new account " + firstName + "\nWe hope you enjoy the pizza!";
            message.BodyEncoding = System.Text.Encoding.UTF8;
            client.Send(message);
            */
        }
    }
}