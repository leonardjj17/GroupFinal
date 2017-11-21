using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Employees
{
    public partial class CustomerSignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["employee"] = null;
            Session["role"] = null;
            Session["storeNum"] = null;

            Response.Redirect("~");
        }
    }
}