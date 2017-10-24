using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Order
    {

        //basic gets and sets for all variables
        public int OrderID { get; set; }

        public string CustomerFirst { get; set; }

        public string CustomerLast { get; set; }

        public double OrderTotal { get; set; }

        public string StoreNum { get; set; }

        public string IsFavorite { get; set; }

        public string OrderType { get; set; }

        //empty constructor
        public Order()
        {
            OrderID = 0;
            CustomerFirst = "";
            CustomerLast = "";
            OrderTotal = 0.0;
            StoreNum = "";
            IsFavorite = "";
            OrderType = "";
        }

        //constructor with all the variables
        public Order(int orderID, string customerFirst, string customerLast, double orderTotal, string storeNum, string isFavorite, string orderType)
        {
            this.OrderID = orderID;
            this.CustomerFirst = customerFirst;
            this.CustomerLast = customerLast;
            this.OrderTotal = orderTotal;
            this.StoreNum = storeNum;
            this.IsFavorite = isFavorite;
            this.OrderType = orderType;
        }
    }
}