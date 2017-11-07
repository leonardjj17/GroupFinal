using GroupFinal.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Views
{
    public partial class Drinks : System.Web.UI.Page
    {
        List<Products> allDrinks = ProductsDA.GetAllDrinks();
        List<Products> allAlcohol = ProductsDA.GetAllAlcohol();

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void loadDrinks()
        {
            pnlDrink.Controls.Clear();
            pnlSize.Visible = true;
            
            foreach (Products drink in allDrinks)
            {
                RadioButton newDrink = new RadioButton();
                newDrink.Text = drink.ProductDetail;
                newDrink.GroupName = "grpDrinks";

                pnlDrink.Controls.Add(newDrink);
                pnlDrink.Controls.Add(new LiteralControl("<br />"));
            }
        }
        protected void loadAlcohol()
        {
            pnlDrink.Controls.Clear();
            pnlSize.Visible = false;
            foreach (Products alcohol in allAlcohol)
            {
                RadioButton newAlcohol = new RadioButton();
                newAlcohol.Text = alcohol.ProductDetail;
                newAlcohol.GroupName = "grpAlcohol";

                pnlDrink.Controls.Add(newAlcohol);
                pnlDrink.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdoSoft.Checked == true)
            {
                //do stuff for softdrinks
            }
            else
            {
                //do stuff for alcohol
            }


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSoft.Checked == true)
            {
                loadDrinks();
            }
            else
            {
                loadAlcohol();
            }
        }
    }
}