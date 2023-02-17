namespace AddressBookProgram
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
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1:Create contcat details\n2:Add new contact\n3:Edit contact\n4:Delete contact\n5:Add multiple contact\n6:Exit");
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
                        addressBook.EditContract("Shivani");
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