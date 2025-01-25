public class LoanCalculator
{
    private ILoanCalculationStrategy _strategy;

    // Set the strategy dynamically
    public void SetStrategy(ILoanCalculationStrategy strategy)
    {
        _strategy = strategy;
    }

    // Calculate the loan using the current strategy
    public decimal Calculate(decimal amount, int months, decimal baseRate)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Loan calculation strategy is not set.");
        }

        return _strategy.CalculateLoan(amount, months, baseRate);
    }
}
