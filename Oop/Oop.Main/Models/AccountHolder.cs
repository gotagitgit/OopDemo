using Oop.Main.Models.Accounts;

namespace Oop.Main.Models;
public class AccountHolder
{
    public AccountHolder(string name, Account account)
    {
        AccountName = name;
        Account = account;
        Loan = new Loan();
    }

    public string AccountName { get; } 

    public Account Account { get; }

    public Loan Loan { get; }
}
