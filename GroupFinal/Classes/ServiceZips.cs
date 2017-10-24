using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class ServiceZips
    {
        private int storeNum;
        private string serviceZip;

        public ServiceZips()
        {
            storeNum = 0;
            serviceZip = "";
        }

        public ServiceZips(int storeNum, string serviceZip)
        {
            this.storeNum = storeNum;
            this.serviceZip = serviceZip;
        }

        public int StoreNum { get; set; }

        public string ServiceZip { get; set; }
    }
}