using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Common;
using Contact_Manager.Models;

namespace Contact_Manager.Repositories
{
    internal class ContactRepository
    {
        private SqlConnection _connection;

        public ContactRepository()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);
        }

        public void Create(Contact contact)
        {
            EnsureConnectionIsOpen();

            var sql = "INSERT INTO Contacts (name, email, phone) VALUES (@Name, @Email, @Phone)";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@name", contact.Name);
            command.Parameters.AddWithValue("@email", contact.Email);
            command.Parameters.AddWithValue("@phone", contact.Phone);

            command.ExecuteNonQuery();
        }

        public List<Contact> GetAll()
        {
            EnsureConnectionIsOpen();

            var sql = "SELECT id, name, email, phone FROM Contacts";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            var contacts = new List<Contact>();

            while (reader.Read())
            {
                contacts.Add(new Contact
                {
                    Id = (int)reader["id"],
                    Name = (string)reader["name"],
                    Email = (string)reader["email"],
                    Phone = (string)reader["phone"]
                });
            }
            return contacts;
        }

        private void EnsureConnectionIsOpen()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}
