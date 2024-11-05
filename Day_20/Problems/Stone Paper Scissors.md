# Stone Paper Scissors Game

#### Question :

    Implement Stone Paper Scissors Game.

---

#### Code :

```c#

// Stone Paper Scissors Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stone_Paper_Scissors.Play;

namespace Stone_Paper_Scissors
{
    internal class Stone_Paper_Scissors
    {
        static void Main(string[] args)
        {
            GameManager.Play();
        }
    }
}

```

```c#

// Game Manager Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stone_Paper_Scissors.Play;

namespace Stone_Paper_Scissors
{
    internal static class GameManager
    {
        public static int User { get; set; }
        public static int Computer { get; set; }

        public static void Play()
        {
            Console.WriteLine("--- Stone Paper Scissors ---");
            Console.WriteLine("\n1 - Stone \n2 - Paper \n3 - Scissors");

            while (true)
            {
                Console.WriteLine("\nEnter b/w 1 and 3 : ");
                int x = int.Parse(Console.ReadLine());

                int y = PlayComputer.GiveValue();
                Console.WriteLine($"From computer : {y}");

                if (x == 1 && y == 3)
                {
                    Console.WriteLine("You got me...");
                    User++;
                }
                else if (x == 1 && y == 2)
                {
                    Console.WriteLine("Got you...");
                    Computer++;
                }
                else if (x == 2 && y == 1)
                {
                    Console.WriteLine("You got me...");
                    User++;
                }
                else if (x == 2 && y == 3)
                {
                    Console.WriteLine("Got you...");
                    Computer++;
                }
                else if (x == 3 && y == 1)
                {
                    Console.WriteLine("Got you...");
                    Computer++;
                }
                else if (x == 3 && y == 2)
                {
                    Console.WriteLine("You got me...");
                    User++;
                }
                else
                {
                    Console.WriteLine("Keep moving...");
                }

                Check();
            }
        }
        public static void Check()
        {
            if (User == 10 || Computer == 10)
            {
                Console.WriteLine("\n--- Game Finished ---");

                Console.WriteLine("Score : ");
                Console.WriteLine($"User : {User}");
                Console.WriteLine($"Computer : {Computer}");
            }
        }
    }
}

```

```c#

// Play Computer Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone_Paper_Scissors.Play
{
    internal static class PlayComputer
    {

        public static int GiveValue()
        {
            Random rand = new Random();

            return rand.Next(1, 4);
        }
    }
}

```
