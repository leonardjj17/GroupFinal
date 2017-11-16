using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Database;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class Sides : System.Web.UI.Page
    {
        List<Products> allSides = ProductsDA.GetAllSides();

        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(Products sides in allSides)
            {
                RadioButton newSide = new RadioButton();
                Image breadsticks = new Image();
                Image cinnasticks = new Image();
                Image garlicKnots = new Image();

                breadsticks.ImageUrl = "~/images/breadsticks.png";
                breadsticks.Width = 300;
                breadsticks.Height = 200;

                cinnasticks.ImageUrl = "~/images/cinnasticks.png";
                cinnasticks.Width = 300;
                breadsticks.Height = 250;

                garlicKnots.ImageUrl = "~/images/garlicKnots.jpg";
                garlicKnots.Width = 300;
                garlicKnots.Height = 200;

                
                newSide.Text = sides.ProductDetail;
                if (newSide.Text == "breadsticks")
                {
                    pnlSides.Controls.Add(breadsticks);
                    pnlSides.Controls.Add(newSide);
                    pnlSides.Controls.Add(new LiteralControl("<br />"));
                    newSide.GroupName = "side";
                } else if (newSide.Text == "cinna sticks")
                {
                    pnlSides.Controls.Add(cinnasticks);
                    pnlSides.Controls.Add(newSide);
                    pnlSides.Controls.Add(new LiteralControl("<br />"));
                    newSide.GroupName = "side";
                } else if (newSide.Text == "garlic knots")
                {
                    pnlSides.Controls.Add(garlicKnots);
                    pnlSides.Controls.Add(newSide);
                    pnlSides.Controls.Add(new LiteralControl("<br />"));
                    newSide.GroupName = "side";
                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double sideTotal = 0;
            string selectedSides = "";

            Side newSide = null;
            

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


            newSide = new Side(selectedSides, sideTotal, 1, sideTotal, "Side Item", 1, sideTotal, selectedSides);

            Session["side"] = newSide;

            Response.Redirect("CartView.aspx");



            //newSide.SideType = selectedSides;
            //newSide.SidePrice = sideTotal;
        }
    }
}