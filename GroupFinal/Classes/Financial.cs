using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Financial
    {
        //the only thing I figure we needed for right now was storeBalance
        private double totalBudget;
        private string storeNum;
        private double totalDailyLoss;
        private double totalDailyProfit;
        private double totalDailyNetGain;
        private int day;
        private int month;
        private int year;

        //constructors
        public Financial()
        {

        }
        public Financial(double totalBudget, string storeNum, double totalDailyLoss, double totalDailyProfit, double totalDailyNetGain, int day, int month, int year)
        {

            this.totalBudget = totalBudget;
            this.storeNum = storeNum;
            this.totalDailyLoss = totalDailyLoss;
            this.totalDailyProfit = totalDailyProfit;
            this.totalDailyNetGain = totalDailyNetGain;
            this.day = day;
            this.month = month;
            this.year = year;
        }
        
        //gets and sets for variables
        public double StoreBalance { get; set; }

        public string StoreNum { get; set; }

        public double TotalDailyLoss { get; set; }

        public double TotalDailyProfit { get; set; }

        public double TotalDailyNetGain { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        //Class to subtract from the total
        public void DeductBalance(double amountToSubtract)
        {
            totalBudget -= amountToSubtract;
            totalDailyLoss -= amountToSubtract;
            UpdateNetGains();
        }
        //Class to add to the total
        public void AddBalance(double amountToAdd)
        {
            totalBudget += amountToAdd;
            totalDailyProfit += amountToAdd;
            UpdateNetGains();
        }
        //Class that updates the totalDailyNetGain variable everytime it is called, should be called anytime you change the dailyProfit or the dailyLoss
        public void UpdateNetGains()
        {
            totalDailyNetGain = totalDailyProfit - totalDailyLoss;
        }
    }
}