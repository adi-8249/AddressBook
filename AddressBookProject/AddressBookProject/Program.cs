using System;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookCreation creation = new AddressBookCreation();
            creation.AddContact("Anjaneya", "Tosh", "Nuapatna", "Cuttack", "Odisha","aptgmail.com", 754035, 9456745454);
            creation.ViewContact();



        }
    }
}
