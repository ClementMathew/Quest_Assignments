# Dependency Inversion Principle

The **Dependency Inversion Principle (DIP)** is one of the SOLID principles in software engineering, stating that high-level modules should not depend on low-level modules. Instead, both should depend on abstractions. In simpler terms, it encourages developers to use interfaces or abstract classes to decouple classes, making code more flexible and reducing tight coupling.

### Scenario :

---

Suppose you have an application that sends notifications. It initially only supports email notifications but might expand to other notification types, such as SMS or push notifications. Without DIP, the `NotificationService` would depend directly on the `EmailNotification` class, making it difficult to expand.

#### Example without DIP:

```csharp
public class EmailNotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

public class NotificationService
{
    private readonly EmailNotification _emailNotification;

    public NotificationService()
    {
        _emailNotification = new EmailNotification();
    }

    public void Notify(string message)
    {
        _emailNotification.Send(message);
    }
}
```

In this example, `NotificationService` depends directly on `EmailNotification`. If we want to add an SMS notification, we would have to modify `NotificationService`, which violates the open-closed principle and makes maintenance harder.

#### Applying DIP :

---

<br>

1. First, we create an abstraction for notifications:

```csharp
public interface INotification
{
    void Send(string message);
}
```

2. Then, implement the `EmailNotification` class based on this interface:

```csharp
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
```

3. Add another notification type, such as `SmsNotification`:

```csharp
public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
```

4. Now, update `NotificationService` to depend on the `INotification` interface, allowing us to inject any notification type:

```csharp
public class NotificationService
{
    private readonly INotification _notification;

    // Dependency Injection through constructor

    public NotificationService(INotification notification)
    {
        _notification = notification;
    }

    public void Notify(string message)
    {
        _notification.Send(message);
    }
}
```

5. In `Main`, you can now decide which notification type to use:

```csharp
class Program
{
    static void Main(string[] args)
    {
        INotification emailNotification = new EmailNotification();
        NotificationService service = new NotificationService(emailNotification);
        service.Notify("Hello via Email!");

        INotification smsNotification = new SmsNotification();
        service = new NotificationService(smsNotification);
        service.Notify("Hello via SMS!");
    }
}
```

### Benefits :

With this structure:

- `NotificationService` no longer depends on a specific notification class but on the `INotification` interface.
- Adding new notification types doesn’t require changes to `NotificationService`.
- This approach adheres to DIP by depending on abstractions, enhancing flexibility and making the system easier to extend.

By using DIP, you ensure that high-level policies are not tightly coupled with low-level implementations, making the code more modular and easier to maintain.
