using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    internal class IEnumerable
    {
        static void Main(string[] args)
        {
            // IEnumerable

            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // ICollection

            ICollection<string> fruits = new List<string> { "Apple", "Banana" };

            fruits.Add("Cherry");
            Console.WriteLine(fruits.Count);

            fruits.Remove("Banana");
            Console.WriteLine(fruits.Count);

            // IList

            IList<string> cities = new List<string> { "New York", "Los Angeles", "Chicago" };

            cities.Insert(1, "Houston");
            Console.WriteLine(cities[1]);

            cities.RemoveAt(2);
            Console.WriteLine(cities.Count);
        }
    }
}
