# Disconnected Architecture

#### Discussed about :

    Structured Query Language using Disconnected Architecture.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_Architecture
{
    internal class Disconnected_Architecture
    {
        static void Main(string[] args)
        {
            string connStr = "Server=CLEMENTS-ASUS-V\\SQLEXPRESS;Database=Disconnected_Architecture;Trusted_Connection=True";

            DataTable dt = new DataTable();
            var conn = new SqlConnection(connStr);

            // Query from Database

            string query = "SELECT * FROM Data";

            var adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.Write(row["Id"] + ". ");
                Console.WriteLine(row["Name"]);
            }

            // Update

            var commandBuilder = new SqlCommandBuilder(adapter);

            var newRow = dt.NewRow();
            newRow["Id"] = 2;
            newRow["Name"] = "Mathew";

            dt.Rows.Add(newRow);
            adapter.Update(dt);

            Console.WriteLine("Task Completed.");
        }
    }
}

```
