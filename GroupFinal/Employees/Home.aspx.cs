//using GroupFinal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Employees
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Employee employee = (Employee)Session["employee"];
            string role = (string)Session["role"];
            if (Session["employee"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblUserName.Text = employee.EmployeeFirst;
            //Linkbutton data to make sure it's only visible if you're a manager
            if (role == "store manager")
            {
                lnkEmployeeListing.Visible = true;
                lnkCreateEmployee.Visible = true;
            }
            if(Session["Message"] != null)
            {
                lblMessage.Text = (string)Session["Message"];
                Session["Message"] = null;
            }
        }

        protected void lnkEmployeeListing_Click(object sender, EventArgs e)
        {

        }
    }
}