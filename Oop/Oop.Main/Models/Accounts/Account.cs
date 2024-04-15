namespace Oop.Main.Models.Accounts;

public abstract class Account
{
    private decimal _balance;

    public Account()
    {
        AccountNumber = Guid.NewGuid();
    }

    public Guid AccountNumber { get; }

    public abstract string Type { get; }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited: {amount:n}");
    }    

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:n}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
