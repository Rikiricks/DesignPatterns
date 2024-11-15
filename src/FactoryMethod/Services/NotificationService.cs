using FactoryMethod.Factory;

namespace FactoryMethod.Services
{
    public class NotificationService(NotifierFactory notifierFactory)
    {
        public void Notify(string message)
        {
           var notifier = notifierFactory.CreateNotifier();
           notifier.SendNotification(message);
        }
    }
}
