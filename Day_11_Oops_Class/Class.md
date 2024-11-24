# Class

#### Discussed about :

    Concepts of class and object creation.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class NewClass
    {
        public string Name;

        public override string ToString()
        {
            return $"Name : {Name}";
        }

        public void DisplayName()
        {
            Console.WriteLine($"Name : {Name}");
        }
    }

    internal class Class
    {
        static void Main(string[] args)
        {
            NewClass newclass = new NewClass();
            newclass.Name = " The class";

            NewClass newerclass = new NewClass();
            newerclass.Name = " The newer class";

            Console.WriteLine(newclass);
            Console.WriteLine(newerclass);

            newclass.DisplayName();
            newerclass.DisplayName();
        }
    }
}

```
