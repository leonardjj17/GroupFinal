using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupFinal
{
    public class User
    {
        private int userID, userZIP;
        private string userFirst, userLast, userAddress, userCity, userState, userPhone, userRole, userCC;

        public User()
        {

        }

        public User(int userID, string userFirst, string userLast, string userAddress, string userCity, string userState, int userZip, string userPhone, string userRole, string userCC)
        {
            this.userID = UserID;
            this.userFirst = UserFirst;
            this.userLast = UserLast;
            this.userAddress = UserAddress;
            this.userCity = UserCity;
            this.userState = UserState;
            this.userZIP = UserZip;
            this.userPhone = UserPhone;
            this.userRole = UserRole;
            this.userCC = UserCC;
        }

        public int UserID { get; set; }
        public string UserFirst { get; set; }
        public string UserLast { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserPhone { get; set; }
        public int UserZip { get; set; }
        public string UserRole { get; set; }
        public string UserCC { get; set; }
    }
}