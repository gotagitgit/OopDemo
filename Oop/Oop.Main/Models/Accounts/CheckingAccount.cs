namespace Oop.Main.Models.Accounts;

public class CheckingAccount : Account, ICheckingAccount
{
    public override string Type => "Checking Account";

    public void Deposit(string checkNumber, decimal amount)
    {
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Check number : {checkNumber}");

        base.Deposit(amount);
    }
}
