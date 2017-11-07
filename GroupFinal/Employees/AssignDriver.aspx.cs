using GroupFinal.DA;
using GroupFinal.Database;
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
            orderID.Value = Request.QueryString.Get("id");
            

            List<Employee> drivers = EmployeeDA.GetDriversByStoreNumber(storeNum);
            foreach (Employee driver in drivers)
            {
                Label lblDriver = new Label();

                string name = driver.EmployeeFirst + " " + driver.EmployeeLast;
                int employeeID = driver.EmployeeID;
                ListItem listItem = new ListItem(name, Convert.ToString(employeeID));
                driverList.Items.Add(listItem);


            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DeliveryDA.AddDriverToOrder(OrderDA.getOrderByID(Convert.ToInt32(orderID)), EmployeeDA.GetEmployeeByID(Convert.ToInt32(driverList.SelectedValue)));
        }
    }
}