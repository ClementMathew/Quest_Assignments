# Animal Sound

#### Question :

    Write a class Animal with a virtual method MakeSound() and create a derived class Dog that overrides MakeSound() to print "Bark!".

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sound
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
    internal class Animal_Sound
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();

            myAnimal.MakeSound();
            myDog.MakeSound();
        }
    }
}

```
