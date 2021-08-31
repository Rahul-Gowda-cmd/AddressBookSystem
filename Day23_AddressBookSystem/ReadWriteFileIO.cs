using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day23_AddressBookSystem
{
    class ReadWriteFileIO
    {
        static string file = @"C:\Users\HP\csharp\Day23_AddressBookSystem\Day23_AddressBookSystem\AddressBook.txt";

        public void WriteToFile(Dictionary<string, AddressBookBuider> addressBookDictionary)
        {
            StreamWriter writer = new StreamWriter(file, true);
            foreach (AddressBookBuider item in addressBookDictionary.Values)
            {
                foreach (Contacts contact in item.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine(File.ReadAllText(file));
        }
    }
}
