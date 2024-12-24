using Decorator.Features;

namespace Decorator.Decorators
{
    public abstract class AccountDecorator : IBankAccount
    {
        protected IBankAccount _account;

        public AccountDecorator(IBankAccount account)
        {
            _account = account;
        }

        public virtual void Deposit(double amount)
        {
            _account.Deposit(amount);
        }

        public virtual double GetBalance()
        {
            return _account.GetBalance();
        }

        public virtual string GetDescription()
        {
            return _account.GetDescription();
        }

        public virtual void Withdraw(double amount)
        {
            _account.Withdraw(amount);
        }
    }
}
