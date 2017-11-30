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
        Products specials = null;
        List<CartItem> cartItems;

        protected void Page_Load(object sender, EventArgs e)
        {
            cartItems = new List<CartItem>();
            //Session["Products"] = p;
            //Response.Redirect("~/views/CartView");
        }

        protected void rdoFamPk_CheckedChanged(object sender, EventArgs e)
        {
            specials.ProductPrice = 19.99;
            specials.ProductType = "Special";
            specials.ProductDetail = "Family Pack";
        }

        protected void rdoIndivPk_CheckedChanged(object sender, EventArgs e)
        {
            specials.ProductPrice = 9.99;
            specials.ProductType = "Special";
            specials.ProductDetail = "Individual Pack";
        }

        protected void rdoLGFamPk_CheckedChanged(object sender, EventArgs e)
        {
            specials.ProductPrice = 29.99;
            specials.ProductType = "Special";
            specials.ProductDetail = "Large Family Pack";

        }

    }
}