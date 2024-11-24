using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new ContactManager();

            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Get All Contacts");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        app.AddContact();
                        break;

                    case "2":
                        app.GetAllContacts();
                        break;

                    case "3":
                        Console.WriteLine("Exiting the application...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
