# Reversing Elements in Array

##### Question :

    Read an array from user and reverse the array without using inbuilt functions.

---

##### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Elements_in_Array
{
    internal class Reversing_Elements_in_Array
    {
        static void Main(string[] args)
        {

            // Reversing elements in the array.

            int n;

            Console.WriteLine("Enter the number of elements : ");
            n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];
            int[] revArray = new int[n];

            Console.WriteLine("Enter the values : ");

            for (int i = 0; i < n; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The reversed array is : ");

            int count = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                revArray[count] = myArray[i];
                count++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(revArray[i] + " ");
            }

            Console.WriteLine();

        }
    }
}

```
