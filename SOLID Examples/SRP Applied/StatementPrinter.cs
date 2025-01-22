namespace SOLID_Examples.SRP_Applied_Example;

public class StatementPrinter
{
    public void Print(BankAccount account)
    {
        Console.WriteLine($"Statement for Account: {account.AccountNumber}");
        foreach (var transaction in account.Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}