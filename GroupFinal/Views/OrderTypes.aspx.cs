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
        Order OrderType = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            OrderType = delivery;
        }

        protected void rdoCarryOut_CheckedChanged(object sender, EventArgs e)
        {
            OrderType = "carryout";
        }

        protected void btnOrderType_Click(object sender, EventArgs e)
        {

        }
    }
}