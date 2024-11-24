# Static Constructor

#### Discussed about :

    Concept of Static Constructor.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Static_Constructor
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }

        static Employee()
        {
            CompanyName = "Microsoft";
        }

        public Employee(string name) => Name = name;

        public override string ToString() => Name + " " + CompanyName;

    }
    internal class Static_Constructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name :" + Employee.CompanyName);

            var e1 = new Employee("Joe");

            Console.WriteLine(e1);
        }
    }
}

```
