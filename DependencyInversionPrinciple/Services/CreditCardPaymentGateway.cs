namespace DependencyInversionPrinciple.Services;

public class CreditCardPaymentGateway : IPaymentGateway
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment successfully received by credit card.");
    }
}