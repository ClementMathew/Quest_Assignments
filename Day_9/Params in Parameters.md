# Params in Parameters

#### Discussed about :

    Params keyword.

---

#### Example Code :

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_in_Parameters
{
    internal class Params_in_Parameters
    {
        // Method using params keyword to accept a variable number of arguments

        static void AddParams(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum of numbers: {sum}");
        }

        // Method without params, requires passing an array explicitly

        static void Add(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum of array elements: {sum}");
        }

        // Method with two fixed parameters and params for additional numbers

        static void AddParamsWithTwoValues(int a, int b, params int[] numbers)
        {
            int sum = a + b + numbers.Sum();

            Console.WriteLine($"Sum of {a}, {b}, and other numbers: {sum}");
        }

        static void Main(string[] args)
        {
            var ar = new int[] { 1, 2, 3, 4 };

            Add(ar);  // Passing array

            Add(new int[] { 1, 2, 3 });  // Passing array directly

            // Using AddParams with a variable number of arguments

            AddParams(1, 2, 3, 4);
            AddParams(1, 2, 3, 4, 5, 60);  // Passing multiple values

            // Using AddParamsWithTwoValues

            AddParamsWithTwoValues(1, 2); // Just two values

            AddParamsWithTwoValues(1, 2, 3, 4, 5, 6);  // Two fixed values followed by params
        }
    }
}

```
