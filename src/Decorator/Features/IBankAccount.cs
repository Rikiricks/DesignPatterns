namespace Decorator.Features
{
    public interface IBankAccount
    {
        string GetDescription();
        double GetBalance();
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
