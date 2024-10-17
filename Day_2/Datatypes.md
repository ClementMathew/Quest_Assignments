# Datatypes

#### Discussed about :

    1. Explicit and Implicit Conversion
    2. Nullable and Non Nullable Datatype
    3. Signed and Unsigned Datatype

---

#### Example Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            // Parsing to int using Explicit conversion.

            Console.WriteLine("Enter the first number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of numbers {n1} and {n2} is {n1 + n2} \n");

            // Implicit conversion.

            int i = 10;
            long l = i;
            Console.WriteLine($"Long 'l' converted from int 'i' is {l}");

            char c = 'A';
            int ic = c;
            Console.WriteLine($"Int 'ic' converted from char 'c' is {ic} \n");

            // Datatypes nullable and not nullable.

            int x = 1;
            int? y = null;

            Console.WriteLine($"Not nullable value : {x}");
            Console.WriteLine($"Nullable value : {y} \n");

            // Signed int datatype.

            int displacement = -23455;

            Console.WriteLine($"Signed int : {displacement}");
            Console.WriteLine($"Signed int max value : {int.MaxValue}");
            Console.WriteLine($"Signed int min value : {int.MinValue} \n");

            // Signed long datatype.

            long displacementLong = -2000000000;

            Console.WriteLine($"Signed long : {displacementLong}");
            Console.WriteLine($"Signed long max value : {long.MaxValue}");
            Console.WriteLine($"Signed long min value : {long.MinValue} \n");

            // Unsigned int datatype.

            uint distance = 23559;

            Console.WriteLine($"Unsigned int : {distance}");
            Console.WriteLine($"Unsigned int max value : {uint.MaxValue}");
            Console.WriteLine($"Unsigned int min value : {uint.MinValue} \n");

            // Unsigned long datatype.

            ulong distanceLong = 2000000000;

            Console.WriteLine($"Unsigned long : {distanceLong}");
            Console.WriteLine($"Unsigned long max value : {ulong.MaxValue}");
            Console.WriteLine($"Unsigned long min value : {ulong.MinValue} \n");

            // Byte datatype.

            byte valueByte = 1;

            Console.WriteLine($"Byte is unsigned by default : {valueByte}");
            Console.WriteLine($"Byte max value : {byte.MaxValue}");
            Console.WriteLine($"Byte min value : {byte.MinValue} \n");

            // Sbyte datatype.

            sbyte signedByte = -1;

            Console.WriteLine($"Signed byte : {signedByte}");
            Console.WriteLine($"Signed byte max value : {sbyte.MaxValue}");
            Console.WriteLine($"Signed byte min value : {sbyte.MinValue} \n");

            // Short datatype.

            short signedShort = -155;

            Console.WriteLine($"Signed short : {signedShort}");
            Console.WriteLine($"Signed short max value : {short.MaxValue}");
            Console.WriteLine($"Signed short min value : {short.MinValue} \n");

            // Unsigned short datatype.

            ushort unSignedShort = 155;

            Console.WriteLine($"Unsigned short : {unSignedShort}");
            Console.WriteLine($"Unsigned short max value : {ushort.MaxValue}");
            Console.WriteLine($"Unsigned short min value : {ushort.MinValue} \n");

            // Double datatype.

            double doubleValue = 1556373.567;

            Console.WriteLine($"Double datatype value : {doubleValue}");
            Console.WriteLine($"Double max value : {double.MaxValue}");
            Console.WriteLine($"Double min value : {double.MinValue} \n");

            // Float datatype.

            float floatValue = 1556.567F;

            Console.WriteLine($"Float datatype value : {floatValue}");
            Console.WriteLine($"Float max value : {float.MaxValue}");
            Console.WriteLine($"Float min value : {float.MinValue} \n");

            // Decimal datatype.

            decimal decimalValue = 15567643874.567763498M;

            Console.WriteLine($"Decimal datatype value : {decimalValue}");
            Console.WriteLine($"Decimal max value : {decimal.MaxValue}");
            Console.WriteLine($"Decimal min value : {decimal.MinValue} \n");

            // Bool datatype.

            bool boolValue = false;

            Console.WriteLine($"Boolean datatype value : {boolValue} \n");

            // Char datatype.

            char letter = 'a';

            Console.WriteLine($"Char datatype value : {letter} \n");

            // Object datatype.

            object objValue1 = 1;
            object objValue2 = 1.1;
            object objValue3 = 'a';
            object objValue4 = "Hai";

            Console.WriteLine($"Object accepting integer : {objValue1}");
            Console.WriteLine($"Object accepting double : {objValue2}");
            Console.WriteLine($"Object accepting char : {objValue3}");
            Console.WriteLine($"Object accepting string : {objValue4} \n");
        }
    }
}

```
