using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class OrderTypes : System.Web.UI.Page
    {
        Order o = new Order();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            o.OrderType = "delivery";
        }

        protected void rdoCarryOut_CheckedChanged(object sender, EventArgs e)
        {
            o.OrderType = "carryout";
        }

        protected void btnOrderType_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Menu.aspx");
        }
    }
}