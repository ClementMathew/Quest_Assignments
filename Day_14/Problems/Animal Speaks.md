# Animal Speaks

#### Question :

    Create an interface IAnimal with a method Speak() and implement the interface in two classes Dog and Cat, each providing their own implementation of Speak().

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Speak
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow!");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    internal class Animal_Speak
    {
        static void Main(string[] args)
        {
            // Dog Speaks

            IAnimal dog = new Dog();

            dog.Speak();

            // Cat Speaks

            IAnimal cat = new Cat();

            cat.Speak();
        }
    }
}

```
