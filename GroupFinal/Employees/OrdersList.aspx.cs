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
    public partial class OrdersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Employee)Session["employee"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string storeNum = (string)Session["storeNum"];

            if (Request.Form.Get("action") == "assign")
            {
                Response.Redirect("AssignDriver.aspx?id=" + Request.Form.Get("id"));
            }

            else
            {
                TableHeaderRow header = new TableHeaderRow();
                TableHeaderCell horderId = new TableHeaderCell();
                TableHeaderCell hcustName = new TableHeaderCell();
                TableHeaderCell horderTotal = new TableHeaderCell();
                TableHeaderCell horderType = new TableHeaderCell();
                TableHeaderCell hdriver = new TableHeaderCell();
                TableHeaderCell hassign = new TableHeaderCell();
                TableHeaderCell hdelete = new TableHeaderCell();
                horderId.Text = "OrderID";
                hcustName.Text = "CustomerName";
                horderTotal.Text = "Order Total";
                horderType.Text = "Order Type";
                hdriver.Text = "Driver";
                hassign.Text = "(Re)Assign Driver";
                hdelete.Text = "Delete";
                header.Controls.Add(horderId);
                header.Controls.Add(hcustName);
                header.Controls.Add(horderTotal);
                header.Controls.Add(horderType);
                header.Controls.Add(hdriver);
                header.Controls.Add(hassign);
                header.Controls.Add(hdelete);
                table.Controls.Add(header);

                OrderList orders = new OrderList(storeNum);
                foreach (Order order in orders.getOrders())
                {
                    TableRow row = new TableRow();
                    TableCell corderID = new TableCell();
                    TableCell ccustomerName = new TableCell();
                    TableCell corderTotal = new TableCell();
                    TableCell corderType = new TableCell();
                    TableCell cdriver = new TableCell();
                    TableCell cassign = new TableCell();
                    TableCell cdelete = new TableCell();

                    corderID.Text = Convert.ToString(order.OrderID);
                    ccustomerName.Text = order.CustomerFirst + " " + order.CustomerLast;
                    corderTotal.Text = Convert.ToString(order.OrderTotal);
                    corderType.Text = order.OrderType;
                    
                    cdriver.Text = "N/A";

                    if (order.OrderType == "delivery")
                    {
                        Employee employee = EmployeeDA.GetEmployeeByID(DeliveryDA.GetDeliveryDriverByOrder(order.OrderID));

                        if (employee != null)
                        {
                            cdriver.Text = employee.EmployeeFirst + " " + employee.EmployeeLast;
                        }
                        else cdriver.Text = "Unassigned";
                        Button btnAssign = new Button();
                        btnAssign.Text = "Assign Driver";
                        btnAssign.Click += (senderer, ee) =>
                        {
                            Response.Redirect("AssignDriver.aspx?action=assign&id=" + order.OrderID);
                        };
                        
                        cassign.Controls.Add(btnAssign);
                        
                        //assignDriver = "<td><form action='AssignDriver.aspx' method='post'><input type='hidden' name='id' value='"
                        //    + orderID + "'><input type='hidden' name='action' value='assign'><input type='submit' value='Assign Driver'></form></td>";
                    }
                    else cassign.Text = "";
                    
                    Button btnDelete = new Button();
                    btnDelete.Text = "Delete Order";
                    if ((string)Session["role"] == "store manager")
                    {
                        btnDelete.Click += (senderer, ee) =>
                        {
                            Response.Redirect("Delete.aspx");
                        };
                        
                    }
                    else
                    {
                        btnDelete.Click += (senderer, ee) =>
                        {
                            Response.Redirect("ManagerLogin.aspx");
                        };
                    }
                    cdelete.Controls.Add(btnDelete);

                    row.Controls.Add(corderID);
                    row.Controls.Add(ccustomerName);
                    row.Controls.Add(corderTotal);
                    row.Controls.Add(corderType);
                    row.Controls.Add(cdriver);
                    row.Controls.Add(cassign);
                    row.Controls.Add(cdelete);
                    table.Controls.Add(row);


                }
            }

        }
    
        
    }
}
 
 