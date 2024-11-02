# Splitting And Reversing Array

#### Question :

    Split in the middle of an array and reverse both arrays and join.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitting_And_Reversing_Array
{
    internal class Splitting_And_Reversing_Array
    {
        static void Main(string[] args)
        {

            // Splitting the array and reversing each array and then joining.

            int n;

            Console.WriteLine("Enter the number of elements : ");
            n = int.Parse(Console.ReadLine());

            int[] myArray = new int[n];
            int[] modArray = new int[n];
            int count = 0;

            Console.WriteLine("Enter the values : ");

            for (int i = 0; i < n; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            if (n % 2 != 0)
            {
                for (int i = (n / 2) - 1; i >= 0; i--)
                {
                    modArray[count] = myArray[i];
                    count++;
                }
                modArray[count] = myArray[n / 2];
                count++;
                for (int i = n - 1; i > n / 2; i--)
                {
                    modArray[count] = myArray[i];
                    count++;
                }
            }
            else
            {
                for (int i = (n / 2) - 1; i >= 0; i--)
                {
                    modArray[count] = myArray[i];
                    count++;
                }
                for (int i = n - 1; i >= n / 2; i--)
                {
                    modArray[count] = myArray[i];
                    count++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(modArray[i]);
            }
        }
    }
}

```
