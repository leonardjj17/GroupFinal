using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Promotional : Products
    {
        private string promotionalSize;

        public Promotional()
        {

        }

        public Promotional(string promotionalSize)
        {
            this.promotionalSize = promotionalSize;
        }

        public string PromotionalSize { get; set; }

    }
}