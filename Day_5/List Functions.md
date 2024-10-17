# List Collection

#### Discussed about :

    All list functions.

---

#### Example Code :

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Functions
{
    internal class List_Functions
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
                Console.Write(lst[i] + " ");

            Console.WriteLine();

            Console.Write("The values in the list using foreach : ");

            foreach (var item in lst)
                Console.Write(item + " ");

            Console.WriteLine();


            //Add multiple elements

            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };
            lst.AddRange(valuesToAdd);
            Console.Write($"The values in the list (AddRange) : {string.Join(" ", lst)}\n");

            // Change or Update an item

            lst[0] = 100;
            Console.Write($"The values in the list after updating  : {string.Join(" ", lst)}\n");

            // Remove an element (it will remove the first occurrence of it)

            lst.Remove(50);
            Console.Write($"The values in the list (Remove) : {string.Join(" ", lst)}\n");

            // Remove at from specific index

            lst.RemoveAt(1);
            Console.Write($"The values in the list (RemoveAt) : {string.Join(" ", lst)}\n");

            // Remove Range

            lst.RemoveRange(1, 2);
            Console.WriteLine($"The values after (Remove Range) : {string.Join(" ", lst)}");

            // Contains

            bool contains100 = lst.Contains(100);
            Console.WriteLine($"The value 100 present or not : {contains100}");

            // Insert

            lst.Insert(2, 3);
            Console.WriteLine($"The values after (Insert) : {string.Join(" ", lst)}");

            // Insert Range

            lst.InsertRange(1, new int[] { 12, 5 });
            Console.WriteLine($"The values after (Insert Range) : {string.Join(" ", lst)}");

            // IndexOf

            int index = lst.IndexOf(2);
            Console.WriteLine($"The index of 2 is : {index}");

            // Last IndexOf

            int lastIndex = lst.LastIndexOf(100);
            Console.WriteLine($"The index of 100 is : {lastIndex}");

            // Sort

            lst.Sort();
            Console.WriteLine($"The values after (Sort) : {string.Join(" ", lst)}");

            // Reverse

            lst.Reverse();
            Console.WriteLine($"The values after (Reverse) : {string.Join(" ", lst)}");

            // To Array

            int[] array = lst.ToArray();
            Console.WriteLine($"The values after (ToArray) : {string.Join(" ", array)}");

            // Find

            int result = lst.Find(x => x > 2);
            Console.WriteLine($"The first occurrence of value > 2 is : {result}");

            // Find All

            List<int> resultAll = lst.FindAll(x => x > 2);
            Console.WriteLine($"The values > 2 are : {string.Join(" ", resultAll)}");

            // Find Index

            int indexFind = lst.FindIndex(x => x > 2);
            Console.WriteLine($"The index of element > 2 : {indexFind}");

            // Find Last

            int resultLast = lst.FindLast(x => x > 2);
            Console.WriteLine($"The last value of element > 2 : {resultLast}");

            // Find Last Index

            int indexLast = lst.FindLastIndex(x => x > 2);
            Console.WriteLine($"The last index of element > 2 : {resultLast}");

            // Count

            int count = lst.Count;
            Console.WriteLine($"The count of elements in array : {count}");

            // Binary Search

            int indexSearch = lst.BinarySearch(3);
            Console.WriteLine($"The binary search of 3 gives index : {indexSearch}");

            // Foreach

            Console.Write($"The foreach values : ");
            lst.ForEach(x => Console.Write(x + " "));

            // Clear

            lst.Clear();
            Console.WriteLine($"\nThe list after (Clear) : {string.Join(" ", lst)}");
        }
    }
}


```
