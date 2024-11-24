# Delegate

#### Discussed about :

    Concept of Delegate.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Delegate
    {
        // Define a delegate type for tasks

        delegate void TaskDelegate();

        // Method to start a timer

        static void StartTimer(int seconds, TaskDelegate task)
        {
            Console.WriteLine("Timer started");

            // Sleep for the specified number of seconds

            Thread.Sleep(seconds * 1000);

            // Invoke the delegate (task)

            task();
        }

        // Method to be executed after 10 seconds

        static void GreetAfterTenSeconds()
        {
            Console.WriteLine("Hello from C#");
        }

        static void Main(string[] args)
        {
            // Start the timer for 10 seconds and execute GreetAfterTenSeconds

            StartTimer(10, GreetAfterTenSeconds);
        }
    }
}

```
