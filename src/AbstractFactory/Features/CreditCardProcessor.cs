using FactoryMethod.Features;

namespace AbstractFactory.Features
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing CreditCard payment of {amount}");
        }
    }
}
