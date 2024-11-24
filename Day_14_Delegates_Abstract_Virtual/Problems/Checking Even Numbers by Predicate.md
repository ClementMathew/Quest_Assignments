# Checking Even Numbers by Predicate

#### Question :

    Write a Predicate<int> that checks if a given integer is even.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checking_Even_Numbers
{
    internal class Checking_Even_Numbers
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = num => num % 2 == 0;

            Console.WriteLine(isEven(4));
            Console.WriteLine(isEven(7));
        }
    }
}

```
