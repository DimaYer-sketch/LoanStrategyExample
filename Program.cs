using System;

class Program
{
    static void Main(string[] args)
    {
        var loanCalculator = new LoanCalculator();

        Console.WriteLine("Enter client age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter loan amount:");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter loan period in months:");
        int months = int.Parse(Console.ReadLine());

        decimal baseRate = 0.02m;

        // Set the strategy based on the client's age
        if (age < 20)
        {
            loanCalculator.SetStrategy(new YoungClientStrategy());
        }
        else if (age >= 20 && age <= 35)
        {
            loanCalculator.SetStrategy(new MidAgeClientStrategy());
        }
        else
        {
            loanCalculator.SetStrategy(new SeniorClientStrategy());
        }

        // Calculate the loan
        decimal total = loanCalculator.Calculate(amount, months, baseRate);

        Console.WriteLine($"Total loan amount: {total:C}");
    }
}
