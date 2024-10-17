# Datetime

#### Discussed about :

    1. Date time functions
    2. Formatting date

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    internal class Datetime
    {
        static void Main(string[] args)
        {
            // DateTime functions.

            DateTime dt = DateTime.Now;
            Console.WriteLine($"Datetime now : {dt}");

            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine($"Datetime utcnow : {dtu} \n");

            Console.WriteLine($"Day : {dt.Day}");
            Console.WriteLine($"Month :{dt.Month}");
            Console.WriteLine($"Year : {dt.Year}");
            Console.WriteLine($"Hour : {dt.Hour}");
            Console.WriteLine($"Minute : {dt.Minute}");
            Console.WriteLine($"Second : {dt.Second}");
            Console.WriteLine($"MilliSecond :{dt.Millisecond} \n");

            // AddDays

            var tendaysFromNow = dt.AddDays(10);
            Console.WriteLine($"Ten days added : {tendaysFromNow}");

            // AddHours

            var tenDaysAndTwentyHoursFromNow = dt.AddHours(20).AddDays(10);
            Console.WriteLine($"Ten days and twenty hours added : {tenDaysAndTwentyHoursFromNow} \n");

            // Formatting date and time

            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy") + "\n");

            // Constructing Date and Time

            var myDt = new DateTime(2024, 10, 07, 10, 50, 49);
            Console.WriteLine($"Constructed datetime : {myDt}");

        }
    }
}

```
