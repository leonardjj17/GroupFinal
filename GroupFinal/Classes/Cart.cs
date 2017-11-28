using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GroupFinal.Classes
{
    [Serializable]
    public class Cart
    {
        
        private List<CartItem> Items { get; set; }
        private DateTime dateCreated;
        private DateTime lastUpdate;
        Products product = null;

        public static Cart GetShoppingCart()
        {

            if (HttpContext.Current.Session["TheShoppingCart"] == null)
            {
                Cart theCart = new Cart();
                theCart.Items = new List<CartItem>();
                HttpContext.Current.Session["TheShoppingCart"] = theCart;
                return (Cart)HttpContext.Current.Session["TheShoppingCart"];
            }

            return (Cart)HttpContext.Current.Session["TheShoppingCart"];

        }



        public Cart()
        {       
            if (this.Items == null)
            {
                
                this.dateCreated = DateTime.Now;
            }

        }

        public void AddItemToCart(Products product)
        {

           
            CartItem theCart = new CartItem();
            theCart.ProductID = product.ProductID;
            theCart.ProductPrice = product.ProductPrice;
            theCart.ProductType = product.ProductType;
            theCart.ProductQty = product.ProductQty;
            
            theCart.ProductDetail = product.ProductDetail;

            Items.Add(theCart);

            
        }
            
      

        public void Update(int RowID, int Id,
                         int theQty, string theDescription, double thePrice)
        {
            CartItem Item = Items[RowID];
            Item.Id = Id;
            Item.Qty = theQty;
            Item.Description = theDescription;
            Item.Price = thePrice;
            lastUpdate = DateTime.Now;
        }

        public void DeleteItem(int rowID)
        {
            Items.RemoveAt(rowID);
            lastUpdate = DateTime.Now;
        }

        private int ItemIndexOfID(int Id)
        {
            int index = 0;
            foreach (CartItem item in Items)
            {
                if (item.Id == Id)
                {
                    return index;
                }
                index += 1;
            }
            return -1;
        }

        public double Total
        {
            get
            {
                double t = 0;
                if (Items == null)
                {
                    return 0;
                }
                foreach (CartItem Item in Items)
                {
                    t += Item.SubTotal;
                }
                return t;
            }
        }

        //public List<CartItem> GetItems(List<CartItem> items)
        //{
        //    //List<CartItem> items = new List<CartItem>();


        //    //foreach (CartItem item in cartItems)
        //    //{
        //    //    Products p = new Products();
        //    //    item.Id = p.ProductID;
        //    //    item.Qty = p.ProductQty;
        //    //    item.Description = p.ProductDetail;
        //    //    item.Price = p.ProductPrice;

        //    //    items.Add(item);
        //    //}
        //    return items;
        //}

    }
}
    

    





    








