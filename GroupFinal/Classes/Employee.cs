using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Employee
    {
        //variable declarations
        private int employeeID;
        private string employeeFirst;
        private string employeeLast;
        private string employeePhone;
        private string employeeRole;
        private DateTime employeeHireDate;
        private string employeeStatus;
        private int employeeOrders;
        private string login;
        private string password;
        private string storeNum;

        //empty constructor
        public Employee()
        {
            employeeID = 0;
            employeeFirst = "";
            employeeLast = "";
            employeePhone = "";
            employeeRole = "";
            employeeHireDate = DateTime.Now;
            employeeStatus = "";
            employeeOrders = 0;
            login = "";
            password = "";
            storeNum = "";
        }
        //constructor with all the variables
        public Employee(int employeeID, string employeeFirst, string employeeLast, string employeePhone, string employeeRole, DateTime employeeHireDate, string employeeStatus, int employeeOrders, string employeeLogin, string employeePassword, string storeNum)
        {
            this.employeeID = employeeID;
            this.employeeFirst = employeeFirst;
            this.employeeLast = employeeLast;
            this.employeePhone = employeePhone;
            this.employeeRole = employeeRole;
            this.employeeHireDate = employeeHireDate;
            this.employeeStatus = employeeStatus;
            this.employeeOrders = employeeOrders;
            this.login = employeeLogin;
            this.password = employeePassword;
            this.storeNum = storeNum;
        }

        //get and sets for all employee variables
        public int EmployeeID { get; set; }

        public string EmployeeFirst { get; set; }

        public string EmployeeLast { get; set; }
        
        public string EmployeePhone { get; set; }

        public string EmployeeRole { get; set; }

        public DateTime EmployeeHireDate { get; set; }

        public string EmployeeStatus { get; set; }

        public int EmployeeOrders { get; set; }

        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public string StoreNum { get; set; }
    }
}