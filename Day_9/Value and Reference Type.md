# Value and Reference Type

#### Discussed about :

    1. Value type datatypes.
    2. Reference type datatypes.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_Reference_Type
{
    internal class Value_and_Reference_Type
    {
        public class MyClass
        {
            public string Data { get; set; }
        }

        static void ChangeDataRefType(MyClass obj) => obj.Data = "New Data";

        static void ChangeDataValueType(int i) => i = 10;

        static void Main(string[] args)
        {
            // Reference Type

            var obj = new MyClass() { Data = "Old Data" };

            Console.WriteLine($"Before Reference Type Change: {obj.Data}");

            ChangeDataRefType(obj);

            Console.WriteLine($"\nAfter Reference Type Change: {obj.Data}");

            // Value Type

            int i = 5;

            Console.WriteLine($"\nBefore Value Type Change: {i}");

            ChangeDataValueType(i);

            Console.WriteLine($"\nAfter Value Type Change: {i}");
        }
    }
}

```
