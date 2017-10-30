using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class PizzaView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pizza newPizza = new Pizza();
        }
    }
}