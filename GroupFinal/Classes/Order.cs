using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Order
    {
        //variable declarations
        private int orderID;
        private string customerFirst;
        private string customerLast;
        private double orderTotal;
        private string storeNum;
        private string isFavorite;
        private string orderType;

        //empty constructor
        public Order()
        {
            orderID = 0;
            customerFirst = "";
            customerLast = "";
            orderTotal = 0.0;
            storeNum = "";
            isFavorite = "";
            orderType = "";
        }

        //constructor with all the variables
        public Order(int orderID, string customerFirst, string customerLast, double orderTotal, string storeNum, string isFavorite, string orderType)
        {
            this.orderID = orderID;
            this.customerFirst = customerFirst;
            this.customerLast = customerLast;
            this.orderTotal = orderTotal;
            this.storeNum = storeNum;
            this.isFavorite = isFavorite;
            this.orderType = orderType;
        }

        //basic gets and sets for all variables
        public int OrderID { get; set; }

        public string CustomerFirst { get; set; }

        public string CustomerLast { get; set; }

        public double OrderTotal { get; set; }

        public string StoreNum { get; set; }

        public string IsFavorite { get; set; }

        public string OrderType { get; set; }
    }
}