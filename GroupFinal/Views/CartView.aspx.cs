using GroupFinal.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Views
{
    public partial class CartView : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["theCart"] != null)

            {
                Cart theCart = (Cart)Session["theCart"];
                
            }

            
        }

        protected void continueOrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void gvShoppingCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {

        }

        protected void gvShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        //private void FillData()
        //{
        //    gvShoppingCart.DataSource = theCart.Items;
        //    gvShoppingCart.DataBind();
        //    if (cart.Items.Count == 0)
        //    {
        //        lblTotal.Visible = false;
        //    }
        //    else
        //    {
        //        lblTotal.Text = string.Format("{ 0,19:C}", cart.Total);
        //    }
        //}

        //public List<CartItem> GetShoppingCartItems()
        // {
        //     ShoppingCartActions actions = new ShoppingCartActions();
        //     return actions.GetCartItems();
        // }
    }
}