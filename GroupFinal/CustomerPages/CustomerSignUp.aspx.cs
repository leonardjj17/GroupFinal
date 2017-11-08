using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.CustomerPages
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = cmboState.SelectedValue;
            string zip = txtZip.Text;
            string phone = txtPhone.Text;
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            Customer c = new Customer();

            c.CustomerFirst = firstName;
            c.CustomerLast = lastName;
            c.CustomerAddress = address;
            c.CustomerCity = city;
            c.CustomerState = state;
            c.CustomerPhone = phone;
            c.CustomerLogin = login;
            c.CustomerPassword = password;


        }
    }
}