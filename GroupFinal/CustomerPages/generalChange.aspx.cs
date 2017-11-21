using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Database;
using GroupFinal.Classes;

namespace GroupFinal.CustomerPages
{
    public partial class generalChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ValueChanging"] == null)
            {
                Response.Redirect("~");
            }
            else
            {

                lblChanging.Text = (string)Session["ValueChanging"];
                if (lblChanging.Text == "Zip")
                {
                    txtChangedValue.MaxLength = 5;
                }
                if(lblChanging.Text == "Email")
                {
                    validatorEmail.Enabled = true;
                }
                if(lblChanging.Text == "Phone")
                {
                    validatorPhone.Enabled = true;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Customer changedCustomer = (Customer)Session["Customer"];
            bool noErrors = true;
            switch ((string)Session["ValueChanging"])
            {
                case ("Email"):
                    List<Customer> cc = CustomerDA.GetAllCustomers();
                    bool noDuplicates = false;
                    foreach(Customer c in cc)
                    {
                        if(c.CustomerLogin == txtChangedValue.Text)
                        {
                            lblError.Text = "That email is already claimed, try a different email";
                            lblError.Visible = true;
                            noDuplicates = false;
                            noErrors = false;
                            break;
                        }
                        else
                        {
                            noDuplicates = true;
                        }
                    }
                    if (noDuplicates)
                    {
                        changedCustomer.CustomerLogin = txtChangedValue.Text;
                    }
                    break;
                case ("First Name"):
                    changedCustomer.CustomerFirst = txtChangedValue.Text;
                    break;
                case ("Last Name"):
                    changedCustomer.CustomerLast = txtChangedValue.Text;
                    break;
                case ("Phone"):                    
                    changedCustomer.CustomerPhone = txtChangedValue.Text;
                    break;
                case ("Address"):
                    changedCustomer.CustomerAddress = txtChangedValue.Text;
                    break;
                case ("City"):
                    changedCustomer.CustomerCity = txtChangedValue.Text;
                    break;
                case ("Zip"):
                    ServiceZips zz = new ServiceZips();
                    zz.ServiceZip = txtChangedValue.Text.ToString();
                    List<ServiceZips> zips = ServiceZipsDA.GetAllServiceZips();
                    foreach (ServiceZips z in zips)
                    {
                        if (zz.ServiceZip == z.ServiceZip)
                        {
                            changedCustomer.CustomerZip = txtChangedValue.Text;
                            changedCustomer.PrimaryStore = zz.StoreNum;
                        }
                        else
                        {
                            lblError.Text = "We can't deliver to that zipcode, contact us with further questions";
                            lblError.Visible = true;
                            noErrors = false;
                        }
                    }
                    break;
            }
            if (noErrors)
            {
                CustomerDA.UpdateCustomer(changedCustomer);
                Session["Customer"] = changedCustomer;
                Response.Redirect("~/CustomerPages/ManageCustomer");
            }
        }
    }
}