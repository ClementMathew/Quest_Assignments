# Sum of Even Numbers

#### Question :

    Read an array from the user and print the sum of even numbers.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Even_Numbers
{
    internal class Sum_of_Even_Numbers
    {
        static void Main(string[] args)
        {

            // Sum of even numbers in an array.

            int n;

            Console.WriteLine("\nEnter the number of elements : ");
            n = int.Parse(Console.ReadLine());

            int[] myArray2 = new int[n];
            int evenSum = 0;

            Console.WriteLine("Enter the values : ");

            for (int i = 0; i < n; i++)
            {
                myArray2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The even sum is : ");

            for (int i = 0; i < n; i++)
            {
                if (myArray2[i] % 2 == 0)
                {
                    evenSum += myArray2[i];
                }
            }
            Console.Write(evenSum + "\n");
        }
    }
}

```
