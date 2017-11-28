using GroupFinal.DA;
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
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            if (EmployeeDA.verifyLogin(login, password)) { 
                //find out if username exists had has correct password
                Employee employee = EmployeeDA.GetEmployeeByLogin(login);
                
                Session["employee"] = employee;
                Session["role"] = employee.EmployeeRole;
                Session["storeNum"] = employee.StoreNum;
                Response.Redirect("Home.aspx");
            }
        }
    }
}