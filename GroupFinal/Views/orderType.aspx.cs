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
    public partial class orderType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Customer"] != null)
            {
                Customer theCustomer = (Customer)Session["Customer"];
                txtZip.Text = theCustomer.CustomerZip;
            }
        }

        protected void btnOrderType_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            ServiceZips zip = new ServiceZips();
            zip.ServiceZip = txtZip.Text.ToString();
            List<ServiceZips> zips = ServiceZipsDA.GetAllServiceZips();
            foreach (ServiceZips z in zips)
            {
                if (zip.ServiceZip == z.ServiceZip)
                {
                    o.StoreNum = z.StoreNum;

                    if(rdoCarryOut.Checked)
                    {
                        o.OrderType = "carryout";
                        o.OrderEstimation = "20";
                    }
                    else
                    {
                        o.OrderType = "delivery";
                        o.OrderEstimation = "50";
                    }

                    Session["Order"] = o;
                    Response.Redirect("~/Views/Menu.aspx");
                }
                else
                {

                }
            }
            
        }
    }
}