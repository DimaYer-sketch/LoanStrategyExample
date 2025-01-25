// Strategy for clients under 20
public class YoungClientStrategy : ILoanCalculationStrategy
{
    public decimal CalculateLoan(decimal amount, int months, decimal baseRate)
    {
        decimal rate = 0.02m + baseRate;
        decimal additionalMonthRate = (months - 12) * 0.0015m;
        return amount + (amount * (rate + additionalMonthRate));
    }
}