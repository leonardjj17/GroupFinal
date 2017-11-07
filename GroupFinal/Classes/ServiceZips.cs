using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class ServiceZips
    {
        private string storeNum;
        private string serviceZip;

        public ServiceZips()
        {
            storeNum = "";
            serviceZip = "";
        }

        public ServiceZips(string storeNum, string serviceZip)
        {
            this.StoreNum = storeNum;
            this.ServiceZip = serviceZip;
        }

        public string StoreNum { get; set; }

        public string ServiceZip { get; set; }
    }
}