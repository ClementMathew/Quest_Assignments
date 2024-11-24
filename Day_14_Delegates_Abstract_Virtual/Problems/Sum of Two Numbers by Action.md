# Sum of Two Numbers by Action

#### Question :

    Create an Action<int, int> delegate that takes two integers and prints their sum.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers_by_Action
{
    internal class Sum_of_Two_Numbers_by_Action
    {
        static void Main(string[] args)
        {
            Action<int, int> sumAction = (a, b) => Console.WriteLine($"The sum : {a + b}");

            sumAction(10, 20);
        }
    }
}

```
