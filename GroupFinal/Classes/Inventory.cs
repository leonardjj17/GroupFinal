using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Inventory
    {/*
        Inventory class will be used to maintain store inventory (i.e. pepperoni, cheese etc)
        */
        private string itemType;
        private int itemAmount;
        private int itemMax;
        private int itemMin;
        private double itemPrice;
        private int itemID;

        public Inventory()
        {
        }

        public Inventory(string itemType, int itemAmount, int itemMax, int itemMin, double itemPrice, int itemID)
        {
            this.itemType = ItemType;
            this.itemAmount = ItemAmount;
            this.itemMax = ItemMax;
            this.itemMin = ItemMin;
            this.itemPrice = ItemPrice;
            this.itemID = ItemID;
        }

        public string ItemType { get; set; }
        public int ItemAmount { get; set; }
        public int ItemMax { get; set; }
        public int ItemMin { get; set; }
        public double ItemPrice { get; set; }
        public int ItemID { get; set; }
    }
}