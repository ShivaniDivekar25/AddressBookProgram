using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Please add contact details");
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State= Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter zip code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            contact.Email = Console.ReadLine();
            contactList.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Contact Details" + "\n" + "FirstName: " +contact.FirstName +"\n" + "LastName: "+contact.LastName+"\n" + "Address: "+contact.Address+ "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "PhoneNumber: " +contact.PhoneNumber + "\n" + "Zip: " + contact.Zip +"\n"+"Email: "+contact.Email);
        }
        public void EditDetails()
        {
            Console.WriteLine("Enter name of person in contact to be edited");
            string Name = Console.ReadLine();
            bool input = false;
            if (contact.FirstName == Name)
            { 
                Console.WriteLine("Enter an option to edit contact");
                Console.WriteLine("1:Edit first name\n2:Edit last name\n3:Edit address\n4:Edit city\n5:Edit state\n6:Edit phone number\n7:Edit zip code\n8:Edit email id");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter First name");
                        string currentFirstName = Console.ReadLine();
                        contact.FirstName = currentFirstName;
                        break;
                    case 2:
                        Console.WriteLine("Enter Last name");
                        string currentLastName = Console.ReadLine();
                        contact.LastName = currentLastName;
                        break;
                    case 3:
                        Console.WriteLine("Enter address");
                        string currentAddress = Console.ReadLine();
                        contact.Address = currentAddress;
                        break;
                    case 4:
                        Console.WriteLine("Enter city");
                        string currentCity = Console.ReadLine();
                        contact.City = currentCity;
                        break;
                    case 5:
                        Console.WriteLine("Enter state");
                        string currentState = Console.ReadLine();
                        contact.State = currentState;
                        break;
                    case 6:
                        Console.WriteLine("Enter phone number");
                        string currentPhoneNumber = Console.ReadLine();
                        contact.PhoneNumber = currentPhoneNumber;
                        break;
                    case 7:
                        Console.WriteLine("Enter zip ocde");
                        int currentZip = Convert.ToInt32(Console.ReadLine());
                        contact.Zip = currentZip;
                        break;
                    case 8:
                        Console.WriteLine("Enter Email id");
                        string currentEmail = Console.ReadLine();
                        contact.Email = currentEmail;
                        break;
                }  
            }
            if(input = false)
                Console.WriteLine("The person is not found"); 
        }
        public void EditContract(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1:Address");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new address");
                            contact.Address = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Please chosse correct option");
                            break;
                    }
                }
            }
        }
    }
}
