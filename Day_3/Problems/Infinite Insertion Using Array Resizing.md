# Infinite Insertion Using Array Resizing

##### Question :

    Read values from user until user says to exit and print the values when exists.

    Note :- Initial array size must be 1 and keep increasing the size of array according to input.

---

##### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Insertion_Using_Array_Resizing
{
    internal class Infinite_Insertion_Using_Array_Resizing
    {
        static void Main(string[] args)
        {

            // Insering infinite elements to fixed size array by resizing.

            int[] numbers = new int[1];
            int i = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or q to exit : ");
                string val = Console.ReadLine();

                if (val == "q")
                {
                    Console.WriteLine("The values are : ");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                else
                {
                    numbers[i] = int.Parse(val);
                    Array.Resize(ref numbers, numbers.Length + 1);
                    i++;
                }
            }


            // Insering infinite elements to fixed size array by resizing with minimal two insertions.

            int[] numbers2 = new int[0];
            int index = 0;

            while (true)
            {
                if (numbers2.Length < 2)
                {
                    Console.Write($"Enter number {numbers2.Length + 1} : ");
                    Array.Resize(ref numbers2, numbers2.Length + 1);
                    numbers2[index] = int.Parse(Console.ReadLine());
                    index++;
                    continue;
                }

                Console.Write($"Enter number {numbers2.Length + 1} or q to exit : ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                Array.Resize(ref numbers2, numbers2.Length + 1);
                numbers2[index] = int.Parse(input);
                index++;
            }

            int sum = 0;
            for (int j = 0; j < numbers2.Length; j++)
            {
                sum += numbers2[j];
            }
            Console.WriteLine(sum);
        }
    }
}

```
