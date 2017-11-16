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
            if (Session["Customer"] == null)
            {
                Response.Redirect("~");
            }
            else
            {
                Customer loggedIn = (Customer)Session["Customer"];

                lblEmail.Text = loggedIn.CustomerLogin;
                lblFirstName.Text = loggedIn.CustomerFirst;
                lblLastName.Text = loggedIn.CustomerLast;
                lblAddress.Text = loggedIn.CustomerAddress;
                lblCity.Text = loggedIn.CustomerCity;
                lblState.Text = loggedIn.CustomerState;
                lblZip.Text = loggedIn.CustomerZip;
                lblPhone.Text = loggedIn.CustomerPhone;
            }
        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "Email";
            Session["OldValue"] = lblEmail.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerPages/PasswordChange");
        }

        protected void btnChangeFirstName_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "First Name";
            Session["OldValue"] = lblFirstName.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangeLastName_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "Last Name";
            Session["OldValue"] = lblLastName.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangeAddress_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "Address";
            Session["OldValue"] = lblAddress.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangeCity_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "City";
            Session["OldValue"] = lblCity.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangeZip_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "Zipcode";
            Session["OldValue"] = lblZip.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }

        protected void btnChangePhone_Click(object sender, EventArgs e)
        {
            Session["ValueChanging"] = "Phone";
            Session["OldValue"] = lblPhone.Text;
            Response.Redirect("~/CustomerPages/generalChange");
        }
    }
}