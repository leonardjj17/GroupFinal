using GroupFinal.Classes;
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
            int driverID = DeliveryDA.GetDeliveryDriverByOrder(Convert.ToInt32(orderID.Value));

            List<Employee> drivers = EmployeeDA.GetDriversByStoreNumberWithDeliveryCount(storeNum);
            foreach (Employee driver in drivers)
            {
                string name = driver.EmployeeFirst + " " + driver.EmployeeLast;
                int employeeID = driver.EmployeeID;
                ListItem listItem = new ListItem(name, Convert.ToString(employeeID));
                if (employeeID == driverID)
                {
                    listItem.Selected = true;
                }
                driverList.Items.Add(listItem);


            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Order order = OrderDA.GetOrderByID(Convert.ToInt32(orderID.Value));
            Employee employee = EmployeeDA.GetEmployeeByID(Convert.ToInt32(driverList.SelectedValue));
            if (DeliveryDA.GetDeliveryByOrderID(order.OrderID) != null)
            {
                DeliveryDA.UpdateDriverForOrder(order, employee);
            }
            else
            {
                DeliveryDA.AddDriverToOrder(order, employee);
            }
            Response.Redirect("OrdersList.aspx");
        }
    }
}