using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_Out
{
    internal class Ref_and_Out
    {
        static void SquareRef(ref int number)
        {
            number *= number;
        }

        static void InitializeOut(out int number)
        {
            number = 10;
        }

        static void Main(string[] args)
        {
            // Using 'ref'

            int refNumber = 5;
            Console.WriteLine("Before SquareRef: " + refNumber);

            SquareRef(ref refNumber);  // Pass by reference
            Console.WriteLine("After SquareRef: " + refNumber);

            // Using 'out'

            int outNumber;  // No need to initialize

            InitializeOut(out outNumber);  // Pass by out keyword
            Console.WriteLine("After InitializeOut: " + outNumber);
        }
    }
}
