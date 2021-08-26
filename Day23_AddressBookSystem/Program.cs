using System;

namespace Day23_AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            while (true)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressBookDetails.AddMember();
                        break;
                    case 2:
                        AddressBookDetails.ViewContacts();
                        break;
                    case 3:
                        // to exit from main method 
                        return;
                }
            }
        }
    }
}
