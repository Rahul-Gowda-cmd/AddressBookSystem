using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_AddressBookSystem
{
    class AddressBookDetails
    {
        private static List<Person> contacts = new List<Person>();
        public static void AddMember()
        {
            //object for person class
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.address = Console.ReadLine();
            Console.Write("Enter City: ");
            person.city = Console.ReadLine();
            Console.Write("Enter State: ");
            person.state = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            person.zipCode = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Write("Enter Phone Number: ");
                string phNo = Console.ReadLine();
                if (phNo.Length == 10)
                {
                    person.phoneNumber = phNo;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                }
            }
            while (true)
            {
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                if (emailId.Contains("@"))
                {
                    person.email = emailId;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                }
            }
            contacts.Add(person);

            Console.WriteLine("Successfully Added");
        }

        public static void ViewContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("***************Your Contact List Has******************");
                foreach (var x in contacts)
                {
                    PrintValues(x);
                    Console.WriteLine("**************************");
                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }


        public static void PrintValues(Person x)
        {
            Console.WriteLine($"First Name : {x.firstName}");
            Console.WriteLine($"Last Name : {x.lastName}");
            Console.WriteLine($"Address : {x.address}");
            Console.WriteLine($"City : {x.city}");
            Console.WriteLine($"State : {x.state}");
            Console.WriteLine($"Zip Code: {x.zipCode}");
            Console.WriteLine($"Phone Number: {x.phoneNumber}");
            Console.WriteLine($"Email: {x.email}");
        }
        //method for editing details
        public static void EditDetails()
        {
            int f;
            if (contacts.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var x in contacts)
                {
                    if (editName.ToLower() == x.firstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    x.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    x.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    x.address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    x.city = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    x.state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    x.zipCode = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Enter New Phone number");
                                    string phno = Console.ReadLine();
                                    while (true)
                                    {
                                        Console.Write("Enter Phone Number: ");
                                        string phNo = Console.ReadLine();
                                        if (phNo.Length == 10)
                                        {
                                            x.phoneNumber = phNo;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Phone Number. It should Contains 10 digits");
                                        }
                                    }
                                    break;
                                case 8:
                                    while (true)
                                    {
                                        Console.Write("Enter new Email-id: ");
                                        string emailId = Console.ReadLine();
                                        if (emailId.Contains("@"))
                                        {
                                            x.email = emailId;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Valid Email Id. It should Contains @ ");
                                        }
                                    }
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Exited");
                                    f = 1;
                                    break;

                            }
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
    }
}
