using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19xBedAndBreakfast
{
    public class Guest
    {
        private string passPortNo;
        private int phoneNo;
        private string fName;
        private string lName;
        private char gender;
        private string address;

        public Guest(string passPortNo, int phone, string fName, string lName, char gender, string address)
        {
            PassPortNo=passPortNo;
            PhoneNo = phone;
            FName = fName;
            LName = lName;
            Gender = gender;
            Address = address;
        }
        public string PassPortNo
        {
            get { return passPortNo; }
            set { passPortNo = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public int PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        public char Gender
        {
            get { return gender; }
            set {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
//                    throw new ArgumentException("Køn skal være 'M' el 'F'");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
