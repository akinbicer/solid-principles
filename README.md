# SOLID Principles

SOLID is a set of principles for object-oriented software design and development. The principles were introduced by Robert C. Martin (also known as Uncle Bob) in the early 2000s. The SOLID principles are:

1. Single Responsibility Principle (SRP)
2. Open/Closed Principle (OCP)
3. Liskov Substitution Principle (LSP)
4. Interface Segregation Principle (ISP)
5. Dependency Inversion Principle (DIP)

## 1. Single Responsibility Principle (SRP)

The Single Responsibility Principle states that a class or module should have only one reason to change. This principle helps to reduce the risk of changes affecting other parts of the code and makes the code more readable and understandable.

Example: The following example shows a CustomerService class that has a single responsibility.

```csharp
public class CustomerService : ICustomerService
{
    private readonly List<Customer?> _customers;

    public CustomerService()
    {
        _customers = new List<Customer?>();
    }

    public List<Customer?> GetAll()
    {
        // Get all the customer information from the database
        return _customers;
    }

    public Customer? Get(Guid id)
    {
        // Get the customer information from the database
        return _customers.FirstOrDefault(x => x != null && x.Id == id);
    }

    public void Add(Customer customer) 
    {
        // Save the customer information to the database
        if (customer == null)
            throw new ArgumentNullException(nameof(customer));
        
        _customers.Add(customer);
    }
}
```

## 2. Open/Closed Principle (OCP)

The Open/Closed Principle states that a class or module should be open for extension but closed for modification. This principle allows new features to be added without modifying existing code.

Example: The following example shows a Payment class that follows the Open/Closed Principle.

```csharp
public abstract class Payment
{
    public abstract bool ProcessPayment(decimal amount);
}

public class CreditCardPayment : Payment
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by credit card has been successfully received.");
        return true;
    }
}

public class PayPalPayment : Payment
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by paypal has been successfully received.");
        return true;
    }
}

public class BankTransferPayment : Payment
{
    public override bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by bank transfer has been successfully received.");
        return true;
    }
}
```

## 3. Liskov Substitution Principle (LSP)

The Liskov Substitution Principle states that a subclass should be able to replace its parent class without affecting the correctness of the program. This principle ensures that the behavior of the program remains consistent when a subclass is used in place of its parent class.

Example: The following example shows a Square class that follows the Liskov Substitution Principle.

```csharp
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set { base.Width = value; base.Height = value; }
    }

    public override int Height
    {
        get { return base.Height; }
        set { base.Height = value; base.Width = value; }
    }
}
```

## 4. Interface Segregation Principle (ISP)

The Interface Segregation Principle states that a class should not be forced to implement interfaces it does not use. This principle helps to prevent unnecessary coupling between classes and makes the code more readable and understandable.

Example: The following example shows a Car class that follows the Interface Segregation Principle.

```csharp
public interface ICar
{
    void CheckSpeed();
    void CheckFuelLevel();
}

public interface INavigation
{
    void Navigate();
}

public class Car : ICar, INavigation
{
    public void CheckSpeed()
    {
        Console.WriteLine("Speed checked.");
    }

    public void CheckFuelLevel()
    {
        Console.WriteLine("Fuel level checked.");
    }

    public void Navigate()
    {
        Console.WriteLine("Navigation started.");
    }
}
```

## 5. Dependency Inversion Principle (DIP)

The Dependency Inversion Principle states that high-level modules should not depend on low-level modules. Both should depend on abstractions. This principle helps to reduce coupling between classes and makes the code more flexible and maintainable.

Example: The following example shows a Payment class that follows the Dependency Inversion Principle.

```csharp
public interface IPaymentGateway
{
    void ProcessPayment();
}

public class Payment
{
    private readonly IPaymentGateway _paymentGateway;

    public Payment(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void ProcessPayment()
    {
        _paymentGateway.ProcessPayment();
    }
}

public class CreditCardPaymentGateway : IPaymentGateway
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment successfully received by credit card.");
    }
}
```

## Issues, Feature Requests or Support
Please use the [New Issue](https://github.com/akinbicer/solid-principles/issues/new) button to submit issues, feature requests or support issues directly to me. You can also send an e-mail to akin.bicer@outlook.com.tr.
