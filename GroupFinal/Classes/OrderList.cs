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
            this.orders = OrderDA.getOrdersByStoreNum(storeID);
        }
        public List<Order> getOrders()
        {
            return orders;
        }
        public void addOrder(Order order)
        {
            this.orders.Add(order);
            OrderDA.addOrder(order);
        }
        public void removeOrder(Order order)
        {
            this.orders.Remove(order);
            OrderDA.removeOrder(order);
        }
    }
}