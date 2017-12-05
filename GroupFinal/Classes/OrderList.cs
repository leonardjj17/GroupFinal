using GroupFinal.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class OrderList
    {
        private List<Order> orders;

        public OrderList(string storeID)
        {
            this.orders = OrderDA.GetAllIncompleteOrdersByStoreNum(storeID);
        }
        public List<Order> getOrders()
        {
            return orders;
        }
        public void AddOrder(Order order)
        {
            this.orders.Add(order);
            //OrderDA.addOrder(order);
        }
        public void RemoveOrder(Order order)
        {
            this.orders.Remove(order);
            //OrderDA.removeOrder(order);
        }
    }
}