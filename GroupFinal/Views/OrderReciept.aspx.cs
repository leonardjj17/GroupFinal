using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class OrderReciept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string customerFirst = "Billy";
            string customerLast = "Batts";

            List<Order> customerOrders = OrderDA.GetAllOrdersByCustomer(customerFirst, customerLast);

            foreach(Order o in customerOrders)
            {
                lblFirst.Text = o.CustomerFirst;
                lblLast.Text = o.CustomerLast;
                lblOrderTotal.Text = o.OrderTotal.ToString("c2");
                lblStoreNumber.Text = Convert.ToString(o.StoreNum);
                lblIsFavorite.Text = o.IsFavorite;
                lblOrderType.Text = o.OrderType;
            }
        }
    }
}