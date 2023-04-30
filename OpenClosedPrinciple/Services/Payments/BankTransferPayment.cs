namespace OpenClosedPrinciple.Services.Payments;

public class BankTransferPayment : Payment
{
    public override bool Process(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} amount by bank transfer has been successfully received.");
        return true;
    }
}