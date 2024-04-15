namespace Oop.Main.Models;

public class Loan
{
    private readonly decimal _amount;
    private readonly double _interestRate;
    private readonly int _duration;

    public Loan() : this(0, 0, 0)
    {
    }

    public Loan(decimal amount, double interestRate, int duration)
    {
        _amount = amount;
        _interestRate = interestRate;
        _duration = duration;
    }

    public decimal CalculateTotalPayment()
    {
        return _amount * (decimal)Math.Pow(1 + _interestRate, _duration);
    }

    public void DisplayLoanDetails()
    {
        Console.WriteLine("Loan amount: " + _amount);
        Console.WriteLine("Interest rate: " + _interestRate);
        Console.WriteLine("Duration: " + _duration + " months");
    }
}
