using Decorator.Features;

namespace Decorator.Decorators
{
    public class InterestDecorator : AccountDecorator
    {
        private double _interestRate;

        public InterestDecorator(IBankAccount account, double interestRate) : base(account)
        {
            _interestRate = interestRate;
        }

        public override string GetDescription() => base._account.GetDescription() + ", Interest";

        public void ApplyInterest()
        {
            double interest = base._account.GetBalance() * _interestRate;
            base._account.Deposit(interest);
            Console.WriteLine($"Applied interest: {interest:C}. New balance: {base._account.GetBalance():C}");
        }
    }
}
