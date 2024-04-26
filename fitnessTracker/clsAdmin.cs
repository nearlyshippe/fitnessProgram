using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessTracker
{
    class clsAdmin
    {
        String adminID, adminName, email, userPwd, userName, phoneNo;

        public String AdminID
        {
            get
            {
                return adminID;
            }
            set
            {
                adminID = value;
            }
        }
        public String AdminName
        {
            get
            {
                return adminName;
            }
            set
            {
                adminName = value;
            }
        }
        public String adminEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public String adminPwd
        {
            get
            {
                return userPwd;
            }
            set
            {
                userPwd = value;
            }
        }
        public String adminUserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public String adminPhone
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
            }
        }
    }
}
