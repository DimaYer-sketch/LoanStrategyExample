// Strategy for clients aged 20 to 35
public class MidAgeClientStrategy : ILoanCalculationStrategy
{
    public decimal CalculateLoan(decimal amount, int months, decimal baseRate)
    {
        decimal rate = amount switch
        {
            <= 5000 => 0.02m,
            > 5000 and <= 30000 => 0.015m + baseRate,
            _ => 0.01m + baseRate
        };
        decimal additionalMonthRate = (months - 12) * 0.0015m;
        return amount + (amount * (rate + additionalMonthRate));
    }
}