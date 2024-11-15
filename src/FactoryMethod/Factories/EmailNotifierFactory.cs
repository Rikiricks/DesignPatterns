using FactoryMethod.Features;

namespace FactoryMethod.Factory
{
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
