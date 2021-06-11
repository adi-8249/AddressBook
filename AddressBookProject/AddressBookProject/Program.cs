using System;

namespace AddressBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookCreation creation = new AddressBookCreation();
            creation.AddContact("Anjaneya", "Tosh", "Nuapatna", "Cuttack", "Odisha", "aptgmail.com", 754035, 9456745454);
            creation.ViewContact();

            int choice;
            do
            {
                Console.WriteLine("Choose An Option \n1.Add New Contact \n2.Edit Existing Contact \n3.Delete A Contact\n4.view contact");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
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
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        creation.EditContact(nameToEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        creation.DeleteContact(nameToDelete);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        creation.ViewContact();
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice != 5);

        }
    }
}
