using AbstractFactory.Features;
using FactoryMethod.Features;

namespace AbstractFactory.Factories
{
    public interface IPaymentFactory
    {
        IPaymentProcessor CreatePaymentProcessor();
        IPaymentValidator CreatePaymentValidator();
    }
}
