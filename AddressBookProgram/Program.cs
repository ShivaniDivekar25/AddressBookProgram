﻿namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            addressBook.Display();
        }
    }
}