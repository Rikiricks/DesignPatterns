using Decorator.Features;
using System.Security.Principal;

namespace Decorator.Decorators
{
    public class OverdraftProtectionDecorator : AccountDecorator
    {
        private double _overdraftLimit;
        public OverdraftProtectionDecorator(IBankAccount account, double overdraftLimit) : base(account)
        {
            _overdraftLimit = overdraftLimit;
        }

        public override string GetDescription() => _account.GetDescription() + ", Overdraft Protection";

        public override void Withdraw(double amount)
        {
            if (_account.GetBalance() + _overdraftLimit >= amount)
            {
                _account.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded.");
            }
        }
            
    }
}
