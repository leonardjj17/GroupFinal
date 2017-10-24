using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static GroupFinal.Database.ProductsDA;

namespace GroupFinal.Views
{
    public partial class Inventory : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Products> allProducts = GetAllIngredients();

            lstIngredients.Text = Convert.ToString(allProducts);
        }
    }
}