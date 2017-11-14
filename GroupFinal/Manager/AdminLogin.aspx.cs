using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;

namespace GroupFinal.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            int storeNumber;
            string login, password;

            storeNumber = Convert.ToInt32(txtStoreNumber.Text);
            login = txtAdminLogin.Text;
            password = txtPassword.Text;

            List<Employee> allAdmins = EmployeeDA.GetAllManagers();

            foreach (Employee admin in allAdmins)
            {
                if((storeNumber == Convert.ToInt16(admin.StoreNum)) &&
                    login == Convert.ToString(admin.Login) &&
                    password == Convert.ToString(admin.Password))               
                {
                    Session["employee"] = admin;
                    Session["role"] = admin.EmployeeRole;
                    Session["storeNum"] = admin.StoreNum;
                    Response.Redirect("~/Default.aspx");
                }
            }

            
        }
    }
}