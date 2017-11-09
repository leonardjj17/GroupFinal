using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class CartItem
    {
      
            private int _productID;
            private string _productName;
            private string _imageUrl;
            private int _quantity;
            private double _price;
            private double _subTotal;

            public CartItem()
            {
            }
            public CartItem(int ProductID, string ProductName,
                  string ImageUrl, int Quantity, double Price)
            {
                _productID = ProductID;
                _productName = ProductName;
                _imageUrl = ImageUrl;
                _quantity = Quantity;
                _price = Price;
                _subTotal = Quantity * Price;
            }
            public int ProductID
            {
                get
                {
                    return _productID;
                }
                set
                {
                    _productID = value;
                }
            }
            public string ProductName
            {
                get { return _productName; }
                set { _productName = value; }
            }
            public string ImageUrl
            {
                get { return _imageUrl; }
                set { _imageUrl = value; }
            }

            public int Quantity
            {
                get { return _quantity; }
                set { _quantity = value; }
            }

            public double Price
            {
                get { return _price; }
                set { _price = value; }
            }

            public double SubTotal
            {
                get { return _quantity * _price; }

            }
        }
    }
