# Sum of Two Numbers by Func

#### Question :

    Define a Func<int, int, int> delegate that takes two integers as parameters and returns their sum.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    internal class Sum_of_Two_Numbers_by_Func
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumFunc = (a, b) => a + b;

            Console.WriteLine(sumFunc(5, 7));
        }
    }
}

```
