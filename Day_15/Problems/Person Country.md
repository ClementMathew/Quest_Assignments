# Person Country

#### Question :

1. **Filter by Country**

   - How do you retrieve persons where the country is "US"?

2. **Find Minimum Age in US**

   - How do you find the minimum age of a person in the US?

3. **Person with Minimum Age in US**

   - How can you find the first person with the minimum age in the US?

4. **Sort by Age Descending**

   - How do you sort the persons by age in descending order?

5. **List Distinct Countries**

   - How do you retrieve a list of distinct countries from the person data?

6. **Convert to Dictionary**

   - How can you create a dictionary containing each person’s name and country?

7. **Group by Country and Count Persons**

   - How can you group persons by country and count the number of persons in each country?

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Person_Country
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name -> {Name}, Country -> {Country}, Age -> {Age}";
        }
    }

    internal class Person_Country
    {
        static void Main(string[] args)
        {

            // Persons Problem

            var data2 = new List<Person>()
            {
              new Person{Name="Person 1", Country="US", Age=20},
              new Person{Name="Person 2", Country="US", Age=30},
              new Person{Name="Person 3", Country="US", Age=40},
              new Person{Name="Person 4", Country="IN", Age=50}
            };


            // Persons where country is US.

            var res2 = data2.Where(p => p.Country == "US");

            Console.Write($"US Country : ");

            foreach (var person in res2)
            {
                Console.WriteLine(person.Name);
            }


            // Minimum Age of Person in US.

            var minAge = data2.Where(p => p.Country == "US").Min(p => p.Age);

            Console.WriteLine($"\nMinimum Age in US Country : {minAge}");


            // Person with Minimum Age.

            var firstPerson = data2.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();

            Console.WriteLine($"\nPerson with Minimum Age in US Country : {firstPerson}");


            // Order Person by their Age.

            var sorted2 = data2.OrderByDescending(p => p.Age);

            Console.WriteLine($"\nPersons in order of age : ");

            foreach (var person in sorted2)
            {
                Console.WriteLine(person.Name);
            }


            // List of Distinct Countries.

            var distinctCountries = data2.Select(p => p.Country).Distinct();

            Console.WriteLine($"\nList of Countries : ");

            foreach (var person in distinctCountries)
            {
                Console.WriteLine(person);
            }


            // Select to Dictionary.

            var countries = data2.Select(p => new Dictionary<string, string>()
            {
                { "Name", p.Name },
                { "Country", p.Country }
            });

            Console.WriteLine("\nThe names and country in Dictionary : \n");

            foreach (var country in countries)
            {
                foreach (var person in country)
                {
                    Console.Write($"{person.Key} -> {person.Value} | ");
                }
                Console.WriteLine();
            }


            // Group by country and count of persons in each country.

            var groups = data2.GroupBy(p => p.Country);

            Console.WriteLine($"\nCount of persons in each country : ");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");

                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person.Name}");
                }
            }
        }
    }
}

```
