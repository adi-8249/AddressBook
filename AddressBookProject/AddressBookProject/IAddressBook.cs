using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProject
{
    interface IAddressBook
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);
        public void EditContact(string name);
        public void DeleteContact(string name);
        public void AddAddressBook(string bookName);
    }
}

