using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int storeNumber;
            string employeeID, password;

            storeNumber = Convert.ToInt32(txtStoreNumber.Text);
            employeeID = txtEmployeeID.Text;
            password = txtPassword.Text;
        }

    }
}