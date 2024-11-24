# Liskov Substitution Principle

The **Liskov Substitution Principle (LSP)** is one of the five SOLID principles of object-oriented programming and design. Formulated by Barbara Liskov in 1987, the principle states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. In other words, if class `S` is a subclass of class `T`, then `T` should be able to be replaced with `S` without altering any of the desirable properties of the program.

### Key Points of LSP:

1. **Behavioral Consistency**: Subclasses must extend the functionality of the parent class without changing its expected behavior. This means that any method that works with the superclass should also work with the subclass.

2. **Preconditions and Postconditions**: Subclasses should not strengthen preconditions (the requirements that must be true before a method is executed) or weaken postconditions (the guarantees that must be true after a method has been executed) of methods inherited from the superclass.

3. **Invariants**: Any invariants (conditions that must always hold true) of the superclass should also be maintained by the subclass.

#### Without LSP :

```csharp
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Ostriches cannot fly.");
    }
}

public class BirdWatcher
{
    public void WatchBird(Bird bird)
    {
        bird.Fly(); // This will throw an exception if an Ostrich is passed
    }
}
```

In this example, the `Ostrich` class violates the Liskov Substitution Principle because it cannot perform the action of flying, which the superclass `Bird` promises. Passing an `Ostrich` object to a method expecting a `Bird` would lead to unexpected behavior (an exception being thrown).

#### With LSP :

```csharp
public abstract class Bird
{
    public abstract void Move();
}

public class FlyingBird : Bird
{
    public override void Move()
    {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird
{
    public override void Move()
    {
        Console.WriteLine("Running");
    }
}

public class BirdWatcher
{
    public void WatchBird(Bird bird)
    {
        bird.Move(); // Now it works with any Bird
    }
}
```

In the corrected example, we create an abstract `Bird` class and derive two subclasses: `FlyingBird` and `Ostrich`. The `Move` method is overridden in both classes, ensuring that the expected behavior is maintained without any violations. Now, passing either type of `Bird` to `WatchBird` will work correctly.

### Benefits of LSP:

- **Increased Reusability**: Properly adhering to LSP allows for greater code reuse and flexibility, as subclasses can be easily interchanged.
- **Enhanced Maintainability**: By ensuring subclasses adhere to the expected behaviors of their superclasses, the system becomes more predictable and easier to maintain.
- **Improved Testing**: Following LSP makes it easier to test subclasses, as they can be treated as instances of the superclass.
