# Boxing and Unboxing

#### Discussed about :

    1. Boxing
    2. Unboxing

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    internal class Boxing_and_Unboxing
    {
        static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine($"The integer i :{i}");

            // Boxing

            object obj = i;

            Console.WriteLine($"\nThe object obj after boxing from int i :{obj}");

            // Unboxing

            int j = (int)obj;

            Console.WriteLine($"\nThe int j after unboxing from object obj :{j}");
        }
    }
}

```
