
#region Factory Method

using AbstractFactory.Factories;
using AbstractFactory.Services;

var emailNotifier = new NotificationService(new EmailNotifierFactory());
emailNotifier.Notify("Hi Riki");

var smsNotifier = new NotificationService(new SMSNotifierFactory());
smsNotifier.Notify("Hola Pal");

#endregion
Console.WriteLine("\n\n");

#region Abstract Factory

var creditCardPayment = new PaymentService(new CreditCardFactory());
creditCardPayment.ExecutePayment("CreditCard", 1000.00M);

var payPalPayment = new PaymentService(new PayPalFactory());
payPalPayment.ExecutePayment("PayPal", 2000.00M);

#endregion
