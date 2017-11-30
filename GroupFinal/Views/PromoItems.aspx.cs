using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;
using GroupFinal.Database;

namespace GroupFinal.Views
{
    public partial class PromoItems : System.Web.UI.Page
    {

        List<CartItem> cartItems;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Promotional shirt1 = new Promotional();
            Promotional shirt2 = new Promotional();
            Promotional shirt3 = new Promotional();
            Promotional shirt4 = new Promotional();

            if (ddlQtyShirt1.SelectedValue != "0" && ddlSizeShirt1.SelectedValue != " ")
            {
                shirt1.ProductPrice = 15.99;
                shirt1.ProductQty = Convert.ToInt32(ddlQtyShirt1.SelectedValue);
                shirt1.PromotionalSize = ddlSizeShirt1.SelectedValue;
                shirt1.ProductType = "Promotional";
                shirt1.ProductDetail = "Let the Shenanigans begin female shirt";
            }
            else
            {
                shirt1 = null;
            }
            if (ddlQtyShirt2.SelectedValue != "0" && ddlSizeShirt2.SelectedValue != " ")
            {
                shirt2.ProductPrice = 15.99;
                shirt2.ProductQty = Convert.ToInt32(ddlQtyShirt2.SelectedValue);
                shirt2.PromotionalSize = ddlSizeShirt2.SelectedValue;
                shirt2.ProductType = "Promotional";
                shirt2.ProductDetail = "Kiss me I'm a piza baker shirt";
            }
            else
            {
                shirt2 = null;
            }
            if (ddlQtyShirt3.SelectedValue != "0" && ddlSizeShirt3.SelectedValue != " ")
            {
                shirt3.ProductPrice = 15.99;
                shirt3.ProductQty = Convert.ToInt32(ddlQtyShirt3.SelectedValue);
                shirt3.PromotionalSize = ddlSizeShirt3.SelectedValue;
                shirt3.ProductType = "Promotional";
                shirt3.ProductDetail = "I shamrock Shenanigans shirt";
            }
            else
            {
                shirt3 = null;
            }
            if (ddlQtyShirt4.SelectedValue != "0" && ddlSizeShirt4.SelectedValue != " ")
            {
                shirt4.ProductPrice = 15.99;
                shirt4.ProductQty = Convert.ToInt32(ddlQtyShirt4.SelectedValue);
                shirt4.PromotionalSize = ddlSizeShirt4.SelectedValue;
                shirt4.ProductType = "Promotional";
                shirt4.ProductDetail = "I shamrock Shenanigans shirt";
            }
            else
            {
                shirt4 = null;
            }

            double orderTotal = 0;
            
            if(shirt1 != null)
            {
                shirt1.ProductPrice += orderTotal;
            }
            if (shirt2 != null)
            {
                shirt2.ProductPrice += orderTotal;
            }
            if (shirt3 != null)
            {
                shirt3.ProductPrice += orderTotal;
            }
            if (shirt4 != null)
            {
                shirt4.ProductPrice += orderTotal;
            }

        }
    }
}