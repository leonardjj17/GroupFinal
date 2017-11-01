using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Cart
    {
        public List<Products> CartItems = new List<Products>();
        public static double CalcSubtotal(List<Products> CartItems)
        {
            double subtotal = 0;
            foreach (Products p in CartItems)
            {
                subtotal += (double)p.ProductMenuPrice;

            }

            return subtotal;
        }
    }
}