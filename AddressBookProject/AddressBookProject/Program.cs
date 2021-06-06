using System;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookCreation creation = new AddressBookCreation("Anjaneya", "Tosh", "Nuapatna", "Cuttack", "Odisha", 9456745454, 754035);
            Console.WriteLine("First Name is:"+ creation.FirstName);
            Console.WriteLine("Last Name is:"+ creation.LastName);
            Console.WriteLine("Address is:"+ creation.Address);
            Console.WriteLine("City is:"+ creation.City);
            Console.WriteLine("State is:"+ creation.State);
            Console.WriteLine("Mobile number is:"+ creation.MobileNo);
            Console.WriteLine("Zip code is:"+ creation.Zip);



        }
    }
}
