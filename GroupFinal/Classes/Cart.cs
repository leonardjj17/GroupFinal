using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Cart
    {
       
    private DateTime dateCreated;
    private DateTime lastUpdate;
    private List<Products> orderItems;
       Order currentOrder = new Order();
        

    public Cart()
    {
        if (this.orderItems == null)
        {
            this.orderItems = new List<Products>();
            this.dateCreated = DateTime.Now;
        }
    }

    public List<Products> Items
    {
        get { return orderItems; }
        set { orderItems = value; }
    }

    public void Insert(int ProductID, double ProductPrice,
    int ProductQty, double ProductCost, string ProductDetail)
    {
        int ItemIndex = ItemIndexOfID(ProductID);
        if (ItemIndex == -1)
        {
            Products newItem = new Products();
            newItem.ProductID = ProductID;
            newItem.ProductPrice = ProductPrice;
            newItem.ProductQty = ProductQty;
            newItem.ProductCost = ProductCost;
            newItem.ProductDetail = ProductDetail;
            orderItems.Add(newItem);
        }
        else
        {
            orderItems[ItemIndex].ProductQty += 1;
        }
        lastUpdate = DateTime.Now;
    }

    public void Update(int RowID, int ProductID,
                     int ProductQty, double ProductPrice)
    {
        Products Item = orderItems[RowID];
        Item.ProductID = ProductID;
        Item.ProductQty = ProductQty;
        Item.ProductPrice = ProductPrice;
        lastUpdate = DateTime.Now;
    }

    public void DeleteItem(int rowID)
    {
        orderItems.RemoveAt(rowID);
        lastUpdate = DateTime.Now;
    }

    private int ItemIndexOfID(int ProductID)
    {
        int index = 0;
        foreach (Products item in orderItems)
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
            foreach (Products p in orderItems)
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


