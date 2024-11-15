using AbstractFactory.Features;
using FactoryMethod.Features;

namespace AbstractFactory.Factories
{
    public class CreditCardFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new CreditCardProcessor();
        }

        public IPaymentValidator CreatePaymentValidator()
        {
            return new CreditCardValidator();
        }
    }
}
