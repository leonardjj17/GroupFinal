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
    public partial class Sides : System.Web.UI.Page
    {
        List<Products> allSides = ProductsDA.GetAllSides();

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(Products sides in allSides)
            {
                CheckBox newSide = new CheckBox();
                newSide.Text = sides.ProductDetail;

                pnlSides.Controls.Add(newSide);
                pnlSides.Controls.Add(new LiteralControl("<br />"));

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double sideTotal = 0;
            string selectedSides = "";
            

            foreach(Control sides in pnlSides.Controls)
            {
                if (sides.GetType().Name == "CheckBox")
                {
                    if(((CheckBox)sides).Checked)
                    {
                        string currentSide = ((CheckBox)sides).Text;
                        selectedSides += currentSide + " ";
                        foreach (Products s in allSides)
                        {
                            if(s.ProductDetail == currentSide)
                            {
                                sideTotal += s.ProductPrice;
                            }
                        }
                    }
                }
            }


        }
    }
}