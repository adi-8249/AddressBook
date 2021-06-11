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
            Console.WriteLine("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State :");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number :");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            creation.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber);
            creation.EditContact(firstName);
            creation.ViewContact();

        }
    }
}
