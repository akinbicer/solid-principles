using OpenClosedPrinciple.Services.Payments;

var bankTransferPayment = new BankTransferPayment();
bankTransferPayment.Process(100);

var creditCardPayment = new CreditCardPayment();
creditCardPayment.Process(1000);

var payPalPayment = new PayPalPayment();
payPalPayment.Process(10000);