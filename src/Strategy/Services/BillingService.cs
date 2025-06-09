using Strategy.Strategies;

namespace Strategy.Services
{
    public class BillingService
    {
        private IBillingStrategy _billingStrategy;

        public BillingService(IBillingStrategy billingStrategy)
        {
            _billingStrategy = billingStrategy;
        }

        public void SetBillingStrategy(IBillingStrategy billingStrategy)
        {
            _billingStrategy = billingStrategy;
        }

        public decimal GenerateBill(decimal amount)
        {
            return _billingStrategy.CalculateBill(amount);
        }
    }
}
