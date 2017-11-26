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
        private List<CartItem> cartItems;
        private DateTime dateCreated;
        private DateTime lastUpdate;
        Products myPizza = null;
        Products mySide = null;


        public Cart()
        {       
            if (this.cartItems == null)
            {
                this.cartItems = new List<CartItem>();
                this.dateCreated = DateTime.Now;
            }

        }

        public List<CartItem> CartItems
        {
            get { return cartItems; }
            set { cartItems = value; }
        }

        public static List<CartItem> AddPizzaToCart(Products myPizza, List<CartItem> cartItems)
        {

            //if (myPizza != null)
            //{
            //    string myType = myPizza.GetType().ToString();

            //    if (myType == "GroupFinal.Pizza")
            //    {
            CartItem theCart = new CartItem();
            theCart.ProductID = myPizza.ProductID;
            theCart.ProductPrice = myPizza.ProductPrice;
            theCart.ProductType = myPizza.ProductType;
            theCart.ProductQty = myPizza.ProductQty;
            theCart.ProductCost = myPizza.ProductCost;
            theCart.ProductDetail = myPizza.ProductDetail;

            cartItems.Add(theCart);

            return cartItems;
            
        }
            public static List<CartItem> AddSidesToCart(Products mySide, List<CartItem> cartItems)
            {
                
                    CartItem theCart = new CartItem();
                    theCart.ProductID = mySide.ProductID;
                    theCart.ProductPrice = mySide.ProductPrice;
                    theCart.ProductType = mySide.ProductType;
                    theCart.ProductQty = mySide.ProductQty;
                    theCart.ProductCost = mySide.ProductCost;
                    theCart.ProductDetail = mySide.ProductDetail;


                    cartItems.Add(theCart);

                    return cartItems;
            }

        public void Insert(int Id, int Qty, string Description, double Price)
        {
            int ItemIndex = ItemIndexOfID(Id);
            if (ItemIndex == -1)
            {
                CartItem NewItem = new CartItem();
                NewItem.Id = Id;
                NewItem.Qty = Qty;
                NewItem.Description = Description;
                NewItem.Price = Price;
              
                cartItems.Add(NewItem);
            }
            else
            {
                cartItems[ItemIndex].Qty += 1;
            }
            lastUpdate = DateTime.Now;
        }

        public void Update(int RowID, int Id,
                         int Qty, string Description, double Price)
        {
            CartItem Item = cartItems[RowID];
            Item.Id = Id;
            Item.Qty = Qty;
            Item.Description = Description;
            Item.Price = Price;
            lastUpdate = DateTime.Now;
        }

        public void DeleteItem(int rowID)
        {
            cartItems.RemoveAt(rowID);
            lastUpdate = DateTime.Now;
        }

        private int ItemIndexOfID(int Id)
        {
            int index = 0;
            foreach (CartItem item in cartItems)
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
                if (cartItems == null)
                {
                    return 0;
                }
                foreach (CartItem Item in cartItems)
                {
                    t += Item.SubTotal;
                }
                return t;
            }
        }

        public List<CartItem> GetItems(List<CartItem> cartItems)
        {
            //List<CartItem> items = new List<CartItem>();
            Products p = new Products();

            foreach (CartItem item in cartItems)
            {

                item.Id = p.ProductID;
                item.Qty = p.ProductQty;
                item.Description = p.ProductDetail;
                item.Price = p.ProductPrice;

                cartItems.Add(item);
            }
            return cartItems;
        }

    }
}
    

    





    








