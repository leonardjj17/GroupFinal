
using GroupFinal.Classes;
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
            if (Session["employee"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            lblUserName.Text = employee.EmployeeFirst;
            //Linkbutton data to make sure it's only visible if you're a manager
            if (employee.EmployeeRole == "store manager")
            {
                lnkEmployeeListing.Visible.Equals(true);
            }
        }
    }
}