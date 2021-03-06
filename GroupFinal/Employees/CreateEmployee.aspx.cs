﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.DA;

namespace GroupFinal.Employees
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["storeNum"] == null) || ((string)Session["role"] != "store manager"))
            {
                Response.Redirect("~");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string status = cmboStatus.SelectedItem.Text;
            string role = cmboJob.Text;
            string login = txtLogin.Text;
            string password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text,10);

            Employee newEmployee = new Employee();

            List<Employee> cc = EmployeeDA.GetAllEmployees();
            bool noDuplicates = false;
            foreach (Employee checker in cc)
            {
                if (checker.Login == login)
                {
                    lblError.Text = "That login is already taken, try a different one!";
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
                newEmployee.EmployeeFirst = firstName;
                newEmployee.EmployeeLast = lastName;
                newEmployee.EmployeeStatus = status;
                newEmployee.EmployeeHireDate = now;
                newEmployee.EmployeeRole = role;
                newEmployee.Login = login;
                newEmployee.Password = password;
                newEmployee.StoreNum = (string)Session["storeNum"];

                EmployeeDA.AddNewEmployee(newEmployee);
                Session["Message"] = "New Employee added! Welcome, " + firstName;
                Response.Redirect("~/Employees/Home");
            }
        }
    }
}