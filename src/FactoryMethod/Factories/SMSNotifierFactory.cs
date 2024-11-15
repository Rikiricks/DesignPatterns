using FactoryMethod.Features;

namespace FactoryMethod.Factory
{
    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
