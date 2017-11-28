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
                    TableCell cmarkComplete = new TableCell();

                    corderID.Text = Convert.ToString(order.OrderID);
                    ccustomerName.Text = order.CustomerFirst + " " + order.CustomerLast;
                    corderTotal.Text = String.Format("{0:c}",order.OrderTotal);
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
                            Response.Redirect("../Manager/AdminLogin.aspx");
                        };
                    }

                    cdelete.Controls.Add(btnDelete);

                    Button btnMarkComplete = new Button();
                    btnMarkComplete.Text = "Complete";
                    btnMarkComplete.Click += (senderer, ee) =>
                    {
                        OrderDA.setOrderComplete(order);
                        Response.Redirect("OrdersList.aspx");
                    };
                    cmarkComplete.Controls.Add(btnMarkComplete);

                    row.Controls.Add(corderID);
                    row.Controls.Add(ccustomerName);
                    row.Controls.Add(corderTotal);
                    row.Controls.Add(corderType);
                    row.Controls.Add(cdriver);
                    row.Controls.Add(cassign);
                    row.Controls.Add(cdelete);
                    row.Controls.Add(cmarkComplete);
                    table.Controls.Add(row);


                }
            }

        }
    
        
    }
}
 
 