


using System;

namespace ExceptionsHandling
{
    // Custom Exception Class

    class MyCustomException : Exception
    {
        public string Message { get; set; }

        public MyCustomException(string message)
        {
            Message = message;
        }
    }

    internal class Exception_Handling
    {
        static void Main(string[] args)
        {
            // First Try-Catch Block

            try
            {
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                Console.WriteLine("Result of division: " + i / j);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too large");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // Second Try-Catch-Finally Block

            try
            {
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                Console.WriteLine("Result of division: " + i / j);
            }
            catch (Exception e)
            {
                // Throwing error

                throw e;
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }

            Console.WriteLine("Code after second try-catch-finally block");

            // Third Try-Catch Block with Custom Exception
            try
            {
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                if (j == 0)
                {
                    throw new MyCustomException("Second number should not be zero.");
                }

                Console.WriteLine("Addition: " + (i + j));
                Console.WriteLine("Subtraction: " + (i - j));
                Console.WriteLine("Multiplication: " + (i * j));
            }
            catch (MyCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
