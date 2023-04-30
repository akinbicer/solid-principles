namespace OpenClosedPrinciple.Services.Payments;

public class PayPalPayment : Payment
{
    public override bool Process(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by paypal has been successfully received.");
        return true;
    }
}