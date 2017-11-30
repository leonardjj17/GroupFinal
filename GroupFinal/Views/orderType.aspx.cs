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
        
        Order o = new Order();
        ServiceZips zip = new ServiceZips();
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
            Response.Redirect("~/Views/Menu.aspx");
            Session["Order"] = o;
        }

        protected void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            o.OrderType = "delivery";
        }

        protected void rdoCarryOut_CheckedChanged(object sender, EventArgs e)
        {
            o.OrderType = "carryout";
        }

        protected void txtZip_TextChanged(object sender, EventArgs e)
        {
            zip.ServiceZip = txtZip.ToString();
            List<ServiceZips> zips = ServiceZipsDA.GetAllServiceZips();
            foreach(ServiceZips z in zips)
            {
                if(zip.ServiceZip == z.ServiceZip)
                {
                    o.StoreNum = z.StoreNum;
                }
            }
         
        }
    }
}