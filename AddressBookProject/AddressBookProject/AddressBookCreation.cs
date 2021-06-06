using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{

    public class AddressBookCreation
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private long mobileNo;
        private int zip;

        public AddressBookCreation(string firstName, string lastName, string address, string city, string state, long mobileNo, int zip)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.mobileNo = mobileNo;
            this.zip = zip;
        }
        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public long MobileNo
        {
            get { return mobileNo; }
            set { mobileNo = value; }
        }
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }








    }
}
