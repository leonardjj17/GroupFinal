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
        Cart cart;

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        //private void FillData()
        //{
        //    gvShoppingCart.DataSource = cart.Items;
        //    gvShoppingCart.DataBind();
        //    if(cart.Items.Count == 0)
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