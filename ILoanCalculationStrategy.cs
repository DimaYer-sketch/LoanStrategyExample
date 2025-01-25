public interface ILoanCalculationStrategy
{
    decimal CalculateLoan(decimal amount, int months, decimal baseRate);
}
