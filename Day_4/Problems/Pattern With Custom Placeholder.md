# Pattern With Custom Placeholder

#### Question :

    Print a pattern of numbers with custom placeholder.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_With_Custom_Placeholder
{
    internal class Pattern_With_Custom_Placeholder
    {
        static void Main(string[] args)
        {

            // Printing pattern

            // 1
            // 2 3
            // 4 5 6
            // 7 8 9 10

            int rows = 6;
            int count = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0, 3}", count++);
                }
                Console.WriteLine();
            }
        }
    }
}

```
