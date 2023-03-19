using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class FileIO
    {
        string path = @"C:\Users\hp\source\repos\AddressBookProgram\AddressBookProgram\FileIO\Contact.txt";
        public void WriteContactToFile(List<Contact> contacts)
        {
            using(StreamWriter writer = File.AppendText(path))
            {
                foreach(var contact in contacts)
                {
                    writer.WriteLine(contact.FirstName);
                    writer.WriteLine(contact.LastName);
                    writer.WriteLine(contact.Address);
                    writer.WriteLine(contact.City);
                    writer.WriteLine(contact.State);
                    writer.WriteLine(contact.PhoneNumber);
                    writer.WriteLine(contact.Zip);
                    writer.WriteLine(contact.Email);
                }
                writer.Close();
            }
        }

        public void ReadContactFromFile()
        {
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
