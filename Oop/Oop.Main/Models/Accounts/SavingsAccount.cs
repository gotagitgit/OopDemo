namespace Oop.Main.Models.Accounts;

public class SavingsAccount : Account
{
    private const decimal MaxLimitInADay = 20000;

    public SavingsAccount()
    {
        Type = "Savings Account";
    }

    public override string Type { get; }

    public override void Withdraw(decimal  amount)
    {
        if (amount <= MaxLimitInADay)
        {
            Withdraw(amount);
        }
        else
        {
            Console.WriteLine($"You can't withdraw more than {MaxLimitInADay}");
        }
    }
}
