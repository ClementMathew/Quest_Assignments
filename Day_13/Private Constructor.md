# Private Constructor

#### Discussed about :

    Concept of Private Constructor.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Singleton
    {
        // Static field to hold the single instance of the class

        private static Singleton _instance = null;

        // Property to provide access to the single instance

        public static Singleton Instance
        {
            get
            {
                // If no instance exists, create one

                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        // Private constructor to prevent instantiation from outside

        private Singleton()
        {
            Console.WriteLine("Singleton instance created!");
        }

        // Method to demonstrate functionality

        public void ShowMessage()
        {
            Console.WriteLine("Hello from the Singleton instance!");
        }
    }
    internal class Private_Constructor
    {
        static void Main(string[] args)
        {
            // Try to create multiple instances

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            // Test if both references point to the same instance

            if (s1 == s2)
            {
                Console.WriteLine("Both variables hold the same instance.");
            }

            // Use the Singleton instance

            s1.ShowMessage();

        }
    }
}

```
