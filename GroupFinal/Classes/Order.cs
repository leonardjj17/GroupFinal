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

        public string OrderEstimation { get; set; }

        public string OrderType { get; set; }
        public double OrderTax { get; set; }
        public double OrderSubTotal { get; set; }
        public string IsCompleted { get; set; }
        public DateTime OrderDate { get; set; }

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
            OrderTax = 0.0;
            OrderSubTotal = 0.0;
        }

        //constructor with all the variables
        public Order(int orderID, string customerFirst, string customerLast, double orderTotal, string storeNum, string isFavorite, string orderType, double orderTax, double orderSubTotal, DateTime orderDate, string isCompleted)
        {
            this.OrderID = orderID;
            this.CustomerFirst = customerFirst;
            this.CustomerLast = customerLast;
            this.OrderTotal = orderTotal;
            this.StoreNum = storeNum;
            this.IsFavorite = isFavorite;
            this.OrderType = orderType;
            this.OrderTax = orderTax;
            this.OrderSubTotal = orderSubTotal;
            this.OrderDate = orderDate;

            this.IsCompleted = isCompleted;
        }
        //method to call at the end of a delivery to make sure that order total is increased if it's a delivery
        public void checkDeliveryPrice()
        {
            if (OrderType == "delivery")
            {
                OrderTotal += 2.00;
                OrderEstimation = "Please allow 50 minutes for delivery";

            }

            else if(OrderType == "carryout")
            {
                OrderEstimation = "Please allow 15 - 20 minutes to make your items";
            }
}
    }
}