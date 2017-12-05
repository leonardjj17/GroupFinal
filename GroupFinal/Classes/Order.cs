using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupFinal.DA;

namespace GroupFinal.Classes
{
    public class Order
    {
        private int orderID;
        private string customerFirst;
        private string customerLast;
        private double orderTotal;
        private string storeNum;
        private string orderEstimation;
        private string orderType;
        private double orderTax;
        private double orderSubtotal;
        private string isCompleted;
        private DateTime orderDate;
         
        //basic gets and sets for all variables
        public int OrderID { get; set; }

        public string CustomerFirst { get; set; }

        public string CustomerLast { get; set; }

        public double OrderTotal { get; set; }

        public string StoreNum { get; set; }

        public string OrderEstimation { get; set; }

        public string OrderType { get; set; }

        public double OrderTax { get; set; }

        public double OrderSubtotal { get; set; }

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
            OrderType = "";
            OrderTax = 0.0;
            OrderSubtotal = 0.0;
            IsCompleted = "";
        }

        //constructor with all the variables
        public Order(int orderID, string customerFirst, string customerLast, double orderTotal, string storeNum, string orderType, double orderTax, double orderSubtotal, DateTime orderDate, string isCompleted)
        {
            this.OrderID = orderID;
            this.CustomerFirst = customerFirst;
            this.CustomerLast = customerLast;
            this.OrderTotal = orderTotal;
            this.StoreNum = storeNum;
            this.OrderType = orderType;
            this.OrderTax = orderTax;
            this.OrderSubtotal = orderSubtotal;
            this.OrderDate = orderDate;

            this.IsCompleted = isCompleted;
        }
        //method to call at the end of a delivery to make sure that order total is increased if it's a delivery
        public void CheckDeliveryPrice()
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
        public void ConvertThenSave(Cart theCart)
        {
            List<CartItem> cartItems = theCart.CartItems;
            
            foreach (CartItem cartItem in cartItems)
            {
                

                
            }
        }
    }
}