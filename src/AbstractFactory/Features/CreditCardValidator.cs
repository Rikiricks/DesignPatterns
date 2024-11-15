namespace AbstractFactory.Features
{
    public class CreditCardValidator : IPaymentValidator
    {
        public bool ValidatePayment(string details)
        {
            Console.WriteLine("Validating credit card details...");
            return true; // Simulate validation
        }
    }
}
