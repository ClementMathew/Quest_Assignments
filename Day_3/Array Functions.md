# Array Functions

##### Discussed about :

    Different built-in functions for array.

---

##### Exapmle Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Functions
{
    internal class Array_Functions
    {
        static void Main(string[] args)
        {

            // Array functions.

            int[] arr = { 4, 1, 3, 2, 3 };

            Console.WriteLine($"Array Length : {arr.Length}");
            Console.WriteLine($"Max value is : {arr.Max()}");
            Console.WriteLine($"Min value is : {arr.Min()}");
            Console.WriteLine($"Sum value is : {arr.Sum()} \n");

            int[,] multiArr = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine($"No of Rows : {multiArr.GetLength(0)}");
            Console.WriteLine($"No of Columns : {multiArr.GetLength(1)}");

            Console.WriteLine($"Upper Bound of 1D array : {arr.GetUpperBound(0)}");
            Console.WriteLine($"Lower Bound of 1D array : {arr.GetLowerBound(0)} \n");

            // Index Of

            int index = Array.IndexOf(arr, 3);
            Console.WriteLine($"Index of 3 : {index}");

            // Last Index Of

            int lastIndex = Array.LastIndexOf(arr, 3);
            Console.WriteLine($"Last Index of 3 : {lastIndex} \n");

            // Sort

            Array.Sort(arr);
            Console.WriteLine($"Sorted Array : {string.Join(", ", arr)}");

            // Reverse

            Array.Reverse(arr);
            Console.WriteLine($"Reversed Array : {string.Join(", ", arr)} \n");

            // Clear

            Array.Clear(arr, 1, 2);
            Console.WriteLine($"Array after Clear : {string.Join(", ", arr)}");

            // Resize

            Array.Resize(ref arr, 7);
            Console.WriteLine($"Resized Array : {string.Join(", ", arr)} \n");

            // Copy

            int[] copyArr = new int[7];

            Array.Copy(arr, copyArr, arr.Length);
            Console.WriteLine($"Copied Array : {string.Join(", ", copyArr)}");

            // Clone

            int[] clonedArr = (int[])arr.Clone();
            Console.WriteLine($"Cloned Array : {string.Join(", ", clonedArr)} \n");

            // Exists

            bool exists = Array.Exists(arr, element => element == 4);
            Console.WriteLine($"Does 4 exist in array ? : {exists}");

            // Find

            int found = Array.Find(arr, element => element > 1);
            Console.WriteLine($"First element > 1 : {found}");

            // Find All

            int[] foundAll = Array.FindAll(arr, element => element > 1);
            Console.WriteLine($"All elements > 1 : {string.Join(", ", foundAll)} \n");

            // Binary Search

            Array.Sort(arr);
            int searchIndex = Array.BinarySearch(arr, 2);
            Console.WriteLine($"Index of 2 after BinarySearch : {searchIndex}");
        }
    }
}

```
