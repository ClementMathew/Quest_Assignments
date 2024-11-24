using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Models;
using Contact_Manager.Repositories;

namespace Contact_Manager
{
    internal class ContactManager
    {
        private ContactRepository _repository;

        public ContactManager()
        {
            _repository = new ContactRepository();
        }

        public void AddContact()
        {
            var contact = new Contact();

            Console.Write("Name: ");
            contact.Name = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            Console.Write("Phone: ");
            contact.Phone = Console.ReadLine();

            _repository.Create(contact);
        }

        public void GetAllContacts()
        {
            var contacts = _repository.GetAll();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id} - {contact.Name} - {contact.Email} - {contact.Phone}");
            }
        }
    }
}
