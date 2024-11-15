using AbstractFactory.Features;
using FactoryMethod.Features;

namespace AbstractFactory.Factories
{
    public class PayPalFactory : IPaymentFactory
    {
        public IPaymentProcessor CreatePaymentProcessor()
        {
            return new PayPalProcessor();
        }

        public IPaymentValidator CreatePaymentValidator()
        {
            return new PayPalValidator();
        }
    }
}
