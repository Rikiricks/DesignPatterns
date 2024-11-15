using FactoryMethod.Features;

namespace FactoryMethod.Factory
{
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
        
    }
}
