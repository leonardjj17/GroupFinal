using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Cart
    {
        public List<Products> CartItems = new List<Products>();
        public Order o = new Order();
        public Order CalcTotal(List<Products> CartItems)
        {
            double subtotal = 0;
            double tax = .075;
            foreach (Products p in CartItems)
            {
                subtotal += (double)p.ProductPrice;

            }
            o.OrderSubTotal = subtotal;
            o.OrderTax = o.OrderSubTotal * tax;
            o.OrderTotal = o.OrderSubTotal + o.OrderTax;

            return o;
        }
    }
}