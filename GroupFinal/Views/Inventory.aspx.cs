using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Database;

namespace GroupFinal.Views
{
    public partial class Inventory : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Products> allProducts = ProductsDA.GetAllIngredients();

            lblIngredients.Text = Convert.ToString(allProducts);
        }
    }
}