using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Financial
    {
        //variables
        private double storeBalance;
        private string storeNum;
        

        //constructors
        public Financial()
        {

        }
        public Financial(double storeBalance, string storeNum)
        {

            this.storeBalance = storeBalance;
            this.storeNum = storeNum;
            
        }
        
        //gets and sets for variables
        public double StoreBalance { get; set; }

        public string StoreNum { get; set; }


        //Class to subtract from the total
        public void DeductBalance(double amountToSubtract)
        {
            storeBalance -= amountToSubtract;
            
        }
        //Class to add to the total
        public void AddBalance(double amountToAdd)
        {
            storeBalance += amountToAdd;
            
        }
    }
}