namespace Oop.Main.Models.Accounts;

public interface ICheckingAccount
{
    void Deposit(string checkNumber, decimal amount);
}