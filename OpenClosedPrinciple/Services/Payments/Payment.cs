namespace OpenClosedPrinciple.Services.Payments;

public abstract class Payment
{
    public abstract bool Process(decimal amount);
}