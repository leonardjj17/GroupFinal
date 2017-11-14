using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.CustomerPages
{
    public partial class ManageCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer loggedIn = (Customer)Session["Customer"];

            lblEmail.Text = loggedIn.CustomerLogin;
            lblFirstName.Text = loggedIn.CustomerFirst;
            lblLastName.Text = loggedIn.CustomerLast;
            lblAddress.Text = loggedIn.CustomerAddress;
            
        }
    }
}