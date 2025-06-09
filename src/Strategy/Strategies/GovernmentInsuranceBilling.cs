namespace Strategy.Strategies
{
    public class GovernmentInsuranceBilling : IBillingStrategy
    {
        public decimal CalculateBill(decimal baseAmount)
        {
            return baseAmount * 0.3m;
        }
    }
}
