namespace Strategy.Strategies
{
    public class SelfPayBilling : IBillingStrategy
    {
        public decimal CalculateBill(decimal baseAmount)
        {
            return baseAmount;
        }
    }
}
