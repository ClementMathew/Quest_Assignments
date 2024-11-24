# Culture Info

#### Discussed about :

    Concept of Culture Info.

---

#### Example Code :

```c#

using System;
using System.Globalization;

public class Culture_Info
{
    public static void Main()
    {
        decimal amount = 1234.56m;
        DateTime date = DateTime.Now;

        // Define some culture info objects

        CultureInfo usCulture = new CultureInfo("en-US");    // United States
        CultureInfo frCulture = new CultureInfo("fr-FR");    // France
        CultureInfo jpCulture = new CultureInfo("ja-JP");    // Japan

        // Display information in US format

        Console.WriteLine("US Format:");
        Console.WriteLine("Date: " + date.ToString("D", usCulture));
        Console.WriteLine("Currency: " + amount.ToString("C", usCulture));
        Console.WriteLine();

        // Display information in French format

        Console.WriteLine("French Format:");
        Console.WriteLine("Date: " + date.ToString("D", frCulture));
        Console.WriteLine("Currency: " + amount.ToString("C", frCulture));
        Console.WriteLine();

        // Display information in Japanese format

        Console.WriteLine("Japanese Format:");
        Console.WriteLine("Date: " + date.ToString("D", jpCulture));
        Console.WriteLine("Currency: " + amount.ToString("C", jpCulture));
    }
}

```
