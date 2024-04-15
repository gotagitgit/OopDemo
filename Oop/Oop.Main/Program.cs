using Oop.Main.Models;
using Oop.Main.Models.Accounts;

namespace Oop.Main;

internal class Program
{
    static void Main(string[] args)
    {
        var accountHolder = new AccountHolder("Juan Dela Cruz", new CheckingAccount());

        //var checkingAccount = (ICheckingAccount)accountHolder.Account;

        //if (checkingAccount != null)
        //{
        //    checkingAccount.Deposit("afasdfas", 100000);

        //}

        Console.WriteLine($"Account Type : {accountHolder.Account.Type}");

        if (accountHolder.Account is ICheckingAccount checkingAccount)
            checkingAccount.Deposit("afasdfas", 50000m);

        accountHolder.Account.Withdraw(20500);
        
        var balance = accountHolder.Account.GetBalance();

        Console.WriteLine(balance);

        //Console.WriteLine($"Account Number {accountHolder.Account.AccountNumber}");

        //var account = new Account();

        //account.Deposit(50000);

        //account.Withdraw(20000);        

        //var balance = account.GetBalance();

        //Console.WriteLine($"My balance is Php {balance:n}");

        //var loan = new Loan(100000, .05, 12);

        //var totalPayment = loan.CalculateTotalPayment();

        //loan.DisplayLoanDetails();

        //Console.WriteLine($"Total payment is Php {totalPayment:n}");

        Console.ReadLine();
    }
}
