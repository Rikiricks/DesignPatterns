namespace Strategy.Strategies
{
    public class PrivateInsuranceBilling : IBillingStrategy
    {
        public decimal CalculateBill(decimal baseAmount)
        {
            return (baseAmount * 0.2m) + 30m;
        }
    }
}
