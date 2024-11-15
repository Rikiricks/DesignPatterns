namespace AbstractFactory.Features
{
    public interface IPaymentValidator
    {
        bool ValidatePayment(string details);
    }
}
