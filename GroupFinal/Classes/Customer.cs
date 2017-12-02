using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class Customer
    {
        private int customerID;
        private string customerFirst;
        private string customerLast;
        private string customerAddress;
        private string customerCity;
        private string customerState;
        private string customerPhone;
        private string customerRole;
        private string primaryStore;
        private string customerLogin;
        private string customerPassword;
        private string customerZIP;

        public Customer()
        {

        }

        public Customer(int customerID, string customerFirst, string customerLast, string customerAddress, string customerCity, 
            string customerState, string customerZip, string customerPhone, string customerRole, string primaryStore, string customerLogin, string customerPassword)

        {
            this.customerID = CustomerID;
            this.customerFirst = CustomerFirst;
            this.customerLast = CustomerLast;
            this.customerAddress = CustomerAddress;
            this.customerCity = CustomerCity;
            this.customerState = CustomerState;
            this.customerZIP = CustomerZip;
            this.customerPhone = CustomerPhone;
            this.customerRole = CustomerRole;
            this.primaryStore = PrimaryStore;
            this.customerLogin = CustomerLogin;
            this.customerPassword = CustomerPassword;
        }

        public int CustomerID { get; set; }
        public string CustomerFirst { get; set; }
        public string CustomerLast { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerRole { get; set; }
        public string PrimaryStore { get; set; }
        public string CustomerLogin { get; set; }
        public string CustomerPassword { get; set; }



    }
}