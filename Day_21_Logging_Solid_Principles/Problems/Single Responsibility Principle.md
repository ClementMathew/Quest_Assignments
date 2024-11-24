# Single Responsibility Principle

The **Single Responsibility Principle (SRP)** is one of the key concepts in object-oriented programming and is part of the SOLID principles. Proposed by Robert C. Martin (also known as Uncle Bob), the SRP states that a class should have only one reason to change, meaning it should only have one job or responsibility. This principle promotes a design where classes are focused and thus easier to understand, maintain, and test.

### Key Concepts of SRP

1. **Single Responsibility**: Each class should only have one responsibility or reason to change. This helps to keep classes small and focused.

2. **Cohesion**: A class that adheres to SRP will have high cohesion, meaning that its methods and properties are closely related and focused on a single task.

3. **Maintainability**: By adhering to SRP, making changes becomes easier since modifications are localized to a single class, reducing the impact on other parts of the code.

#### Without SRP :

```csharp
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveToDatabase()
    {
        // Code to save the user to the database
    }

    public void SendEmail()
    {
        // Code to send an email to the user
    }
}
```

In this example, the `User` class has two responsibilities: managing user data and handling email notifications. This violates the SRP because changes in email functionality could affect the user data management.

#### With SRP :

```csharp
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserRepository
{
    public void Save(User user)
    {
        // Code to save the user to the database
    }
}

public class EmailService
{
    public void SendEmail(string email)
    {
        // Code to send an email to the user
    }
}
```

In the refactored example, each class has a single responsibility. The `User` class handles user properties, the `UserRepository` handles database interactions, and the `EmailService` takes care of sending emails. This adheres to the SRP, allowing each class to be modified independently.

### Benefits of SRP:

- **Improved Readability**: Code becomes easier to read and understand as each class has a clear purpose.
- **Easier Maintenance**: Changes can be made to one part of the system without impacting others, reducing the likelihood of bugs.
- **Enhanced Testability**: Smaller, focused classes are easier to test since they do less, allowing for more effective unit tests.
