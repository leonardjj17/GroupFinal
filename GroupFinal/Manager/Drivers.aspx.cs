﻿using GroupFinal.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Manager
{
    public partial class Drivers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<String, int> list = DeliveryDA.getDeliveryCountForAllDriversAtStore(((Employee)Session["employee"]).StoreNum);
            foreach(KeyValuePair<string, int> entry in list)
            {
                TableRow newRow = new TableRow();
                TableCell driver = new TableCell();
                TableCell count = new TableCell();
                driver.Text = entry.Key;
                count.Text = entry.Value.ToString();
                newRow.Controls.Add(driver);
                newRow.Controls.Add(count);
                Count.Controls.Add(newRow);
            }
        }
    }
}