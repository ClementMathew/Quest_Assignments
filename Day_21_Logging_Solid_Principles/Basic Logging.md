# Basic Logging

#### Discussed about :

    Concepts of Logging.

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Basic_Logging
{
    internal class Basic_Logging
    {
        // Set up a static readonly logger instance for the Program class

        private static readonly ILog log = LogManager.GetLogger(typeof(Basic_Logging));

        static void Main(string[] args)
        {
            // Set up a simple configuration that logs to the console

            BasicConfigurator.Configure();

            log.Info("Entering application.");

            Console.WriteLine("Hello World!");

            try
            {
                Console.Write("Enter num1: ");
                int i = int.Parse(Console.ReadLine());

                Console.Write("Enter num2: ");
                int j = int.Parse(Console.ReadLine());

                int sum = i + j;
                Console.WriteLine("Sum: " + sum);
            }
            catch (Exception e)
            {
                // Log the error message to the console and any configured logging destination

                log.Error("An error occurred: " + e.Message);
            }
            log.Info("Leaving application.");
        }
    }
}

```
