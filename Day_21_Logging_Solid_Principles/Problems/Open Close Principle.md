# Open Close Principle

The **Open/Closed Principle (OCP)** is one of the five SOLID principles of object-oriented programming, formulated by Bertrand Meyer in 1988. The principle states that software entities (such as classes, modules, functions, etc.) should be open for extension but closed for modification. This means that the behavior of a module can be extended without altering its source code, promoting a design that accommodates new functionality while minimizing the risk of introducing bugs.

### Key Concepts of OCP

1. **Open for Extension**: You can add new functionality to a class or module without modifying its existing code. This is often achieved through inheritance, interfaces, or composition.

2. **Closed for Modification**: The existing code remains unchanged when new functionalities are introduced. This helps in maintaining stability and reliability within the codebase.

#### Without OCP :

```csharp
public class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        switch (shape)
        {
            case Circle c:
                return Math.PI * c.Radius * c.Radius;
            case Rectangle r:
                return r.Width * r.Height;
            // If a new shape is added, we need to modify this method
            default:
                throw new ArgumentException("Unknown shape");
        }
    }
}

public class Circle
{
    public double Radius { get; set; }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}
```

In this example, every time a new shape is added (like a triangle), the `CalculateArea` method must be modified, violating the OCP.

#### With OCP :

```csharp
public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea() => Math.PI * Radius * Radius;
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea() => Width * Height;
}

public class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea(); // No need to modify this method when adding new shapes
    }
}
```

In the modified example, the `AreaCalculator` class does not need to be changed when new shapes are introduced. Each shape implements the `IShape` interface, allowing them to be processed without modifying the `CalculateArea` method.

### Benefits of OCP:

- **Reduced Risk of Bugs**: Since existing code is not modified, the risk of introducing new bugs is minimized.
- **Improved Maintainability**: Extending functionality becomes easier and cleaner, which leads to more maintainable code.
- **Enhanced Flexibility**: New requirements can be accommodated by adding new classes instead of modifying existing ones, promoting flexibility in the design.
