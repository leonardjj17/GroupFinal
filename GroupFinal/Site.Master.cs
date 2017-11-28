using GroupFinal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal
{
    public partial class SiteMaster : MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if(Session["Customer"] != null)
            {
                Customer customer = (Customer)Session["Customer"];
                string userName = customer.CustomerFirst + " " + customer.CustomerLast;
            }

           
        }
    }
}