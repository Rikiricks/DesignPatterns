namespace Decorator.Features
{
    public class BasicAccount : IBankAccount
    {
        private double _balance;

        public BasicAccount(double initialBalance)
        {
            _balance = initialBalance;
        }

        public string GetDescription() => "Basic Account";

        public double GetBalance() => _balance;

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
