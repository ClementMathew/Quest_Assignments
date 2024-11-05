# Task Run

#### Discussed about :

    Concepts of Task and Run.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Run
{
    internal class Task_Run
    {
        static async Task<int> Multiply(int number)
        {
            await Task.Delay(1000);

            return number * 2;
        }

        public static async Task Main()
        {
            var tasks = new List<Task<int>>()
            {
                Task.Run(() => Multiply(2)),
                Task.Run(() => Multiply(5)),
                Task.Run(() => Multiply(8))
            };

            int[] results = await Task.WhenAll(tasks);
            Console.WriteLine(string.Join(", ", results));
        }
    }
}

```
