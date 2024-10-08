# Remove Even Numbers

##### Question :

    Display a list by removing all even numbers entered by user.

---

##### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Even_Numbers
{
    internal class Remove_Even_Numbers
    {
        static void Main(string[] args)
        {
            // Display a list by removing all even numbers entered by user.

            var list = new List<int>();

            Console.WriteLine("Enter 5 numbers : ");

            for (int i = 0; i < 5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            // always recommend to use the copy of it in foreach

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }

            // printing the list

            Console.Write("The list after removing even numbers : ");

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}

```
