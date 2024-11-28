#region Design Patterns
//1) Creational Patterns

//   - Factory Method
//   - Abstract Factory 
//   - Builder
//   - Singleton


//2) Structural Patterns

//   - Adapter
//   - Decorator 
//   - Proxy


//3) Behavioral Patterns

//   - Strategy
//   - Observer
#endregion

#region Factory Method

using Adapter.Features;

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

Console.WriteLine("\n\n");

#region Singleton
string[] firstDocumentStrings = { "PC1_doc1", "PC1_doc2", "PC1_doc3" };
string[] secondDocumentStrings = { "PC2_doc4", "PC2_doc5", "PC2_doc6" };
var printSpooler1 = PrintSpooler.GetPrintSpooler();
var printSpooler2 = PrintSpooler.GetPrintSpooler();

var task1 = Task.Run(() => printSpooler1.AddPrintJob(firstDocumentStrings));
var task2 = Task.Run(() => printSpooler2.AddPrintJob(secondDocumentStrings));

await Task.WhenAll(task1, task2);

printSpooler1.ProcessPrintJob();
printSpooler2.ProcessPrintJob();
#endregion

Console.WriteLine("\n\n");

#region Adapter

var xmlToJsonDataConverter = new XmlToJsonAdapter(new XmlDataProvider());
var result = xmlToJsonDataConverter.GetJsonData();
Console.WriteLine(result);
#endregion