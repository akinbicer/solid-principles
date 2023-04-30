namespace DependencyInversionPrinciple.Services;

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