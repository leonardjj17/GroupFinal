using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("GroupFinal")
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}