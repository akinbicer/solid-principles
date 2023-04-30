namespace OpenClosedPrinciple.Services.Payments;

public class CreditCardPayment : Payment
{
    public override bool Process(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by credit card has been successfully received.");
        return true;
    }
}