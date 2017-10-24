using GroupFinal.Classes;
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
            string storeNum = (string)Session["storeNum"];

            OrderList orders = new OrderList(storeNum);
            foreach (Order order in orders.getOrders())
            {

            }

        }
    }
}