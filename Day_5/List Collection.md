# List Collection

##### Discussed about :

    List functions like Add, AddRange, Remove and RemoveAt.

---

##### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class List
    {
        static void Main(string[] args)
        {
            // Collection type List and its properties.

            List<int> lst = new List<int>();
            Console.WriteLine(lst + "\n");

            // Add a single element.

            lst.Add(10);

            // To display values from list.

            Console.Write("The values in the list (Add) : ");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.WriteLine();

            Console.Write("The values in the list using foreach : ");

            foreach (var item in lst)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Add multiple elements

            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };

            lst.AddRange(valuesToAdd);

            Console.Write("The values in the list (AddRange) : ");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.WriteLine();

            // Change or Update an item

            lst[0] = 100;

            Console.Write("The values in the list after updating : ");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.WriteLine();

            // Remove an element (it will remove the first occurance of it)

            lst.Remove(50);

            Console.Write("The values in the list (Remove) : ");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.WriteLine();

            // Remove at from specific index

            lst.RemoveAt(1);

            Console.Write("The values in the list (RemoveAt) : ");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

```
