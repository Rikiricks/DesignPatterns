namespace FactoryMethod.Features
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.Write($"Sending SMS: {message}");
        }
    }
}
