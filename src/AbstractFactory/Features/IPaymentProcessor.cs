namespace FactoryMethod.Features
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
