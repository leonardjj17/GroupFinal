using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Cart
    {
       
    private DateTime _dateCreated;
    private DateTime _lastUpdate;
    private List<CartItem> orderItems;

    public Cart()
    {
        if (this.orderItems == null)
        {
            this.orderItems = new List<CartItem>();
            this._dateCreated = DateTime.Now;
        }
    }

    public List<CartItem> Items
    {
        get { return orderItems; }
        set { orderItems = value; }
    }

    public void Insert(int ProductID, double Price,
    int Quantity, string ProductName, string ImageUrl)
    {
        int ItemIndex = ItemIndexOfID(ProductID);
        if (ItemIndex == -1)
        {
            CartItem NewItem = new CartItem();
            NewItem.ProductID = ProductID;
            NewItem.Quantity = Quantity;
            NewItem.Price = Price;
            NewItem.ProductName = ProductName;
            NewItem.ImageUrl = ImageUrl;
            orderItems.Add(NewItem);
        }
        else
        {
            orderItems[ItemIndex].Quantity += 1;
        }
        _lastUpdate = DateTime.Now;
    }

    public void Update(int RowID, int ProductID,
                     int Quantity, double Price)
    {
        CartItem Item = orderItems[RowID];
        Item.ProductID = ProductID;
        Item.Quantity = Quantity;
        Item.Price = Price;
        _lastUpdate = DateTime.Now;
    }

    public void DeleteItem(int rowID)
    {
        orderItems.RemoveAt(rowID);
        _lastUpdate = DateTime.Now;
    }

    private int ItemIndexOfID(int ProductID)
    {
        int index = 0;
        foreach (CartItem item in orderItems)
        {
            if (item.ProductID == ProductID)
            {
                return index;
            }
            index += 1;
        }
        return -1;
    }

        public Order CalcTotal(List<Cart> items)
        {
            double subtotal = 0;
            double tax = .075;
            foreach (Products p in CartItems)
            {
                subtotal += (double)p.ProductMenuPrice;

                }
                currentOrder.OrderSubTotal = subtotal;
                currentOrder.OrderTax = currentOrder.OrderSubTotal * tax;
                currentOrder.OrderTotal = currentOrder.OrderSubTotal + currentOrder.OrderTax;

                return currentOrder;
           
        }
         
   
            
    }
}


