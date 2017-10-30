using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;
using GroupFinal.Classes;
using GroupFinal.Database;

namespace GroupFinal.Views
{
    public partial class FinancialView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Financial currentStore = FinancialDA.GetTotalBalanceByStoreNum((string)Session["storeNum"]);
            lblStoreNumber.Text = (string)Session["storeNum"];
            lblStoreBalance.Text = Convert.ToString(currentStore.StoreBalance);
        }
    }
}