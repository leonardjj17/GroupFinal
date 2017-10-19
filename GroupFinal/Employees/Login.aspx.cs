using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Employees
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String login = txtUsername.Text;
            String password = txtPassword.Text;


            //find out if username exists had has correct password

            if (true)
            {
                Session["login"] = login;
                Response.Redirect("Home.aspx");
            }
        }
    }
}