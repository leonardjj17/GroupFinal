using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GroupFinal.Classes
{
    public class Cart : Page
    {
        List<Products> cartItems = new List<Products>();
        Pizza myPizza;

        public Cart()
        {
            if (Session["pizza"] == null)
            {
                myPizza = new Pizza();
            }
            else
            {
                myPizza = (Pizza)Session["pizza"];
            }

          
        }
        public List<Products> AddItemsToCart(Pizza myPizza)
        {
            cartItems.Add(myPizza);

            return cartItems;
        }

      

        //public List<Products> GetAllCartItems()
        //public List<CartItem> Items { get; set; }

        //public Cart()
        //{
        //    Items = new List<CartItem>();
        //}

        //private int ItemIndexOf(int ID)
        //{
        //    foreach (CartItem item in Items)
        //    {
        //        if(item.Id == ID)
        //        {
        //            return Items.IndexOf(item);
        //        }
        //    }
        //    return -1;
        //}

        //public void Insert(CartItem item)
        //{
        //    int index = ItemIndexOf(item.Id);
        //    if(index == -1)
        //    {
        //        Items.Add(item);
        //    }
        //    else
        //    {
        //        Items[index].Qty++;
        //    }

        //}

        //public void Delete(int rowID)
        //{
        //    Items.RemoveAt(rowID);
        //}

        //public void Update(int rowID, int Qty)
        //{
        //    if(Qty > 0)
        //    {
        //        Items[rowID].Qty = Qty;
        //    }
        //    else
        //    {
        //        Delete(rowID);
        //    }
        //}

        //public double GrandTotal
        //{
        //    get
        //    {
        //        if (Items == null)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            double total = 0;
        //            foreach(CartItem item in Items)
        //            {
        //                total += item.Qty * item.Price;
        //            }
        //            return total;
        //        }
        //    }
        //}
        //private string CartId { get; set; }
        //private DateTime dateCreated;
        //private DateTime lastUpdate;


        //private List<Products> orderItems;
        //Order currentOrder = new Order();


        //public Cart()
        //{
        //    if (this.orderItems == null)
        //    {
        //        this.orderItems = new List<Products>();
        //        this.dateCreated = DateTime.Now;
        //    }
        //}

        //public List<Products> Items
        //{
        //    get { return orderItems; }
        //    set { orderItems = value; }
        //}

        //public void Insert(int ProductID, double ProductPrice,
        //int ProductQty, double ProductCost, string ProductDetail)
        //{
        //    int ItemIndex = ItemIndexOfID(ProductID);
        //    if (ItemIndex == -1)
        //    {
        //        Products newItem = new Products();
        //        newItem.ProductID = ProductID;
        //        newItem.ProductPrice = ProductPrice;
        //        newItem.ProductQty = ProductQty;
        //        newItem.ProductCost = ProductCost;
        //        newItem.ProductDetail = ProductDetail;
        //        orderItems.Add(newItem);
        //    }
        //    else
        //    {
        //        orderItems[ItemIndex].ProductQty += 1;
        //    }
        //    lastUpdate = DateTime.Now;
        //}

        //public void Update(int RowID, int ProductID,
        //                 int ProductQty, double ProductPrice)
        //{
        //    Products Item = orderItems[RowID];
        //    Item.ProductID = ProductID;
        //    Item.ProductQty = ProductQty;
        //    Item.ProductPrice = ProductPrice;
        //    lastUpdate = DateTime.Now;
        //}

        //public void DeleteItem(int rowID)
        //{
        //    orderItems.RemoveAt(rowID);
        //    lastUpdate = DateTime.Now;
        //}

        //private int ItemIndexOfID(int ProductID)
        //{
        //    int index = 0;
        //    foreach (Products item in orderItems)
        //    {
        //        if (item.ProductID == ProductID)
        //        {
        //            return index;
        //        }
        //        index += 1;
        //    }
        //    return -1;
        //}

        public Order CalcTotal(List<Products> cartItems)
        {
            Order currentOrder = new Order();

            double subtotal = 0;
            double tax = .075;
            foreach (Pizza p in cartItems)
            {
                subtotal += p.ProductPrice;

            }
            currentOrder.OrderSubTotal = subtotal;
            currentOrder.OrderTax = currentOrder.OrderSubTotal * tax;
            currentOrder.OrderTotal = currentOrder.OrderSubTotal + currentOrder.OrderTax;

            return currentOrder;

        }

     
    }
}


