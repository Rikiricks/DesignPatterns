using Decorator.Features;

namespace Decorator.Decorators
{
    public class RewardsPointsDecorator : AccountDecorator
    {
        private int _rewardsPoints;
        public RewardsPointsDecorator(IBankAccount account) : base(account) { }

        public override string GetDescription() => base._account.GetDescription() + ", Rewards Points";

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            _rewardsPoints += (int)(amount / 10); // Earn 1 point for every $10 deposited
            Console.WriteLine($"Earned {_rewardsPoints} rewards points.");
        }
    }
}
