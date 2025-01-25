// Strategy for clients over 35
public class SeniorClientStrategy : ILoanCalculationStrategy
{
    public decimal CalculateLoan(decimal amount, int months, decimal baseRate)
    {
        decimal rate = amount switch
        {
            <= 15000 => 0.015m + baseRate,
            > 15000 and <= 30000 => 0.03m + baseRate,
            _ => 0.01m
        };
        decimal additionalMonthRate = (months - 12) * 0.0015m;
        return amount + (amount * (rate + additionalMonthRate));
    }
}