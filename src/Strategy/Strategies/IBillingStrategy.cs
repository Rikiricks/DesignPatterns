namespace Strategy.Strategies
{
    public interface IBillingStrategy
    {
        decimal CalculateBill(decimal baseAmount);
    }
}
