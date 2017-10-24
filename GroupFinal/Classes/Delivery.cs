using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal.Classes
{
    public class Delivery
    {
        private int orderNum;
        private int employeeNum;

        public Delivery()
        {
            orderNum = 0;
            employeeNum = 0;
        }

        public Delivery(int orderNum, int employeeNum)
        {
            this.orderNum = orderNum;
            this.employeeNum = employeeNum;
        }

        public int OrderNum { get; set; }

        public int EmployeeNum { get; set; }
    }
}