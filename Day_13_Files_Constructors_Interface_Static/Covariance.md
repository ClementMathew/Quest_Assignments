# Covariance

#### Discussed about :

    Concept of Covariance.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    // Base class Animal

    class Animal
    {
        public string Name { get; set; }
    }

    // Derived class Dog

    class Dog : Animal
    {
        public string Breed { get; set; }
    }

    internal class Covariance
    {
        static void Main(string[] args)
        {
            // List of derived type Dog

            List<Dog> dogs = new List<Dog>
            {
                new Dog { Name = "Max", Breed = "Labrador" },
                new Dog { Name = "Buddy", Breed = "Beagle" }
            };

            // Covariance allows assignment of List<Dog> to IEnumerable<Animal>

            IEnumerable<Animal> animals = dogs;

            // You can still iterate through the animals list

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}

```
