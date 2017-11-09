using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class Specials : System.Web.UI.Page
    {
        Products p = new Products();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Products"] = p;
            Response.Redirect("~/views/CartView");
        }

        protected void rdoFamPk_CheckedChanged(object sender, EventArgs e)
        {
            p.ProductPrice = 19.99;
            p.ProductType = "Special";
            p.ProductDetail = "Family Pack";
        }

        protected void rdoIndivPk_CheckedChanged(object sender, EventArgs e)
        {
            p.ProductPrice = 9.99;
            p.ProductType = "Special";
            p.ProductDetail = "Individual Pack";
        }

        protected void rdoLGFamPk_CheckedChanged(object sender, EventArgs e)
        {
            p.ProductPrice = 29.99;
            p.ProductType = "Special";
            p.ProductDetail = "Large Family Pack";

        }

    }
}