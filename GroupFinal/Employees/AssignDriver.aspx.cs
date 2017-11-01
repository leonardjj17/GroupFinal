using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Employees
{
    public partial class AssignDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Employee)Session["employee"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string storeNum = (string)Session["storeNum"];


            Label lblStoreID = new Label();
            lblStoreID.Text ="<input type='hidden' name='storeID' value='" + Request.QueryString.Get("id") + "'>";
            pnlStoreID.Controls.Add(lblStoreID);
            
            List<Employee> drivers = EmployeeDA.GetDriversByStoreNumber(storeNum);
            foreach (Employee driver in drivers)
            {
                Label lblDriver = new Label();

                string name = driver.EmployeeFirst + " " + driver.EmployeeLast;
                int employeeID = driver.EmployeeID;
                

                lblDriver.Text = "<option value='" + employeeID + "'>" + name + "</option>";
                pnlDrivers.Controls.Add(lblDriver);

            }
            

        }
    }
}