public class BankAccount
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }
    private List<string> Transactions = new List<string>();
    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
    }
    public void Withdraw(double amount)
    {
        Balance -= amount;
        Transactions.Add($"Withdrew ${amount}. New Balance: ${Balance}");
    }
    public void PrintStatement()
    {
        Console.WriteLine($"Statement for Account: {AccountNumber}");
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}