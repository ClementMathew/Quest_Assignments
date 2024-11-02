# Sum of Two Numbers

#### Question :

    Calculate the sum of two numbers using function.

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
    internal class Sum_of_Two_Numbers
    {
        // Sum of numbers by using function.
        static void Sum(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }

        // Returning sum to main function.
        static int Add(int a, int b)
        {
            return (a + b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int b = int.Parse(Console.ReadLine());

            Sum(a, b);

            int sum = Add(a, b);

            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }
    }
}

```
