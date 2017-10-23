using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Financial
    {
        //the only thing I figure we needed for right now was storeBalance
        private double storeBalance;
        private int storeNum;

        //Class to subtract from the total
        public void DeductBalance(int amountToSubtract)
        {
            storeBalance = storeBalance - amountToSubtract;
        }
        //Class to add to the total
        public void AddBalance(int amountToAdd)
        {
            storeBalance = storeBalance + amountToAdd;
        }
    }
}