# Types of Inheritance

Below is the implementation of different types of inheritance with `Console.WriteLine()` statements in each method to reflect the method call according to the class name.

<br>

### 1. **Single Inheritance**

---

A class inherits from one base class.

```csharp

class Parent
{
    public void Display()
    {
        Console.WriteLine("Parent class method.");
    }
}

class Child : Parent
{
    public void Show()
    {
        Console.WriteLine("Child class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.Display();  // Parent class method.
        child.Show();     // Child class method.
    }
}

```

<br>

### 2. **Multiple Inheritance using Interfaces**

---

Not directly supported in C#. A class cannot inherit from more than one class directly, but it can implement multiple interfaces.

```csharp

interface IFirst
{
    void FirstMethod();
}

interface ISecond
{
    void SecondMethod();
}

class DerivedClass : IFirst, ISecond
{
    public void FirstMethod()
    {
        Console.WriteLine("First interface method in DerivedClass.");
    }

    public void SecondMethod()
    {
        Console.WriteLine("Second interface method in DerivedClass.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.FirstMethod();   // First interface method in DerivedClass.
        obj.SecondMethod();  // Second interface method in DerivedClass.
    }
}

```

<br>

### 3. **Multilevel Inheritance**

---

A class inherits from a class that is already derived from another class.

```csharp

class Grandparent
{
    public void GrandparentMethod()
    {
        Console.WriteLine("Grandparent class method.");
    }
}

class Parent : Grandparent
{
    public void ParentMethod()
    {
        Console.WriteLine("Parent class method.");
    }
}

class Child : Parent
{
    public void ChildMethod()
    {
        Console.WriteLine("Child class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.GrandparentMethod();  // Grandparent class method.
        child.ParentMethod();       // Parent class method.
        child.ChildMethod();        // Child class method.
    }
}

```

<br>

### 4. **Hierarchical Inheritance**

---

Multiple classes inherit from the same base class.

```csharp

class Parent
{
    public void ParentMethod()
    {
        Console.WriteLine("Parent class method.");
    }
}

class Child1 : Parent
{
    public void Child1Method()
    {
        Console.WriteLine("Child1 class method.");
    }
}

class Child2 : Parent
{
    public void Child2Method()
    {
        Console.WriteLine("Child2 class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child1 child1 = new Child1();
        child1.ParentMethod();  // Parent class method.
        child1.Child1Method();  // Child1 class method.

        Child2 child2 = new Child2();
        child2.ParentMethod();  // Parent class method.
        child2.Child2Method();  // Child2 class method.
    }
}

```

<br>

### 5. **Hybrid Inheritance using Interfaces**

---

A combination of two or more types of inheritance (e.g., single, multilevel, hierarchical). Although C# does not support multiple inheritance, hybrid inheritance can be achieved using interfaces.

```csharp

interface IFirst
{
    void FirstMethod();
}

class Parent
{
    public void ParentMethod()
    {
        Console.WriteLine("Parent class method.");
    }
}

class Child : Parent, IFirst
{
    public void FirstMethod()
    {
        Console.WriteLine("First interface method in Child class.");
    }

    public void ChildMethod()
    {
        Console.WriteLine("Child class method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child child = new Child();
        child.ParentMethod();  // Parent class method.
        child.FirstMethod();   // First interface method in Child class.
        child.ChildMethod();   // Child class method.
    }
}

```
