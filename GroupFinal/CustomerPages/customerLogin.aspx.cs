using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;
using GroupFinal.Database;

namespace GroupFinal.CustomerPages
{
    public partial class customerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Customer c = CustomerDA.GetCustomerByLogin(email);

            if(c == null)
            {
                lblError.Text = "No such email please try again or <a runat='server' href='customerSignUp.aspx'>sign up!</a>";
                lblError.Visible = true;
            }
            else
            {
                if(CustomerDA.VerifyLogin(email, password))
                {
                    Session["Customer"] = c;
                    Response.Redirect("~");
                }
                else
                {
                    lblError.Text = "Incorrect Email/Password try again";
                    lblError.Visible = true;
                }
            }
        }
    }
}