# Multicast Delegate

#### Discussed about :

    Concepts of Multicast Delegate.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Multicast_Delegate
    {
        static void Main(string[] args)
        {
            Func<int, int, int> del = (a, b) => a + b;

            del += (a, b) => a - b;

            foreach (Func<int, int, int> item in del.GetInvocationList())
            {
                Console.WriteLine(item(5, 10));
            }
        }
    }
}

```
