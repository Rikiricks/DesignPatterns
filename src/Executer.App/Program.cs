
#region Factory Method

using AbstractFactory.Factories;
using AbstractFactory.Services;
using Builder.Features;

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

Console.WriteLine("\n\n");

#region Builder

IEmailBuilder emailBuilder = new EmailBuilder();

Email email = emailBuilder
            .SetTo("recipient@example.com")
            .SetFrom("sender@example.com")
            .SetSubject("Meeting Reminder")
            .SetBody("Don't forget about the meeting tomorrow at 10 AM.")
            .AddAttachment("agenda.pdf")
            .Build();

Console.WriteLine(email.ToString());

#endregion