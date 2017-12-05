using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Stores
    {
        private string storeID;
        private string storeAddress;
        private string storeCity;
        private string storeState;
        private string storeZip;
        private string storeManager;



        public Stores()
        {
        }

        public Stores(string storeID, string storeAddress, string storeCity, string storeState, string storeZip, string storeManager)
        {
            this.storeID = StoreID;
            this.storeAddress = StoreAddress;
            this.storeCity = StoreCity;
            this.storeState = StoreState;
            this.storeZip = StoreZip;
            this.storeManager = StoreManager;

        }

        public string StoreID { get; set; }
        public string StoreAddress { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
        public string StoreZip { get; set; }
        public string StoreManager { get; set; }
    }
}