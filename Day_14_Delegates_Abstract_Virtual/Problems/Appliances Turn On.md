# Appliances Turn On

#### Question :

    Define an abstract class Appliance with an abstract method TurnOn() and create a derived class Fan that implements the TurnOn() method.

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances_Turn_On
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }

    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is now ON.");
        }
    }
    internal class Appliances_Turn_On
    {

        static void Main(string[] args)
        {
            Appliance myFan = new Fan();

            myFan.TurnOn();
        }
    }
}

```
