namespace AbstractFactory.Features
{
    public class PayPalValidator : IPaymentValidator
    {
        public bool ValidatePayment(string details)
        {
            Console.WriteLine("Validating PayPal details...");
            return true; // Simulate validation
        }
    }
}
