using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Database;
using GroupFinal.Classes;
using System.Net.Mail;
using System.Net;

namespace GroupFinal.CustomerPages
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            string password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text, 10);

            Customer c = new Customer();

            c.CustomerFirst = firstName;
            c.CustomerLast = lastName;
            c.CustomerAddress = address;
            c.CustomerCity = city;
            c.CustomerState = state;
            c.CustomerPhone = phone;
            c.CustomerLogin = login;
            c.CustomerPassword = password;

            ServiceZips zz = new ServiceZips();
            zz.ServiceZip = txtZip.Text.ToString();
            List<ServiceZips> zips = ServiceZipsDA.GetAllServiceZips();
            foreach (ServiceZips z in zips)
            {
                if (zz.ServiceZip == z.ServiceZip)
                {
                    c.CustomerZip = zz.ServiceZip;
                    c.PrimaryStore = z.StoreNum;
                    List<Customer> cc = CustomerDA.GetAllCustomers();
                    bool noDuplicates = false;
                    foreach (Customer checker in cc)
                    {
                        if (checker.CustomerLogin == c.CustomerLogin)
                        {
                            lblError.Text = "That email is already taken, try another one or try logging in";
                            lblError.Visible = true;
                            noDuplicates = false;
                            break;
                        }
                        else
                        {
                            noDuplicates = true;
                        }
                    }
                    if (noDuplicates)
                    {
                        Session["customer"] = c;
                        CustomerDA.AddCustomer(c);
                        //SmtpClient needs a host and port passed to it
                        SmtpClient client = new SmtpClient();

                        //where you declare the host
                        client.Host = "smtp.gmail.com";

                        //where you declare the port
                        client.Port = 587;

                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("shenaniganspizzaandpub@gmail.com", "NotAnEasyPassword");
                        MailAddress from = new MailAddress("shenaniganspizzaandpub@gmail.com");
                        MailAddress to = new MailAddress(login);
                        MailMessage message = new MailMessage(from, to);
                        message.Subject = "Your new account!";
                        message.Body = "Thank you for signing up for your new account " + firstName + "\nWe hope you enjoy the pizza!\n\nYour new account information,\n\n\tLogin:\t" + login + "\n\tPassword:\t" + password + "\n\tFirst Name:\t" + firstName + "\n\tLast Name:\t" + lastName + "\n\tAddress:\t" + address + "\n\tCity:\t" + city +
                            "\n\tState:\t" + state + "\n\tPhone:\t" + phone;
                        message.BodyEncoding = System.Text.Encoding.UTF8;
                        //this is closed off for when there is no host or port, can't send mail unless it's online
                        client.Send(message);


                        Response.Redirect("~/");

                    
                    }
                    
                }
                
            }
            if(lblError.Text == "")
            {
                lblError.Text = "Something went wrong with creating your account, \nWe may be unable to deliver to you currently,\nContact us if you have questions.";
                lblError.Visible = true;
            }


        }
    }
}