﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Database;

namespace GroupFinal.CustomerPages
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] == null)
            {
                Response.Redirect("~");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string oldPassword = txtOldPassword.Text;
            Customer loggedIn = (Customer)Session["Customer"];
            if (!CustomerDA.VerifyLogin(loggedIn.CustomerLogin, oldPassword))
            {
                lblError.Text = "Old Password is incorrect, try again";
                lblError.Visible = true;
            }
            else
            {
                loggedIn.CustomerPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, 10);
                CustomerDA.UpdateCustomer(loggedIn);
                Session["Customer"] = loggedIn;
                Response.Redirect("~/CustomerPages/ManageCustomer");
            }
        }
    }
}