# Access Specifiers

#### Discussed about :

    All access specifiers.

Here is a list of C# access specifiers in markdown format:

- **`public`**: Accessible from any other code.

- **`private`**: Accessible only within the same class.

- **`protected`**: Accessible within the same class and derived classes.

- **`internal`**: Accessible within the same assembly, but not from another assembly.

- **`protected internal`**: Accessible within the same assembly or in derived classes.

<br>

---

#### Code :

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
    public class ExampleClass
    {
        public string PublicField = "Public Field";

        private string PrivateField = "Private Field";

        protected string ProtectedField = "Protected Field";

        internal string InternalField = "Internal Field";

        protected internal string ProtectedInternalField = "Protected Internal Field";

        // Public method

        public void PublicMethod()
        {
            Console.WriteLine("Public Method: Can be called anywhere.");
            Console.WriteLine(PrivateField); // Private field accessible here
            Console.WriteLine(ProtectedField); // Protected field accessible here
            Console.WriteLine(InternalField); // Internal field accessible here
            Console.WriteLine(ProtectedInternalField); // Protected internal field accessible here
        }

        // Private method

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method: Only accessible within this class.");
        }

        // Protected method

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method: Accessible in this class and derived classes.");
        }

        // Internal method

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method: Accessible within the same assembly.");
        }

        // Protected internal method

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method: Accessible within this assembly or derived classes.");
        }
    }

    // Derived class to demonstrate protected and protected internal access

    public class DerivedClass : ExampleClass
    {
        public void ShowAccess()
        {
            Console.WriteLine(PublicField); // Accessible
            Console.WriteLine(ProtectedField); // Accessible
            Console.WriteLine(ProtectedInternalField); // Accessible
            Console.WriteLine(InternalField); // Accessible within same assembly

            // PrivateField is NOT accessible here
        }
    }

    // Another class in the same assembly

    internal class InternalClass
    {
        public void ShowInternalAccess()
        {
            ExampleClass example = new ExampleClass();
            Console.WriteLine(example.PublicField); // Accessible
            Console.WriteLine(example.InternalField); // Accessible within the same assembly
            Console.WriteLine(example.ProtectedInternalField); // Accessible within the same assembly

            // example.PrivateField and example.ProtectedField are NOT accessible here
        }
    }

    // Main program

    internal class Access_Specifiers
    {
        static void Main(string[] args)
        {
            ExampleClass example = new ExampleClass();

            Console.WriteLine(example.PublicField); // Accessible

            // Access to methods with different access levels

            example.PublicMethod(); // Accessible
            example.InternalMethod(); // Accessible within same assembly
            example.ProtectedInternalMethod(); // Accessible within same assembly

            // Private and protected methods are NOT accessible here
        }
    }
}

```
