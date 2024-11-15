using AbstractFactory.Factories;

namespace AbstractFactory.Services
{
    public class PaymentService(IPaymentFactory paymentFactory)
    {
        public void ExecutePayment(string details, decimal amount)
        {
            // Validate payment
            var paymentValidator = paymentFactory.CreatePaymentValidator();
            var isValid = paymentValidator.ValidatePayment(details);
            if (isValid)
            {
                var paymentProcessor = paymentFactory.CreatePaymentProcessor();
                paymentProcessor.ProcessPayment(amount);
            }
        }
    }
}
