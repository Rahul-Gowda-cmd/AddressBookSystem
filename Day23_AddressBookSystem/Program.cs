using System;

namespace Day23_AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program");
            AddressBookDetails abd = new AddressBookDetails();
            while (true)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit members Contacts lists\n4.Delete members Contacts list\n5.Search Details\n6.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddMember();
                        break;
                    case 2:
                        abd.ViewContacts();
                        break;
                    case 3:
                        abd.EditDetails();
                        break;
                    case 4:
                        abd.DeleteDetails();
                        break;
                    case 5:
                        abd.SearchDetails();
                        break;
                    case 6:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;
                }

            }
        }
    }
}
