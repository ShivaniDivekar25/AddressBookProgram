﻿namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            bool flag = true;
            while (flag)
            { 
                AddressBook addressBook = new AddressBook();
                ContactBook contactBook = new ContactBook();
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1:Create contact details\n2:Add new contact\n3:Edit contact\n4:Delete contact\n5:Add multiple contact\n6:No duplicate entry\n7:Search person based on city or state\n8:Search person number based on city or state\n9:Store contacts in dictionary\n10:Sort contact by name\n11:Sort contact by city or state or zip\n12:Write or read file\n13:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.CreateContact();
                        addressBook.Display();
                        break;
                    case 2:
                        addressBook.CreateContact();
                        addressBook.Display();
                        break;
                    case 3:
                        addressBook.CreateContact();
                        addressBook.EditContact("Shivani");
                        addressBook.Display();
                        break;
                    case 4:
                        addressBook.CreateContact();
                        addressBook.DeleteContact("Shivani");
                        break;
                    case 5:
                        addressBook.CreateContact();
                        addressBook.Display();
                        break;
                    case 6:
                        addressBook.CreateContact();
                        addressBook.NoDuplicateEntry("Shivani");
                        addressBook.Display();
                        break;
                    case 7:
                        addressBook.CreateContact();
                        addressBook.SearchPersonBasedOnCityOrState("Pune","Kerla");
                        addressBook.Display();
                        break;
                    case 8:
                        addressBook.CreateContact();
                        addressBook.SearchNumPersonContactBasedOnCityOrState();
                        addressBook.Display();
                        break;
                    case 9:
                        contactBook.AddContact("Shivani", "Divekar", "Dange Chauk", "Pune", "Maharastra", 1236, "8983922703", "Shivani@gmail.com");
                        contactBook.ShowList();
                        break;
                    case 10:
                        contactBook.AddContact("Shivani", "Divekar", "Dange Chauk", "Pune", "Maharastra", 1236, "8983922703", "Shivani@gmail.com");
                        contactBook.AddContact("Malhar", "Divekar", "Karve Nagar", "Kolhapur", "Maharastra", 1236, "8983922708", "Malhar@gmail.com");
                        contactBook.SortContactByName();
                        break;
                    case 11:
                        contactBook.AddContact("Shivani", "Divekar", "Dange Chauk", "Pune", "Maharastra", 4006, "8983922703", "Shivani@gmail.com");
                        contactBook.AddContact("Malhar", "Divekar", "Karve Nagar", "Kolhapur", "Kerla", 2056, "8983922708", "Malhar@gmail.com");
                        contactBook.SortContactByCity();
                        Console.WriteLine("-------------------");
                        contactBook.SortContactByState();
                        Console.WriteLine("-------------------");
                        contactBook.SortContactByZip();
                        Console.WriteLine("_------------------");
                        break;
                    case 12:
                        FileIO file = new FileIO();
                        file.WriteContactToFile(contactBook.contactList);
                        file.ReadContactFromFile();
                        break;
                    case 13:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
        }
    }
}