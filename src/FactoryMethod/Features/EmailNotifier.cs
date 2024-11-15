namespace FactoryMethod.Features
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
