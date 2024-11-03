# SQL and C#

#### Discussed about :

1. **Database Connection String**

   - What is the purpose of `connString`, and how is it used to connect to the database?

2. **Create Table Query**

   - How would you write a SQL command to create a `BOOKS` table with columns for `id`, `name`, `author`, and `price`?

3. **Parameterized Insert Query**

   - Explain how the `insertQuery` uses parameterized SQL to insert a book into the database. Why is parameterization important?

4. **Using a `SqlConnection` and `SqlCommand`**

   - How does the code utilize `SqlConnection` and `SqlCommand` classes to execute SQL commands?

5. **Fetching Records**

   - How would you modify the code to retrieve records from the `BOOKS` table and display their `id`, `name`, `author`, and `price`?

6. **Inserting Multiple Records**

   - How does the code insert multiple `Book` objects from the list `list` into the `BOOKS` table? Why is `AddWithValue` used?

7. **Executing a `SELECT` Statement**

   - How would you write code to execute a `SELECT` query to retrieve all records from the `BOOKS` table?

8. **Closing Connections**

   - Why is it important to close the database connection after executing commands?

<br>

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_and_C_
{
    internal class SQL_and_C_
    {
        const string connString = @"Data Source=localhost\SQLExpress;Initial Catalog=Book_Library;Integrated Security=True";

        static void Main(string[] args)
        {
            // Create the BOOKS table in the database

            var createTableQuery = @"CREATE TABLE BOOKS
                                     (
                                         id INT PRIMARY KEY IDENTITY,
                                         name VARCHAR(50),
                                         author VARCHAR(50),
                                         price INT
                                     )";

            // Sample user input for adding a book to the database

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("Price: ");
            var price = Console.ReadLine();

            var insertQuery = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var command = new SqlCommand(insertQuery, conn);

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@price", price);

                command.ExecuteNonQuery();
            }

            // Select statement to retrieve records

            var query = $"SELECT id, name, author, price from Books";

            using (var connn = new SqlConnection(connString))
            {
                connn.Open();
                var commandd = new SqlCommand(query, connn);
                var reader = commandd.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var namee = reader.GetString(1);
                    var value = reader.GetString(2);
                    var pricee = reader.GetInt32(3);

                    Console.WriteLine($"{id} = {namee} - {value} = {pricee}");
                }
            }

            // Inserting a list of books

            var list = new List<Books>()
            {
                new Books{Name = "Book2", Author = "Author 2", Price = 2000},
                new Books { Name = "Book3", Author = "Author3", Price = 150 },
                new Books { Name = "Book4", Author = "Author4", Price = 250 },
                new Books { Name = "Book5", Author = "Author5", Price = 300 },
                new Books { Name = "Book6", Author = "Author6", Price = 500 },
            };

            using (var connect = new SqlConnection(connString))
            {
                connect.Open();
                foreach (var item in list)
                {
                    var insertQ = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
                    var command = new SqlCommand(insertQ, connect);
                    command.Parameters.AddWithValue("@name", item.Name);
                    command.Parameters.AddWithValue("@author", item.Author);
                    command.Parameters.AddWithValue("@price", item.Price);
                    command.ExecuteNonQuery();
                }

            }
        }
    }
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}

```
